// For use in LilyGo T Relay controller
// ESP32 Wrover Module

#include <TaskScheduler.h>
#include <WiFi.h>
#include <ESPmDNS.h>
#include <WiFiUdp.h>
#include <WiFiClient.h>
#include <WiFiAP.h>
#include <ArduinoOTA.h>
#include <ModbusIP_ESP8266.h>
#include "Wire.h"
#include <INA3221.h>

const char* ssid = "yourssidhere";
const char* password = "yourwifipasswordhere";

const char apid[] = "PowerController";  //  your network SSID (name)
const char appass[] = "yourpasswordhere";       // your network password

IPAddress apIP(192, 168, 4, 1);

ModbusIP mb;

const int Coil_REG = 100;               // Modbus Offsets
const int Pwr_REG = 200;

unsigned int outputprog;
unsigned int lastprogress;

int wificounter = 0;

#define RELAY_PIN_1 21
#define RELAY_PIN_2 19
#define RELAY_PIN_3 18
#define RELAY_PIN_4 5
#define LED_PIN     25

INA3221 ina3221(INA3221_ADDR40_GND);
#define PRINT_DEC_POINTS 3       // decimal points to print

#define SDA_pin 32
#define SCL_pin 33

Scheduler runner;
void readpwr();

Task t1(10, TASK_FOREVER, &readpwr);

void i2cscanner()
{
  byte error, address;
  int nDevices;
 
  Serial.println("Scanning...");
 
  nDevices = 0;
  for(address = 1; address < 127; address++ )
  {
    // The i2c_scanner uses the return value of
    // the Write.endTransmisstion to see if
    // a device did acknowledge to the address.
    Wire.beginTransmission(address);
    error = Wire.endTransmission();
 
    if (error == 0)
    {
      Serial.print("I2C device found at address 0x");
      if (address<16)
        Serial.print("0");
      Serial.print(address,HEX);
      Serial.println("  !");
 
      nDevices++;
    }
    else if (error==4)
    {
      Serial.print("Unknown error at address 0x");
      if (address<16)
        Serial.print("0");
      Serial.println(address,HEX);
    }    
  }
  if (nDevices == 0)
    Serial.println("No I2C devices found\n");
  else
    Serial.println("done\n");
}

void setup()
{
    Serial.begin(115200);
    
    pinMode(RELAY_PIN_1, OUTPUT);
    pinMode(RELAY_PIN_2, OUTPUT);
    pinMode(RELAY_PIN_3, OUTPUT);
    pinMode(RELAY_PIN_4, OUTPUT);
    pinMode(LED_PIN, OUTPUT);
    delay(100);

  WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, password);
  
  while (WiFi.waitForConnectResult() != WL_CONNECTED && wificounter != 2) 
  {    
    delay(5000);
    ++wificounter;
  }

  if(WiFi.waitForConnectResult() != WL_CONNECTED)
  {    
    WiFi.mode(WIFI_AP);
    WiFi.softAP(apid, appass,5);
    WiFi.softAPConfig(apIP, apIP, IPAddress(255, 255, 255, 0));  
    IPAddress myIP = WiFi.softAPIP();    
  }

  Serial.print("IP number assigned by DHCP is ");
  Serial.println(WiFi.localIP());
  
  ArduinoOTA
    .onStart([]() {
      String type;
      if (ArduinoOTA.getCommand() == U_FLASH)
        type = "sketch";
      else // U_SPIFFS
        type = "filesystem";

      // NOTE: if updating SPIFFS this would be the place to unmount SPIFFS using SPIFFS.end()      
      lastprogress = 0;
    })
    .onEnd([]() {
            
    })
    .onProgress([](unsigned int progress, unsigned int total) {      
      outputprog = progress / (total / 100);
      if (lastprogress != outputprog)
      {                        
        lastprogress = outputprog;
      }
    })
    .onError([](ota_error_t error) {      
      
    });

  ArduinoOTA.begin();

  Wire.begin(SDA_pin,SCL_pin);
  i2cscanner();
  ina3221.begin(&Wire);
  ina3221.reset();

  // Set shunt resistors to 10 mOhm for all channels
  ina3221.setShuntRes(10, 10, 10);

  // Set series filter resistors to 10 Ohm for all channels.
  // Series filter resistors introduce error to the current measurement.
  // The error can be estimated and depends on the resitor values and the bus
  // voltage.
  ina3221.setFilterRes(10, 10, 10);

  //ina3221.setAveragingMode(INA3221_REG_CONF_AVG_1);
  //ina3221.setAveragingMode(INA3221_REG_CONF_AVG_4);
  //ina3221.setAveragingMode(INA3221_REG_CONF_AVG_16);
  //ina3221.setAveragingMode(INA3221_REG_CONF_AVG_64);
  //ina3221.setAveragingMode(INA3221_REG_CONF_AVG_128);
  //ina3221.setAveragingMode(INA3221_REG_CONF_AVG_256);
  ina3221.setAveragingMode(INA3221_REG_CONF_AVG_512);  
  //ina3221.setAveragingMode(INA3221_REG_CONF_AVG_1024);
  
  mb.server();  
  mb.addCoil(Coil_REG, 0, 4);
  mb.addHreg(Pwr_REG,0,9); 
  
  runner.init();
  runner.addTask(t1);
  t1.enable();  
}

