<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditPhantomLogbook
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
        'Frame2
        '
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Frame2.Location = New System.Drawing.Point(1, 112)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(295, 57)
        Me.Frame2.TabIndex = 48
        Me.Frame2.Text = "Ship Phantom To"
        '
        'Text17
        '
        Me.Text17 = New System.Windows.Forms.TextBox()
        Me.Text17.Location = New System.Drawing.Point(24, 24)
        Me.Text17.Name = "Text17"
        Me.Text17.Size = New System.Drawing.Size(201, 21)
        Me.Text17.TabIndex = 50
        Me.Text17.Text = ""
        Me.Text17.Text = ""
        Me.Text17.Multiline = "False"
        '
        'Text16
        '
        Me.Text16 = New System.Windows.Forms.TextBox()
        Me.Text16.Location = New System.Drawing.Point(228, 24)
        Me.Text16.Name = "Text16"
        Me.Text16.Size = New System.Drawing.Size(49, 21)
        Me.Text16.TabIndex = 49
        Me.Text16.Text = ""
        Me.Text16.Text = ""
        Me.Text16.Multiline = "False"
        Me.Frame2.Controls.Add(Me.Text17)
        Me.Frame2.Controls.Add(Me.Text16)
        '
        'BtnClose
        '
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnClose.Location = New System.Drawing.Point(8, 480)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 25)
        Me.BtnClose.TabIndex = 47
        Me.BtnClose.Text = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame1.Location = New System.Drawing.Point(1, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(297, 105)
        Me.Frame1.TabIndex = 39
        Me.Frame1.Text = "Institution Information"
        '
        'Text1
        '
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text1.Location = New System.Drawing.Point(68, 48)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(89, 21)
        Me.Text1.TabIndex = 42
        Me.Text1.Text = ""
        Me.Text1.Text = ""
        Me.Text1.Multiline = "False"
        '
        'Text2
        '
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text2.Location = New System.Drawing.Point(192, 48)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(89, 21)
        Me.Text2.TabIndex = 41
        Me.Text2.Text = ""
        Me.Text2.Text = ""
        Me.Text2.Multiline = "False"
        '
        'Text6
        '
        Me.Text6 = New System.Windows.Forms.TextBox()
        Me.Text6.Location = New System.Drawing.Point(100, 72)
        Me.Text6.Name = "Text6"
        Me.Text6.Size = New System.Drawing.Size(181, 21)
        Me.Text6.TabIndex = 40
        Me.Text6.Text = ""
        Me.Text6.Text = ""
        Me.Text6.Multiline = "False"
        '
        'CmbMailTLDLookup
        '
        Me.CmbMailTLDLookup = New System.Windows.Forms.ComboBox()
        Me.CmbMailTLDLookup.Location = New System.Drawing.Point(32, 24)
        Me.CmbMailTLDLookup.Name = "CmbMailTLDLookup"
        Me.CmbMailTLDLookup.Size = New System.Drawing.Size(250, 21)
        Me.CmbMailTLDLookup.TabIndex = 43
        Me.CmbMailTLDLookup.Text = ""
        '
        'Label5
        '
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label5.Location = New System.Drawing.Point(28, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Phone"
        Me.Label5.Text = "Phone"
        '
        'Label6
        '
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label6.Location = New System.Drawing.Point(164, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "FAX"
        Me.Label6.Text = "FAX"
        '
        'Label7
        '
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label7.Location = New System.Drawing.Point(28, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "TLD Physicist"
        Me.Label7.Text = "TLD Physicist"
        Me.Frame1.Controls.Add(Me.Text1)
        Me.Frame1.Controls.Add(Me.Text2)
        Me.Frame1.Controls.Add(Me.Text6)
        Me.Frame1.Controls.Add(Me.CmbMailTLDLookup)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label7)
        '
        'BtnCancel
        '
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCancel.Location = New System.Drawing.Point(80, 480)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(65, 25)
        Me.BtnCancel.TabIndex = 38
        Me.BtnCancel.Text = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnOK.Location = New System.Drawing.Point(8, 480)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(65, 25)
        Me.BtnOK.TabIndex = 37
        Me.BtnOK.Text = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'FrmBoxes
        '
        Me.FrmBoxes = New System.Windows.Forms.GroupBox()
        Me.FrmBoxes.Location = New System.Drawing.Point(1, 176)
        Me.FrmBoxes.Name = "FrmBoxes"
        Me.FrmBoxes.Size = New System.Drawing.Size(605, 297)
        Me.FrmBoxes.TabIndex = 8
        Me.FrmBoxes.Text = "Boxes"
        '
        'BtnEditBox
        '
        Me.BtnEditBox = New System.Windows.Forms.Button()
        Me.BtnEditBox.Location = New System.Drawing.Point(426, 42)
        Me.BtnEditBox.Name = "BtnEditBox"
        Me.BtnEditBox.Size = New System.Drawing.Size(137, 25)
        Me.BtnEditBox.TabIndex = 26
        Me.BtnEditBox.Text = "Edit Box..."
        Me.BtnEditBox.UseVisualStyleBackColor = True
        '
        'BtnAddBox
        '
        Me.BtnAddBox = New System.Windows.Forms.Button()
        Me.BtnAddBox.Location = New System.Drawing.Point(426, 15)
        Me.BtnAddBox.Name = "BtnAddBox"
        Me.BtnAddBox.Size = New System.Drawing.Size(137, 25)
        Me.BtnAddBox.TabIndex = 25
        Me.BtnAddBox.Text = "Add New Box..."
        Me.BtnAddBox.UseVisualStyleBackColor = True
        '
        'BtnPrintIrradiationForms
        '
        Me.BtnPrintIrradiationForms = New System.Windows.Forms.Button()
        Me.BtnPrintIrradiationForms.Location = New System.Drawing.Point(426, 148)
        Me.BtnPrintIrradiationForms.Name = "BtnPrintIrradiationForms"
        Me.BtnPrintIrradiationForms.Size = New System.Drawing.Size(137, 25)
        Me.BtnPrintIrradiationForms.TabIndex = 24
        Me.BtnPrintIrradiationForms.Text = "Print Irradiation Forms..."
        Me.BtnPrintIrradiationForms.UseVisualStyleBackColor = True
        '
        'FrmPhantomList
        '
        Me.FrmPhantomList = New System.Windows.Forms.GroupBox()
        Me.FrmPhantomList.Location = New System.Drawing.Point(19, 151)
        Me.FrmPhantomList.Name = "FrmPhantomList"
        Me.FrmPhantomList.Size = New System.Drawing.Size(368, 92)
        Me.FrmPhantomList.TabIndex = 22
        Me.FrmPhantomList.Text = "Phantom List"
        '
        'LstPhantoms
        '
        Me.LstPhantoms = New System.Windows.Forms.ListBox()
        Me.LstPhantoms.Location = New System.Drawing.Point(12, 16)
        Me.LstPhantoms.Name = "LstPhantoms"
        Me.LstPhantoms.Size = New System.Drawing.Size(340, 69)
        Me.LstPhantoms.TabIndex = 23
        Me.LstPhantoms.Text = ""
        Me.LstPhantoms.FormattingEnabled = True
        Me.FrmBoxes.Controls.Add(Me.BtnEditBox)
        Me.FrmBoxes.Controls.Add(Me.BtnAddBox)
        Me.FrmBoxes.Controls.Add(Me.BtnPrintIrradiationForms)
        Me.FrmBoxes.Controls.Add(Me.FrmPhantomList)
        Me.FrmPhantomList.Controls.Add(Me.LstPhantoms)
        '
        'EdtBoxComment
        '
        Me.EdtBoxComment = New System.Windows.Forms.TextBox()
        Me.EdtBoxComment.Location = New System.Drawing.Point(87, 254)
        Me.EdtBoxComment.Name = "EdtBoxComment"
        Me.EdtBoxComment.Size = New System.Drawing.Size(300, 37)
        Me.EdtBoxComment.TabIndex = 21
        Me.EdtBoxComment.Text = ""
        Me.EdtBoxComment.Text = ""
        Me.EdtBoxComment.Multiline = "True"
        '
        'BtnBoxContents
        '
        Me.BtnBoxContents = New System.Windows.Forms.Button()
        Me.BtnBoxContents.Location = New System.Drawing.Point(426, 69)
        Me.BtnBoxContents.Name = "BtnBoxContents"
        Me.BtnBoxContents.Size = New System.Drawing.Size(137, 25)
        Me.BtnBoxContents.TabIndex = 20
        Me.BtnBoxContents.Text = "View Box Contents..."
        Me.BtnBoxContents.UseVisualStyleBackColor = True
        '
        'Text4
        '
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Text4.Location = New System.Drawing.Point(87, 78)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(97, 21)
        Me.Text4.TabIndex = 19
        Me.Text4.Text = ""
        Me.Text4.Text = ""
        Me.Text4.Multiline = "False"
        '
        'Text3
        '
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text3.Location = New System.Drawing.Point(88, 30)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(97, 21)
        Me.Text3.TabIndex = 18
        Me.Text3.Text = ""
        Me.Text3.Text = ""
        Me.Text3.Multiline = "False"
        '
        'EdtDateReceived
        '
        Me.EdtDateReceived = New System.Windows.Forms.TextBox()
        Me.EdtDateReceived.Location = New System.Drawing.Point(87, 104)
        Me.EdtDateReceived.Name = "EdtDateReceived"
        Me.EdtDateReceived.Size = New System.Drawing.Size(97, 21)
        Me.EdtDateReceived.TabIndex = 17
        Me.EdtDateReceived.Text = ""
        Me.EdtDateReceived.Text = ""
        Me.EdtDateReceived.Multiline = "False"
        '
        'EdtDateSent
        '
        Me.EdtDateSent = New System.Windows.Forms.TextBox()
        Me.EdtDateSent.Location = New System.Drawing.Point(87, 54)
        Me.EdtDateSent.Name = "EdtDateSent"
        Me.EdtDateSent.Size = New System.Drawing.Size(97, 21)
        Me.EdtDateSent.TabIndex = 16
        Me.EdtDateSent.Text = ""
        Me.EdtDateSent.Text = ""
        Me.EdtDateSent.Multiline = "False"
        '
        'EdtReceiveCost
        '
        Me.EdtReceiveCost = New System.Windows.Forms.TextBox()
        Me.EdtReceiveCost.Location = New System.Drawing.Point(290, 108)
        Me.EdtReceiveCost.Name = "EdtReceiveCost"
        Me.EdtReceiveCost.Size = New System.Drawing.Size(97, 21)
        Me.EdtReceiveCost.TabIndex = 15
        Me.EdtReceiveCost.Text = ""
        Me.EdtReceiveCost.Text = ""
        Me.EdtReceiveCost.Multiline = "False"
        '
        'EdtSendCost
        '
        Me.EdtSendCost = New System.Windows.Forms.TextBox()
        Me.EdtSendCost.Location = New System.Drawing.Point(290, 84)
        Me.EdtSendCost.Name = "EdtSendCost"
        Me.EdtSendCost.Size = New System.Drawing.Size(97, 21)
        Me.EdtSendCost.TabIndex = 14
        Me.EdtSendCost.Text = ""
        Me.EdtSendCost.Text = ""
        Me.EdtSendCost.Multiline = "False"
        '
        'EdtCarrier
        '
        Me.EdtCarrier = New System.Windows.Forms.TextBox()
        Me.EdtCarrier.Location = New System.Drawing.Point(290, 60)
        Me.EdtCarrier.Name = "EdtCarrier"
        Me.EdtCarrier.Size = New System.Drawing.Size(97, 21)
        Me.EdtCarrier.TabIndex = 13
        Me.EdtCarrier.Text = ""
        Me.EdtCarrier.Text = ""
        Me.EdtCarrier.Multiline = "False"
        '
        'EdtTrackingNum
        '
        Me.EdtTrackingNum = New System.Windows.Forms.TextBox()
        Me.EdtTrackingNum.Location = New System.Drawing.Point(290, 36)
        Me.EdtTrackingNum.Name = "EdtTrackingNum"
        Me.EdtTrackingNum.Size = New System.Drawing.Size(97, 21)
        Me.EdtTrackingNum.TabIndex = 12
        Me.EdtTrackingNum.Text = ""
        Me.EdtTrackingNum.Text = ""
        Me.EdtTrackingNum.Multiline = "False"
        '
        'BtnMoveBox
        '
        Me.BtnMoveBox = New System.Windows.Forms.Button()
        Me.BtnMoveBox.Location = New System.Drawing.Point(426, 96)
        Me.BtnMoveBox.Name = "BtnMoveBox"
        Me.BtnMoveBox.Size = New System.Drawing.Size(137, 25)
        Me.BtnMoveBox.TabIndex = 10
        Me.BtnMoveBox.Text = "Move Box..."
        Me.BtnMoveBox.UseVisualStyleBackColor = True
        '
        'BtnDeleteBox
        '
        Me.BtnDeleteBox = New System.Windows.Forms.Button()
        Me.BtnDeleteBox.Location = New System.Drawing.Point(426, 122)
        Me.BtnDeleteBox.Name = "BtnDeleteBox"
        Me.BtnDeleteBox.Size = New System.Drawing.Size(137, 25)
        Me.BtnDeleteBox.TabIndex = 9
        Me.BtnDeleteBox.Text = "Delete Box"
        Me.BtnDeleteBox.UseVisualStyleBackColor = True
        '
        'LstDatesRead
        '
        Me.LstDatesRead = New System.Windows.Forms.ListBox()
        Me.LstDatesRead.Location = New System.Drawing.Point(87, 128)
        Me.LstDatesRead.Name = "LstDatesRead"
        Me.LstDatesRead.Size = New System.Drawing.Size(97, 17)
        Me.LstDatesRead.TabIndex = 11
        Me.LstDatesRead.Text = ""
        Me.LstDatesRead.FormattingEnabled = True
        '
        'Label19
        '
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label19.Location = New System.Drawing.Point(18, 254)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Comments"
        Me.Label19.Text = "Comments"
        '
        'Label4
        '
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label4.Location = New System.Drawing.Point(16, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Date(s) Read"
        Me.Label4.Text = "Date(s) Read"
        '
        'Label3
        '
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label3.Location = New System.Drawing.Point(18, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Rec. Tech"
        Me.Label3.Text = "Rec. Tech"
        '
        'Label2
        '
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label2.Location = New System.Drawing.Point(16, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Mailing Tech"
        Me.Label2.Text = "Mailing Tech"
        '
        'Label8
        '
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label8.Location = New System.Drawing.Point(18, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Date Rec."
        Me.Label8.Text = "Date Rec."
        '
        'Label9
        '
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label9.Location = New System.Drawing.Point(18, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Date Sent"
        Me.Label9.Text = "Date Sent"
        '
        'Label10
        '
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label10.Location = New System.Drawing.Point(228, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 17)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Rec. Cost"
        Me.Label10.Text = "Rec. Cost"
        '
        'Label11
        '
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label11.Location = New System.Drawing.Point(228, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 17)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Send Cost"
        Me.Label11.Text = "Send Cost"
        '
        'Label14
        '
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label14.Location = New System.Drawing.Point(228, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 17)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Carrier"
        Me.Label14.Text = "Carrier"
        '
        'Label12
        '
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label12.Location = New System.Drawing.Point(228, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Track Num"
        Me.Label12.Text = "Track Num"
        Me.FrmBoxes.Controls.Add(Me.EdtBoxComment)
        Me.FrmBoxes.Controls.Add(Me.BtnBoxContents)
        Me.FrmBoxes.Controls.Add(Me.Text4)
        Me.FrmBoxes.Controls.Add(Me.Text3)
        Me.FrmBoxes.Controls.Add(Me.EdtDateReceived)
        Me.FrmBoxes.Controls.Add(Me.EdtDateSent)
        Me.FrmBoxes.Controls.Add(Me.EdtReceiveCost)
        Me.FrmBoxes.Controls.Add(Me.EdtSendCost)
        Me.FrmBoxes.Controls.Add(Me.EdtCarrier)
        Me.FrmBoxes.Controls.Add(Me.EdtTrackingNum)
        Me.FrmBoxes.Controls.Add(Me.BtnMoveBox)
        Me.FrmBoxes.Controls.Add(Me.BtnDeleteBox)
        Me.FrmBoxes.Controls.Add(Me.LstDatesRead)
        Me.FrmBoxes.Controls.Add(Me.Label19)
        Me.FrmBoxes.Controls.Add(Me.Label4)
        Me.FrmBoxes.Controls.Add(Me.Label3)
        Me.FrmBoxes.Controls.Add(Me.Label2)
        Me.FrmBoxes.Controls.Add(Me.Label8)
        Me.FrmBoxes.Controls.Add(Me.Label9)
        Me.FrmBoxes.Controls.Add(Me.Label10)
        Me.FrmBoxes.Controls.Add(Me.Label11)
        Me.FrmBoxes.Controls.Add(Me.Label14)
        Me.FrmBoxes.Controls.Add(Me.Label12)
        '
        'Frame5
        '
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.Frame5.Location = New System.Drawing.Point(304, 8)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Size = New System.Drawing.Size(300, 161)
        Me.Frame5.TabIndex = 1
        Me.Frame5.Text = "Logbook Info"
        '
        'EdtLogbookComment
        '
        Me.EdtLogbookComment = New System.Windows.Forms.TextBox()
        Me.EdtLogbookComment.Location = New System.Drawing.Point(60, 16)
        Me.EdtLogbookComment.Name = "EdtLogbookComment"
        Me.EdtLogbookComment.Size = New System.Drawing.Size(221, 113)
        Me.EdtLogbookComment.TabIndex = 4
        Me.EdtLogbookComment.Text = ""
        Me.EdtLogbookComment.Text = ""
        Me.EdtLogbookComment.Multiline = "True"
        '
        'EdtStartDate
        '
        Me.EdtStartDate = New System.Windows.Forms.TextBox()
        Me.EdtStartDate.Location = New System.Drawing.Point(68, 132)
        Me.EdtStartDate.Name = "EdtStartDate"
        Me.EdtStartDate.Size = New System.Drawing.Size(77, 21)
        Me.EdtStartDate.TabIndex = 3
        Me.EdtStartDate.Text = ""
        Me.EdtStartDate.Text = ""
        Me.EdtStartDate.Multiline = "False"
        '
        'EdtEndDate
        '
        Me.EdtEndDate = New System.Windows.Forms.TextBox()
        Me.EdtEndDate.Location = New System.Drawing.Point(208, 132)
        Me.EdtEndDate.Name = "EdtEndDate"
        Me.EdtEndDate.Size = New System.Drawing.Size(77, 21)
        Me.EdtEndDate.TabIndex = 2
        Me.EdtEndDate.Text = ""
        Me.EdtEndDate.Text = ""
        Me.EdtEndDate.Multiline = "False"
        '
        'Label1
        '
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Comment"
        Me.Label1.Text = "Comment"
        '
        'Label15
        '
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label15.Location = New System.Drawing.Point(12, 140)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Start Date"
        Me.Label15.Text = "Start Date"
        '
        'Label16
        '
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label16.Location = New System.Drawing.Point(152, 140)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "End Date"
        Me.Label16.Text = "End Date"
        Me.Frame5.Controls.Add(Me.EdtLogbookComment)
        Me.Frame5.Controls.Add(Me.EdtStartDate)
        Me.Frame5.Controls.Add(Me.EdtEndDate)
        Me.Frame5.Controls.Add(Me.Label1)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.Controls.Add(Me.Label16)
        '
        'BtnTagAsCompleted
        '
        Me.BtnTagAsCompleted = New System.Windows.Forms.Button()
        Me.BtnTagAsCompleted.Location = New System.Drawing.Point(448, 480)
        Me.BtnTagAsCompleted.Name = "BtnTagAsCompleted"
        Me.BtnTagAsCompleted.Size = New System.Drawing.Size(153, 25)
        Me.BtnTagAsCompleted.TabIndex = 0
        Me.BtnTagAsCompleted.Text = "Tag Logbook As Completed"
        Me.BtnTagAsCompleted.UseVisualStyleBackColor = True
        '
        'frmEditPhantomLogbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 513)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.FrmBoxes)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.BtnTagAsCompleted)
        Me.Name = "frmEditPhantomLogbook"
        Me.Text = "frmEditPhantomLogbook"
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents Frame2 As GroupBox
    Friend WithEvents Text17 As TextBox
    Friend WithEvents Text16 As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents Text6 As TextBox
    Friend WithEvents CmbMailTLDLookup As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents FrmBoxes As GroupBox
    Friend WithEvents BtnEditBox As Button
    Friend WithEvents BtnAddBox As Button
    Friend WithEvents BtnPrintIrradiationForms As Button
    Friend WithEvents FrmPhantomList As GroupBox
    Friend WithEvents LstPhantoms As ListBox
    Friend WithEvents EdtBoxComment As TextBox
    Friend WithEvents BtnBoxContents As Button
    Friend WithEvents Text4 As TextBox
    Friend WithEvents Text3 As TextBox
    Friend WithEvents EdtDateReceived As TextBox
    Friend WithEvents EdtDateSent As TextBox
    Friend WithEvents EdtReceiveCost As TextBox
    Friend WithEvents EdtSendCost As TextBox
    Friend WithEvents EdtCarrier As TextBox
    Friend WithEvents EdtTrackingNum As TextBox
    Friend WithEvents BtnMoveBox As Button
    Friend WithEvents BtnDeleteBox As Button
    Friend WithEvents LstDatesRead As ListBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Frame5 As GroupBox
    Friend WithEvents EdtLogbookComment As TextBox
    Friend WithEvents EdtStartDate As TextBox
    Friend WithEvents EdtEndDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnTagAsCompleted As Button
End Class
