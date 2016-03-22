<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActivationLetters
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
        Me.BtnClose.Location = New System.Drawing.Point(280, 40)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 25)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnPrint.Location = New System.Drawing.Point(281, 8)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(89, 25)
        Me.BtnPrint.TabIndex = 3
        Me.BtnPrint.Text = "BtnPrint"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'ChkOncologistLetter
        '
        Me.ChkOncologistLetter = New System.Windows.Forms.CheckBox()
        Me.ChkOncologistLetter.AutoSize = True
        Me.ChkOncologistLetter.Location = New System.Drawing.Point(12, 36)
        Me.ChkOncologistLetter.Name = "ChkOncologistLetter"
        Me.ChkOncologistLetter.Size = New System.Drawing.Size(121, 17)
        Me.ChkOncologistLetter.TabIndex = 1
        Me.ChkOncologistLetter.Text = "Oncologist Letter"
        Me.ChkOncologistLetter.UseVisualStyleBackColor = True
        '
        'ChkPhysicistLetter
        '
        Me.ChkPhysicistLetter = New System.Windows.Forms.CheckBox()
        Me.ChkPhysicistLetter.AutoSize = True
        Me.ChkPhysicistLetter.Location = New System.Drawing.Point(12, 12)
        Me.ChkPhysicistLetter.Name = "ChkPhysicistLetter"
        Me.ChkPhysicistLetter.Size = New System.Drawing.Size(121, 13)
        Me.ChkPhysicistLetter.TabIndex = 0
        Me.ChkPhysicistLetter.Text = "Physicist Letter"
        Me.ChkPhysicistLetter.UseVisualStyleBackColor = True
        '
        'ChkFeeForm
        '
        Me.ChkFeeForm = New System.Windows.Forms.CheckBox()
        Me.ChkFeeForm.AutoSize = True
        Me.ChkFeeForm.Location = New System.Drawing.Point(152, 11)
        Me.ChkFeeForm.Name = "ChkFeeForm"
        Me.ChkFeeForm.Size = New System.Drawing.Size(89, 17)
        Me.ChkFeeForm.TabIndex = 2
        Me.ChkFeeForm.Text = "Fee Form"
        Me.ChkFeeForm.UseVisualStyleBackColor = True
        '
        'frmActivationLetters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 78)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.ChkOncologistLetter)
        Me.Controls.Add(Me.ChkPhysicistLetter)
        Me.Controls.Add(Me.ChkFeeForm)
        Me.Name = "frmActivationLetters"
        Me.Text = "frmActivationLetters"
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents ChkOncologistLetter As CheckBox
    Friend WithEvents ChkPhysicistLetter As CheckBox
    Friend WithEvents ChkFeeForm As CheckBox
End Class