void readpwr()
{
    float current[3];
    float current_compensated[3];
    float voltage[3];

    current[0]             = ina3221.getCurrent(INA3221_CH1);    
    current_compensated[0] = ina3221.getCurrentCompensated(INA3221_CH1);
    mb.Hreg((Pwr_REG + 1), (uint16_t)(current_compensated[0] * 1000));
    voltage[0]             = ina3221.getVoltage(INA3221_CH1);
    mb.Hreg((Pwr_REG), (uint16_t)(voltage[0] * 1000));

    current[1]             = ina3221.getCurrent(INA3221_CH2);
    current_compensated[1] = ina3221.getCurrentCompensated(INA3221_CH2);
    mb.Hreg((Pwr_REG + 3), (uint16_t)(current_compensated[1] * 1000));
    voltage[1]             = ina3221.getVoltage(INA3221_CH2);
    mb.Hreg((Pwr_REG + 2), (uint16_t)(voltage[1] * 1000));

    current[2]             = ina3221.getCurrent(INA3221_CH3);
    current_compensated[2] = ina3221.getCurrentCompensated(INA3221_CH3);
    mb.Hreg((Pwr_REG + 5), (uint16_t)(current_compensated[2] * 1000));
    voltage[2]             = ina3221.getVoltage(INA3221_CH3);
    mb.Hreg((Pwr_REG + 4), (uint16_t)(voltage[2] * 1000));

    /*Serial.print("Channel 1: \n Current: ");
    Serial.print(current[0], PRINT_DEC_POINTS);
    Serial.print("A\n Compensated current: ");
    Serial.print(current_compensated[0], PRINT_DEC_POINTS);
    Serial.print("\n Voltage: ");
    Serial.print(voltage[0], PRINT_DEC_POINTS);
    Serial.println("V");

    Serial.print("Channel 2: \n Current: ");
    Serial.print(current[1], PRINT_DEC_POINTS);
    Serial.print("A\n Compensated current: ");
    Serial.print(current_compensated[1], PRINT_DEC_POINTS);
    Serial.print("\n Voltage: ");
    Serial.print(voltage[1], PRINT_DEC_POINTS);
    Serial.println("V");

    Serial.print("Channel 3: \n Current: ");
    Serial.print(current[2], PRINT_DEC_POINTS);
    Serial.print("A\n Compensated current: ");
    Serial.print(current_compensated[2], PRINT_DEC_POINTS);
    Serial.print("\n Voltage: ");
    Serial.print(voltage[2], PRINT_DEC_POINTS);
    Serial.println("V\n");
    */
}

void loop()
{ 
  ArduinoOTA.handle();  
  
  if (lastprogress == 0 && WiFi.status() == WL_CONNECTED)
  { 
    runner.execute();
    mb.task();
    
    digitalWrite(RELAY_PIN_1, mb.Coil(Coil_REG));
    digitalWrite(RELAY_PIN_2, mb.Coil(Coil_REG + 1));
    digitalWrite(RELAY_PIN_3, mb.Coil(Coil_REG + 2));
    digitalWrite(RELAY_PIN_4, mb.Coil(Coil_REG + 3));
    digitalWrite(LED_PIN, LOW);
  }

  if (WiFi.status() != WL_CONNECTED)
  {
    digitalWrite(LED_PIN, LOW);
    delay(1000);
    digitalWrite(LED_PIN, HIGH);
    delay(1000);
  }

}
