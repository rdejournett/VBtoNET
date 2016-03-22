<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddBeamMeasured
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
        'BtnAddMeasForBeam
        '
        Me.BtnAddMeasForBeam = New System.Windows.Forms.Button()
        Me.BtnAddMeasForBeam.Location = New System.Drawing.Point(260, 384)
        Me.BtnAddMeasForBeam.Name = "BtnAddMeasForBeam"
        Me.BtnAddMeasForBeam.Size = New System.Drawing.Size(217, 25)
        Me.BtnAddMeasForBeam.TabIndex = 11
        Me.BtnAddMeasForBeam.Text = "Add Meas For Selected Beam"
        Me.BtnAddMeasForBeam.UseVisualStyleBackColor = True
        '
        'BtnAddMeasForMachine
        '
        Me.BtnAddMeasForMachine = New System.Windows.Forms.Button()
        Me.BtnAddMeasForMachine.Location = New System.Drawing.Point(32, 384)
        Me.BtnAddMeasForMachine.Name = "BtnAddMeasForMachine"
        Me.BtnAddMeasForMachine.Size = New System.Drawing.Size(217, 25)
        Me.BtnAddMeasForMachine.TabIndex = 10
        Me.BtnAddMeasForMachine.Text = "Add Meas For All Beams"
        Me.BtnAddMeasForMachine.UseVisualStyleBackColor = True
        '
        'LstBeamsProcessed
        '
        Me.LstBeamsProcessed = New System.Windows.Forms.ListBox()
        Me.LstBeamsProcessed.FormattingEnabled = True
        Me.LstBeamsProcessed.Location = New System.Drawing.Point(372, 12)
        Me.LstBeamsProcessed.Name = "LstBeamsProcessed"
        Me.LstBeamsProcessed.Size = New System.Drawing.Size(125, 69)
        Me.LstBeamsProcessed.TabIndex = 9
        '
        'Frame2
        '
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Frame2.Location = New System.Drawing.Point(12, 244)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Text = "Beams"
        Me.Frame2.Size = New System.Drawing.Size(485, 133)
        Me.Frame2.TabIndex = 5
        '
        'Frame1
        '
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame1.Location = New System.Drawing.Point(12, 104)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Text = "Machines"
        Me.Frame1.Size = New System.Drawing.Size(485, 133)
        Me.Frame1.TabIndex = 4
        '
        'BtnCancel
        '
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCancel.Location = New System.Drawing.Point(84, 432)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(65, 25)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnOK.Location = New System.Drawing.Point(12, 432)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(65, 25)
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Text = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'CmbReviewTypeLookup
        '
        Me.CmbReviewTypeLookup = New System.Windows.Forms.ComboBox()
        Me.CmbReviewTypeLookup.FormattingEnabled = True
        Me.CmbReviewTypeLookup.Location = New System.Drawing.Point(92, 12)
        Me.CmbReviewTypeLookup.Name = "CmbReviewTypeLookup"
        Me.CmbReviewTypeLookup.Size = New System.Drawing.Size(133, 21)
        Me.CmbReviewTypeLookup.TabIndex = 2
        '
        'Label2
        '
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label2.Location = New System.Drawing.Point(272, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Beams Processed"
        '
        'Label1
        '
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Review Type"
        '
        'frmAddBeamMeasured
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 465)
        Me.Controls.Add(Me.BtnAddMeasForBeam)
        Me.Controls.Add(Me.BtnAddMeasForMachine)
        Me.Controls.Add(Me.LstBeamsProcessed)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.CmbReviewTypeLookup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddBeamMeasured"
        Me.Text = "frmAddBeamMeasured"
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents BtnAddMeasForBeam As Button
    Friend WithEvents BtnAddMeasForMachine As Button
    Friend WithEvents LstBeamsProcessed As ListBox
    Friend WithEvents Frame2 As GroupBox
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents CmbReviewTypeLookup As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
