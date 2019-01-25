<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditPhantomAndBlock
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
        'BtnClose
        '
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnClose.Location = New System.Drawing.Point(24, 728)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 25)
        Me.BtnClose.TabIndex = 87
        Me.BtnClose.Text = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCancel.Location = New System.Drawing.Point(80, 728)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(65, 25)
        Me.BtnCancel.TabIndex = 86
        Me.BtnCancel.Text = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnOK.Location = New System.Drawing.Point(8, 728)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(65, 25)
        Me.BtnOK.TabIndex = 85
        Me.BtnOK.Text = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame1.Location = New System.Drawing.Point(8, 48)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(538, 339)
        Me.Frame1.TabIndex = 72
        Me.Frame1.Text = "Beam and Phantom Info"
        '
        'cmbTargetMotioin
        '
        Me.cmbTargetMotioin = New System.Windows.Forms.ComboBox()
        Me.cmbTargetMotioin.Location = New System.Drawing.Point(352, 232)
        Me.cmbTargetMotioin.Name = "cmbTargetMotioin"
        Me.cmbTargetMotioin.Size = New System.Drawing.Size(177, 21)
        Me.cmbTargetMotioin.TabIndex = 17
        Me.cmbTargetMotioin.Text = ""
        '
        'cmbTPS
        '
        Me.cmbTPS = New System.Windows.Forms.ComboBox()
        Me.cmbTPS.Location = New System.Drawing.Point(304, 208)
        Me.cmbTPS.Name = "cmbTPS"
        Me.cmbTPS.Size = New System.Drawing.Size(225, 21)
        Me.cmbTPS.TabIndex = 15
        Me.cmbTPS.Text = ""
        '
        'cmbStereotactic
        '
        Me.cmbStereotactic = New System.Windows.Forms.ComboBox()
        Me.cmbStereotactic.Location = New System.Drawing.Point(104, 240)
        Me.cmbStereotactic.Name = "cmbStereotactic"
        Me.cmbStereotactic.Size = New System.Drawing.Size(169, 21)
        Me.cmbStereotactic.TabIndex = 16
        Me.cmbStereotactic.Text = ""
        '
        'cmbIMRTTech
        '
        Me.cmbIMRTTech = New System.Windows.Forms.ComboBox()
        Me.cmbIMRTTech.Location = New System.Drawing.Point(344, 184)
        Me.cmbIMRTTech.Name = "cmbIMRTTech"
        Me.cmbIMRTTech.Size = New System.Drawing.Size(185, 21)
        Me.cmbIMRTTech.TabIndex = 13
        Me.cmbIMRTTech.Text = ""
        '
        'cmbCollimator
        '
        Me.cmbCollimator = New System.Windows.Forms.ComboBox()
        Me.cmbCollimator.Location = New System.Drawing.Point(56, 216)
        Me.cmbCollimator.Name = "cmbCollimator"
        Me.cmbCollimator.Size = New System.Drawing.Size(217, 21)
        Me.cmbCollimator.TabIndex = 14
        Me.cmbCollimator.Text = ""
        '
        'cmbIMD
        '
        Me.cmbIMD = New System.Windows.Forms.ComboBox()
        Me.cmbIMD.Location = New System.Drawing.Point(136, 192)
        Me.cmbIMD.Name = "cmbIMD"
        Me.cmbIMD.Size = New System.Drawing.Size(137, 21)
        Me.cmbIMD.TabIndex = 12
        Me.cmbIMD.Text = ""
        '
        'cmbTechnique
        '
        Me.cmbTechnique = New System.Windows.Forms.ComboBox()
        Me.cmbTechnique.Location = New System.Drawing.Point(408, 152)
        Me.cmbTechnique.Name = "cmbTechnique"
        Me.cmbTechnique.Size = New System.Drawing.Size(121, 21)
        Me.cmbTechnique.TabIndex = 11
        Me.cmbTechnique.Text = ""
        '
        'DBCombo7
        '
        Me.DBCombo7 = New System.Windows.Forms.ComboBox()
        Me.DBCombo7.Location = New System.Drawing.Point(408, 128)
        Me.DBCombo7.Name = "DBCombo7"
        Me.DBCombo7.Size = New System.Drawing.Size(121, 21)
        Me.DBCombo7.TabIndex = 10
        Me.DBCombo7.Text = ""
        '
        'Frame2
        '
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Frame2.Location = New System.Drawing.Point(336, 95)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(187, 31)
        Me.Frame2.TabIndex = 98
        Me.Frame2.Text = "Dose Specified To"
        '
        'EdtMuscleWater
        '
        Me.EdtMuscleWater = New System.Windows.Forms.TextBox()
        Me.EdtMuscleWater.Location = New System.Drawing.Point(153, 12)
        Me.EdtMuscleWater.Name = "EdtMuscleWater"
        Me.EdtMuscleWater.Size = New System.Drawing.Size(25, 19)
        Me.EdtMuscleWater.TabIndex = 99
        Me.EdtMuscleWater.Text = ""
        Me.EdtMuscleWater.Text = ""
        Me.EdtMuscleWater.Multiline = False
        'Datafield = "MUSCLE_OR_WATER"
        'Datafield = "rdcPhantom"
        Me.Frame1.Controls.Add(Me.cmbTargetMotioin)
        Me.Frame1.Controls.Add(Me.cmbTPS)
        Me.Frame1.Controls.Add(Me.cmbStereotactic)
        Me.Frame1.Controls.Add(Me.cmbIMRTTech)
        Me.Frame1.Controls.Add(Me.cmbCollimator)
        Me.Frame1.Controls.Add(Me.cmbIMD)
        Me.Frame1.Controls.Add(Me.cmbTechnique)
        Me.Frame1.Controls.Add(Me.DBCombo7)
        Me.Frame1.Controls.Add(Me.Frame2)
        Me.Frame2.Controls.Add(Me.EdtMuscleWater)
        '
        'Text19
        '
        Me.Text19 = New System.Windows.Forms.TextBox()
        Me.Text19.Location = New System.Drawing.Point(104, 303)
        Me.Text19.Name = "Text19"
        Me.Text19.Size = New System.Drawing.Size(73, 22)
        Me.Text19.TabIndex = 20
        Me.Text19.Text = ""
        Me.Text19.Text = ""
        Me.Text19.Multiline = False
        'Datafield = "REPORTS_SENT_DATE"
        'Datafield = "rdcPhantom"
        '
        'cmbRPCPhysicist
        '
        Me.cmbRPCPhysicist = New System.Windows.Forms.ComboBox()
        Me.cmbRPCPhysicist.Location = New System.Drawing.Point(104, 280)
        Me.cmbRPCPhysicist.Name = "cmbRPCPhysicist"
        Me.cmbRPCPhysicist.Size = New System.Drawing.Size(169, 21)
        Me.cmbRPCPhysicist.TabIndex = 18
        Me.cmbRPCPhysicist.Text = ""
        '
        'btnContactLookup2
        '
        Me.btnContactLookup2 = New System.Windows.Forms.Button()
        Me.btnContactLookup2.Location = New System.Drawing.Point(272, 120)
        Me.btnContactLookup2.Name = "btnContactLookup2"
        Me.btnContactLookup2.Size = New System.Drawing.Size(28, 22)
        Me.btnContactLookup2.TabIndex = 93
        Me.btnContactLookup2.Text = "..."
        Me.btnContactLookup2.UseVisualStyleBackColor = True
        '
        'edtIrradiated2
        '
        Me.edtIrradiated2 = New System.Windows.Forms.TextBox()
        Me.edtIrradiated2.Location = New System.Drawing.Point(280, 144)
        Me.edtIrradiated2.Name = "edtIrradiated2"
        Me.edtIrradiated2.Size = New System.Drawing.Size(33, 21)
        Me.edtIrradiated2.TabIndex = 92
        Me.edtIrradiated2.Text = ""
        Me.edtIrradiated2.Text = ""
        Me.edtIrradiated2.Multiline = False
        'Datafield = "IRRADIATED"
        'Datafield = "rdcPhantom"
        '
        'ChkIrradiated2
        '
        Me.ChkIrradiated2 = New System.Windows.Forms.CheckBox()
        Me.ChkIrradiated2.Location = New System.Drawing.Point(209, 148)
        Me.ChkIrradiated2.Name = "ChkIrradiated2"
        Me.ChkIrradiated2.Size = New System.Drawing.Size(73, 17)
        Me.ChkIrradiated2.TabIndex = 6
        Me.ChkIrradiated2.Text = "Irradiated"
        '
        'Text18
        '
        Me.Text18 = New System.Windows.Forms.TextBox()
        Me.Text18.Location = New System.Drawing.Point(144, 144)
        Me.Text18.Name = "Text18"
        Me.Text18.Size = New System.Drawing.Size(64, 22)
        Me.Text18.TabIndex = 5
        Me.Text18.Text = ""
        Me.Text18.Text = ""
        Me.Text18.Multiline = False
        'Datafield = "IRRADIATE_DATE"
        'Datafield = "rdcPhantom"
        '
        'CmbPhantoms
        '
        Me.CmbPhantoms = New System.Windows.Forms.ComboBox()
        Me.CmbPhantoms.Location = New System.Drawing.Point(88, 96)
        Me.CmbPhantoms.Name = "CmbPhantoms"
        Me.CmbPhantoms.Size = New System.Drawing.Size(185, 21)
        Me.CmbPhantoms.TabIndex = 3
        Me.CmbPhantoms.Text = ""
        '
        'EdtManufacturer
        '
        Me.EdtManufacturer = New System.Windows.Forms.TextBox()
        Me.EdtManufacturer.Location = New System.Drawing.Point(100, 16)
        Me.EdtManufacturer.Name = "EdtManufacturer"
        Me.EdtManufacturer.Size = New System.Drawing.Size(137, 21)
        Me.EdtManufacturer.TabIndex = 77
        Me.EdtManufacturer.Text = ""
        Me.EdtManufacturer.Text = ""
        Me.EdtManufacturer.Multiline = False
        'Datafield = "MANUFACTURER"
        'Datafield = "rdcBeamLookup"
        '
        'EdtModel
        '
        Me.EdtModel = New System.Windows.Forms.TextBox()
        Me.EdtModel.Location = New System.Drawing.Point(100, 40)
        Me.EdtModel.Name = "EdtModel"
        Me.EdtModel.Size = New System.Drawing.Size(137, 21)
        Me.EdtModel.TabIndex = 76
        Me.EdtModel.Text = ""
        Me.EdtModel.Text = ""
        Me.EdtModel.Multiline = False
        'Datafield = "MODEL"
        'Datafield = "rdcBeamLookup"
        '
        'Text3
        '
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text3.Location = New System.Drawing.Point(320, 16)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(45, 21)
        Me.Text3.TabIndex = 75
        Me.Text3.Text = ""
        Me.Text3.Text = ""
        Me.Text3.Multiline = False
        'Datafield = "ENERGY"
        'Datafield = "rdcBeamLookup"
        '
        'Text5
        '
        Me.Text5 = New System.Windows.Forms.TextBox()
        Me.Text5.Location = New System.Drawing.Point(320, 64)
        Me.Text5.Name = "Text5"
        Me.Text5.Size = New System.Drawing.Size(45, 21)
        Me.Text5.TabIndex = 74
        Me.Text5.Text = ""
        Me.Text5.Text = ""
        Me.Text5.Multiline = False
        'Datafield = "SOURCE_NO"
        'Datafield = "rdcBeamLookup"
        '
        'Text6
        '
        Me.Text6 = New System.Windows.Forms.TextBox()
        Me.Text6.Location = New System.Drawing.Point(100, 64)
        Me.Text6.Name = "Text6"
        Me.Text6.Size = New System.Drawing.Size(93, 21)
        Me.Text6.TabIndex = 73
        Me.Text6.Text = ""
        Me.Text6.Text = ""
        Me.Text6.Multiline = False
        'Datafield = "BTYPE"
        'Datafield = "rdcBeamLookup"
        '
        'BtnBeamLookup
        '
        Me.BtnBeamLookup = New System.Windows.Forms.Button()
        Me.BtnBeamLookup.Location = New System.Drawing.Point(381, 27)
        Me.BtnBeamLookup.Name = "BtnBeamLookup"
        Me.BtnBeamLookup.Size = New System.Drawing.Size(92, 25)
        Me.BtnBeamLookup.TabIndex = 1
        Me.BtnBeamLookup.Text = "Beam Lookup..."
        Me.BtnBeamLookup.UseVisualStyleBackColor = True
        '
        'BtnEditMachine
        '
        Me.BtnEditMachine = New System.Windows.Forms.Button()
        Me.BtnEditMachine.Location = New System.Drawing.Point(381, 60)
        Me.BtnEditMachine.Name = "BtnEditMachine"
        Me.BtnEditMachine.Size = New System.Drawing.Size(92, 25)
        Me.BtnEditMachine.TabIndex = 2
        Me.BtnEditMachine.Text = "Edit Machine..."
        Me.BtnEditMachine.UseVisualStyleBackColor = True
        '
        'CmbMachNumLookup
        '
        Me.CmbMachNumLookup = New System.Windows.Forms.ComboBox()
        Me.CmbMachNumLookup.Location = New System.Drawing.Point(320, 40)
        Me.CmbMachNumLookup.Name = "CmbMachNumLookup"
        Me.CmbMachNumLookup.Size = New System.Drawing.Size(45, 21)
        Me.CmbMachNumLookup.TabIndex = 78
        Me.CmbMachNumLookup.Text = ""
        '
        'CmbBatchLookup
        '
        Me.CmbBatchLookup = New System.Windows.Forms.ComboBox()
        Me.CmbBatchLookup.Location = New System.Drawing.Point(466, 304)
        Me.CmbBatchLookup.Name = "CmbBatchLookup"
        Me.CmbBatchLookup.Size = New System.Drawing.Size(64, 21)
        Me.CmbBatchLookup.TabIndex = 21
        Me.CmbBatchLookup.Text = ""
        '
        'CmbIrradiatePhantom
        '
        Me.CmbIrradiatePhantom = New System.Windows.Forms.ComboBox()
        Me.CmbIrradiatePhantom.Location = New System.Drawing.Point(144, 120)
        Me.CmbIrradiatePhantom.Name = "CmbIrradiatePhantom"
        Me.CmbIrradiatePhantom.Size = New System.Drawing.Size(129, 21)
        Me.CmbIrradiatePhantom.TabIndex = 4
        Me.CmbIrradiatePhantom.Text = ""
        '
        'DBCombo4
        '
        Me.DBCombo4 = New System.Windows.Forms.ComboBox()
        Me.DBCombo4.Location = New System.Drawing.Point(443, 280)
        Me.DBCombo4.Name = "DBCombo4"
        Me.DBCombo4.Size = New System.Drawing.Size(88, 21)
        Me.DBCombo4.TabIndex = 19
        Me.DBCombo4.Text = ""
        '
        'DBCombo2
        '
        Me.DBCombo2 = New System.Windows.Forms.ComboBox()
        Me.DBCombo2.Location = New System.Drawing.Point(184, 169)
        Me.DBCombo2.Name = "DBCombo2"
        Me.DBCombo2.Size = New System.Drawing.Size(88, 21)
        Me.DBCombo2.TabIndex = 7
        Me.DBCombo2.Text = ""
        '
        'Label40
        '
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label40.Location = New System.Drawing.Point(280, 240)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(83, 17)
        Me.Label40.TabIndex = 108
        Me.Label40.Text = "Target Motion"
        Me.Label40.Text = "Target Motion"
        '
        'Label39
        '
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label39.Location = New System.Drawing.Point(280, 214)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(43, 17)
        Me.Label39.TabIndex = 107
        Me.Label39.Text = "TPS"
        Me.Label39.Text = "TPS"
        '
        'Label38
        '
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label38.Location = New System.Drawing.Point(8, 242)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(107, 17)
        Me.Label38.TabIndex = 106
        Me.Label38.Text = "Stereotactic System"
        Me.Label38.Text = "Stereotactic System"
        '
        'Label37
        '
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label37.Location = New System.Drawing.Point(280, 190)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(99, 17)
        Me.Label37.TabIndex = 105
        Me.Label37.Text = "IMRT Tech."
        Me.Label37.Text = "IMRT Tech."
        '
        'Label35
        '
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label35.Location = New System.Drawing.Point(8, 218)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(59, 17)
        Me.Label35.TabIndex = 104
        Me.Label35.Text = "Collimator"
        Me.Label35.Text = "Collimator"
        '
        'Label34
        '
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label34.Location = New System.Drawing.Point(8, 196)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(107, 17)
        Me.Label34.TabIndex = 103
        Me.Label34.Text = "Intens. Mod. Device"
        Me.Label34.Text = "Intens. Mod. Device"
        '
        'Label33
        '
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label33.Location = New System.Drawing.Point(320, 160)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(99, 17)
        Me.Label33.TabIndex = 101
        Me.Label33.Text = "Irr. Technique"
        Me.Label33.Text = "Irr. Technique"
        '
        'Label27
        '
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label27.Location = New System.Drawing.Point(320, 136)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(99, 17)
        Me.Label27.TabIndex = 100
        Me.Label27.Text = "Phantom Reason"
        Me.Label27.Text = "Phantom Reason"
        '
        'Label14
        '
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label14.Location = New System.Drawing.Point(8, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 13)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Inst. Calib. Protocol"
        Me.Label14.Text = "Inst. Calib. Protocol"
        '
        'Label26
        '
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label26.Location = New System.Drawing.Point(320, 289)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(113, 13)
        Me.Label26.TabIndex = 96
        Me.Label26.Text = "RPC Calib. Protocol"
        Me.Label26.Text = "RPC Calib. Protocol"
        '
        'Label32
        '
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label32.Location = New System.Drawing.Point(8, 312)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(99, 17)
        Me.Label32.TabIndex = 95
        Me.Label32.Text = "Reports Sent Date"
        Me.Label32.Text = "Reports Sent Date"
        '
        'Label31
        '
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label31.Location = New System.Drawing.Point(8, 288)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 25)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "RPC Physicist"
        Me.Label31.Text = "RPC Physicist"
        '
        'Label30
        '
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label30.Location = New System.Drawing.Point(8, 125)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(149, 13)
        Me.Label30.TabIndex = 91
        Me.Label30.Text = "Person Irradiating Phantom"
        Me.Label30.Text = "Person Irradiating Phantom"
        '
        'Label29
        '
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label29.Location = New System.Drawing.Point(8, 152)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(122, 13)
        Me.Label29.TabIndex = 90
        Me.Label29.Text = "Irradiation Date"
        Me.Label29.Text = "Irradiation Date"
        '
        'Label28
        '
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label28.Location = New System.Drawing.Point(8, 104)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 17)
        Me.Label28.TabIndex = 89
        Me.Label28.Text = "Phantom"
        Me.Label28.Text = "Phantom"
        '
        'Label25
        '
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label25.Location = New System.Drawing.Point(320, 312)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 13)
        Me.Label25.TabIndex = 88
        Me.Label25.Text = "Batch"
        Me.Label25.Text = "Batch"
        '
        'Label1
        '
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Manufacturer"
        Me.Label1.Text = "Manufacturer"
        '
        'Label2
        '
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Model"
        Me.Label2.Text = "Model"
        '
        'Label4
        '
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label4.Location = New System.Drawing.Point(252, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Energy"
        Me.Label4.Text = "Energy"
        '
        'Label6
        '
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label6.Location = New System.Drawing.Point(252, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Mach#"
        Me.Label6.Text = "Mach#"
        '
        'Label7
        '
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label7.Location = New System.Drawing.Point(252, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Source No"
        Me.Label7.Text = "Source No"
        '
        'Label8
        '
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label8.Location = New System.Drawing.Point(8, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Type"
        Me.Label8.Text = "Type"
        Me.Frame1.Controls.Add(Me.Text19)
        Me.Frame1.Controls.Add(Me.cmbRPCPhysicist)
        Me.Frame1.Controls.Add(Me.btnContactLookup2)
        Me.Frame1.Controls.Add(Me.edtIrradiated2)
        Me.Frame1.Controls.Add(Me.ChkIrradiated2)
        Me.Frame1.Controls.Add(Me.Text18)
        Me.Frame1.Controls.Add(Me.CmbPhantoms)
        Me.Frame1.Controls.Add(Me.EdtManufacturer)
        Me.Frame1.Controls.Add(Me.EdtModel)
        Me.Frame1.Controls.Add(Me.Text3)
        Me.Frame1.Controls.Add(Me.Text5)
        Me.Frame1.Controls.Add(Me.Text6)
        Me.Frame1.Controls.Add(Me.BtnBeamLookup)
        Me.Frame1.Controls.Add(Me.BtnEditMachine)
        Me.Frame1.Controls.Add(Me.CmbMachNumLookup)
        Me.Frame1.Controls.Add(Me.CmbBatchLookup)
        Me.Frame1.Controls.Add(Me.CmbIrradiatePhantom)
        Me.Frame1.Controls.Add(Me.DBCombo4)
        Me.Frame1.Controls.Add(Me.DBCombo2)
        Me.Frame1.Controls.Add(Me.Label40)
        Me.Frame1.Controls.Add(Me.Label39)
        Me.Frame1.Controls.Add(Me.Label38)
        Me.Frame1.Controls.Add(Me.Label37)
        Me.Frame1.Controls.Add(Me.Label35)
        Me.Frame1.Controls.Add(Me.Label34)
        Me.Frame1.Controls.Add(Me.Label33)
        Me.Frame1.Controls.Add(Me.Label27)
        Me.Frame1.Controls.Add(Me.Label14)
        Me.Frame1.Controls.Add(Me.Label26)
        Me.Frame1.Controls.Add(Me.Label32)
        Me.Frame1.Controls.Add(Me.Label31)
        Me.Frame1.Controls.Add(Me.Label30)
        Me.Frame1.Controls.Add(Me.Label29)
        Me.Frame1.Controls.Add(Me.Label28)
        Me.Frame1.Controls.Add(Me.Label25)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label8)
        '
        'Frame4
        '
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.Frame4.Location = New System.Drawing.Point(8, 496)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(538, 221)
        Me.Frame4.TabIndex = 51
        Me.Frame4.Text = "Dose Specification for Block"
        '
        'cmbOutputSource
        '
        Me.cmbOutputSource = New System.Windows.Forms.ComboBox()
        Me.cmbOutputSource.Location = New System.Drawing.Point(132, 40)
        Me.cmbOutputSource.Name = "cmbOutputSource"
        Me.cmbOutputSource.Size = New System.Drawing.Size(113, 21)
        Me.cmbOutputSource.TabIndex = 29
        Me.cmbOutputSource.Text = ""
        '
        'CmbCorrectionTypeLookup
        '
        Me.CmbCorrectionTypeLookup = New System.Windows.Forms.ComboBox()
        Me.CmbCorrectionTypeLookup.Location = New System.Drawing.Point(132, 88)
        Me.CmbCorrectionTypeLookup.Name = "CmbCorrectionTypeLookup"
        Me.CmbCorrectionTypeLookup.Size = New System.Drawing.Size(113, 21)
        Me.CmbCorrectionTypeLookup.TabIndex = 35
        Me.CmbCorrectionTypeLookup.Text = ""
        '
        'TxtTMR
        '
        Me.TxtTMR = New System.Windows.Forms.TextBox()
        Me.TxtTMR.Location = New System.Drawing.Point(423, 63)
        Me.TxtTMR.Name = "TxtTMR"
        Me.TxtTMR.Size = New System.Drawing.Size(64, 22)
        Me.TxtTMR.TabIndex = 34
        Me.TxtTMR.Text = ""
        Me.TxtTMR.Text = ""
        Me.TxtTMR.Multiline = False
        'Datafield = "TMR"
        'Datafield = "rdcPhantomBlock"
        '
        'Frame5
        '
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.Frame5.Location = New System.Drawing.Point(8, 144)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Size = New System.Drawing.Size(517, 67)
        Me.Frame5.TabIndex = 53
        Me.Frame5.Text = "Setup"
        '
        'Text2
        '
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text2.Location = New System.Drawing.Point(207, 39)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(58, 22)
        Me.Text2.TabIndex = 58
        Me.Text2.Text = ""
        Me.Text2.Text = ""
        Me.Text2.Multiline = False
        'Datafield = "DEPTH_TYPE"
        'Datafield = "rdcSetupLookup"
        '
        'BtnSetupLookup
        '
        Me.BtnSetupLookup = New System.Windows.Forms.Button()
        Me.BtnSetupLookup.Location = New System.Drawing.Point(294, 42)
        Me.BtnSetupLookup.Name = "BtnSetupLookup"
        Me.BtnSetupLookup.Size = New System.Drawing.Size(121, 22)
        Me.BtnSetupLookup.TabIndex = 37
        Me.BtnSetupLookup.Text = "Setup Lookup..."
        Me.BtnSetupLookup.UseVisualStyleBackColor = True
        '
        'Text15
        '
        Me.Text15 = New System.Windows.Forms.TextBox()
        Me.Text15.Location = New System.Drawing.Point(66, 15)
        Me.Text15.Name = "Text15"
        Me.Text15.Size = New System.Drawing.Size(57, 21)
        Me.Text15.TabIndex = 57
        Me.Text15.Text = ""
        Me.Text15.Text = ""
        Me.Text15.Multiline = False
        'Datafield = "SSD_SAD_AIR"
        'Datafield = "rdcSetupLookup"
        '
        'Text14
        '
        Me.Text14 = New System.Windows.Forms.TextBox()
        Me.Text14.Location = New System.Drawing.Point(66, 39)
        Me.Text14.Name = "Text14"
        Me.Text14.Size = New System.Drawing.Size(57, 21)
        Me.Text14.TabIndex = 56
        Me.Text14.Text = ""
        Me.Text14.Text = ""
        Me.Text14.Multiline = False
        'Datafield = "FIELD_SIZE"
        'Datafield = "rdcSetupLookup"
        '
        'Text13
        '
        Me.Text13 = New System.Windows.Forms.TextBox()
        Me.Text13.Location = New System.Drawing.Point(208, 15)
        Me.Text13.Name = "Text13"
        Me.Text13.Size = New System.Drawing.Size(57, 21)
        Me.Text13.TabIndex = 55
        Me.Text13.Text = ""
        Me.Text13.Text = ""
        Me.Text13.Multiline = False
        'Datafield = "DISTANCE"
        'Datafield = "rdcSetupLookup"
        '
        'Text12
        '
        Me.Text12 = New System.Windows.Forms.TextBox()
        Me.Text12.Location = New System.Drawing.Point(358, 15)
        Me.Text12.Name = "Text12"
        Me.Text12.Size = New System.Drawing.Size(57, 21)
        Me.Text12.TabIndex = 54
        Me.Text12.Text = ""
        Me.Text12.Text = ""
        Me.Text12.Multiline = False
        'Datafield = "DEPTH"
        'Datafield = "rdcSetupLookup"
        '
        'Label9
        '
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label9.Location = New System.Drawing.Point(144, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Depth Type"
        Me.Label9.Text = "Depth Type"
        '
        'Label22
        '
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label22.Location = New System.Drawing.Point(9, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 17)
        Me.Label22.TabIndex = 62
        Me.Label22.Text = "Type"
        Me.Label22.Text = "Type"
        '
        'Label21
        '
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label21.Location = New System.Drawing.Point(144, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 17)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "SSD (cm)"
        Me.Label21.Text = "SSD (cm)"
        '
        'Label20
        '
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label20.Location = New System.Drawing.Point(9, 47)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 17)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Field Size"
        Me.Label20.Text = "Field Size"
        '
        'Label19
        '
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label19.Location = New System.Drawing.Point(294, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 17)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Depth (cm)"
        Me.Label19.Text = "Depth (cm)"
        Me.Frame4.Controls.Add(Me.cmbOutputSource)
        Me.Frame4.Controls.Add(Me.CmbCorrectionTypeLookup)
        Me.Frame4.Controls.Add(Me.TxtTMR)
        Me.Frame4.Controls.Add(Me.Frame5)
        Me.Frame5.Controls.Add(Me.Text2)
        Me.Frame5.Controls.Add(Me.BtnSetupLookup)
        Me.Frame5.Controls.Add(Me.Text15)
        Me.Frame5.Controls.Add(Me.Text14)
        Me.Frame5.Controls.Add(Me.Text13)
        Me.Frame5.Controls.Add(Me.Text12)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.Controls.Add(Me.Label22)
        Me.Frame5.Controls.Add(Me.Label21)
        Me.Frame5.Controls.Add(Me.Label20)
        Me.Frame5.Controls.Add(Me.Label19)
        '
        'Text11
        '
        Me.Text11 = New System.Windows.Forms.TextBox()
        Me.Text11.Location = New System.Drawing.Point(132, 16)
        Me.Text11.Name = "Text11"
        Me.Text11.Size = New System.Drawing.Size(64, 22)
        Me.Text11.TabIndex = 52
        Me.Text11.Text = ""
        Me.Text11.Text = ""
        Me.Text11.Multiline = False
        'Datafield = "DOSE_DISTANCE"
        'Datafield = "rdcSetupLookup"
        '
        'Text8
        '
        Me.Text8 = New System.Windows.Forms.TextBox()
        Me.Text8.Location = New System.Drawing.Point(423, 16)
        Me.Text8.Name = "Text8"
        Me.Text8.Size = New System.Drawing.Size(64, 22)
        Me.Text8.TabIndex = 30
        Me.Text8.Text = ""
        Me.Text8.Text = ""
        Me.Text8.Multiline = False
        'Datafield = "INST_OUTPUT"
        'Datafield = "rdcPhantomBlock"
        '
        'Text9
        '
        Me.Text9 = New System.Windows.Forms.TextBox()
        Me.Text9.Location = New System.Drawing.Point(423, 40)
        Me.Text9.Name = "Text9"
        Me.Text9.Size = New System.Drawing.Size(64, 22)
        Me.Text9.TabIndex = 31
        Me.Text9.Text = ""
        Me.Text9.Text = ""
        Me.Text9.Multiline = False
        'Datafield = "INSTITUTION_DOSE"
        'Datafield = "rdcPhantomBlock"
        '
        'TxtExactDate
        '
        Me.TxtExactDate = New System.Windows.Forms.TextBox()
        Me.TxtExactDate.Location = New System.Drawing.Point(132, 64)
        Me.TxtExactDate.Name = "TxtExactDate"
        Me.TxtExactDate.Size = New System.Drawing.Size(64, 22)
        Me.TxtExactDate.TabIndex = 33
        Me.TxtExactDate.Text = ""
        Me.TxtExactDate.Text = ""
        Me.TxtExactDate.Multiline = False
        'Datafield = "EXACT_DATE"
        'Datafield = "rdcPhantomBlock"
        '
        'Text16
        '
        Me.Text16 = New System.Windows.Forms.TextBox()
        Me.Text16.Location = New System.Drawing.Point(132, 112)
        Me.Text16.Name = "Text16"
        Me.Text16.Size = New System.Drawing.Size(64, 22)
        Me.Text16.TabIndex = 36
        Me.Text16.Text = ""
        Me.Text16.Text = ""
        Me.Text16.Multiline = False
        'Datafield = "OTHER_CORRECTION"
        'Datafield = "rdcPhantomBlock"
        '
        'LblTMR
        '
        Me.LblTMR = New System.Windows.Forms.Label()
        Me.LblTMR.Location = New System.Drawing.Point(300, 73)
        Me.LblTMR.Name = "LblTMR"
        Me.LblTMR.Size = New System.Drawing.Size(110, 13)
        Me.LblTMR.TabIndex = 71
        Me.LblTMR.Text = "TMR"
        Me.LblTMR.Text = "TMR"
        '
        'Label12
        '
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label12.Location = New System.Drawing.Point(300, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Inst Output"
        Me.Label12.Text = "Inst Output"
        '
        'Label13
        '
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label13.Location = New System.Drawing.Point(12, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 13)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Output Determined From"
        Me.Label13.Text = "Output Determined From"
        '
        'Label15
        '
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label15.Location = New System.Drawing.Point(300, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Institution Dose"
        Me.Label15.Text = "Institution Dose"
        '
        'Label16
        '
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label16.Location = New System.Drawing.Point(12, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 13)
        Me.Label16.TabIndex = 67
        Me.Label16.Text = "Dist to Dose Spec. Pt."
        Me.Label16.Text = "Dist to Dose Spec. Pt."
        '
        'LblExactDate
        '
        Me.LblExactDate = New System.Windows.Forms.Label()
        Me.LblExactDate.Location = New System.Drawing.Point(12, 73)
        Me.LblExactDate.Name = "LblExactDate"
        Me.LblExactDate.Size = New System.Drawing.Size(113, 13)
        Me.LblExactDate.TabIndex = 66
        Me.LblExactDate.Text = "Date Dose Is Exact"
        Me.LblExactDate.Text = "Date Dose Is Exact"
        '
        'Label23
        '
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label23.Location = New System.Drawing.Point(12, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(125, 13)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Other Correction"
        Me.Label23.Text = "Other Correction"
        '
        'Label24
        '
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label24.Location = New System.Drawing.Point(12, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 13)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Other Correction Type"
        Me.Label24.Text = "Other Correction Type"
        Me.Frame4.Controls.Add(Me.Text11)
        Me.Frame4.Controls.Add(Me.Text8)
        Me.Frame4.Controls.Add(Me.Text9)
        Me.Frame4.Controls.Add(Me.TxtExactDate)
        Me.Frame4.Controls.Add(Me.Text16)
        Me.Frame4.Controls.Add(Me.LblTMR)
        Me.Frame4.Controls.Add(Me.Label12)
        Me.Frame4.Controls.Add(Me.Label13)
        Me.Frame4.Controls.Add(Me.Label15)
        Me.Frame4.Controls.Add(Me.Label16)
        Me.Frame4.Controls.Add(Me.LblExactDate)
        Me.Frame4.Controls.Add(Me.Label23)
        Me.Frame4.Controls.Add(Me.Label24)
        '
        'Frame3
        '
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.Frame3.Location = New System.Drawing.Point(9, 392)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Size = New System.Drawing.Size(538, 97)
        Me.Frame3.TabIndex = 43
        Me.Frame3.Text = "Irradiation Setup For Block"
        '
        'txtDistToPlatform
        '
        Me.txtDistToPlatform = New System.Windows.Forms.TextBox()
        Me.txtDistToPlatform.Location = New System.Drawing.Point(424, 70)
        Me.txtDistToPlatform.Name = "txtDistToPlatform"
        Me.txtDistToPlatform.Size = New System.Drawing.Size(65, 22)
        Me.txtDistToPlatform.TabIndex = 28
        Me.txtDistToPlatform.Text = ""
        Me.txtDistToPlatform.Text = ""
        Me.txtDistToPlatform.Multiline = False
        'Datafield = "PLATFORM_DISTANCE"
        'Datafield = "rdcPhantomBlock"
        '
        'txtActualSetting
        '
        Me.txtActualSetting = New System.Windows.Forms.TextBox()
        Me.txtActualSetting.Location = New System.Drawing.Point(112, 70)
        Me.txtActualSetting.Name = "txtActualSetting"
        Me.txtActualSetting.Size = New System.Drawing.Size(73, 22)
        Me.txtActualSetting.TabIndex = 25
        Me.txtActualSetting.Text = ""
        Me.txtActualSetting.Text = ""
        Me.txtActualSetting.Multiline = False
        'Datafield = "ACTUAL_SETTING"
        'Datafield = "rdcPhantomBlock"
        '
        'txtNetSetting
        '
        Me.txtNetSetting = New System.Windows.Forms.TextBox()
        Me.txtNetSetting.Location = New System.Drawing.Point(424, 45)
        Me.txtNetSetting.Name = "txtNetSetting"
        Me.txtNetSetting.Size = New System.Drawing.Size(64, 22)
        Me.txtNetSetting.TabIndex = 27
        Me.txtNetSetting.Text = ""
        Me.txtNetSetting.Text = ""
        Me.txtNetSetting.Multiline = False
        'Datafield = "NET_SETTING"
        'Datafield = "rdcPhantomBlock"
        '
        'cmbPersonIrrBlock
        '
        Me.cmbPersonIrrBlock = New System.Windows.Forms.ComboBox()
        Me.cmbPersonIrrBlock.Location = New System.Drawing.Point(125, 21)
        Me.cmbPersonIrrBlock.Name = "cmbPersonIrrBlock"
        Me.cmbPersonIrrBlock.Size = New System.Drawing.Size(129, 21)
        Me.cmbPersonIrrBlock.TabIndex = 22
        Me.cmbPersonIrrBlock.Text = ""
        '
        'edtIrradiated
        '
        Me.edtIrradiated = New System.Windows.Forms.TextBox()
        Me.edtIrradiated.Location = New System.Drawing.Point(232, 48)
        Me.edtIrradiated.Name = "edtIrradiated"
        Me.edtIrradiated.Size = New System.Drawing.Size(25, 19)
        Me.edtIrradiated.TabIndex = 102
        Me.edtIrradiated.Text = ""
        Me.edtIrradiated.Text = ""
        Me.edtIrradiated.Multiline = False
        'Datafield = "IRRADIATED"
        'Datafield = "rdcPhantomBlock"
        '
        'ChkIrradiated
        '
        Me.ChkIrradiated = New System.Windows.Forms.CheckBox()
        Me.ChkIrradiated.Location = New System.Drawing.Point(168, 48)
        Me.ChkIrradiated.Name = "ChkIrradiated"
        Me.ChkIrradiated.Size = New System.Drawing.Size(73, 17)
        Me.ChkIrradiated.TabIndex = 24
        Me.ChkIrradiated.Text = "Irradiated"
        '
        'txtIrradDate
        '
        Me.txtIrradDate = New System.Windows.Forms.TextBox()
        Me.txtIrradDate.Location = New System.Drawing.Point(88, 46)
        Me.txtIrradDate.Name = "txtIrradDate"
        Me.txtIrradDate.Size = New System.Drawing.Size(73, 22)
        Me.txtIrradDate.TabIndex = 23
        Me.txtIrradDate.Text = ""
        Me.txtIrradDate.Text = ""
        Me.txtIrradDate.Multiline = False
        'Datafield = "IRRADIATE_DATE"
        'Datafield = "rdcPhantomBlock"
        '
        'BtnContactLookup
        '
        Me.BtnContactLookup = New System.Windows.Forms.Button()
        Me.BtnContactLookup.Location = New System.Drawing.Point(255, 21)
        Me.BtnContactLookup.Name = "BtnContactLookup"
        Me.BtnContactLookup.Size = New System.Drawing.Size(28, 22)
        Me.BtnContactLookup.TabIndex = 44
        Me.BtnContactLookup.Text = "..."
        Me.BtnContactLookup.UseVisualStyleBackColor = True
        '
        'EdtBlockNum
        '
        Me.EdtBlockNum = New System.Windows.Forms.TextBox()
        Me.EdtBlockNum.Location = New System.Drawing.Point(423, 21)
        Me.EdtBlockNum.Name = "EdtBlockNum"
        Me.EdtBlockNum.Size = New System.Drawing.Size(64, 22)
        Me.EdtBlockNum.TabIndex = 26
        Me.EdtBlockNum.Text = ""
        Me.EdtBlockNum.Text = ""
        Me.EdtBlockNum.Multiline = False
        '
        'LblActualSetting
        '
        Me.LblActualSetting = New System.Windows.Forms.Label()
        Me.LblActualSetting.Location = New System.Drawing.Point(12, 75)
        Me.LblActualSetting.Name = "LblActualSetting"
        Me.LblActualSetting.Size = New System.Drawing.Size(107, 13)
        Me.LblActualSetting.TabIndex = 50
        Me.LblActualSetting.Text = "Actual Timer Setting"
        Me.LblActualSetting.Text = "Actual Timer Setting"
        '
        'LblNetSetting
        '
        Me.LblNetSetting = New System.Windows.Forms.Label()
        Me.LblNetSetting.Location = New System.Drawing.Point(297, 54)
        Me.LblNetSetting.Name = "LblNetSetting"
        Me.LblNetSetting.Size = New System.Drawing.Size(119, 13)
        Me.LblNetSetting.TabIndex = 49
        Me.LblNetSetting.Text = "Net Timer Setting"
        Me.LblNetSetting.Text = "Net Timer Setting"
        '
        'LblDistToPlatform
        '
        Me.LblDistToPlatform = New System.Windows.Forms.Label()
        Me.LblDistToPlatform.Location = New System.Drawing.Point(297, 78)
        Me.LblDistToPlatform.Name = "LblDistToPlatform"
        Me.LblDistToPlatform.Size = New System.Drawing.Size(125, 13)
        Me.LblDistToPlatform.TabIndex = 48
        Me.LblDistToPlatform.Text = "Dist. to Top of Platform"
        Me.LblDistToPlatform.Text = "Dist. to Top of Platform"
        '
        'Label17
        '
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label17.Location = New System.Drawing.Point(12, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 13)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Irradiation Date"
        Me.Label17.Text = "Irradiation Date"
        '
        'Label5
        '
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label5.Location = New System.Drawing.Point(297, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Block Number"
        Me.Label5.Text = "Block Number"
        '
        'Label3
        '
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Person Irradiating TLD"
        Me.Label3.Text = "Person Irradiating TLD"
        Me.Frame3.Controls.Add(Me.txtDistToPlatform)
        Me.Frame3.Controls.Add(Me.txtActualSetting)
        Me.Frame3.Controls.Add(Me.txtNetSetting)
        Me.Frame3.Controls.Add(Me.cmbPersonIrrBlock)
        Me.Frame3.Controls.Add(Me.edtIrradiated)
        Me.Frame3.Controls.Add(Me.ChkIrradiated)
        Me.Frame3.Controls.Add(Me.txtIrradDate)
        Me.Frame3.Controls.Add(Me.BtnContactLookup)
        Me.Frame3.Controls.Add(Me.EdtBlockNum)
        Me.Frame3.Controls.Add(Me.LblActualSetting)
        Me.Frame3.Controls.Add(Me.LblNetSetting)
        Me.Frame3.Controls.Add(Me.LblDistToPlatform)
        Me.Frame3.Controls.Add(Me.Label17)
        Me.Frame3.Controls.Add(Me.Label5)
        Me.Frame3.Controls.Add(Me.Label3)
        '
        'Frame6
        '
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.Frame6.Location = New System.Drawing.Point(8, 0)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Size = New System.Drawing.Size(538, 46)
        Me.Frame6.TabIndex = 0
        Me.Frame6.Text = "Institution Info"
        '
        'Text4
        '
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Text4.Location = New System.Drawing.Point(360, 18)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(148, 22)
        Me.Text4.TabIndex = 39
        Me.Text4.Text = ""
        Me.Text4.Text = ""
        Me.Text4.Multiline = False
        'Datafield = "LOCATION"
        'Datafield = "rdcInstitutionInfo"
        '
        'Text7
        '
        Me.Text7 = New System.Windows.Forms.TextBox()
        Me.Text7.Location = New System.Drawing.Point(144, 18)
        Me.Text7.Name = "Text7"
        Me.Text7.Size = New System.Drawing.Size(154, 22)
        Me.Text7.TabIndex = 38
        Me.Text7.Text = ""
        Me.Text7.Text = ""
        Me.Text7.Multiline = False
        'Datafield = "INSTITUTION_NAME"
        'Datafield = "rdcInstitutionInfo"
        '
        'Text10
        '
        Me.Text10 = New System.Windows.Forms.TextBox()
        Me.Text10.Location = New System.Drawing.Point(48, 18)
        Me.Text10.Name = "Text10"
        Me.Text10.Size = New System.Drawing.Size(46, 22)
        Me.Text10.TabIndex = 32
        Me.Text10.Text = ""
        Me.Text10.Text = ""
        Me.Text10.Multiline = False
        'Datafield = "INSTITUTION_CODE"
        'Datafield = "rdcInstitutionInfo"
        '
        'Label10
        '
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label10.Location = New System.Drawing.Point(312, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Location"
        Me.Label10.Text = "Location"
        '
        'Label11
        '
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label11.Location = New System.Drawing.Point(108, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Name"
        Me.Label11.Text = "Name"
        '
        'Label18
        '
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label18.Location = New System.Drawing.Point(12, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Code"
        Me.Label18.Text = "Code"
        Me.Frame6.Controls.Add(Me.Text4)
        Me.Frame6.Controls.Add(Me.Text7)
        Me.Frame6.Controls.Add(Me.Text10)
        Me.Frame6.Controls.Add(Me.Label10)
        Me.Frame6.Controls.Add(Me.Label11)
        Me.Frame6.Controls.Add(Me.Label18)
        '
        'frmEditPhantomAndBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 761)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame6)
        Me.Name = "frmEditPhantomAndBlock"
        Me.Text = "frmEditPhantomAndBlock"
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents cmbTargetMotioin As ComboBox
    Friend WithEvents cmbTPS As ComboBox
    Friend WithEvents cmbStereotactic As ComboBox
    Friend WithEvents cmbIMRTTech As ComboBox
    Friend WithEvents cmbCollimator As ComboBox
    Friend WithEvents cmbIMD As ComboBox
    Friend WithEvents cmbTechnique As ComboBox
    Friend WithEvents DBCombo7 As ComboBox
    Friend WithEvents Frame2 As GroupBox
    Friend WithEvents EdtMuscleWater As TextBox
    Friend WithEvents Text19 As TextBox
    Friend WithEvents cmbRPCPhysicist As ComboBox
    Friend WithEvents btnContactLookup2 As Button
    Friend WithEvents edtIrradiated2 As TextBox
    Friend WithEvents ChkIrradiated2 As CheckBox
    Friend WithEvents Text18 As TextBox
    Friend WithEvents CmbPhantoms As ComboBox
    Friend WithEvents EdtManufacturer As TextBox
    Friend WithEvents EdtModel As TextBox
    Friend WithEvents Text3 As TextBox
    Friend WithEvents Text5 As TextBox
    Friend WithEvents Text6 As TextBox
    Friend WithEvents BtnBeamLookup As Button
    Friend WithEvents BtnEditMachine As Button
    Friend WithEvents CmbMachNumLookup As ComboBox
    Friend WithEvents CmbBatchLookup As ComboBox
    Friend WithEvents CmbIrradiatePhantom As ComboBox
    Friend WithEvents DBCombo4 As ComboBox
    Friend WithEvents DBCombo2 As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Frame4 As GroupBox
    Friend WithEvents cmbOutputSource As ComboBox
    Friend WithEvents CmbCorrectionTypeLookup As ComboBox
    Friend WithEvents TxtTMR As TextBox
    Friend WithEvents Frame5 As GroupBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents BtnSetupLookup As Button
    Friend WithEvents Text15 As TextBox
    Friend WithEvents Text14 As TextBox
    Friend WithEvents Text13 As TextBox
    Friend WithEvents Text12 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Text11 As TextBox
    Friend WithEvents Text8 As TextBox
    Friend WithEvents Text9 As TextBox
    Friend WithEvents TxtExactDate As TextBox
    Friend WithEvents Text16 As TextBox
    Friend WithEvents LblTMR As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblExactDate As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Frame3 As GroupBox
    Friend WithEvents txtDistToPlatform As TextBox
    Friend WithEvents txtActualSetting As TextBox
    Friend WithEvents txtNetSetting As TextBox
    Friend WithEvents cmbPersonIrrBlock As ComboBox
    Friend WithEvents edtIrradiated As TextBox
    Friend WithEvents ChkIrradiated As CheckBox
    Friend WithEvents txtIrradDate As TextBox
    Friend WithEvents BtnContactLookup As Button
    Friend WithEvents EdtBlockNum As TextBox
    Friend WithEvents LblActualSetting As Label
    Friend WithEvents LblNetSetting As Label
    Friend WithEvents LblDistToPlatform As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Frame6 As GroupBox
    Friend WithEvents Text4 As TextBox
    Friend WithEvents Text7 As TextBox
    Friend WithEvents Text10 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
End Class
