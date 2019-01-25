<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCredentialing
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
        Me.Frame1.Location = New System.Drawing.Point(8, 448)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(577, 153)
        Me.Frame1.TabIndex = 29
        Me.Frame1.Text = "Brachy Sources"
        '
        'cmdExport
        '
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdExport.Location = New System.Drawing.Point(88, 120)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(105, 25)
        Me.cmdExport.TabIndex = 45
        Me.cmdExport.Text = "Export to Excel"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdPrintQuestionnaire
        '
        Me.cmdPrintQuestionnaire = New System.Windows.Forms.Button()
        Me.cmdPrintQuestionnaire.Location = New System.Drawing.Point(200, 120)
        Me.cmdPrintQuestionnaire.Name = "cmdPrintQuestionnaire"
        Me.cmdPrintQuestionnaire.Size = New System.Drawing.Size(113, 25)
        Me.cmdPrintQuestionnaire.TabIndex = 36
        Me.cmdPrintQuestionnaire.Text = "Print Questionnaire"
        Me.cmdPrintQuestionnaire.UseVisualStyleBackColor = True
        '
        'BtnEditBrachyCredential
        '
        Me.BtnEditBrachyCredential = New System.Windows.Forms.Button()
        Me.BtnEditBrachyCredential.Location = New System.Drawing.Point(320, 120)
        Me.BtnEditBrachyCredential.Name = "BtnEditBrachyCredential"
        Me.BtnEditBrachyCredential.Size = New System.Drawing.Size(81, 25)
        Me.BtnEditBrachyCredential.TabIndex = 33
        Me.BtnEditBrachyCredential.Text = "Edit Brachy"
        Me.BtnEditBrachyCredential.UseVisualStyleBackColor = True
        '
        'BtnAddBrachyCredential
        '
        Me.BtnAddBrachyCredential = New System.Windows.Forms.Button()
        Me.BtnAddBrachyCredential.Location = New System.Drawing.Point(408, 120)
        Me.BtnAddBrachyCredential.Name = "BtnAddBrachyCredential"
        Me.BtnAddBrachyCredential.Size = New System.Drawing.Size(73, 25)
        Me.BtnAddBrachyCredential.TabIndex = 32
        Me.BtnAddBrachyCredential.Text = "Add Brachy"
        Me.BtnAddBrachyCredential.UseVisualStyleBackColor = True
        '
        'BtnDeleteBrachyCredential
        '
        Me.BtnDeleteBrachyCredential = New System.Windows.Forms.Button()
        Me.BtnDeleteBrachyCredential.Location = New System.Drawing.Point(488, 120)
        Me.BtnDeleteBrachyCredential.Name = "BtnDeleteBrachyCredential"
        Me.BtnDeleteBrachyCredential.Size = New System.Drawing.Size(81, 25)
        Me.BtnDeleteBrachyCredential.TabIndex = 31
        Me.BtnDeleteBrachyCredential.Text = "Delete Brachy"
        Me.BtnDeleteBrachyCredential.UseVisualStyleBackColor = True
        '
        'GrdBrachyCredential
        '
        Me.GrdBrachyCredential = New System.Windows.Forms.DataGridView()
        Me.GrdBrachyCredential.Location = New System.Drawing.Point(8, 16)
        Me.GrdBrachyCredential.Name = "GrdBrachyCredential"
        Me.GrdBrachyCredential.Size = New System.Drawing.Size(561, 97)
        Me.GrdBrachyCredential.TabIndex = 30
        Me.GrdBrachyCredential.Text = "GrdBrachyCredential"
        Me.GrdBrachyCredential.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdBrachyCredential.AllowUserToAddRows = False
        Me.GrdBrachyCredential.AllowUserToDeleteRows = False
        Me.GrdBrachyCredential.MultiSelect = False
        Me.GrdBrachyCredential.ReadOnly = True
        Me.GrdBrachyCredential.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Frame1.Controls.Add(Me.cmdExport)
        Me.Frame1.Controls.Add(Me.cmdPrintQuestionnaire)
        Me.Frame1.Controls.Add(Me.BtnEditBrachyCredential)
        Me.Frame1.Controls.Add(Me.BtnAddBrachyCredential)
        Me.Frame1.Controls.Add(Me.BtnDeleteBrachyCredential)
        Me.Frame1.Controls.Add(Me.GrdBrachyCredential)
        '
        'FrmCredentialInformation
        '
        Me.FrmCredentialInformation = New System.Windows.Forms.GroupBox()
        Me.FrmCredentialInformation.Location = New System.Drawing.Point(8, 32)
        Me.FrmCredentialInformation.Name = "FrmCredentialInformation"
        Me.FrmCredentialInformation.Size = New System.Drawing.Size(578, 267)
        Me.FrmCredentialInformation.TabIndex = 6
        Me.FrmCredentialInformation.Text = "Credentialing Information"
        '
        'txtRespMotion
        '
        Me.txtRespMotion = New System.Windows.Forms.TextBox()
        Me.txtRespMotion.Location = New System.Drawing.Point(288, 144)
        Me.txtRespMotion.Name = "txtRespMotion"
        Me.txtRespMotion.Size = New System.Drawing.Size(284, 21)
        Me.txtRespMotion.TabIndex = 44
        Me.txtRespMotion.Text = ""
        Me.txtRespMotion.Text = ""
        Me.txtRespMotion.Multiline = False
        'Datafield = "RESP_MOTION"
        'Datasource = "rdcCredentialGrid"
        '
        'TxtComments
        '
        Me.TxtComments = New System.Windows.Forms.TextBox()
        Me.TxtComments.Location = New System.Drawing.Point(112, 168)
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.Size = New System.Drawing.Size(422, 57)
        Me.TxtComments.TabIndex = 41
        Me.TxtComments.Text = ""
        Me.TxtComments.Text = ""
        Me.TxtComments.Multiline = True
        'Datafield = "Comments"
        'Datasource = "rdcCredentialGrid"
        '
        'Text10
        '
        Me.Text10 = New System.Windows.Forms.TextBox()
        Me.Text10.Location = New System.Drawing.Point(112, 120)
        Me.Text10.Name = "Text10"
        Me.Text10.Size = New System.Drawing.Size(206, 21)
        Me.Text10.TabIndex = 40
        Me.Text10.Text = ""
        Me.Text10.Text = ""
        Me.Text10.Multiline = False
        'Datafield = "STUDY_PROT_STRING"
        'Datasource = "rdcCredentialGrid"
        '
        'Text9
        '
        Me.Text9 = New System.Windows.Forms.TextBox()
        Me.Text9.Location = New System.Drawing.Point(432, 120)
        Me.Text9.Name = "Text9"
        Me.Text9.Size = New System.Drawing.Size(100, 21)
        Me.Text9.TabIndex = 37
        Me.Text9.Text = ""
        Me.Text9.Text = ""
        Me.Text9.Multiline = False
        'Datafield = "PHANTOM_DATE"
        'Datasource = "rdcCredentialGrid"
        '
        'Text5
        '
        Me.Text5 = New System.Windows.Forms.TextBox()
        Me.Text5.Location = New System.Drawing.Point(112, 144)
        Me.Text5.Name = "Text5"
        Me.Text5.Size = New System.Drawing.Size(100, 21)
        Me.Text5.TabIndex = 34
        Me.Text5.Text = ""
        Me.Text5.Text = ""
        Me.Text5.Multiline = False
        '
        'BtnAddCredential
        '
        Me.BtnAddCredential = New System.Windows.Forms.Button()
        Me.BtnAddCredential.Location = New System.Drawing.Point(344, 232)
        Me.BtnAddCredential.Name = "BtnAddCredential"
        Me.BtnAddCredential.Size = New System.Drawing.Size(109, 25)
        Me.BtnAddCredential.TabIndex = 17
        Me.BtnAddCredential.Text = "&Add Credential"
        Me.BtnAddCredential.UseVisualStyleBackColor = True
        '
        'BtnEditCredential
        '
        Me.BtnEditCredential = New System.Windows.Forms.Button()
        Me.BtnEditCredential.Location = New System.Drawing.Point(232, 232)
        Me.BtnEditCredential.Name = "BtnEditCredential"
        Me.BtnEditCredential.Size = New System.Drawing.Size(109, 25)
        Me.BtnEditCredential.TabIndex = 16
        Me.BtnEditCredential.Text = "&Edit Credential"
        Me.BtnEditCredential.UseVisualStyleBackColor = True
        '
        'Text4
        '
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Text4.Location = New System.Drawing.Point(432, 72)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(100, 21)
        Me.Text4.TabIndex = 15
        Me.Text4.Text = ""
        Me.Text4.Text = ""
        Me.Text4.Multiline = False
        'Datafield = "study_group_no"
        'Datasource = "rdcCredentialGrid"
        '
        'Text1
        '
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text1.Location = New System.Drawing.Point(432, 24)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(100, 21)
        Me.Text1.TabIndex = 14
        Me.Text1.Text = ""
        Me.Text1.Text = ""
        Me.Text1.Multiline = False
        'Datafield = "Credentialing_date"
        'Datasource = "rdcCredentialGrid"
        '
        'Text2
        '
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text2.Location = New System.Drawing.Point(432, 48)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(100, 21)
        Me.Text2.TabIndex = 13
        Me.Text2.Text = ""
        Me.Text2.Text = ""
        Me.Text2.Multiline = False
        'Datafield = "decredentialing_date"
        'Datasource = "rdcCredentialGrid"
        '
        'Text7
        '
        Me.Text7 = New System.Windows.Forms.TextBox()
        Me.Text7.Location = New System.Drawing.Point(112, 96)
        Me.Text7.Name = "Text7"
        Me.Text7.Size = New System.Drawing.Size(141, 21)
        Me.Text7.TabIndex = 12
        Me.Text7.Text = ""
        Me.Text7.Text = ""
        Me.Text7.Multiline = False
        'Datafield = "Physicist"
        'Datasource = "rdcCredentialGrid"
        '
        'Text6
        '
        Me.Text6 = New System.Windows.Forms.TextBox()
        Me.Text6.Location = New System.Drawing.Point(112, 24)
        Me.Text6.Name = "Text6"
        Me.Text6.Size = New System.Drawing.Size(141, 21)
        Me.Text6.TabIndex = 11
        Me.Text6.Text = ""
        Me.Text6.Text = ""
        Me.Text6.Multiline = False
        'Datafield = "CRED_TYPE"
        'Datasource = "rdcCredentialGrid"
        '
        'Text3
        '
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text3.Location = New System.Drawing.Point(112, 72)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(140, 21)
        Me.Text3.TabIndex = 10
        Me.Text3.Text = ""
        Me.Text3.Text = ""
        Me.Text3.Multiline = False
        'Datafield = "Oncologist"
        'Datasource = "rdcCredentialGrid"
        '
        'txtSWOG
        '
        Me.txtSWOG = New System.Windows.Forms.TextBox()
        Me.txtSWOG.Location = New System.Drawing.Point(432, 96)
        Me.txtSWOG.Name = "txtSWOG"
        Me.txtSWOG.Size = New System.Drawing.Size(140, 21)
        Me.txtSWOG.TabIndex = 9
        Me.txtSWOG.Text = ""
        Me.txtSWOG.Text = ""
        Me.txtSWOG.Multiline = False
        'Datafield = "TPC"
        'Datasource = "rdcCredentialGrid"
        '
        'Text8
        '
        Me.Text8 = New System.Windows.Forms.TextBox()
        Me.Text8.Location = New System.Drawing.Point(112, 48)
        Me.Text8.Name = "Text8"
        Me.Text8.Size = New System.Drawing.Size(140, 21)
        Me.Text8.TabIndex = 8
        Me.Text8.Text = ""
        Me.Text8.Text = ""
        Me.Text8.Multiline = False
        'Datafield = "Status"
        'Datasource = "rdcCredentialGrid"
        '
        'BtnDeleteCredential
        '
        Me.BtnDeleteCredential = New System.Windows.Forms.Button()
        Me.BtnDeleteCredential.Location = New System.Drawing.Point(456, 232)
        Me.BtnDeleteCredential.Name = "BtnDeleteCredential"
        Me.BtnDeleteCredential.Size = New System.Drawing.Size(109, 25)
        Me.BtnDeleteCredential.TabIndex = 7
        Me.BtnDeleteCredential.Text = "&Delete Credential"
        Me.BtnDeleteCredential.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label14.Location = New System.Drawing.Point(216, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 17)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Resp. Motion"
        Me.Label14.Text = "Resp. Motion"
        '
        'Label13
        '
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label13.Location = New System.Drawing.Point(32, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 17)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Comments"
        Me.Label13.Text = "Comments"
        '
        'Label12
        '
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label12.Location = New System.Drawing.Point(32, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Study Protocol"
        Me.Label12.Text = "Study Protocol"
        '
        'Label10
        '
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label10.Location = New System.Drawing.Point(320, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 17)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Phantom Date"
        Me.Label10.Text = "Phantom Date"
        '
        'Label6
        '
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label6.Location = New System.Drawing.Point(32, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "RTF Number"
        Me.Label6.Text = "RTF Number"
        '
        'Label2
        '
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Credential Type"
        Me.Label2.Text = "Credential Type"
        '
        'Label3
        '
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label3.Location = New System.Drawing.Point(32, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Physicist"
        Me.Label3.Text = "Physicist"
        '
        'Label5
        '
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label5.Location = New System.Drawing.Point(320, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Study Goup Number"
        Me.Label5.Text = "Study Goup Number"
        '
        'Label7
        '
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label7.Location = New System.Drawing.Point(320, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Credentialing Date"
        Me.Label7.Text = "Credentialing Date"
        '
        'Label8
        '
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label8.Location = New System.Drawing.Point(320, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Decredentialing Date"
        Me.Label8.Text = "Decredentialing Date"
        '
        'Label4
        '
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label4.Location = New System.Drawing.Point(32, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Oncologist"
        Me.Label4.Text = "Oncologist"
        '
        'lblSWOG
        '
        Me.lblSWOG = New System.Windows.Forms.Label()
        Me.lblSWOG.Location = New System.Drawing.Point(320, 104)
        Me.lblSWOG.Name = "lblSWOG"
        Me.lblSWOG.Size = New System.Drawing.Size(114, 17)
        Me.lblSWOG.TabIndex = 19
        Me.lblSWOG.Text = "Treat Plan Computer"
        Me.lblSWOG.Text = "Treat Plan Computer"
        '
        'Label9
        '
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label9.Location = New System.Drawing.Point(32, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Status"
        Me.Label9.Text = "Status"
        Me.FrmCredentialInformation.Controls.Add(Me.txtRespMotion)
        Me.FrmCredentialInformation.Controls.Add(Me.TxtComments)
        Me.FrmCredentialInformation.Controls.Add(Me.Text10)
        Me.FrmCredentialInformation.Controls.Add(Me.Text9)
        Me.FrmCredentialInformation.Controls.Add(Me.Text5)
        Me.FrmCredentialInformation.Controls.Add(Me.BtnAddCredential)
        Me.FrmCredentialInformation.Controls.Add(Me.BtnEditCredential)
        Me.FrmCredentialInformation.Controls.Add(Me.Text4)
        Me.FrmCredentialInformation.Controls.Add(Me.Text1)
        Me.FrmCredentialInformation.Controls.Add(Me.Text2)
        Me.FrmCredentialInformation.Controls.Add(Me.Text7)
        Me.FrmCredentialInformation.Controls.Add(Me.Text6)
        Me.FrmCredentialInformation.Controls.Add(Me.Text3)
        Me.FrmCredentialInformation.Controls.Add(Me.txtSWOG)
        Me.FrmCredentialInformation.Controls.Add(Me.Text8)
        Me.FrmCredentialInformation.Controls.Add(Me.BtnDeleteCredential)
        Me.FrmCredentialInformation.Controls.Add(Me.Label14)
        Me.FrmCredentialInformation.Controls.Add(Me.Label13)
        Me.FrmCredentialInformation.Controls.Add(Me.Label12)
        Me.FrmCredentialInformation.Controls.Add(Me.Label10)
        Me.FrmCredentialInformation.Controls.Add(Me.Label6)
        Me.FrmCredentialInformation.Controls.Add(Me.Label2)
        Me.FrmCredentialInformation.Controls.Add(Me.Label3)
        Me.FrmCredentialInformation.Controls.Add(Me.Label5)
        Me.FrmCredentialInformation.Controls.Add(Me.Label7)
        Me.FrmCredentialInformation.Controls.Add(Me.Label8)
        Me.FrmCredentialInformation.Controls.Add(Me.Label4)
        Me.FrmCredentialInformation.Controls.Add(Me.lblSWOG)
        Me.FrmCredentialInformation.Controls.Add(Me.Label9)
        '
        'BtnInstitutionSearch
        '
        Me.BtnInstitutionSearch = New System.Windows.Forms.Button()
        Me.BtnInstitutionSearch.Location = New System.Drawing.Point(561, 0)
        Me.BtnInstitutionSearch.Name = "BtnInstitutionSearch"
        Me.BtnInstitutionSearch.Size = New System.Drawing.Size(25, 25)
        Me.BtnInstitutionSearch.TabIndex = 4
        Me.BtnInstitutionSearch.Text = "BtnInstitutionSearch"
        Me.BtnInstitutionSearch.UseVisualStyleBackColor = True
        '
        'optAll
        '
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optAll.Location = New System.Drawing.Point(408, 312)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(121, 18)
        Me.optAll.TabIndex = 3
        Me.optAll.Text = "View All Credentials"
        Me.optAll.Text = "View All Credentials"
        '
        'optCurrent
        '
        Me.optCurrent = New System.Windows.Forms.RadioButton()
        Me.optCurrent.Location = New System.Drawing.Point(216, 312)
        Me.optCurrent.Name = "optCurrent"
        Me.optCurrent.Size = New System.Drawing.Size(161, 18)
        Me.optCurrent.TabIndex = 2
        Me.optCurrent.Text = "View Current Credentials Only"
        Me.optCurrent.Text = "View Current Credentials Only"
        '
        'BtnClose
        '
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnClose.Location = New System.Drawing.Point(8, 608)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 25)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GrdCredential
        '
        Me.GrdCredential = New System.Windows.Forms.DataGridView()
        Me.GrdCredential.Location = New System.Drawing.Point(8, 336)
        Me.GrdCredential.Name = "GrdCredential"
        Me.GrdCredential.Size = New System.Drawing.Size(578, 105)
        Me.GrdCredential.TabIndex = 1
        Me.GrdCredential.Text = "GrdCredential"
        Me.GrdCredential.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdCredential.AllowUserToAddRows = False
        Me.GrdCredential.AllowUserToDeleteRows = False
        Me.GrdCredential.MultiSelect = False
        Me.GrdCredential.ReadOnly = True
        Me.GrdCredential.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Label11
        '
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label11.Location = New System.Drawing.Point(8, 320)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Credentials"
        Me.Label11.Text = "Credentials"
        '
        'LblInstitutionName
        '
        Me.LblInstitutionName = New System.Windows.Forms.Label()
        Me.LblInstitutionName.Location = New System.Drawing.Point(9, 6)
        Me.LblInstitutionName.Name = "LblInstitutionName"
        Me.LblInstitutionName.Size = New System.Drawing.Size(323, 19)
        Me.LblInstitutionName.TabIndex = 27
        Me.LblInstitutionName.Text = "Institution Name"
        Me.LblInstitutionName.Text = "Institution Name"
        '
        'Label1
        '
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1.Location = New System.Drawing.Point(329, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Institution"
        Me.Label1.Text = "Institution"
        '
        'frmCredentialing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 650)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.FrmCredentialInformation)
        Me.Controls.Add(Me.BtnInstitutionSearch)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.optCurrent)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrdCredential)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblInstitutionName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCredentialing"
        Me.Text = "frmCredentialing"
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents cmdExport As Button
    Friend WithEvents cmdPrintQuestionnaire As Button
    Friend WithEvents BtnEditBrachyCredential As Button
    Friend WithEvents BtnAddBrachyCredential As Button
    Friend WithEvents BtnDeleteBrachyCredential As Button
    Friend WithEvents GrdBrachyCredential As DataGridView
    Friend WithEvents FrmCredentialInformation As GroupBox
    Friend WithEvents txtRespMotion As TextBox
    Friend WithEvents TxtComments As TextBox
    Friend WithEvents Text10 As TextBox
    Friend WithEvents Text9 As TextBox
    Friend WithEvents Text5 As TextBox
    Friend WithEvents BtnAddCredential As Button
    Friend WithEvents BtnEditCredential As Button
    Friend WithEvents Text4 As TextBox
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents Text7 As TextBox
    Friend WithEvents Text6 As TextBox
    Friend WithEvents Text3 As TextBox
    Friend WithEvents txtSWOG As TextBox
    Friend WithEvents Text8 As TextBox
    Friend WithEvents BtnDeleteCredential As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSWOG As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnInstitutionSearch As Button
    Friend WithEvents optAll As RadioButton
    Friend WithEvents optCurrent As RadioButton
    Friend WithEvents BtnClose As Button
    Friend WithEvents GrdCredential As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents LblInstitutionName As Label
    Friend WithEvents Label1 As Label
End Class
