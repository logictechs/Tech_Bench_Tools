<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.IP_address_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Connect_btn = New System.Windows.Forms.Button()
        Me.Disconnect_btn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PowerController = New System.Windows.Forms.TabPage()
        Me.ch3_output_enabler = New System.Windows.Forms.CheckBox()
        Me.ch2_output_enabler = New System.Windows.Forms.CheckBox()
        Me.ch1_output_enabler = New System.Windows.Forms.CheckBox()
        Me.ch3_current_agauge = New System.Windows.Forms.AGauge()
        Me.ch2_current_agauge = New System.Windows.Forms.AGauge()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ch1_current_agauge = New System.Windows.Forms.AGauge()
        Me.ch3_voltage_agauge = New System.Windows.Forms.AGauge()
        Me.ch2_voltage_agauge = New System.Windows.Forms.AGauge()
        Me.ch1_voltage_agauge = New System.Windows.Forms.AGauge()
        Me.ReadWriteValues_Worker = New System.ComponentModel.BackgroundWorker()
        Me.ch1_voltage_value = New System.Windows.Forms.Label()
        Me.ch2_voltage_value = New System.Windows.Forms.Label()
        Me.ch3_voltage_value = New System.Windows.Forms.Label()
        Me.ch1_current_value = New System.Windows.Forms.Label()
        Me.ch2_current_value = New System.Windows.Forms.Label()
        Me.ch3_current_value = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.PowerController.SuspendLayout()
        Me.SuspendLayout()
        '
        'IP_address_txt
        '
        Me.IP_address_txt.Location = New System.Drawing.Point(5, 25)
        Me.IP_address_txt.Name = "IP_address_txt"
        Me.IP_address_txt.Size = New System.Drawing.Size(100, 23)
        Me.IP_address_txt.TabIndex = 0
        Me.IP_address_txt.Text = "192.168.1.137"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Address:"
        '
        'Connect_btn
        '
        Me.Connect_btn.Location = New System.Drawing.Point(111, 25)
        Me.Connect_btn.Name = "Connect_btn"
        Me.Connect_btn.Size = New System.Drawing.Size(75, 23)
        Me.Connect_btn.TabIndex = 2
        Me.Connect_btn.Text = "&Connect"
        Me.Connect_btn.UseVisualStyleBackColor = True
        '
        'Disconnect_btn
        '
        Me.Disconnect_btn.Enabled = False
        Me.Disconnect_btn.Location = New System.Drawing.Point(192, 25)
        Me.Disconnect_btn.Name = "Disconnect_btn"
        Me.Disconnect_btn.Size = New System.Drawing.Size(75, 23)
        Me.Disconnect_btn.TabIndex = 3
        Me.Disconnect_btn.Text = "&Disconnect"
        Me.Disconnect_btn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.PowerController)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(692, 503)
        Me.TabControl1.TabIndex = 4
        '
        'PowerController
        '
        Me.PowerController.Controls.Add(Me.ch3_current_value)
        Me.PowerController.Controls.Add(Me.ch2_current_value)
        Me.PowerController.Controls.Add(Me.ch1_current_value)
        Me.PowerController.Controls.Add(Me.ch3_voltage_value)
        Me.PowerController.Controls.Add(Me.ch2_voltage_value)
        Me.PowerController.Controls.Add(Me.ch1_voltage_value)
        Me.PowerController.Controls.Add(Me.ch3_output_enabler)
        Me.PowerController.Controls.Add(Me.ch2_output_enabler)
        Me.PowerController.Controls.Add(Me.ch1_output_enabler)
        Me.PowerController.Controls.Add(Me.ch3_current_agauge)
        Me.PowerController.Controls.Add(Me.ch2_current_agauge)
        Me.PowerController.Controls.Add(Me.Label7)
        Me.PowerController.Controls.Add(Me.Label6)
        Me.PowerController.Controls.Add(Me.Label5)
        Me.PowerController.Controls.Add(Me.Label4)
        Me.PowerController.Controls.Add(Me.Label3)
        Me.PowerController.Controls.Add(Me.Label2)
        Me.PowerController.Controls.Add(Me.ch1_current_agauge)
        Me.PowerController.Controls.Add(Me.ch3_voltage_agauge)
        Me.PowerController.Controls.Add(Me.ch2_voltage_agauge)
        Me.PowerController.Controls.Add(Me.ch1_voltage_agauge)
        Me.PowerController.Controls.Add(Me.Connect_btn)
        Me.PowerController.Controls.Add(Me.Disconnect_btn)
        Me.PowerController.Controls.Add(Me.IP_address_txt)
        Me.PowerController.Controls.Add(Me.Label1)
        Me.PowerController.Location = New System.Drawing.Point(4, 24)
        Me.PowerController.Name = "PowerController"
        Me.PowerController.Padding = New System.Windows.Forms.Padding(3)
        Me.PowerController.Size = New System.Drawing.Size(684, 475)
        Me.PowerController.TabIndex = 0
        Me.PowerController.Text = "Power Controller"
        Me.PowerController.UseVisualStyleBackColor = True
        '
        'ch3_output_enabler
        '
        Me.ch3_output_enabler.AutoSize = True
        Me.ch3_output_enabler.Location = New System.Drawing.Point(512, 52)
        Me.ch3_output_enabler.Name = "ch3_output_enabler"
        Me.ch3_output_enabler.Size = New System.Drawing.Size(102, 19)
        Me.ch3_output_enabler.TabIndex = 20
        Me.ch3_output_enabler.Text = "Output Enable"
        Me.ch3_output_enabler.UseVisualStyleBackColor = True
        '
        'ch2_output_enabler
        '
        Me.ch2_output_enabler.AutoSize = True
        Me.ch2_output_enabler.Location = New System.Drawing.Point(298, 52)
        Me.ch2_output_enabler.Name = "ch2_output_enabler"
        Me.ch2_output_enabler.Size = New System.Drawing.Size(102, 19)
        Me.ch2_output_enabler.TabIndex = 19
        Me.ch2_output_enabler.Text = "Output Enable"
        Me.ch2_output_enabler.UseVisualStyleBackColor = True
        '
        'ch1_output_enabler
        '
        Me.ch1_output_enabler.AutoSize = True
        Me.ch1_output_enabler.Location = New System.Drawing.Point(84, 52)
        Me.ch1_output_enabler.Name = "ch1_output_enabler"
        Me.ch1_output_enabler.Size = New System.Drawing.Size(102, 19)
        Me.ch1_output_enabler.TabIndex = 18
        Me.ch1_output_enabler.Text = "Output Enable"
        Me.ch1_output_enabler.UseVisualStyleBackColor = True
        '
        'ch3_current_agauge
        '
        Me.ch3_current_agauge.BaseArcColor = System.Drawing.Color.Gray
        Me.ch3_current_agauge.BaseArcRadius = 80
        Me.ch3_current_agauge.BaseArcStart = 135
        Me.ch3_current_agauge.BaseArcSweep = 270
        Me.ch3_current_agauge.BaseArcWidth = 2
        Me.ch3_current_agauge.Center = New System.Drawing.Point(100, 100)
        Me.ch3_current_agauge.Location = New System.Drawing.Point(434, 281)
        Me.ch3_current_agauge.MaxValue = 6.0!
        Me.ch3_current_agauge.MinValue = 0!
        Me.ch3_current_agauge.Name = "ch3_current_agauge"
        Me.ch3_current_agauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.ch3_current_agauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.ch3_current_agauge.NeedleRadius = 80
        Me.ch3_current_agauge.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.ch3_current_agauge.NeedleWidth = 2
        Me.ch3_current_agauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.ch3_current_agauge.ScaleLinesInterInnerRadius = 73
        Me.ch3_current_agauge.ScaleLinesInterOuterRadius = 80
        Me.ch3_current_agauge.ScaleLinesInterWidth = 1
        Me.ch3_current_agauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.ch3_current_agauge.ScaleLinesMajorInnerRadius = 70
        Me.ch3_current_agauge.ScaleLinesMajorOuterRadius = 80
        Me.ch3_current_agauge.ScaleLinesMajorStepValue = 1.0!
        Me.ch3_current_agauge.ScaleLinesMajorWidth = 2
        Me.ch3_current_agauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.ch3_current_agauge.ScaleLinesMinorInnerRadius = 75
        Me.ch3_current_agauge.ScaleLinesMinorOuterRadius = 80
        Me.ch3_current_agauge.ScaleLinesMinorTicks = 9
        Me.ch3_current_agauge.ScaleLinesMinorWidth = 1
        Me.ch3_current_agauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.ch3_current_agauge.ScaleNumbersFormat = Nothing
        Me.ch3_current_agauge.ScaleNumbersRadius = 95
        Me.ch3_current_agauge.ScaleNumbersRotation = 0
        Me.ch3_current_agauge.ScaleNumbersStartScaleLine = 0
        Me.ch3_current_agauge.ScaleNumbersStepScaleLines = 1
        Me.ch3_current_agauge.Size = New System.Drawing.Size(208, 181)
        Me.ch3_current_agauge.TabIndex = 17
        Me.ch3_current_agauge.Text = "CH3 Current"
        Me.ch3_current_agauge.Value = 0!
        '
        'ch2_current_agauge
        '
        Me.ch2_current_agauge.BaseArcColor = System.Drawing.Color.Gray
        Me.ch2_current_agauge.BaseArcRadius = 80
        Me.ch2_current_agauge.BaseArcStart = 135
        Me.ch2_current_agauge.BaseArcSweep = 270
        Me.ch2_current_agauge.BaseArcWidth = 2
        Me.ch2_current_agauge.Center = New System.Drawing.Point(100, 100)
        Me.ch2_current_agauge.Location = New System.Drawing.Point(220, 281)
        Me.ch2_current_agauge.MaxValue = 6.0!
        Me.ch2_current_agauge.MinValue = 0!
        Me.ch2_current_agauge.Name = "ch2_current_agauge"
        Me.ch2_current_agauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.ch2_current_agauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.ch2_current_agauge.NeedleRadius = 80
        Me.ch2_current_agauge.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.ch2_current_agauge.NeedleWidth = 2
        Me.ch2_current_agauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.ch2_current_agauge.ScaleLinesInterInnerRadius = 73
        Me.ch2_current_agauge.ScaleLinesInterOuterRadius = 80
        Me.ch2_current_agauge.ScaleLinesInterWidth = 1
        Me.ch2_current_agauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.ch2_current_agauge.ScaleLinesMajorInnerRadius = 70
        Me.ch2_current_agauge.ScaleLinesMajorOuterRadius = 80
        Me.ch2_current_agauge.ScaleLinesMajorStepValue = 1.0!
        Me.ch2_current_agauge.ScaleLinesMajorWidth = 2
        Me.ch2_current_agauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.ch2_current_agauge.ScaleLinesMinorInnerRadius = 75
        Me.ch2_current_agauge.ScaleLinesMinorOuterRadius = 80
        Me.ch2_current_agauge.ScaleLinesMinorTicks = 9
        Me.ch2_current_agauge.ScaleLinesMinorWidth = 1
        Me.ch2_current_agauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.ch2_current_agauge.ScaleNumbersFormat = Nothing
        Me.ch2_current_agauge.ScaleNumbersRadius = 95
        Me.ch2_current_agauge.ScaleNumbersRotation = 0
        Me.ch2_current_agauge.ScaleNumbersStartScaleLine = 0
        Me.ch2_current_agauge.ScaleNumbersStepScaleLines = 1
        Me.ch2_current_agauge.Size = New System.Drawing.Size(208, 181)
        Me.ch2_current_agauge.TabIndex = 16
        Me.ch2_current_agauge.Text = "CH2 Current"
        Me.ch2_current_agauge.Value = 0!
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(434, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "CH3 Current"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(220, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "CH2 Current"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "CH1 Current"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(434, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "CH3 Voltage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "CH2 Voltage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "CH1 Voltage"
        '
        'ch1_current_agauge
        '
        Me.ch1_current_agauge.BaseArcColor = System.Drawing.Color.Gray
        Me.ch1_current_agauge.BaseArcRadius = 80
        Me.ch1_current_agauge.BaseArcStart = 135
        Me.ch1_current_agauge.BaseArcSweep = 270
        Me.ch1_current_agauge.BaseArcWidth = 2
        Me.ch1_current_agauge.Center = New System.Drawing.Point(100, 100)
        Me.ch1_current_agauge.Location = New System.Drawing.Point(6, 281)
        Me.ch1_current_agauge.MaxValue = 6.0!
        Me.ch1_current_agauge.MinValue = 0!
        Me.ch1_current_agauge.Name = "ch1_current_agauge"
        Me.ch1_current_agauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.ch1_current_agauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.ch1_current_agauge.NeedleRadius = 80
        Me.ch1_current_agauge.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.ch1_current_agauge.NeedleWidth = 2
        Me.ch1_current_agauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.ch1_current_agauge.ScaleLinesInterInnerRadius = 73
        Me.ch1_current_agauge.ScaleLinesInterOuterRadius = 80
        Me.ch1_current_agauge.ScaleLinesInterWidth = 1
        Me.ch1_current_agauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.ch1_current_agauge.ScaleLinesMajorInnerRadius = 70
        Me.ch1_current_agauge.ScaleLinesMajorOuterRadius = 80
        Me.ch1_current_agauge.ScaleLinesMajorStepValue = 1.0!
        Me.ch1_current_agauge.ScaleLinesMajorWidth = 2
        Me.ch1_current_agauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.ch1_current_agauge.ScaleLinesMinorInnerRadius = 75
        Me.ch1_current_agauge.ScaleLinesMinorOuterRadius = 80
        Me.ch1_current_agauge.ScaleLinesMinorTicks = 9
        Me.ch1_current_agauge.ScaleLinesMinorWidth = 1
        Me.ch1_current_agauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.ch1_current_agauge.ScaleNumbersFormat = Nothing
        Me.ch1_current_agauge.ScaleNumbersRadius = 95
        Me.ch1_current_agauge.ScaleNumbersRotation = 0
        Me.ch1_current_agauge.ScaleNumbersStartScaleLine = 0
        Me.ch1_current_agauge.ScaleNumbersStepScaleLines = 1
        Me.ch1_current_agauge.Size = New System.Drawing.Size(208, 181)
        Me.ch1_current_agauge.TabIndex = 7
        Me.ch1_current_agauge.Text = "CH1 Current"
        Me.ch1_current_agauge.Value = 0!
        '
        'ch3_voltage_agauge
        '
        Me.ch3_voltage_agauge.BaseArcColor = System.Drawing.Color.Gray
        Me.ch3_voltage_agauge.BaseArcRadius = 80
        Me.ch3_voltage_agauge.BaseArcStart = 135
        Me.ch3_voltage_agauge.BaseArcSweep = 270
        Me.ch3_voltage_agauge.BaseArcWidth = 2
        Me.ch3_voltage_agauge.Center = New System.Drawing.Point(100, 100)
        Me.ch3_voltage_agauge.Location = New System.Drawing.Point(434, 74)
        Me.ch3_voltage_agauge.MaxValue = 26.0!
        Me.ch3_voltage_agauge.MinValue = 0!
        Me.ch3_voltage_agauge.Name = "ch3_voltage_agauge"
        Me.ch3_voltage_agauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.ch3_voltage_agauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.ch3_voltage_agauge.NeedleRadius = 80
        Me.ch3_voltage_agauge.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.ch3_voltage_agauge.NeedleWidth = 2
        Me.ch3_voltage_agauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.ch3_voltage_agauge.ScaleLinesInterInnerRadius = 73
        Me.ch3_voltage_agauge.ScaleLinesInterOuterRadius = 80
        Me.ch3_voltage_agauge.ScaleLinesInterWidth = 1
        Me.ch3_voltage_agauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.ch3_voltage_agauge.ScaleLinesMajorInnerRadius = 70
        Me.ch3_voltage_agauge.ScaleLinesMajorOuterRadius = 80
        Me.ch3_voltage_agauge.ScaleLinesMajorStepValue = 2.0!
        Me.ch3_voltage_agauge.ScaleLinesMajorWidth = 2
        Me.ch3_voltage_agauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.ch3_voltage_agauge.ScaleLinesMinorInnerRadius = 75
        Me.ch3_voltage_agauge.ScaleLinesMinorOuterRadius = 80
        Me.ch3_voltage_agauge.ScaleLinesMinorTicks = 9
        Me.ch3_voltage_agauge.ScaleLinesMinorWidth = 1
        Me.ch3_voltage_agauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.ch3_voltage_agauge.ScaleNumbersFormat = Nothing
        Me.ch3_voltage_agauge.ScaleNumbersRadius = 95
        Me.ch3_voltage_agauge.ScaleNumbersRotation = 0
        Me.ch3_voltage_agauge.ScaleNumbersStartScaleLine = 0
        Me.ch3_voltage_agauge.ScaleNumbersStepScaleLines = 1
        Me.ch3_voltage_agauge.Size = New System.Drawing.Size(208, 181)
        Me.ch3_voltage_agauge.TabIndex = 6
        Me.ch3_voltage_agauge.Text = "CH3 Voltage"
        Me.ch3_voltage_agauge.Value = 0!
        '
        'ch2_voltage_agauge
        '
        Me.ch2_voltage_agauge.BaseArcColor = System.Drawing.Color.Gray
        Me.ch2_voltage_agauge.BaseArcRadius = 80
        Me.ch2_voltage_agauge.BaseArcStart = 135
        Me.ch2_voltage_agauge.BaseArcSweep = 270
        Me.ch2_voltage_agauge.BaseArcWidth = 2
        Me.ch2_voltage_agauge.Center = New System.Drawing.Point(100, 100)
        Me.ch2_voltage_agauge.Location = New System.Drawing.Point(220, 74)
        Me.ch2_voltage_agauge.MaxValue = 26.0!
        Me.ch2_voltage_agauge.MinValue = 0!
        Me.ch2_voltage_agauge.Name = "ch2_voltage_agauge"
        Me.ch2_voltage_agauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.ch2_voltage_agauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.ch2_voltage_agauge.NeedleRadius = 80
        Me.ch2_voltage_agauge.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.ch2_voltage_agauge.NeedleWidth = 2
        Me.ch2_voltage_agauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.ch2_voltage_agauge.ScaleLinesInterInnerRadius = 73
        Me.ch2_voltage_agauge.ScaleLinesInterOuterRadius = 80
        Me.ch2_voltage_agauge.ScaleLinesInterWidth = 1
        Me.ch2_voltage_agauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.ch2_voltage_agauge.ScaleLinesMajorInnerRadius = 70
        Me.ch2_voltage_agauge.ScaleLinesMajorOuterRadius = 80
        Me.ch2_voltage_agauge.ScaleLinesMajorStepValue = 2.0!
        Me.ch2_voltage_agauge.ScaleLinesMajorWidth = 2
        Me.ch2_voltage_agauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.ch2_voltage_agauge.ScaleLinesMinorInnerRadius = 75
        Me.ch2_voltage_agauge.ScaleLinesMinorOuterRadius = 80
        Me.ch2_voltage_agauge.ScaleLinesMinorTicks = 9
        Me.ch2_voltage_agauge.ScaleLinesMinorWidth = 1
        Me.ch2_voltage_agauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.ch2_voltage_agauge.ScaleNumbersFormat = Nothing
        Me.ch2_voltage_agauge.ScaleNumbersRadius = 95
        Me.ch2_voltage_agauge.ScaleNumbersRotation = 0
        Me.ch2_voltage_agauge.ScaleNumbersStartScaleLine = 0
        Me.ch2_voltage_agauge.ScaleNumbersStepScaleLines = 1
        Me.ch2_voltage_agauge.Size = New System.Drawing.Size(208, 181)
        Me.ch2_voltage_agauge.TabIndex = 5
        Me.ch2_voltage_agauge.Text = "CH2 Voltage"
        Me.ch2_voltage_agauge.Value = 0!
        '
        'ch1_voltage_agauge
        '
        Me.ch1_voltage_agauge.BaseArcColor = System.Drawing.Color.Gray
        Me.ch1_voltage_agauge.BaseArcRadius = 80
        Me.ch1_voltage_agauge.BaseArcStart = 135
        Me.ch1_voltage_agauge.BaseArcSweep = 270
        Me.ch1_voltage_agauge.BaseArcWidth = 2
        Me.ch1_voltage_agauge.Center = New System.Drawing.Point(100, 100)
        Me.ch1_voltage_agauge.Location = New System.Drawing.Point(6, 74)
        Me.ch1_voltage_agauge.MaxValue = 26.0!
        Me.ch1_voltage_agauge.MinValue = 0!
        Me.ch1_voltage_agauge.Name = "ch1_voltage_agauge"
        Me.ch1_voltage_agauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray
        Me.ch1_voltage_agauge.NeedleColor2 = System.Drawing.Color.DimGray
        Me.ch1_voltage_agauge.NeedleRadius = 80
        Me.ch1_voltage_agauge.NeedleType = System.Windows.Forms.NeedleType.Advance
        Me.ch1_voltage_agauge.NeedleWidth = 2
        Me.ch1_voltage_agauge.ScaleLinesInterColor = System.Drawing.Color.Black
        Me.ch1_voltage_agauge.ScaleLinesInterInnerRadius = 73
        Me.ch1_voltage_agauge.ScaleLinesInterOuterRadius = 80
        Me.ch1_voltage_agauge.ScaleLinesInterWidth = 1
        Me.ch1_voltage_agauge.ScaleLinesMajorColor = System.Drawing.Color.Black
        Me.ch1_voltage_agauge.ScaleLinesMajorInnerRadius = 70
        Me.ch1_voltage_agauge.ScaleLinesMajorOuterRadius = 80
        Me.ch1_voltage_agauge.ScaleLinesMajorStepValue = 2.0!
        Me.ch1_voltage_agauge.ScaleLinesMajorWidth = 2
        Me.ch1_voltage_agauge.ScaleLinesMinorColor = System.Drawing.Color.Gray
        Me.ch1_voltage_agauge.ScaleLinesMinorInnerRadius = 75
        Me.ch1_voltage_agauge.ScaleLinesMinorOuterRadius = 80
        Me.ch1_voltage_agauge.ScaleLinesMinorTicks = 9
        Me.ch1_voltage_agauge.ScaleLinesMinorWidth = 1
        Me.ch1_voltage_agauge.ScaleNumbersColor = System.Drawing.Color.Black
        Me.ch1_voltage_agauge.ScaleNumbersFormat = Nothing
        Me.ch1_voltage_agauge.ScaleNumbersRadius = 95
        Me.ch1_voltage_agauge.ScaleNumbersRotation = 0
        Me.ch1_voltage_agauge.ScaleNumbersStartScaleLine = 0
        Me.ch1_voltage_agauge.ScaleNumbersStepScaleLines = 1
        Me.ch1_voltage_agauge.Size = New System.Drawing.Size(208, 181)
        Me.ch1_voltage_agauge.TabIndex = 4
        Me.ch1_voltage_agauge.Text = "CH1 Voltage"
        Me.ch1_voltage_agauge.Value = 0!
        '
        'ReadWriteValues_Worker
        '
        Me.ReadWriteValues_Worker.WorkerReportsProgress = True
        Me.ReadWriteValues_Worker.WorkerSupportsCancellation = True
        '
        'ch1_voltage_value
        '
        Me.ch1_voltage_value.AutoSize = True
        Me.ch1_voltage_value.Location = New System.Drawing.Point(96, 219)
        Me.ch1_voltage_value.Name = "ch1_voltage_value"
        Me.ch1_voltage_value.Size = New System.Drawing.Size(22, 15)
        Me.ch1_voltage_value.TabIndex = 21
        Me.ch1_voltage_value.Text = "0.0"
        '
        'ch2_voltage_value
        '
        Me.ch2_voltage_value.AutoSize = True
        Me.ch2_voltage_value.Location = New System.Drawing.Point(310, 219)
        Me.ch2_voltage_value.Name = "ch2_voltage_value"
        Me.ch2_voltage_value.Size = New System.Drawing.Size(22, 15)
        Me.ch2_voltage_value.TabIndex = 22
        Me.ch2_voltage_value.Text = "0.0"
        '
        'ch3_voltage_value
        '
        Me.ch3_voltage_value.AutoSize = True
        Me.ch3_voltage_value.Location = New System.Drawing.Point(524, 219)
        Me.ch3_voltage_value.Name = "ch3_voltage_value"
        Me.ch3_voltage_value.Size = New System.Drawing.Size(22, 15)
        Me.ch3_voltage_value.TabIndex = 23
        Me.ch3_voltage_value.Text = "0.0"
        '
        'ch1_current_value
        '
        Me.ch1_current_value.AutoSize = True
        Me.ch1_current_value.Location = New System.Drawing.Point(96, 425)
        Me.ch1_current_value.Name = "ch1_current_value"
        Me.ch1_current_value.Size = New System.Drawing.Size(22, 15)
        Me.ch1_current_value.TabIndex = 22
        Me.ch1_current_value.Text = "0.0"
        '
        'ch2_current_value
        '
        Me.ch2_current_value.AutoSize = True
        Me.ch2_current_value.Location = New System.Drawing.Point(310, 425)
        Me.ch2_current_value.Name = "ch2_current_value"
        Me.ch2_current_value.Size = New System.Drawing.Size(22, 15)
        Me.ch2_current_value.TabIndex = 22
        Me.ch2_current_value.Text = "0.0"
        '
        'ch3_current_value
        '
        Me.ch3_current_value.AutoSize = True
        Me.ch3_current_value.Location = New System.Drawing.Point(524, 425)
        Me.ch3_current_value.Name = "ch3_current_value"
        Me.ch3_current_value.Size = New System.Drawing.Size(22, 15)
        Me.ch3_current_value.TabIndex = 22
        Me.ch3_current_value.Text = "0.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 527)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Tech Bench Tools"
        Me.TabControl1.ResumeLayout(False)
        Me.PowerController.ResumeLayout(False)
        Me.PowerController.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IP_address_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Connect_btn As Button
    Friend WithEvents Disconnect_btn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PowerController As TabPage
    Friend WithEvents ch3_current_agauge As AGauge
    Friend WithEvents ch2_current_agauge As AGauge
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ch1_current_agauge As AGauge
    Friend WithEvents ch3_voltage_agauge As AGauge
    Friend WithEvents ch2_voltage_agauge As AGauge
    Friend WithEvents ch1_voltage_agauge As AGauge
    Friend WithEvents ReadWriteValues_Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ch3_output_enabler As CheckBox
    Friend WithEvents ch2_output_enabler As CheckBox
    Friend WithEvents ch1_output_enabler As CheckBox
    Friend WithEvents ch3_current_value As Label
    Friend WithEvents ch2_current_value As Label
    Friend WithEvents ch1_current_value As Label
    Friend WithEvents ch3_voltage_value As Label
    Friend WithEvents ch2_voltage_value As Label
    Friend WithEvents ch1_voltage_value As Label
End Class
