<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBatchCorrection
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
        'BtnCancel
        '
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnCancel.Location = New System.Drawing.Point(84, 81)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(65, 25)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "BtnCancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnOK.Location = New System.Drawing.Point(12, 81)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(65, 25)
        Me.BtnOK.TabIndex = 4
        Me.BtnOK.Text = "BtnOK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TxtBatchCorrection
        '
        Me.TxtBatchCorrection = New System.Windows.Forms.TextBox()
        Me.TxtBatchCorrection.Location = New System.Drawing.Point(138, 33)
        Me.TxtBatchCorrection.Name = "TxtBatchCorrection"
        Me.TxtBatchCorrection.Size = New System.Drawing.Size(91, 22)
        Me.TxtBatchCorrection.TabIndex = 3
        Me.TxtBatchCorrection.Text = "TxtBatchCorrection"
        '
        'CmbBatchLookup
        '
        Me.CmbBatchLookup = New System.Windows.Forms.ComboBox()
        Me.CmbBatchLookup.FormattingEnabled = True
        Me.CmbBatchLookup.Location = New System.Drawing.Point(138, 9)
        Me.CmbBatchLookup.Name = "CmbBatchLookup"
        Me.CmbBatchLookup.Size = New System.Drawing.Size(91, 21)
        Me.CmbBatchLookup.TabIndex = 1
        '
        'Label2
        '
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Correction Factor"
        '
        'Label1
        '
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batch to be corrected"
        '
        'frmBatchCorrection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 119)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.TxtBatchCorrection)
        Me.Controls.Add(Me.CmbBatchLookup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBatchCorrection"
        Me.Text = "frmBatchCorrection"
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtBatchCorrection As TextBox
    Friend WithEvents CmbBatchLookup As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
