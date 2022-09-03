Imports System.Threading
Imports System.Threading.Tasks
Imports System.IO
Imports System.Text
Public Class Form1
    Dim ModbusClient As EasyModbus.ModbusClient
    Dim connected As Boolean = False
    Dim backworkercanceling As Boolean = False
    Dim backworkercanceled As Boolean = True
    Dim rxdvalues() As Integer
    Dim floatvalues(6) As Double
    Private Sub Connect_btn_Click(sender As Object, e As EventArgs) Handles Connect_btn.Click
        If IP_address_txt.Text = "" Then
            MessageBox.Show("Enter IP address first!")
            Return
        End If
        Connect_btn.Enabled = False
        Disconnect_btn.Enabled = True

        Try
            ModbusClient = New EasyModbus.ModbusClient(IP_address_txt.Text, 502)
            ModbusClient.ConnectionTimeout = 5000
            ModbusClient.NumberOfRetries = 5
            ModbusClient.Connect()
            connected = True
            Thread.Sleep(2000)
            ModbusClient.WriteSingleCoil(100, False)
            ModbusClient.WriteSingleCoil(101, False)
            ModbusClient.WriteSingleCoil(102, False)
            ReadWriteValues_Worker.RunWorkerAsync()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connect_btn.Enabled = True
            Disconnect_btn.Enabled = False
            Return
        End Try

    End Sub

    Private Sub Disconnect_btn_Click(sender As Object, e As EventArgs) Handles Disconnect_btn.Click
        Connect_btn.Enabled = True
        Disconnect_btn.Enabled = False

        Try
            ModbusClient.WriteSingleCoil(100, False)
            ModbusClient.WriteSingleCoil(101, False)
            ModbusClient.WriteSingleCoil(102, False)
            ModbusClient.Disconnect()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        While backworkercanceled = False

        End While
        ch1_output_enabler.Checked = False
        ch2_output_enabler.Checked = False
        ch3_output_enabler.Checked = False


    End Sub

    Private Sub ReadWriteValues_Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ReadWriteValues_Worker.DoWork
        If ReadWriteValues_Worker.CancellationPending = True Then
            e.Cancel = True
            ModbusClient.Disconnect()
            Return
        End If
        If ModbusClient.Connected = True AndAlso backworkercanceling = False AndAlso e.Cancel = False AndAlso connected = True Then
            If connected = True Then
                Try
                    rxdvalues = ModbusClient.ReadHoldingRegisters(200, 6)
                    floatvalues(0) = rxdvalues(0) / 1000
                    floatvalues(1) = rxdvalues(1) / 1000
                    floatvalues(2) = rxdvalues(2) / 1000
                    floatvalues(3) = rxdvalues(3) / 1000
                    floatvalues(4) = rxdvalues(4) / 1000
                    floatvalues(5) = rxdvalues(5) / 1000
                Catch ex As Exception
                    ModbusClient.Disconnect()
                    MessageBox.Show(ex.Message)
                    connected = False
                End Try
            End If
        Else
            connected = False
        End If


    End Sub

    Private Sub ch1_output_enabler_CheckedChanged(sender As Object, e As EventArgs) Handles ch1_output_enabler.CheckedChanged
        If ModbusClient.Connected = True Then
            If ch1_output_enabler.Checked = True Then
                Try
                    ModbusClient.WriteSingleCoil(100, True)
                Catch ex As Exception
                    ModbusClient.Disconnect()
                    MessageBox.Show(ex.Message)
                    connected = False
                End Try

            Else
                Try
                    ModbusClient.WriteSingleCoil(100, False)
                Catch ex As Exception
                    ModbusClient.Disconnect()
                    MessageBox.Show(ex.Message)
                    connected = False
                End Try

            End If
        End If


    End Sub
    Private Sub ch2_output_enabler_CheckedChanged(sender As Object, e As EventArgs) Handles ch2_output_enabler.CheckedChanged
        If ModbusClient.Connected = True Then
            If ch2_output_enabler.Checked = True Then
                Try
                    ModbusClient.WriteSingleCoil(101, True)
                Catch ex As Exception
                    ModbusClient.Disconnect()
                    MessageBox.Show(ex.Message)
                    connected = False
                End Try

            Else
                Try
                    ModbusClient.WriteSingleCoil(101, False)
                Catch ex As Exception
                    ModbusClient.Disconnect()
                    MessageBox.Show(ex.Message)
                    connected = False
                End Try

            End If
        End If

    End Sub

    Private Sub ch3_output_enabler_CheckedChanged(sender As Object, e As EventArgs) Handles ch3_output_enabler.CheckedChanged
        If ModbusClient.Connected = True Then
            If ch3_output_enabler.Checked = True Then
                Try
                    ModbusClient.WriteSingleCoil(102, True)
                Catch ex As Exception
                    ModbusClient.Disconnect()
                    MessageBox.Show(ex.Message)
                    connected = False
                End Try

            Else
                Try
                    ModbusClient.WriteSingleCoil(102, False)
                Catch ex As Exception
                    ModbusClient.Disconnect()
                    MessageBox.Show(ex.Message)
                    connected = False
                End Try

            End If
        End If

    End Sub
    Private Sub ReadWriteValues_Worker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ReadWriteValues_Worker.RunWorkerCompleted
        ch1_voltage_agauge.Value = floatvalues(0)
        ch1_current_agauge.Value = floatvalues(1)
        ch2_voltage_agauge.Value = floatvalues(2)
        ch2_current_agauge.Value = floatvalues(3)
        ch3_voltage_agauge.Value = floatvalues(4)
        ch3_current_agauge.Value = floatvalues(5)

        ch1_voltage_value.Text = floatvalues(0).ToString
        ch1_current_value.Text = floatvalues(1).ToString
        ch2_voltage_value.Text = floatvalues(2).ToString
        ch2_current_value.Text = floatvalues(3).ToString
        ch3_voltage_value.Text = floatvalues(4).ToString
        ch3_current_value.Text = floatvalues(5).ToString


        If e.Cancelled = True Then
            backworkercanceled = e.Cancelled
            Return
        Else
            If connected = True Then
                ReadWriteValues_Worker.RunWorkerAsync()
            Else
                ReadWriteValues_Worker.CancelAsync()
            End If
        End If


    End Sub


End Class
