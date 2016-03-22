<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditPhantomSession 
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
        Me.BtnClose.Location = new System.Drawing.Point(16,505)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = new System.Drawing.Size(89,25)
        Me.BtnClose.TabIndex = 85
        Me.BtnClose.Text = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame1.Location = new System.Drawing.Point(9,8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = new System.Drawing.Size(540,153)
        Me.Frame1.TabIndex = 67
        Me.Frame1.Text = "Blocks"
        '
        'FrmSessionBlocks
        '
        Me.FrmSessionBlocks = New System.Windows.Forms.GroupBox()
        Me.FrmSessionBlocks.Location = new System.Drawing.Point(224,20)
        Me.FrmSessionBlocks.Name = "FrmSessionBlocks"
        Me.FrmSessionBlocks.Size = new System.Drawing.Size(309,121)
        Me.FrmSessionBlocks.TabIndex = 78
        Me.FrmSessionBlocks.Text = "Blocks Read In This Session"
        '
        'BtnRemoveBlock
        '
        Me.BtnRemoveBlock = New System.Windows.Forms.Button()
        Me.BtnRemoveBlock.Location = new System.Drawing.Point(280,20)
        Me.BtnRemoveBlock.Name = "BtnRemoveBlock"
        Me.BtnRemoveBlock.Size = new System.Drawing.Size(21,21)
        Me.BtnRemoveBlock.TabIndex = 80
        Me.BtnRemoveBlock.Text = "BtnRemoveBlock"
        Me.BtnRemoveBlock.UseVisualStyleBackColor = True
        '
        'BtnRemoveAllBlocks
        '
        Me.BtnRemoveAllBlocks = New System.Windows.Forms.Button()
        Me.BtnRemoveAllBlocks.Location = new System.Drawing.Point(172,20)
        Me.BtnRemoveAllBlocks.Name = "BtnRemoveAllBlocks"
        Me.BtnRemoveAllBlocks.Size = new System.Drawing.Size(21,21)
        Me.BtnRemoveAllBlocks.TabIndex = 79
        Me.BtnRemoveAllBlocks.Text = "BtnRemoveAllBlocks"
        Me.BtnRemoveAllBlocks.UseVisualStyleBackColor = True
        '
        'LstBlocks
        '
        Me.LstBlocks = New System.Windows.Forms.ListBox()
        Me.LstBlocks.Location = new System.Drawing.Point(204,44)
        Me.LstBlocks.Name = "LstBlocks"
        Me.LstBlocks.Size = new System.Drawing.Size(97,69)
        Me.LstBlocks.TabIndex = 81
        Me.LstBlocks.Text = ""
        Me.LstBlocks.FormattingEnabled = True
        '
        'LstInstitutions
        '
        Me.LstInstitutions = New System.Windows.Forms.ListBox()
        Me.LstInstitutions.Location = new System.Drawing.Point(8,44)
        Me.LstInstitutions.Name = "LstInstitutions"
        Me.LstInstitutions.Size = new System.Drawing.Size(185,69)
        Me.LstInstitutions.TabIndex = 82
        Me.LstInstitutions.Text = ""
        Me.LstInstitutions.FormattingEnabled = True
        '
        'Label19
        '
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label19.Location = new System.Drawing.Point(8,24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = new System.Drawing.Size(123,13)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Institutions"
        Me.Label19.Text = "Institutions"
        '
        'Label3
        '
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label3.Location = new System.Drawing.Point(204,24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = new System.Drawing.Size(71,17)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Phantoms"
        Me.Label3.Text = "Phantoms"
        Me.Frame1.Controls.Add(Me.FrmSessionBlocks)
        Me.FrmSessionBlocks.Controls.Add(Me.BtnRemoveBlock)
        Me.FrmSessionBlocks.Controls.Add(Me.BtnRemoveAllBlocks)
        Me.FrmSessionBlocks.Controls.Add(Me.LstBlocks)
        Me.FrmSessionBlocks.Controls.Add(Me.LstInstitutions)
        Me.FrmSessionBlocks.Controls.Add(Me.Label19)
        Me.FrmSessionBlocks.Controls.Add(Me.Label3)
        '
        'Frame5
        '
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.Frame5.Location = new System.Drawing.Point(8,12)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Size = new System.Drawing.Size(213,137)
        Me.Frame5.TabIndex = 68
        Me.Frame5.Text = "Select Blocks To Add To Session"
        '
        'BtnAddAllBlocks
        '
        Me.BtnAddAllBlocks = New System.Windows.Forms.Button()
        Me.BtnAddAllBlocks.Location = new System.Drawing.Point(152,108)
        Me.BtnAddAllBlocks.Name = "BtnAddAllBlocks"
        Me.BtnAddAllBlocks.Size = new System.Drawing.Size(49,21)
        Me.BtnAddAllBlocks.TabIndex = 72
        Me.BtnAddAllBlocks.Text = "Add All"
        Me.BtnAddAllBlocks.UseVisualStyleBackColor = True
        '
        'BtnAddBlock
        '
        Me.BtnAddBlock = New System.Windows.Forms.Button()
        Me.BtnAddBlock.Location = new System.Drawing.Point(128,108)
        Me.BtnAddBlock.Name = "BtnAddBlock"
        Me.BtnAddBlock.Size = new System.Drawing.Size(21,21)
        Me.BtnAddBlock.TabIndex = 71
        Me.BtnAddBlock.Text = "BtnAddBlock"
        Me.BtnAddBlock.UseVisualStyleBackColor = True
        '
        'BtnInstitutionSearch
        '
        Me.BtnInstitutionSearch = New System.Windows.Forms.Button()
        Me.BtnInstitutionSearch.Location = new System.Drawing.Point(176,28)
        Me.BtnInstitutionSearch.Name = "BtnInstitutionSearch"
        Me.BtnInstitutionSearch.Size = new System.Drawing.Size(25,25)
        Me.BtnInstitutionSearch.TabIndex = 69
        Me.BtnInstitutionSearch.Text = "BtnInstitutionSearch"
        Me.BtnInstitutionSearch.UseVisualStyleBackColor = True
        '
        'CmbBlockLookup
        '
        Me.CmbBlockLookup = New System.Windows.Forms.ComboBox()
        Me.CmbBlockLookup.Location = new System.Drawing.Point(12,108)
        Me.CmbBlockLookup.Name = "CmbBlockLookup"
        Me.CmbBlockLookup.Size = new System.Drawing.Size(109,21)
        Me.CmbBlockLookup.TabIndex = 73
        Me.CmbBlockLookup.Text = ""
        '
        'CmbInstitutionLookup
        '
        Me.CmbInstitutionLookup = New System.Windows.Forms.ComboBox()
        Me.CmbInstitutionLookup.Location = new System.Drawing.Point(12,68)
        Me.CmbInstitutionLookup.Name = "CmbInstitutionLookup"
        Me.CmbInstitutionLookup.Size = new System.Drawing.Size(189,21)
        Me.CmbInstitutionLookup.TabIndex = 74
        Me.CmbInstitutionLookup.Text = ""
        '
        'Label21
        '
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label21.Location = new System.Drawing.Point(12,95)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = new System.Drawing.Size(107,13)
        Me.Label21.TabIndex = 77
        Me.Label21.Text = "Select Phantom"
        Me.Label21.Text = "Select Phantom"
        '
        'Label20
        '
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label20.Location = new System.Drawing.Point(12,15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = new System.Drawing.Size(159,13)
        Me.Label20.TabIndex = 76
        Me.Label20.Text = "Select Institution"
        Me.Label20.Text = "Select Institution"
        '
        'Label39
        '
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label39.Location = new System.Drawing.Point(12,54)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = new System.Drawing.Size(91,17)
        Me.Label39.TabIndex = 75
        Me.Label39.Text = "Select Box"
        Me.Label39.Text = "Select Box"
        Me.Frame1.Controls.Add(Me.Frame5)
        Me.Frame5.Controls.Add(Me.BtnAddAllBlocks)
        Me.Frame5.Controls.Add(Me.BtnAddBlock)
        Me.Frame5.Controls.Add(Me.BtnInstitutionSearch)
        Me.Frame5.Controls.Add(Me.CmbBlockLookup)
        Me.Frame5.Controls.Add(Me.CmbInstitutionLookup)
        Me.Frame5.Controls.Add(Me.Label21)
        Me.Frame5.Controls.Add(Me.Label20)
        Me.Frame5.Controls.Add(Me.Label39)
        '
        'BtnOK
        '
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnOK.Location = new System.Drawing.Point(12,505)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = new System.Drawing.Size(65,25)
        Me.BtnOK.TabIndex = 54
        Me.BtnOK.Text = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCancel.Location = new System.Drawing.Point(84,505)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = new System.Drawing.Size(65,25)
        Me.BtnCancel.TabIndex = 53
        Me.BtnCancel.Text = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'TxtSessionResults225
        '
        Me.TxtSessionResults225 = New System.Windows.Forms.TextBox()
        Me.TxtSessionResults225.Location = new System.Drawing.Point(72,480)
        Me.TxtSessionResults225.Name = "TxtSessionResults225"
        Me.TxtSessionResults225.Size = new System.Drawing.Size(473,21)
        Me.TxtSessionResults225.TabIndex = 52
        Me.TxtSessionResults225.Text = ""
        Me.TxtSessionResults225.Text = ""
        Me.TxtSessionResults225.Multiline = "False"
        'Datafield = "COMMENTS"
        'Datafield = "rdcSession"
        '
        'SSTab1
        '
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me.SSTab1.Location = new System.Drawing.Point(8,272)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.Size = new System.Drawing.Size(544,200)
        Me.SSTab1.TabIndex = 0
        Me.SSTab1.Text = "Setup"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage0)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage1)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage2)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage3)
        '
        'SSTab1TabPage0
        '
        Me.SSTab1TabPage0 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage0.Location = new System.Drawing.Point(4,22)
        Me.SSTab1TabPage0.Name = "SSTab1TabPage0"
        Me.SSTab1TabPage0.Size = new System.Drawing.Size(536,174)
        Me.SSTab1TabPage0.TabIndex = 0
        Me.SSTab1TabPage0.Text = "Setup"
        '
        'SSTab1TabPage1
        '
        Me.SSTab1TabPage1 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage1.Location = new System.Drawing.Point(4,22)
        Me.SSTab1TabPage1.Name = "SSTab1TabPage1"
        Me.SSTab1TabPage1.Size = new System.Drawing.Size(536,174)
        Me.SSTab1TabPage1.TabIndex = 1
        Me.SSTab1TabPage1.Text = "Results"
        '
        'SSTab1TabPage2
        '
        Me.SSTab1TabPage2 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage2.Location = new System.Drawing.Point(4,22)
        Me.SSTab1TabPage2.Name = "SSTab1TabPage2"
        Me.SSTab1TabPage2.Size = new System.Drawing.Size(536,174)
        Me.SSTab1TabPage2.TabIndex = 2
        Me.SSTab1TabPage2.Text = "8 Gy Standards"
        '
        'SSTab1TabPage3
        '
        Me.SSTab1TabPage3 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage3.Location = new System.Drawing.Point(4,22)
        Me.SSTab1TabPage3.Name = "SSTab1TabPage3"
        Me.SSTab1TabPage3.Size = new System.Drawing.Size(536,174)
        Me.SSTab1TabPage3.TabIndex = 3
        Me.SSTab1TabPage3.Text = "30 Gy Standards"
        '
        'TxtSessionResults367
        '
        Me.TxtSessionResults367 = New System.Windows.Forms.TextBox()
        Me.TxtSessionResults367.Location = new System.Drawing.Point(288,51)
        Me.TxtSessionResults367.Name = "TxtSessionResults367"
        Me.TxtSessionResults367.Size = new System.Drawing.Size(67,21)
        Me.TxtSessionResults367.TabIndex = 31
        Me.TxtSessionResults367.Text = ""
        Me.TxtSessionResults367.Text = ""
        Me.TxtSessionResults367.Multiline = "False"
        'Datafield = "MEASURE_PREDICTED"
        'Datafield = "rdcSessionResults"
        '
        'TxtSessionResults380
        '
        Me.TxtSessionResults380 = New System.Windows.Forms.TextBox()
        Me.TxtSessionResults380.Location = new System.Drawing.Point(464,48)
        Me.TxtSessionResults380.Name = "TxtSessionResults380"
        Me.TxtSessionResults380.Size = new System.Drawing.Size(67,21)
        Me.TxtSessionResults380.TabIndex = 30
        Me.TxtSessionResults380.Text = ""
        Me.TxtSessionResults380.Text = ""
        Me.TxtSessionResults380.Multiline = "False"
        'Datafield = "FIRST_LAST_STANDARD"
        'Datafield = "rdcSessionResults"
        '
        'TxtSessionResults393
        '
        Me.TxtSessionResults393 = New System.Windows.Forms.TextBox()
        Me.TxtSessionResults393.Location = new System.Drawing.Point(464,25)
        Me.TxtSessionResults393.Name = "TxtSessionResults393"
        Me.TxtSessionResults393.Size = new System.Drawing.Size(67,21)
        Me.TxtSessionResults393.TabIndex = 29
        Me.TxtSessionResults393.Text = ""
        Me.TxtSessionResults393.Text = ""
        Me.TxtSessionResults393.Multiline = "False"
        'Datafield = "FIRST_LAST_CONTROL"
        'Datafield = "rdcSessionResults"
        '
        'TxtSessionResults406
        '
        Me.TxtSessionResults406 = New System.Windows.Forms.TextBox()
        Me.TxtSessionResults406.Location = new System.Drawing.Point(120,51)
        Me.TxtSessionResults406.Name = "TxtSessionResults406"
        Me.TxtSessionResults406.Size = new System.Drawing.Size(67,21)
        Me.TxtSessionResults406.TabIndex = 2
        Me.TxtSessionResults406.Text = ""
        Me.TxtSessionResults406.Text = ""
        Me.TxtSessionResults406.Multiline = "False"
        'Datafield = "IRRADIATION_DATE"
        'Datafield = "rdcStandards"
        '
        'TxtSessionResults416
        '
        Me.TxtSessionResults416 = New System.Windows.Forms.TextBox()
        Me.TxtSessionResults416.Location = new System.Drawing.Point(120,27)
        Me.TxtSessionResults416.Name = "TxtSessionResults416"
        Me.TxtSessionResults416.Size = new System.Drawing.Size(67,21)
        Me.TxtSessionResults416.TabIndex = 1
        Me.TxtSessionResults416.Text = ""
        Me.TxtSessionResults416.Text = ""
        Me.TxtSessionResults416.Multiline = "False"
        'Datafield = "IRRADIATION_DATE"
        'Datafield = "rdcControls"
        '
        'TxtSessionResults426
        '
        Me.TxtSessionResults426 = New System.Windows.Forms.TextBox()
        Me.TxtSessionResults426.Location = new System.Drawing.Point(288,27)
        Me.TxtSessionResults426.Name = "TxtSessionResults426"
        Me.TxtSessionResults426.Size = new System.Drawing.Size(67,21)
        Me.TxtSessionResults426.TabIndex = 28
        Me.TxtSessionResults426.Text = ""
        Me.TxtSessionResults426.Text = ""
        Me.TxtSessionResults426.Multiline = "False"
        'Datafield = "SENSITIVITY"
        'Datafield = "rdcSessionResults"
        '
        'Frame6
        '
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.Frame6.Location = new System.Drawing.Point(0,66)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Size = new System.Drawing.Size(253,103)
        Me.Frame6.TabIndex = 20
        Me.Frame6.Text = "Machine Used for Standards"
        '
        'TxtStdInHouse
        '
        Me.TxtStdInHouse = New System.Windows.Forms.TextBox()
        Me.TxtStdInHouse.Location = new System.Drawing.Point(93,45)
        Me.TxtStdInHouse.Name = "TxtStdInHouse"
        Me.TxtStdInHouse.Size = new System.Drawing.Size(100,22)
        Me.TxtStdInHouse.TabIndex = 24
        Me.TxtStdInHouse.Text = ""
        Me.TxtStdInHouse.Text = ""
        Me.TxtStdInHouse.Multiline = "False"
        '
        'TxtStdModel
        '
        Me.TxtStdModel = New System.Windows.Forms.TextBox()
        Me.TxtStdModel.Location = new System.Drawing.Point(93,21)
        Me.TxtStdModel.Name = "TxtStdModel"
        Me.TxtStdModel.Size = new System.Drawing.Size(100,22)
        Me.TxtStdModel.TabIndex = 23
        Me.TxtStdModel.Text = ""
        Me.TxtStdModel.Text = ""
        Me.TxtStdModel.Multiline = "False"
        '
        'BtnStandardMachineLookup
        '
        Me.BtnStandardMachineLookup = New System.Windows.Forms.Button()
        Me.BtnStandardMachineLookup.Location = new System.Drawing.Point(210,45)
        Me.BtnStandardMachineLookup.Name = "BtnStandardMachineLookup"
        Me.BtnStandardMachineLookup.Size = new System.Drawing.Size(28,22)
        Me.BtnStandardMachineLookup.TabIndex = 22
        Me.BtnStandardMachineLookup.Text = "..."
        Me.BtnStandardMachineLookup.UseVisualStyleBackColor = True
        '
        'CmbStdBatchLookup
        '
        Me.CmbStdBatchLookup = New System.Windows.Forms.ComboBox()
        Me.CmbStdBatchLookup.Location = new System.Drawing.Point(93,69)
        Me.CmbStdBatchLookup.Name = "CmbStdBatchLookup"
        Me.CmbStdBatchLookup.Size = new System.Drawing.Size(85,21)
        Me.CmbStdBatchLookup.TabIndex = 21
        Me.CmbStdBatchLookup.Text = ""
        '
        'Label25
        '
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label25.Location = new System.Drawing.Point(15,54)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = new System.Drawing.Size(86,13)
        Me.Label25.TabIndex = 27
        Me.Label25.Text = "In-House Des."
        Me.Label25.Text = "In-House Des."
        '
        'Label33
        '
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label33.Location = new System.Drawing.Point(15,30)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = new System.Drawing.Size(53,13)
        Me.Label33.TabIndex = 26
        Me.Label33.Text = "Model"
        Me.Label33.Text = "Model"
        '
        'Label34
        '
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label34.Location = new System.Drawing.Point(15,78)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = new System.Drawing.Size(77,16)
        Me.Label34.TabIndex = 25
        Me.Label34.Text = "Batch"
        Me.Label34.Text = "Batch"
        Me.SSTab1TabPage1.Controls.Add(Me.TxtSessionResults367)
        Me.SSTab1TabPage1.Controls.Add(Me.TxtSessionResults380)
        Me.SSTab1TabPage1.Controls.Add(Me.TxtSessionResults393)
        Me.SSTab1TabPage1.Controls.Add(Me.TxtSessionResults406)
        Me.SSTab1TabPage1.Controls.Add(Me.TxtSessionResults416)
        Me.SSTab1TabPage1.Controls.Add(Me.TxtSessionResults426)
        Me.SSTab1TabPage0.Controls.Add(Me.Frame6)
        Me.Frame6.Controls.Add(Me.TxtStdInHouse)
        Me.Frame6.Controls.Add(Me.TxtStdModel)
        Me.Frame6.Controls.Add(Me.BtnStandardMachineLookup)
        Me.Frame6.Controls.Add(Me.CmbStdBatchLookup)
        Me.Frame6.Controls.Add(Me.Label25)
        Me.Frame6.Controls.Add(Me.Label33)
        Me.Frame6.Controls.Add(Me.Label34)
        '
        'Frame4
        '
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.Frame4.Location = new System.Drawing.Point(0,66)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = new System.Drawing.Size(253,103)
        Me.Frame4.TabIndex = 12
        Me.Frame4.Text = "Machine Used for Controls"
        '
        'TxtCtlInHouse
        '
        Me.TxtCtlInHouse = New System.Windows.Forms.TextBox()
        Me.TxtCtlInHouse.Location = new System.Drawing.Point(90,45)
        Me.TxtCtlInHouse.Name = "TxtCtlInHouse"
        Me.TxtCtlInHouse.Size = new System.Drawing.Size(100,22)
        Me.TxtCtlInHouse.TabIndex = 15
        Me.TxtCtlInHouse.Text = ""
        Me.TxtCtlInHouse.Text = ""
        Me.TxtCtlInHouse.Multiline = "False"
        '
        'TxtCtlModel
        '
        Me.TxtCtlModel = New System.Windows.Forms.TextBox()
        Me.TxtCtlModel.Location = new System.Drawing.Point(90,21)
        Me.TxtCtlModel.Name = "TxtCtlModel"
        Me.TxtCtlModel.Size = new System.Drawing.Size(100,22)
        Me.TxtCtlModel.TabIndex = 14
        Me.TxtCtlModel.Text = ""
        Me.TxtCtlModel.Text = ""
        Me.TxtCtlModel.Multiline = "False"
        '
        'BtnControlMachineLookup
        '
        Me.BtnControlMachineLookup = New System.Windows.Forms.Button()
        Me.BtnControlMachineLookup.Location = new System.Drawing.Point(207,45)
        Me.BtnControlMachineLookup.Name = "BtnControlMachineLookup"
        Me.BtnControlMachineLookup.Size = new System.Drawing.Size(28,22)
        Me.BtnControlMachineLookup.TabIndex = 13
        Me.BtnControlMachineLookup.Text = "..."
        Me.BtnControlMachineLookup.UseVisualStyleBackColor = True
        '
        'CmbCtlBatchLookup
        '
        Me.CmbCtlBatchLookup = New System.Windows.Forms.ComboBox()
        Me.CmbCtlBatchLookup.Location = new System.Drawing.Point(90,69)
        Me.CmbCtlBatchLookup.Name = "CmbCtlBatchLookup"
        Me.CmbCtlBatchLookup.Size = new System.Drawing.Size(85,21)
        Me.CmbCtlBatchLookup.TabIndex = 16
        Me.CmbCtlBatchLookup.Text = ""
        '
        'Label36
        '
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label36.Location = new System.Drawing.Point(15,33)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = new System.Drawing.Size(86,16)
        Me.Label36.TabIndex = 19
        Me.Label36.Text = "Model"
        Me.Label36.Text = "Model"
        '
        'Label35
        '
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label35.Location = new System.Drawing.Point(15,54)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = new System.Drawing.Size(86,13)
        Me.Label35.TabIndex = 18
        Me.Label35.Text = "In-House Des."
        Me.Label35.Text = "In-House Des."
        '
        'Label37
        '
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label37.Location = new System.Drawing.Point(15,78)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = new System.Drawing.Size(77,16)
        Me.Label37.TabIndex = 17
        Me.Label37.Text = "Batch"
        Me.Label37.Text = "Batch"
        Me.SSTab1TabPage0.Controls.Add(Me.Frame4)
        Me.Frame4.Controls.Add(Me.TxtCtlInHouse)
        Me.Frame4.Controls.Add(Me.TxtCtlModel)
        Me.Frame4.Controls.Add(Me.BtnControlMachineLookup)
        Me.Frame4.Controls.Add(Me.CmbCtlBatchLookup)
        Me.Frame4.Controls.Add(Me.Label36)
        Me.Frame4.Controls.Add(Me.Label35)
        Me.Frame4.Controls.Add(Me.Label37)
        '
        'Text1
        '
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text1.Location = new System.Drawing.Point(177,84)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = new System.Drawing.Size(67,21)
        Me.Text1.TabIndex = 3
        Me.Text1.Text = ""
        Me.Text1.Text = ""
        Me.Text1.Multiline = "False"
        'Datafield = "INIT_LIGHT"
        'Datafield = "rdcSession"
        '
        'Text2
        '
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text2.Location = new System.Drawing.Point(177,108)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = new System.Drawing.Size(67,21)
        Me.Text2.TabIndex = 4
        Me.Text2.Text = ""
        Me.Text2.Text = ""
        Me.Text2.Multiline = "False"
        'Datafield = "INIT_PMT"
        'Datafield = "rdcSession"
        '
        'Text3
        '
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text3.Location = new System.Drawing.Point(177,132)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = new System.Drawing.Size(67,21)
        Me.Text3.TabIndex = 5
        Me.Text3.Text = ""
        Me.Text3.Text = ""
        Me.Text3.Multiline = "False"
        'Datafield = "INIT_BKGD"
        'Datafield = "rdcSession"
        '
        'Text4
        '
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Text4.Location = new System.Drawing.Point(177,156)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = new System.Drawing.Size(67,21)
        Me.Text4.TabIndex = 6
        Me.Text4.Text = ""
        Me.Text4.Text = ""
        Me.Text4.Multiline = "False"
        'Datafield = "INIT_BALANCE"
        'Datafield = "rdcSession"
        '
        'Text5
        '
        Me.Text5 = New System.Windows.Forms.TextBox()
        Me.Text5.Location = new System.Drawing.Point(366,84)
        Me.Text5.Name = "Text5"
        Me.Text5.Size = new System.Drawing.Size(67,21)
        Me.Text5.TabIndex = 7
        Me.Text5.Text = ""
        Me.Text5.Text = ""
        Me.Text5.Multiline = "False"
        'Datafield = "FINAL_LIGHT"
        'Datafield = "rdcSession"
        '
        'Text6
        '
        Me.Text6 = New System.Windows.Forms.TextBox()
        Me.Text6.Location = new System.Drawing.Point(366,108)
        Me.Text6.Name = "Text6"
        Me.Text6.Size = new System.Drawing.Size(67,21)
        Me.Text6.TabIndex = 8
        Me.Text6.Text = ""
        Me.Text6.Text = ""
        Me.Text6.Multiline = "False"
        'Datafield = "FINAL_PMT"
        'Datafield = "rdcSession"
        '
        'Text7
        '
        Me.Text7 = New System.Windows.Forms.TextBox()
        Me.Text7.Location = new System.Drawing.Point(366,132)
        Me.Text7.Name = "Text7"
        Me.Text7.Size = new System.Drawing.Size(67,21)
        Me.Text7.TabIndex = 9
        Me.Text7.Text = ""
        Me.Text7.Text = ""
        Me.Text7.Multiline = "False"
        'Datafield = "FINAL_BKGD"
        'Datafield = "rdcSession"
        '
        'Text8
        '
        Me.Text8 = New System.Windows.Forms.TextBox()
        Me.Text8.Location = new System.Drawing.Point(366,156)
        Me.Text8.Name = "Text8"
        Me.Text8.Size = new System.Drawing.Size(67,21)
        Me.Text8.TabIndex = 10
        Me.Text8.Text = ""
        Me.Text8.Text = ""
        Me.Text8.Multiline = "False"
        'Datafield = "FINAL_BALANCE"
        'Datafield = "rdcSession"
        '
        'BtnBatchCorrection
        '
        Me.BtnBatchCorrection = New System.Windows.Forms.Button()
        Me.BtnBatchCorrection.Location = new System.Drawing.Point(0,30)
        Me.BtnBatchCorrection.Name = "BtnBatchCorrection"
        Me.BtnBatchCorrection.Size = new System.Drawing.Size(76,25)
        Me.BtnBatchCorrection.TabIndex = 11
        Me.BtnBatchCorrection.Text = "Batch Corr."
        Me.BtnBatchCorrection.UseVisualStyleBackColor = True
        '
        'DBList1
        '
        Me.DBList1 = New System.Windows.Forms.ListBox()
        Me.DBList1.Location = new System.Drawing.Point(0,36)
        Me.DBList1.Name = "DBList1"
        Me.DBList1.Size = new System.Drawing.Size(64,17)
        Me.DBList1.TabIndex = 32
        Me.DBList1.Text = ""
        Me.DBList1.FormattingEnabled = True
        '
        'CmbBalanceLookup
        '
        Me.CmbBalanceLookup = New System.Windows.Forms.ComboBox()
        Me.CmbBalanceLookup.Location = new System.Drawing.Point(0,33)
        Me.CmbBalanceLookup.Name = "CmbBalanceLookup"
        Me.CmbBalanceLookup.Size = new System.Drawing.Size(95,21)
        Me.CmbBalanceLookup.TabIndex = 33
        Me.CmbBalanceLookup.Text = ""
        '
        'CmbReaderLookup
        '
        Me.CmbReaderLookup = New System.Windows.Forms.ComboBox()
        Me.CmbReaderLookup.Location = new System.Drawing.Point(0,34)
        Me.CmbReaderLookup.Name = "CmbReaderLookup"
        Me.CmbReaderLookup.Size = new System.Drawing.Size(94,21)
        Me.CmbReaderLookup.TabIndex = 34
        Me.CmbReaderLookup.Text = ""
        '
        'cmdAddVeryHighDoseSet
        '
        Me.cmdAddVeryHighDoseSet = New System.Windows.Forms.Button()
        Me.cmdAddVeryHighDoseSet.Location = new System.Drawing.Point(0,64)
        Me.cmdAddVeryHighDoseSet.Name = "cmdAddVeryHighDoseSet"
        Me.cmdAddVeryHighDoseSet.Size = new System.Drawing.Size(185,41)
        Me.cmdAddVeryHighDoseSet.TabIndex = 109
        Me.cmdAddVeryHighDoseSet.Text = "Add 30 Gy Standards"
        Me.cmdAddVeryHighDoseSet.UseVisualStyleBackColor = True
        '
        'cmdAddHighDoseSet
        '
        Me.cmdAddHighDoseSet = New System.Windows.Forms.Button()
        Me.cmdAddHighDoseSet.Location = new System.Drawing.Point(0,88)
        Me.cmdAddHighDoseSet.Name = "cmdAddHighDoseSet"
        Me.cmdAddHighDoseSet.Size = new System.Drawing.Size(145,33)
        Me.cmdAddHighDoseSet.TabIndex = 108
        Me.cmdAddHighDoseSet.Text = "Add 8 Gy Standards"
        Me.cmdAddHighDoseSet.UseVisualStyleBackColor = True
        '
        'frmHighDose
        '
        Me.frmHighDose = New System.Windows.Forms.GroupBox()
        Me.frmHighDose.Location = new System.Drawing.Point(0,32)
        Me.frmHighDose.Name = "frmHighDose"
        Me.frmHighDose.Size = new System.Drawing.Size(505,153)
        Me.frmHighDose.TabIndex = 96
        Me.frmHighDose.Text = "8 Gy"
        '
        'txtIrrDateHighDose
        '
        Me.txtIrrDateHighDose = New System.Windows.Forms.TextBox()
        Me.txtIrrDateHighDose.Location = new System.Drawing.Point(232,16)
        Me.txtIrrDateHighDose.Name = "txtIrrDateHighDose"
        Me.txtIrrDateHighDose.Size = new System.Drawing.Size(97,21)
        Me.txtIrrDateHighDose.TabIndex = 110
        Me.txtIrrDateHighDose.Text = ""
        Me.txtIrrDateHighDose.Text = ""
        Me.txtIrrDateHighDose.Multiline = "False"
        'Datafield = "IRRADIATION_DATE"
        'Datafield = "rdcHighDoseStandards"
        '
        'Text11
        '
        Me.Text11 = New System.Windows.Forms.TextBox()
        Me.Text11.Location = new System.Drawing.Point(232,112)
        Me.Text11.Name = "Text11"
        Me.Text11.Size = new System.Drawing.Size(67,21)
        Me.Text11.TabIndex = 104
        Me.Text11.Text = ""
        Me.Text11.Text = ""
        Me.Text11.Multiline = "False"
        'Datafield = "FIRST_LAST_H_STANDARD"
        'Datafield = "rdcSessionResults"
        '
        'txtNumEndEffectsHighDose
        '
        Me.txtNumEndEffectsHighDose = New System.Windows.Forms.TextBox()
        Me.txtNumEndEffectsHighDose.Location = new System.Drawing.Point(232,88)
        Me.txtNumEndEffectsHighDose.Name = "txtNumEndEffectsHighDose"
        Me.txtNumEndEffectsHighDose.Size = new System.Drawing.Size(97,21)
        Me.txtNumEndEffectsHighDose.TabIndex = 101
        Me.txtNumEndEffectsHighDose.Text = ""
        Me.txtNumEndEffectsHighDose.Text = ""
        Me.txtNumEndEffectsHighDose.Multiline = "False"
        'Datafield = "NUM_END_EFFECTS"
        'Datafield = "rdcHighDoseStandards"
        '
        'txtIrrTimeHighDose
        '
        Me.txtIrrTimeHighDose = New System.Windows.Forms.TextBox()
        Me.txtIrrTimeHighDose.Location = new System.Drawing.Point(232,64)
        Me.txtIrrTimeHighDose.Name = "txtIrrTimeHighDose"
        Me.txtIrrTimeHighDose.Size = new System.Drawing.Size(97,21)
        Me.txtIrrTimeHighDose.TabIndex = 100
        Me.txtIrrTimeHighDose.Text = ""
        Me.txtIrrTimeHighDose.Text = ""
        Me.txtIrrTimeHighDose.Multiline = "False"
        'Datafield = "IRRADIATION_TIME"
        'Datafield = "rdcHighDoseStandards"
        '
        'cmbBatchHighDose
        '
        Me.cmbBatchHighDose = New System.Windows.Forms.ComboBox()
        Me.cmbBatchHighDose.Location = new System.Drawing.Point(232,40)
        Me.cmbBatchHighDose.Name = "cmbBatchHighDose"
        Me.cmbBatchHighDose.Size = new System.Drawing.Size(97,21)
        Me.cmbBatchHighDose.TabIndex = 103
        Me.cmbBatchHighDose.Text = ""
        '
        'Label9
        '
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label9.Location = new System.Drawing.Point(104,120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = new System.Drawing.Size(106,17)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "1st to Last HD Stds"
        Me.Label9.Text = "1st to Last HD Stds"
        '
        'Label43
        '
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label43.Location = new System.Drawing.Point(104,96)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = new System.Drawing.Size(123,17)
        Me.Label43.TabIndex = 102
        Me.Label43.Text = "Number of End Effects"
        Me.Label43.Text = "Number of End Effects"
        '
        'Label42
        '
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label42.Location = new System.Drawing.Point(104,72)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = new System.Drawing.Size(115,17)
        Me.Label42.TabIndex = 99
        Me.Label42.Text = "Irradiation Time"
        Me.Label42.Text = "Irradiation Time"
        '
        'Label41
        '
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label41.Location = new System.Drawing.Point(104,48)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = new System.Drawing.Size(99,17)
        Me.Label41.TabIndex = 98
        Me.Label41.Text = "Batch"
        Me.Label41.Text = "Batch"
        '
        'Label40
        '
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label40.Location = new System.Drawing.Point(104,24)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = new System.Drawing.Size(99,17)
        Me.Label40.TabIndex = 97
        Me.Label40.Text = "Irradiation Date"
        Me.Label40.Text = "Irradiation Date"
        Me.SSTab1TabPage1.Controls.Add(Me.Text1)
        Me.SSTab1TabPage1.Controls.Add(Me.Text2)
        Me.SSTab1TabPage1.Controls.Add(Me.Text3)
        Me.SSTab1TabPage1.Controls.Add(Me.Text4)
        Me.SSTab1TabPage1.Controls.Add(Me.Text5)
        Me.SSTab1TabPage1.Controls.Add(Me.Text6)
        Me.SSTab1TabPage1.Controls.Add(Me.Text7)
        Me.SSTab1TabPage1.Controls.Add(Me.Text8)
        Me.SSTab1TabPage0.Controls.Add(Me.BtnBatchCorrection)
        Me.SSTab1TabPage0.Controls.Add(Me.DBList1)
        Me.SSTab1TabPage0.Controls.Add(Me.CmbBalanceLookup)
        Me.SSTab1TabPage0.Controls.Add(Me.CmbReaderLookup)
        Me.SSTab1TabPage3.Controls.Add(Me.cmdAddVeryHighDoseSet)
        Me.SSTab1TabPage2.Controls.Add(Me.cmdAddHighDoseSet)
        Me.SSTab1TabPage2.Controls.Add(Me.frmHighDose)
        Me.frmHighDose.Controls.Add(Me.txtIrrDateHighDose)
        Me.frmHighDose.Controls.Add(Me.Text11)
        Me.frmHighDose.Controls.Add(Me.txtNumEndEffectsHighDose)
        Me.frmHighDose.Controls.Add(Me.txtIrrTimeHighDose)
        Me.frmHighDose.Controls.Add(Me.cmbBatchHighDose)
        Me.frmHighDose.Controls.Add(Me.Label9)
        Me.frmHighDose.Controls.Add(Me.Label43)
        Me.frmHighDose.Controls.Add(Me.Label42)
        Me.frmHighDose.Controls.Add(Me.Label41)
        Me.frmHighDose.Controls.Add(Me.Label40)
        '
        'frmVeryHighDose
        '
        Me.frmVeryHighDose = New System.Windows.Forms.GroupBox()
        Me.frmVeryHighDose.Location = new System.Drawing.Point(0,32)
        Me.frmVeryHighDose.Name = "frmVeryHighDose"
        Me.frmVeryHighDose.Size = new System.Drawing.Size(505,145)
        Me.frmVeryHighDose.TabIndex = 88
        Me.frmVeryHighDose.Text = "30 Gy"
        '
        'txtNumEndEffectsVeryHighDose
        '
        Me.txtNumEndEffectsVeryHighDose = New System.Windows.Forms.TextBox()
        Me.txtNumEndEffectsVeryHighDose.Location = new System.Drawing.Point(232,88)
        Me.txtNumEndEffectsVeryHighDose.Name = "txtNumEndEffectsVeryHighDose"
        Me.txtNumEndEffectsVeryHighDose.Size = new System.Drawing.Size(97,21)
        Me.txtNumEndEffectsVeryHighDose.TabIndex = 111
        Me.txtNumEndEffectsVeryHighDose.Text = ""
        Me.txtNumEndEffectsVeryHighDose.Text = ""
        Me.txtNumEndEffectsVeryHighDose.Multiline = "False"
        'Datafield = "NUM_END_EFFECTS"
        'Datafield = "rdcVeryHighDoseStandards"
        '
        'Text12
        '
        Me.Text12 = New System.Windows.Forms.TextBox()
        Me.Text12.Location = new System.Drawing.Point(232,112)
        Me.Text12.Name = "Text12"
        Me.Text12.Size = new System.Drawing.Size(67,21)
        Me.Text12.TabIndex = 106
        Me.Text12.Text = ""
        Me.Text12.Text = ""
        Me.Text12.Multiline = "False"
        'Datafield = "FIRST_LAST_VH_STANDARD"
        'Datafield = "rdcSessionResults"
        '
        'txtIrrTimeVeryHighDose
        '
        Me.txtIrrTimeVeryHighDose = New System.Windows.Forms.TextBox()
        Me.txtIrrTimeVeryHighDose.Location = new System.Drawing.Point(232,64)
        Me.txtIrrTimeVeryHighDose.Name = "txtIrrTimeVeryHighDose"
        Me.txtIrrTimeVeryHighDose.Size = new System.Drawing.Size(97,21)
        Me.txtIrrTimeVeryHighDose.TabIndex = 95
        Me.txtIrrTimeVeryHighDose.Text = ""
        Me.txtIrrTimeVeryHighDose.Text = ""
        Me.txtIrrTimeVeryHighDose.Multiline = "False"
        'Datafield = "IRRADIATION_TIME"
        'Datafield = "rdcVeryHighDoseStandards"
        '
        'txtIrrDateVeryHighDose
        '
        Me.txtIrrDateVeryHighDose = New System.Windows.Forms.TextBox()
        Me.txtIrrDateVeryHighDose.Location = new System.Drawing.Point(232,16)
        Me.txtIrrDateVeryHighDose.Name = "txtIrrDateVeryHighDose"
        Me.txtIrrDateVeryHighDose.Size = new System.Drawing.Size(97,21)
        Me.txtIrrDateVeryHighDose.TabIndex = 90
        Me.txtIrrDateVeryHighDose.Text = ""
        Me.txtIrrDateVeryHighDose.Text = ""
        Me.txtIrrDateVeryHighDose.Multiline = "False"
        'Datafield = "IRRADIATION_DATE"
        'Datafield = "rdcVeryHighDoseStandards"
        '
        'cmbBatchVeryHighDose
        '
        Me.cmbBatchVeryHighDose = New System.Windows.Forms.ComboBox()
        Me.cmbBatchVeryHighDose.Location = new System.Drawing.Point(232,40)
        Me.cmbBatchVeryHighDose.Name = "cmbBatchVeryHighDose"
        Me.cmbBatchVeryHighDose.Size = new System.Drawing.Size(97,21)
        Me.cmbBatchVeryHighDose.TabIndex = 94
        Me.cmbBatchVeryHighDose.Text = ""
        '
        'Label23
        '
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label23.Location = new System.Drawing.Point(104,120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = new System.Drawing.Size(115,17)
        Me.Label23.TabIndex = 107
        Me.Label23.Text = "1st to Last VHD Stds"
        Me.Label23.Text = "1st to Last VHD Stds"
        '
        'Label47
        '
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label47.Location = new System.Drawing.Point(104,96)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = new System.Drawing.Size(131,17)
        Me.Label47.TabIndex = 93
        Me.Label47.Text = "Number of End Effects"
        Me.Label47.Text = "Number of End Effects"
        '
        'Label46
        '
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label46.Location = new System.Drawing.Point(104,72)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = new System.Drawing.Size(107,17)
        Me.Label46.TabIndex = 92
        Me.Label46.Text = "Irradiation Time"
        Me.Label46.Text = "Irradiation Time"
        '
        'Label45
        '
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label45.Location = new System.Drawing.Point(104,48)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = new System.Drawing.Size(99,17)
        Me.Label45.TabIndex = 91
        Me.Label45.Text = "Batch"
        Me.Label45.Text = "Batch"
        '
        'Label44
        '
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label44.Location = new System.Drawing.Point(104,24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = new System.Drawing.Size(123,17)
        Me.Label44.TabIndex = 89
        Me.Label44.Text = "Irradiation Date"
        Me.Label44.Text = "Irradiation Date"
        Me.SSTab1TabPage3.Controls.Add(Me.frmVeryHighDose)
        Me.frmVeryHighDose.Controls.Add(Me.txtNumEndEffectsVeryHighDose)
        Me.frmVeryHighDose.Controls.Add(Me.Text12)
        Me.frmVeryHighDose.Controls.Add(Me.txtIrrTimeVeryHighDose)
        Me.frmVeryHighDose.Controls.Add(Me.txtIrrDateVeryHighDose)
        Me.frmVeryHighDose.Controls.Add(Me.cmbBatchVeryHighDose)
        Me.frmVeryHighDose.Controls.Add(Me.Label23)
        Me.frmVeryHighDose.Controls.Add(Me.Label47)
        Me.frmVeryHighDose.Controls.Add(Me.Label46)
        Me.frmVeryHighDose.Controls.Add(Me.Label45)
        Me.frmVeryHighDose.Controls.Add(Me.Label44)
        '
        'Label18
        '
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label18.Location = new System.Drawing.Point(192,56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = new System.Drawing.Size(99,15)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "Meas to Predicted"
        Me.Label18.Text = "Meas to Predicted"
        '
        'Label17
        '
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label17.Location = new System.Drawing.Point(360,57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = new System.Drawing.Size(95,15)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "1st to Last Stds"
        Me.Label17.Text = "1st to Last Stds"
        '
        'Label16
        '
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label16.Location = new System.Drawing.Point(12,60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = new System.Drawing.Size(104,15)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Date Of Standards"
        Me.Label16.Text = "Date Of Standards"
        '
        'Label15
        '
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label15.Location = new System.Drawing.Point(360,36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = new System.Drawing.Size(94,15)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "1st to Last Ctls"
        Me.Label15.Text = "1st to Last Ctls"
        '
        'Label14
        '
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label14.Location = new System.Drawing.Point(12,36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = new System.Drawing.Size(104,15)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Date Of Controls"
        Me.Label14.Text = "Date Of Controls"
        '
        'Label13
        '
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label13.Location = new System.Drawing.Point(192,33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = new System.Drawing.Size(91,15)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Meas Sensitivity"
        Me.Label13.Text = "Meas Sensitivity"
        '
        'Label22
        '
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label22.Location = new System.Drawing.Point(0,39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = new System.Drawing.Size(83,13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Balance"
        Me.Label22.Text = "Balance"
        '
        'Label12
        '
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label12.Location = new System.Drawing.Point(0,39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = new System.Drawing.Size(63,15)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Batch(es)"
        Me.Label12.Text = "Batch(es)"
        '
        'Label11
        '
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label11.Location = new System.Drawing.Point(0,40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = new System.Drawing.Size(114,15)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Reader"
        Me.Label11.Text = "Reader"
        '
        'Label24
        '
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label24.Location = new System.Drawing.Point(81,93)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = new System.Drawing.Size(77,13)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "Initial Light"
        Me.Label24.Text = "Initial Light"
        '
        'Label26
        '
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label26.Location = new System.Drawing.Point(81,117)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = new System.Drawing.Size(77,13)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "Initial PMT"
        Me.Label26.Text = "Initial PMT"
        '
        'Label27
        '
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label27.Location = new System.Drawing.Point(81,141)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = new System.Drawing.Size(98,16)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "Initial Background"
        Me.Label27.Text = "Initial Background"
        '
        'Label28
        '
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label28.Location = new System.Drawing.Point(81,165)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = new System.Drawing.Size(80,13)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Initial Balance"
        Me.Label28.Text = "Initial Balance"
        '
        'Label29
        '
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label29.Location = new System.Drawing.Point(267,93)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = new System.Drawing.Size(77,13)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Final Light"
        Me.Label29.Text = "Final Light"
        '
        'Label30
        '
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label30.Location = new System.Drawing.Point(267,117)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = new System.Drawing.Size(77,13)
        Me.Label30.TabIndex = 37
        Me.Label30.Text = "Final PMT"
        Me.Label30.Text = "Final PMT"
        '
        'Label31
        '
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label31.Location = new System.Drawing.Point(267,141)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = new System.Drawing.Size(107,16)
        Me.Label31.TabIndex = 36
        Me.Label31.Text = "Final Background"
        Me.Label31.Text = "Final Background"
        '
        'Label32
        '
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label32.Location = new System.Drawing.Point(267,165)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = new System.Drawing.Size(80,13)
        Me.Label32.TabIndex = 35
        Me.Label32.Text = "Final Balance"
        Me.Label32.Text = "Final Balance"
        Me.SSTab1TabPage1.Controls.Add(Me.Label18)
        Me.SSTab1TabPage1.Controls.Add(Me.Label17)
        Me.SSTab1TabPage1.Controls.Add(Me.Label16)
        Me.SSTab1TabPage1.Controls.Add(Me.Label15)
        Me.SSTab1TabPage1.Controls.Add(Me.Label14)
        Me.SSTab1TabPage1.Controls.Add(Me.Label13)
        Me.SSTab1TabPage0.Controls.Add(Me.Label22)
        Me.SSTab1TabPage0.Controls.Add(Me.Label12)
        Me.SSTab1TabPage0.Controls.Add(Me.Label11)
        Me.SSTab1TabPage1.Controls.Add(Me.Label24)
        Me.SSTab1TabPage1.Controls.Add(Me.Label26)
        Me.SSTab1TabPage1.Controls.Add(Me.Label27)
        Me.SSTab1TabPage1.Controls.Add(Me.Label28)
        Me.SSTab1TabPage1.Controls.Add(Me.Label29)
        Me.SSTab1TabPage1.Controls.Add(Me.Label30)
        Me.SSTab1TabPage1.Controls.Add(Me.Label31)
        Me.SSTab1TabPage1.Controls.Add(Me.Label32)
        '
        'Frame2
        '
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Frame2.Location = new System.Drawing.Point(8,160)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = new System.Drawing.Size(542,107)
        Me.Frame2.TabIndex = 55
        Me.Frame2.Text = "Tracking"
        '
        'FinalizeSessionDate
        '
        Me.FinalizeSessionDate = New System.Windows.Forms.TextBox()
        Me.FinalizeSessionDate.Location = new System.Drawing.Point(408,72)
        Me.FinalizeSessionDate.Name = "FinalizeSessionDate"
        Me.FinalizeSessionDate.Size = new System.Drawing.Size(101,21)
        Me.FinalizeSessionDate.TabIndex = 87
        Me.FinalizeSessionDate.Text = ""
        Me.FinalizeSessionDate.Text = ""
        Me.FinalizeSessionDate.Multiline = "False"
        'Datafield = "FINALIZE_SESSION_DATE"
        'Datafield = "rdcSession"
        '
        'TxtShipInfo1911
        '
        Me.TxtShipInfo1911 = New System.Windows.Forms.TextBox()
        Me.TxtShipInfo1911.Location = new System.Drawing.Point(408,21)
        Me.TxtShipInfo1911.Name = "TxtShipInfo1911"
        Me.TxtShipInfo1911.Size = new System.Drawing.Size(101,21)
        Me.TxtShipInfo1911.TabIndex = 59
        Me.TxtShipInfo1911.Text = ""
        Me.TxtShipInfo1911.Text = ""
        Me.TxtShipInfo1911.Multiline = "False"
        'Datafield = "READ_DATE"
        'Datafield = "rdcSession"
        '
        'TxtShipInfo1921
        '
        Me.TxtShipInfo1921 = New System.Windows.Forms.TextBox()
        Me.TxtShipInfo1921.Location = new System.Drawing.Point(408,47)
        Me.TxtShipInfo1921.Name = "TxtShipInfo1921"
        Me.TxtShipInfo1921.Size = new System.Drawing.Size(101,21)
        Me.TxtShipInfo1921.TabIndex = 57
        Me.TxtShipInfo1921.Text = ""
        Me.TxtShipInfo1921.Text = ""
        Me.TxtShipInfo1921.Multiline = "False"
        'Datafield = "SIGNED_DIR_DATE"
        'Datafield = "rdcSession"
        '
        'CmbTechReadBy
        '
        Me.CmbTechReadBy = New System.Windows.Forms.ComboBox()
        Me.CmbTechReadBy.Location = new System.Drawing.Point(120,20)
        Me.CmbTechReadBy.Name = "CmbTechReadBy"
        Me.CmbTechReadBy.Size = new System.Drawing.Size(140,21)
        Me.CmbTechReadBy.TabIndex = 56
        Me.CmbTechReadBy.Text = ""
        '
        'CmbTechEnteredLookup
        '
        Me.CmbTechEnteredLookup = New System.Windows.Forms.ComboBox()
        Me.CmbTechEnteredLookup.Location = new System.Drawing.Point(120,44)
        Me.CmbTechEnteredLookup.Name = "CmbTechEnteredLookup"
        Me.CmbTechEnteredLookup.Size = new System.Drawing.Size(140,21)
        Me.CmbTechEnteredLookup.TabIndex = 58
        Me.CmbTechEnteredLookup.Text = ""
        '
        'CmbTechCheckedLookup
        '
        Me.CmbTechCheckedLookup = New System.Windows.Forms.ComboBox()
        Me.CmbTechCheckedLookup.Location = new System.Drawing.Point(120,68)
        Me.CmbTechCheckedLookup.Name = "CmbTechCheckedLookup"
        Me.CmbTechCheckedLookup.Size = new System.Drawing.Size(140,21)
        Me.CmbTechCheckedLookup.TabIndex = 60
        Me.CmbTechCheckedLookup.Text = ""
        '
        'Label8
        '
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label8.Location = new System.Drawing.Point(304,25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = new System.Drawing.Size(109,15)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Date Read"
        Me.Label8.Text = "Date Read"
        '
        'Label4
        '
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label4.Location = new System.Drawing.Point(10,52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = new System.Drawing.Size(95,15)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Tech Entered By"
        Me.Label4.Text = "Tech Entered By"
        '
        'Label5
        '
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label5.Location = new System.Drawing.Point(10,76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = new System.Drawing.Size(107,15)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Tech Checked By"
        Me.Label5.Text = "Tech Checked By"
        '
        'Label10
        '
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label10.Location = new System.Drawing.Point(304,48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = new System.Drawing.Size(113,15)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Date Director Signed"
        Me.Label10.Text = "Date Director Signed"
        '
        'Label2
        '
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label2.Location = new System.Drawing.Point(10,28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = new System.Drawing.Size(99,13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Tech Read By"
        Me.Label2.Text = "Tech Read By"
        '
        'Label38
        '
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label38.Location = new System.Drawing.Point(304,72)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = new System.Drawing.Size(115,17)
        Me.Label38.TabIndex = 61
        Me.Label38.Text = "Session Finalized"
        Me.Label38.Text = "Session Finalized"
        Me.Frame2.Controls.Add(Me.FinalizeSessionDate)
        Me.Frame2.Controls.Add(Me.TxtShipInfo1911)
        Me.Frame2.Controls.Add(Me.TxtShipInfo1921)
        Me.Frame2.Controls.Add(Me.CmbTechReadBy)
        Me.Frame2.Controls.Add(Me.CmbTechEnteredLookup)
        Me.Frame2.Controls.Add(Me.CmbTechCheckedLookup)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label10)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label38)
        '
        'Label1
        '
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1.Location = new System.Drawing.Point(16,480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = new System.Drawing.Size(67,17)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Comment"
        Me.Label1.Text = "Comment"
        '
        'frmEditPhantomSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558,536)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtSessionResults225)
        Me.Controls.Add(Me.SSTab1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEditPhantomSession"
        Me.Text = "frmEditPhantomSession"
        Me.ResumeLayout(False)


  End Sub
Friend WithEvents BtnClose As Button
Friend WithEvents Frame1 As GroupBox
Friend WithEvents FrmSessionBlocks As GroupBox
Friend WithEvents BtnRemoveBlock As Button
Friend WithEvents BtnRemoveAllBlocks As Button
Friend WithEvents LstBlocks As ListBox
Friend WithEvents LstInstitutions As ListBox
Friend WithEvents Label19 As Label
Friend WithEvents Label3 As Label
Friend WithEvents Frame5 As GroupBox
Friend WithEvents BtnAddAllBlocks As Button
Friend WithEvents BtnAddBlock As Button
Friend WithEvents BtnInstitutionSearch As Button
Friend WithEvents CmbBlockLookup As ComboBox
Friend WithEvents CmbInstitutionLookup As ComboBox
Friend WithEvents Label21 As Label
Friend WithEvents Label20 As Label
Friend WithEvents Label39 As Label
Friend WithEvents BtnOK As Button
Friend WithEvents BtnCancel As Button
Friend WithEvents TxtSessionResults225 As TextBox
Friend WithEvents SSTab1 As TabControl
Friend WithEvents SSTab1TabPage0 As TabPage
Friend WithEvents SSTab1TabPage1 As TabPage
Friend WithEvents SSTab1TabPage2 As TabPage
Friend WithEvents SSTab1TabPage3 As TabPage
Friend WithEvents TxtSessionResults367 As TextBox
Friend WithEvents TxtSessionResults380 As TextBox
Friend WithEvents TxtSessionResults393 As TextBox
Friend WithEvents TxtSessionResults406 As TextBox
Friend WithEvents TxtSessionResults416 As TextBox
Friend WithEvents TxtSessionResults426 As TextBox
Friend WithEvents Frame6 As GroupBox
Friend WithEvents TxtStdInHouse As TextBox
Friend WithEvents TxtStdModel As TextBox
Friend WithEvents BtnStandardMachineLookup As Button
Friend WithEvents CmbStdBatchLookup As ComboBox
Friend WithEvents Label25 As Label
Friend WithEvents Label33 As Label
Friend WithEvents Label34 As Label
Friend WithEvents Frame4 As GroupBox
Friend WithEvents TxtCtlInHouse As TextBox
Friend WithEvents TxtCtlModel As TextBox
Friend WithEvents BtnControlMachineLookup As Button
Friend WithEvents CmbCtlBatchLookup As ComboBox
Friend WithEvents Label36 As Label
Friend WithEvents Label35 As Label
Friend WithEvents Label37 As Label
Friend WithEvents Text1 As TextBox
Friend WithEvents Text2 As TextBox
Friend WithEvents Text3 As TextBox
Friend WithEvents Text4 As TextBox
Friend WithEvents Text5 As TextBox
Friend WithEvents Text6 As TextBox
Friend WithEvents Text7 As TextBox
Friend WithEvents Text8 As TextBox
Friend WithEvents BtnBatchCorrection As Button
Friend WithEvents DBList1 As ListBox
Friend WithEvents CmbBalanceLookup As ComboBox
Friend WithEvents CmbReaderLookup As ComboBox
Friend WithEvents cmdAddVeryHighDoseSet As Button
Friend WithEvents cmdAddHighDoseSet As Button
Friend WithEvents frmHighDose As GroupBox
Friend WithEvents txtIrrDateHighDose As TextBox
Friend WithEvents Text11 As TextBox
Friend WithEvents txtNumEndEffectsHighDose As TextBox
Friend WithEvents txtIrrTimeHighDose As TextBox
Friend WithEvents cmbBatchHighDose As ComboBox
Friend WithEvents Label9 As Label
Friend WithEvents Label43 As Label
Friend WithEvents Label42 As Label
Friend WithEvents Label41 As Label
Friend WithEvents Label40 As Label
Friend WithEvents frmVeryHighDose As GroupBox
Friend WithEvents txtNumEndEffectsVeryHighDose As TextBox
Friend WithEvents Text12 As TextBox
Friend WithEvents txtIrrTimeVeryHighDose As TextBox
Friend WithEvents txtIrrDateVeryHighDose As TextBox
Friend WithEvents cmbBatchVeryHighDose As ComboBox
Friend WithEvents Label23 As Label
Friend WithEvents Label47 As Label
Friend WithEvents Label46 As Label
Friend WithEvents Label45 As Label
Friend WithEvents Label44 As Label
Friend WithEvents Label18 As Label
Friend WithEvents Label17 As Label
Friend WithEvents Label16 As Label
Friend WithEvents Label15 As Label
Friend WithEvents Label14 As Label
Friend WithEvents Label13 As Label
Friend WithEvents Label22 As Label
Friend WithEvents Label12 As Label
Friend WithEvents Label11 As Label
Friend WithEvents Label24 As Label
Friend WithEvents Label26 As Label
Friend WithEvents Label27 As Label
Friend WithEvents Label28 As Label
Friend WithEvents Label29 As Label
Friend WithEvents Label30 As Label
Friend WithEvents Label31 As Label
Friend WithEvents Label32 As Label
Friend WithEvents Frame2 As GroupBox
Friend WithEvents FinalizeSessionDate As TextBox
Friend WithEvents TxtShipInfo1911 As TextBox
Friend WithEvents TxtShipInfo1921 As TextBox
Friend WithEvents CmbTechReadBy As ComboBox
Friend WithEvents CmbTechEnteredLookup As ComboBox
Friend WithEvents CmbTechCheckedLookup As ComboBox
Friend WithEvents Label8 As Label
Friend WithEvents Label4 As Label
Friend WithEvents Label5 As Label
Friend WithEvents Label10 As Label
Friend WithEvents Label2 As Label
Friend WithEvents Label38 As Label
Friend WithEvents Label1 As Label
End Class
