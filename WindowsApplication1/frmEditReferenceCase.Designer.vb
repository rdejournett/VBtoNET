<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditReferenceCase
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
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame1.Location = New System.Drawing.Point(8, 216)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(577, 89)
        Me.Frame1.TabIndex = 36
        Me.Frame1.Text = "Reference Case"
        '
        'EdtPointNo
        '
        Me.EdtPointNo = New System.Windows.Forms.TextBox()
        Me.EdtPointNo.Location = New System.Drawing.Point(440, 20)
        Me.EdtPointNo.Name = "EdtPointNo"
        Me.EdtPointNo.Size = New System.Drawing.Size(53, 21)
        Me.EdtPointNo.TabIndex = 5
        Me.EdtPointNo.Text = ""
        Me.EdtPointNo.Text = ""
        Me.EdtPointNo.Multiline = False
        'Datafield = "POINT_NO"
        'Datafield = "rdcReferenceCase"
        '
        'Text2
        '
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text2.Location = New System.Drawing.Point(136, 48)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(53, 21)
        Me.Text2.TabIndex = 3
        Me.Text2.Text = ""
        Me.Text2.Text = ""
        Me.Text2.Multiline = False
        'Datafield = "RC_RATIO"
        'Datafield = "rdcReferenceCase"
        '
        'CmbRefCaseTypeLookup
        '
        Me.CmbRefCaseTypeLookup = New System.Windows.Forms.ComboBox()
        Me.CmbRefCaseTypeLookup.Location = New System.Drawing.Point(136, 24)
        Me.CmbRefCaseTypeLookup.Name = "CmbRefCaseTypeLookup"
        Me.CmbRefCaseTypeLookup.Size = New System.Drawing.Size(125, 21)
        Me.CmbRefCaseTypeLookup.TabIndex = 1
        Me.CmbRefCaseTypeLookup.Text = ""
        '
        'Label1
        '
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reference Case Type"
        Me.Label1.Text = "Reference Case Type"
        '
        'Label2
        '
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label2.Location = New System.Drawing.Point(316, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calculation Point"
        Me.Label2.Text = "Calculation Point"
        '
        'Label3
        '
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RPC To Institution"
        Me.Label3.Text = "RPC To Institution"
        Me.Frame1.Controls.Add(Me.EdtPointNo)
        Me.Frame1.Controls.Add(Me.Text2)
        Me.Frame1.Controls.Add(Me.CmbRefCaseTypeLookup)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label3)
        '
        'BtnCancel
        '
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCancel.Location = New System.Drawing.Point(80, 312)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(65, 25)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnOK.Location = New System.Drawing.Point(8, 312)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(65, 25)
        Me.BtnOK.TabIndex = 6
        Me.BtnOK.Text = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Frame2
        '
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Frame2.Location = New System.Drawing.Point(8, 12)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(577, 101)
        Me.Frame2.TabIndex = 23
        Me.Frame2.Text = "Treatment Planning Computer"
        '
        'BtnSelectTPC
        '
        Me.BtnSelectTPC = New System.Windows.Forms.Button()
        Me.BtnSelectTPC.Location = New System.Drawing.Point(472, 64)
        Me.BtnSelectTPC.Name = "BtnSelectTPC"
        Me.BtnSelectTPC.Size = New System.Drawing.Size(97, 25)
        Me.BtnSelectTPC.TabIndex = 8
        Me.BtnSelectTPC.Text = "Select TPC..."
        Me.BtnSelectTPC.UseVisualStyleBackColor = True
        '
        'Text3
        '
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text3.Location = New System.Drawing.Point(100, 20)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(117, 21)
        Me.Text3.TabIndex = 29
        Me.Text3.Text = ""
        Me.Text3.Text = ""
        Me.Text3.Multiline = False
        'Datafield = "MANUFACTURER"
        'Datafield = "rdcTPCLookup"
        '
        'Text4
        '
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Text4.Location = New System.Drawing.Point(100, 44)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(117, 21)
        Me.Text4.TabIndex = 28
        Me.Text4.Text = ""
        Me.Text4.Text = ""
        Me.Text4.Multiline = False
        'Datafield = "MODEL"
        'Datafield = "rdcTPCLookup"
        '
        'Text5
        '
        Me.Text5 = New System.Windows.Forms.TextBox()
        Me.Text5.Location = New System.Drawing.Point(100, 68)
        Me.Text5.Name = "Text5"
        Me.Text5.Size = New System.Drawing.Size(85, 21)
        Me.Text5.TabIndex = 27
        Me.Text5.Text = ""
        Me.Text5.Text = ""
        Me.Text5.Multiline = False
        'Datafield = "VERSION"
        'Datafield = "rdcTPCLookup"
        '
        'Text6
        '
        Me.Text6 = New System.Windows.Forms.TextBox()
        Me.Text6.Location = New System.Drawing.Point(360, 44)
        Me.Text6.Name = "Text6"
        Me.Text6.Size = New System.Drawing.Size(85, 21)
        Me.Text6.TabIndex = 26
        Me.Text6.Text = ""
        Me.Text6.Text = ""
        Me.Text6.Multiline = False
        'Datafield = "INSTALL_DATE"
        'Datafield = "rdcTPCLookup"
        '
        'Text7
        '
        Me.Text7 = New System.Windows.Forms.TextBox()
        Me.Text7.Location = New System.Drawing.Point(360, 68)
        Me.Text7.Name = "Text7"
        Me.Text7.Size = New System.Drawing.Size(85, 21)
        Me.Text7.TabIndex = 25
        Me.Text7.Text = ""
        Me.Text7.Text = ""
        Me.Text7.Multiline = False
        'Datafield = "REMOVAL_DATE"
        'Datafield = "rdcTPCLookup"
        '
        'Text8
        '
        Me.Text8 = New System.Windows.Forms.TextBox()
        Me.Text8.Location = New System.Drawing.Point(360, 20)
        Me.Text8.Name = "Text8"
        Me.Text8.Size = New System.Drawing.Size(209, 21)
        Me.Text8.TabIndex = 24
        Me.Text8.Text = ""
        Me.Text8.Text = ""
        Me.Text8.Multiline = False
        'Datafield = "USED_FOR"
        'Datafield = "rdcTPCLookup"
        '
        'Label4
        '
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label4.Location = New System.Drawing.Point(16, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Manufacturer"
        Me.Label4.Text = "Manufacturer"
        '
        'Label5
        '
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label5.Location = New System.Drawing.Point(16, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Model"
        Me.Label5.Text = "Model"
        '
        'Label6
        '
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label6.Location = New System.Drawing.Point(16, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Version"
        Me.Label6.Text = "Version"
        '
        'Label7
        '
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label7.Location = New System.Drawing.Point(260, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Clinical Use Began"
        Me.Label7.Text = "Clinical Use Began"
        '
        'Label8
        '
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label8.Location = New System.Drawing.Point(260, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Decomissioned"
        Me.Label8.Text = "Decomissioned"
        '
        'Label9
        '
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label9.Location = New System.Drawing.Point(260, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Used For"
        Me.Label9.Text = "Used For"
        Me.Frame2.Controls.Add(Me.BtnSelectTPC)
        Me.Frame2.Controls.Add(Me.Text3)
        Me.Frame2.Controls.Add(Me.Text4)
        Me.Frame2.Controls.Add(Me.Text5)
        Me.Frame2.Controls.Add(Me.Text6)
        Me.Frame2.Controls.Add(Me.Text7)
        Me.Frame2.Controls.Add(Me.Text8)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label9)
        '
        'Frame3
        '
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Frame3.Location = New System.Drawing.Point(8, 116)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Size = New System.Drawing.Size(577, 97)
        Me.Frame3.TabIndex = 10
        Me.Frame3.Text = "Machine/Beam"
        '
        'BtnSelectBeam
        '
        Me.BtnSelectBeam = New System.Windows.Forms.Button()
        Me.BtnSelectBeam.Location = New System.Drawing.Point(472, 60)
        Me.BtnSelectBeam.Name = "BtnSelectBeam"
        Me.BtnSelectBeam.Size = New System.Drawing.Size(97, 25)
        Me.BtnSelectBeam.TabIndex = 9
        Me.BtnSelectBeam.Text = "Select Beam..."
        Me.BtnSelectBeam.UseVisualStyleBackColor = True
        '
        'EdtBeamType
        '
        Me.EdtBeamType = New System.Windows.Forms.TextBox()
        Me.EdtBeamType.Location = New System.Drawing.Point(100, 64)
        Me.EdtBeamType.Name = "EdtBeamType"
        Me.EdtBeamType.Size = New System.Drawing.Size(93, 21)
        Me.EdtBeamType.TabIndex = 16
        Me.EdtBeamType.Text = ""
        Me.EdtBeamType.Text = ""
        Me.EdtBeamType.Multiline = False
        'Datafield = "BEAM_TYPE"
        'Datafield = "rdcBeamLookup"
        '
        'Text10
        '
        Me.Text10 = New System.Windows.Forms.TextBox()
        Me.Text10.Location = New System.Drawing.Point(360, 64)
        Me.Text10.Name = "Text10"
        Me.Text10.Size = New System.Drawing.Size(45, 21)
        Me.Text10.TabIndex = 15
        Me.Text10.Text = ""
        Me.Text10.Text = ""
        Me.Text10.Multiline = False
        'Datafield = "SOURCE_NO"
        'Datafield = "rdcBeamLookup"
        '
        'Text11
        '
        Me.Text11 = New System.Windows.Forms.TextBox()
        Me.Text11.Location = New System.Drawing.Point(360, 40)
        Me.Text11.Name = "Text11"
        Me.Text11.Size = New System.Drawing.Size(45, 21)
        Me.Text11.TabIndex = 14
        Me.Text11.Text = ""
        Me.Text11.Text = ""
        Me.Text11.Multiline = False
        'Datafield = "MACH#"
        'Datafield = "rdcBeamLookup"
        '
        'Text12
        '
        Me.Text12 = New System.Windows.Forms.TextBox()
        Me.Text12.Location = New System.Drawing.Point(360, 16)
        Me.Text12.Name = "Text12"
        Me.Text12.Size = New System.Drawing.Size(45, 21)
        Me.Text12.TabIndex = 13
        Me.Text12.Text = ""
        Me.Text12.Text = ""
        Me.Text12.Multiline = False
        'Datafield = "ENERGY"
        'Datafield = "rdcBeamLookup"
        '
        'EdtModel
        '
        Me.EdtModel = New System.Windows.Forms.TextBox()
        Me.EdtModel.Location = New System.Drawing.Point(100, 40)
        Me.EdtModel.Name = "EdtModel"
        Me.EdtModel.Size = New System.Drawing.Size(137, 21)
        Me.EdtModel.TabIndex = 12
        Me.EdtModel.Text = ""
        Me.EdtModel.Text = ""
        Me.EdtModel.Multiline = False
        'Datafield = "MODEL"
        'Datafield = "rdcBeamLookup"
        '
        'EdtManufacturer
        '
        Me.EdtManufacturer = New System.Windows.Forms.TextBox()
        Me.EdtManufacturer.Location = New System.Drawing.Point(100, 16)
        Me.EdtManufacturer.Name = "EdtManufacturer"
        Me.EdtManufacturer.Size = New System.Drawing.Size(137, 21)
        Me.EdtManufacturer.TabIndex = 11
        Me.EdtManufacturer.Text = ""
        Me.EdtManufacturer.Text = ""
        Me.EdtManufacturer.Multiline = False
        'Datafield = "MANUFACTURER"
        'Datafield = "rdcBeamLookup"
        '
        'Label10
        '
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label10.Location = New System.Drawing.Point(12, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Type"
        Me.Label10.Text = "Type"
        '
        'Label11
        '
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label11.Location = New System.Drawing.Point(260, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Source No"
        Me.Label11.Text = "Source No"
        '
        'Label12
        '
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label12.Location = New System.Drawing.Point(260, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 17)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Mach#"
        Me.Label12.Text = "Mach#"
        '
        'Label13
        '
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label13.Location = New System.Drawing.Point(260, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Energy"
        Me.Label13.Text = "Energy"
        '
        'Label14
        '
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label14.Location = New System.Drawing.Point(12, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Model"
        Me.Label14.Text = "Model"
        '
        'Label15
        '
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label15.Location = New System.Drawing.Point(12, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Manufacturer"
        Me.Label15.Text = "Manufacturer"
        Me.Frame3.Controls.Add(Me.BtnSelectBeam)
        Me.Frame3.Controls.Add(Me.EdtBeamType)
        Me.Frame3.Controls.Add(Me.Text10)
        Me.Frame3.Controls.Add(Me.Text11)
        Me.Frame3.Controls.Add(Me.Text12)
        Me.Frame3.Controls.Add(Me.EdtModel)
        Me.Frame3.Controls.Add(Me.EdtManufacturer)
        Me.Frame3.Controls.Add(Me.Label10)
        Me.Frame3.Controls.Add(Me.Label11)
        Me.Frame3.Controls.Add(Me.Label12)
        Me.Frame3.Controls.Add(Me.Label13)
        Me.Frame3.Controls.Add(Me.Label14)
        Me.Frame3.Controls.Add(Me.Label15)
        '
        'frmEditReferenceCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 347)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame3)
        Me.Name = "frmEditReferenceCase"
        Me.Text = "frmEditReferenceCase"
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents EdtPointNo As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents CmbRefCaseTypeLookup As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents Frame2 As GroupBox
    Friend WithEvents BtnSelectTPC As Button
    Friend WithEvents Text3 As TextBox
    Friend WithEvents Text4 As TextBox
    Friend WithEvents Text5 As TextBox
    Friend WithEvents Text6 As TextBox
    Friend WithEvents Text7 As TextBox
    Friend WithEvents Text8 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Frame3 As GroupBox
    Friend WithEvents BtnSelectBeam As Button
    Friend WithEvents EdtBeamType As TextBox
    Friend WithEvents Text10 As TextBox
    Friend WithEvents Text11 As TextBox
    Friend WithEvents Text12 As TextBox
    Friend WithEvents EdtModel As TextBox
    Friend WithEvents EdtManufacturer As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
