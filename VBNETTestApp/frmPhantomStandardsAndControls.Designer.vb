<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPhantomStandardsAndControls
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
        'SSTab1
        '
        Me.SSTab1 = New System.Windows.Forms.TabControl()
        Me.SSTab1.Location = New System.Drawing.Point(8, 0)
        Me.SSTab1.Name = "SSTab1"
        Me.SSTab1.Size = New System.Drawing.Size(489, 609)
        Me.SSTab1.TabIndex = 0
        Me.SSTab1.Text = "General"
        Me.SSTab1.SelectedIndex = 0
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage0)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage1)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage2)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage3)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage4)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage5)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage6)
        Me.SSTab1.Controls.Add(Me.SSTab1TabPage7)
        '
        'SSTab1TabPage0
        '
        Me.SSTab1TabPage0 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage0.Location = New System.Drawing.Point(4, 22)
        Me.SSTab1TabPage0.Name = "SSTab1TabPage0"
        Me.SSTab1TabPage0.Size = New System.Drawing.Size(481, 583)
        Me.SSTab1TabPage0.TabIndex = 0
        Me.SSTab1TabPage0.Text = "General"
        '
        'SSTab1TabPage1
        '
        Me.SSTab1TabPage1 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.SSTab1TabPage1.Name = "SSTab1TabPage1"
        Me.SSTab1TabPage1.Size = New System.Drawing.Size(481, 583)
        Me.SSTab1TabPage1.TabIndex = 1
        Me.SSTab1TabPage1.Text = "Standards"
        '
        'SSTab1TabPage2
        '
        Me.SSTab1TabPage2 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.SSTab1TabPage2.Name = "SSTab1TabPage2"
        Me.SSTab1TabPage2.Size = New System.Drawing.Size(481, 583)
        Me.SSTab1TabPage2.TabIndex = 2
        Me.SSTab1TabPage2.Text = "Controls"
        '
        'SSTab1TabPage3
        '
        Me.SSTab1TabPage3 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.SSTab1TabPage3.Name = "SSTab1TabPage3"
        Me.SSTab1TabPage3.Size = New System.Drawing.Size(481, 583)
        Me.SSTab1TabPage3.TabIndex = 3
        Me.SSTab1TabPage3.Text = "Calculations"
        '
        'SSTab1TabPage4
        '
        Me.SSTab1TabPage4 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.SSTab1TabPage4.Name = "SSTab1TabPage4"
        Me.SSTab1TabPage4.Size = New System.Drawing.Size(481, 583)
        Me.SSTab1TabPage4.TabIndex = 4
        Me.SSTab1TabPage4.Text = "Session Summary"
        '
        'SSTab1TabPage5
        '
        Me.SSTab1TabPage5 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.SSTab1TabPage5.Name = "SSTab1TabPage5"
        Me.SSTab1TabPage5.Size = New System.Drawing.Size(481, 583)
        Me.SSTab1TabPage5.TabIndex = 5
        Me.SSTab1TabPage5.Text = "Comments"
        '
        'SSTab1TabPage6
        '
        Me.SSTab1TabPage6 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.SSTab1TabPage6.Name = "SSTab1TabPage6"
        Me.SSTab1TabPage6.Size = New System.Drawing.Size(481, 583)
        Me.SSTab1TabPage6.TabIndex = 6
        Me.SSTab1TabPage6.Text = "8 Gy Standards"
        '
        'SSTab1TabPage7
        '
        Me.SSTab1TabPage7 = New System.Windows.Forms.TabPage()
        Me.SSTab1TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.SSTab1TabPage7.Name = "SSTab1TabPage7"
        Me.SSTab1TabPage7.Size = New System.Drawing.Size(481, 583)
        Me.SSTab1TabPage7.TabIndex = 7
        Me.SSTab1TabPage7.Text = "30 Gy Standards"
        '
        'txt30GyIrrDate
        '
        Me.txt30GyIrrDate = New System.Windows.Forms.TextBox()
        Me.txt30GyIrrDate.Location = New System.Drawing.Point(0, 128)
        Me.txt30GyIrrDate.Name = "txt30GyIrrDate"
        Me.txt30GyIrrDate.Size = New System.Drawing.Size(64, 22)
        Me.txt30GyIrrDate.TabIndex = 223
        Me.txt30GyIrrDate.Text = ""
        Me.txt30GyIrrDate.Text = ""
        Me.txt30GyIrrDate.Multiline = "False"
        '
        'txt8GyIrrDate
        '
        Me.txt8GyIrrDate = New System.Windows.Forms.TextBox()
        Me.txt8GyIrrDate.Location = New System.Drawing.Point(0, 102)
        Me.txt8GyIrrDate.Name = "txt8GyIrrDate"
        Me.txt8GyIrrDate.Size = New System.Drawing.Size(64, 22)
        Me.txt8GyIrrDate.TabIndex = 222
        Me.txt8GyIrrDate.Text = ""
        Me.txt8GyIrrDate.Text = ""
        Me.txt8GyIrrDate.Multiline = "False"
        '
        'FrmStdSet269
        '
        Me.FrmStdSet269 = New System.Windows.Forms.GroupBox()
        Me.FrmStdSet269.Location = New System.Drawing.Point(0, 216)
        Me.FrmStdSet269.Name = "FrmStdSet269"
        Me.FrmStdSet269.Size = New System.Drawing.Size(469, 103)
        Me.FrmStdSet269.TabIndex = 204
        Me.FrmStdSet269.Text = "LAST"
        '
        'TxtStdAvgRdg287
        '
        Me.TxtStdAvgRdg287 = New System.Windows.Forms.TextBox()
        Me.TxtStdAvgRdg287.Location = New System.Drawing.Point(63, 75)
        Me.TxtStdAvgRdg287.Name = "TxtStdAvgRdg287"
        Me.TxtStdAvgRdg287.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdAvgRdg287.TabIndex = 210
        Me.TxtStdAvgRdg287.Text = ""
        Me.TxtStdAvgRdg287.Text = ""
        Me.TxtStdAvgRdg287.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcStdSetInfo(5)"
        '
        'TxtStdStdDev300
        '
        Me.TxtStdStdDev300 = New System.Windows.Forms.TextBox()
        Me.TxtStdStdDev300.Location = New System.Drawing.Point(168, 75)
        Me.TxtStdStdDev300.Name = "TxtStdStdDev300"
        Me.TxtStdStdDev300.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdStdDev300.TabIndex = 209
        Me.TxtStdStdDev300.Text = ""
        Me.TxtStdStdDev300.Text = ""
        Me.TxtStdStdDev300.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcStdSetInfo(5)"
        '
        'BtnAddStdCapsule313
        '
        Me.BtnAddStdCapsule313 = New System.Windows.Forms.Button()
        Me.BtnAddStdCapsule313.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddStdCapsule313.Name = "BtnAddStdCapsule313"
        Me.BtnAddStdCapsule313.Size = New System.Drawing.Size(82, 22)
        Me.BtnAddStdCapsule313.TabIndex = 208
        Me.BtnAddStdCapsule313.Text = "Add Capsule.."
        Me.BtnAddStdCapsule313.UseVisualStyleBackColor = True
        '
        'BtnEditStdCapsule322
        '
        Me.BtnEditStdCapsule322 = New System.Windows.Forms.Button()
        Me.BtnEditStdCapsule322.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditStdCapsule322.Name = "BtnEditStdCapsule322"
        Me.BtnEditStdCapsule322.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditStdCapsule322.TabIndex = 207
        Me.BtnEditStdCapsule322.Text = "Edit Capsule..."
        Me.BtnEditStdCapsule322.UseVisualStyleBackColor = True
        '
        'BtnDeleteStdCapsule331
        '
        Me.BtnDeleteStdCapsule331 = New System.Windows.Forms.Button()
        Me.BtnDeleteStdCapsule331.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteStdCapsule331.Name = "BtnDeleteStdCapsule331"
        Me.BtnDeleteStdCapsule331.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteStdCapsule331.TabIndex = 206
        Me.BtnDeleteStdCapsule331.Text = "Delete Capsule"
        Me.BtnDeleteStdCapsule331.UseVisualStyleBackColor = True
        '
        'TxtStdSetToFirst340
        '
        Me.TxtStdSetToFirst340 = New System.Windows.Forms.TextBox()
        Me.TxtStdSetToFirst340.Location = New System.Drawing.Point(318, 75)
        Me.TxtStdSetToFirst340.Name = "TxtStdSetToFirst340"
        Me.TxtStdSetToFirst340.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdSetToFirst340.TabIndex = 205
        Me.TxtStdSetToFirst340.Text = ""
        Me.TxtStdSetToFirst340.Text = ""
        Me.TxtStdSetToFirst340.Multiline = "False"
        'Datafield = "SET_TO_FIRST"
        'Datafield = "rdcStdSetInfo(5)"
        '
        'GrdStdCapsules449
        '
        Me.GrdStdCapsules449 = New System.Windows.Forms.DataGridView()
        Me.GrdStdCapsules449.Location = New System.Drawing.Point(6, 12)
        Me.GrdStdCapsules449.Name = "GrdStdCapsules449"
        Me.GrdStdCapsules449.Size = New System.Drawing.Size(370, 61)
        Me.GrdStdCapsules449.TabIndex = 211
        Me.GrdStdCapsules449.Text = "GrdStdCapsules449"
        Me.GrdStdCapsules449.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblStdAvgRdg459
        '
        Me.LblStdAvgRdg459 = New System.Windows.Forms.Label()
        Me.LblStdAvgRdg459.Location = New System.Drawing.Point(6, 84)
        Me.LblStdAvgRdg459.Name = "LblStdAvgRdg459"
        Me.LblStdAvgRdg459.Size = New System.Drawing.Size(62, 13)
        Me.LblStdAvgRdg459.TabIndex = 215
        Me.LblStdAvgRdg459.Text = "Avg Rdg"
        Me.LblStdAvgRdg459.Text = "Avg Rdg"
        '
        'LblStdStdDev477
        '
        Me.LblStdStdDev477 = New System.Windows.Forms.Label()
        Me.LblStdStdDev477.Location = New System.Drawing.Point(135, 84)
        Me.LblStdStdDev477.Name = "LblStdStdDev477"
        Me.LblStdStdDev477.Size = New System.Drawing.Size(44, 13)
        Me.LblStdStdDev477.TabIndex = 214
        Me.LblStdStdDev477.Text = "+ / -"
        Me.LblStdStdDev477.Text = "+ / -"
        '
        'LblStdSetToFirst495
        '
        Me.LblStdSetToFirst495 = New System.Windows.Forms.Label()
        Me.LblStdSetToFirst495.Location = New System.Drawing.Point(252, 84)
        Me.LblStdSetToFirst495.Name = "LblStdSetToFirst495"
        Me.LblStdSetToFirst495.Size = New System.Drawing.Size(71, 13)
        Me.LblStdSetToFirst495.TabIndex = 213
        Me.LblStdSetToFirst495.Text = "Set To 1st"
        Me.LblStdSetToFirst495.Text = "Set To 1st"
        '
        'Label37513
        '
        Me.Label37513 = New System.Windows.Forms.Label()
        Me.Label37513.Location = New System.Drawing.Point(231, 84)
        Me.Label37513.Name = "Label37513"
        Me.Label37513.Size = New System.Drawing.Size(26, 13)
        Me.Label37513.TabIndex = 212
        Me.Label37513.Text = "%"
        Me.Label37513.Text = "%"
        Me.SSTab1TabPage0.Controls.Add(Me.txt30GyIrrDate)
        Me.SSTab1TabPage0.Controls.Add(Me.txt8GyIrrDate)
        Me.SSTab1TabPage7.Controls.Add(Me.FrmStdSet269)
        Me.FrmStdSet269.Controls.Add(Me.TxtStdAvgRdg287)
        Me.FrmStdSet269.Controls.Add(Me.TxtStdStdDev300)
        Me.FrmStdSet269.Controls.Add(Me.BtnAddStdCapsule313)
        Me.FrmStdSet269.Controls.Add(Me.BtnEditStdCapsule322)
        Me.FrmStdSet269.Controls.Add(Me.BtnDeleteStdCapsule331)
        Me.FrmStdSet269.Controls.Add(Me.TxtStdSetToFirst340)
        Me.FrmStdSet269.Controls.Add(Me.GrdStdCapsules449)
        Me.FrmStdSet269.Controls.Add(Me.LblStdAvgRdg459)
        Me.FrmStdSet269.Controls.Add(Me.LblStdStdDev477)
        Me.FrmStdSet269.Controls.Add(Me.LblStdSetToFirst495)
        Me.FrmStdSet269.Controls.Add(Me.Label37513)
        '
        'FrmStdSet532
        '
        Me.FrmStdSet532 = New System.Windows.Forms.GroupBox()
        Me.FrmStdSet532.Location = New System.Drawing.Point(0, 80)
        Me.FrmStdSet532.Name = "FrmStdSet532"
        Me.FrmStdSet532.Size = New System.Drawing.Size(469, 103)
        Me.FrmStdSet532.TabIndex = 194
        Me.FrmStdSet532.Text = "FIRST"
        '
        'BtnEditStdCapsule550
        '
        Me.BtnEditStdCapsule550 = New System.Windows.Forms.Button()
        Me.BtnEditStdCapsule550.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditStdCapsule550.Name = "BtnEditStdCapsule550"
        Me.BtnEditStdCapsule550.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditStdCapsule550.TabIndex = 199
        Me.BtnEditStdCapsule550.Text = "Edit Capsule..."
        Me.BtnEditStdCapsule550.UseVisualStyleBackColor = True
        '
        'BtnAddStdCapsule559
        '
        Me.BtnAddStdCapsule559 = New System.Windows.Forms.Button()
        Me.BtnAddStdCapsule559.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddStdCapsule559.Name = "BtnAddStdCapsule559"
        Me.BtnAddStdCapsule559.Size = New System.Drawing.Size(85, 22)
        Me.BtnAddStdCapsule559.TabIndex = 198
        Me.BtnAddStdCapsule559.Text = "Add Capsule.."
        Me.BtnAddStdCapsule559.UseVisualStyleBackColor = True
        '
        'TxtStdStdDev568
        '
        Me.TxtStdStdDev568 = New System.Windows.Forms.TextBox()
        Me.TxtStdStdDev568.Location = New System.Drawing.Point(168, 75)
        Me.TxtStdStdDev568.Name = "TxtStdStdDev568"
        Me.TxtStdStdDev568.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdStdDev568.TabIndex = 197
        Me.TxtStdStdDev568.Text = ""
        Me.TxtStdStdDev568.Text = ""
        Me.TxtStdStdDev568.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcStdSetInfo(0)"
        '
        'TxtStdAvgRdg581
        '
        Me.TxtStdAvgRdg581 = New System.Windows.Forms.TextBox()
        Me.TxtStdAvgRdg581.Location = New System.Drawing.Point(63, 75)
        Me.TxtStdAvgRdg581.Name = "TxtStdAvgRdg581"
        Me.TxtStdAvgRdg581.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdAvgRdg581.TabIndex = 196
        Me.TxtStdAvgRdg581.Text = ""
        Me.TxtStdAvgRdg581.Text = ""
        Me.TxtStdAvgRdg581.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcStdSetInfo(4)"
        '
        'BtnDeleteStdCapsule594
        '
        Me.BtnDeleteStdCapsule594 = New System.Windows.Forms.Button()
        Me.BtnDeleteStdCapsule594.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteStdCapsule594.Name = "BtnDeleteStdCapsule594"
        Me.BtnDeleteStdCapsule594.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteStdCapsule594.TabIndex = 195
        Me.BtnDeleteStdCapsule594.Text = "Delete Capsule"
        Me.BtnDeleteStdCapsule594.UseVisualStyleBackColor = True
        '
        'GrdStdCapsules699
        '
        Me.GrdStdCapsules699 = New System.Windows.Forms.DataGridView()
        Me.GrdStdCapsules699.Location = New System.Drawing.Point(6, 12)
        Me.GrdStdCapsules699.Name = "GrdStdCapsules699"
        Me.GrdStdCapsules699.Size = New System.Drawing.Size(370, 61)
        Me.GrdStdCapsules699.TabIndex = 200
        Me.GrdStdCapsules699.Text = "GrdStdCapsules699"
        Me.GrdStdCapsules699.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblStdStdDev709
        '
        Me.LblStdStdDev709 = New System.Windows.Forms.Label()
        Me.LblStdStdDev709.Location = New System.Drawing.Point(135, 84)
        Me.LblStdStdDev709.Name = "LblStdStdDev709"
        Me.LblStdStdDev709.Size = New System.Drawing.Size(41, 13)
        Me.LblStdStdDev709.TabIndex = 203
        Me.LblStdStdDev709.Text = "+ / -"
        Me.LblStdStdDev709.Text = "+ / -"
        '
        'LblStdAvgRdg727
        '
        Me.LblStdAvgRdg727 = New System.Windows.Forms.Label()
        Me.LblStdAvgRdg727.Location = New System.Drawing.Point(6, 84)
        Me.LblStdAvgRdg727.Name = "LblStdAvgRdg727"
        Me.LblStdAvgRdg727.Size = New System.Drawing.Size(62, 13)
        Me.LblStdAvgRdg727.TabIndex = 202
        Me.LblStdAvgRdg727.Text = "Avg Rdg"
        Me.LblStdAvgRdg727.Text = "Avg Rdg"
        '
        'Label37745
        '
        Me.Label37745 = New System.Windows.Forms.Label()
        Me.Label37745.Location = New System.Drawing.Point(231, 84)
        Me.Label37745.Name = "Label37745"
        Me.Label37745.Size = New System.Drawing.Size(47, 13)
        Me.Label37745.TabIndex = 201
        Me.Label37745.Text = "%"
        Me.Label37745.Text = "%"
        Me.SSTab1TabPage7.Controls.Add(Me.FrmStdSet532)
        Me.FrmStdSet532.Controls.Add(Me.BtnEditStdCapsule550)
        Me.FrmStdSet532.Controls.Add(Me.BtnAddStdCapsule559)
        Me.FrmStdSet532.Controls.Add(Me.TxtStdStdDev568)
        Me.FrmStdSet532.Controls.Add(Me.TxtStdAvgRdg581)
        Me.FrmStdSet532.Controls.Add(Me.BtnDeleteStdCapsule594)
        Me.FrmStdSet532.Controls.Add(Me.GrdStdCapsules699)
        Me.FrmStdSet532.Controls.Add(Me.LblStdStdDev709)
        Me.FrmStdSet532.Controls.Add(Me.LblStdAvgRdg727)
        Me.FrmStdSet532.Controls.Add(Me.Label37745)
        '
        'FrmStdSet764
        '
        Me.FrmStdSet764 = New System.Windows.Forms.GroupBox()
        Me.FrmStdSet764.Location = New System.Drawing.Point(0, 216)
        Me.FrmStdSet764.Name = "FrmStdSet764"
        Me.FrmStdSet764.Size = New System.Drawing.Size(469, 103)
        Me.FrmStdSet764.TabIndex = 182
        Me.FrmStdSet764.Text = "LAST"
        '
        'TxtStdSetToFirst782
        '
        Me.TxtStdSetToFirst782 = New System.Windows.Forms.TextBox()
        Me.TxtStdSetToFirst782.Location = New System.Drawing.Point(318, 75)
        Me.TxtStdSetToFirst782.Name = "TxtStdSetToFirst782"
        Me.TxtStdSetToFirst782.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdSetToFirst782.TabIndex = 188
        Me.TxtStdSetToFirst782.Text = ""
        Me.TxtStdSetToFirst782.Text = ""
        Me.TxtStdSetToFirst782.Multiline = "False"
        'Datafield = "SET_TO_FIRST"
        'Datafield = "rdcStdSetInfo(3)"
        '
        'BtnDeleteStdCapsule795
        '
        Me.BtnDeleteStdCapsule795 = New System.Windows.Forms.Button()
        Me.BtnDeleteStdCapsule795.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteStdCapsule795.Name = "BtnDeleteStdCapsule795"
        Me.BtnDeleteStdCapsule795.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteStdCapsule795.TabIndex = 187
        Me.BtnDeleteStdCapsule795.Text = "Delete Capsule"
        Me.BtnDeleteStdCapsule795.UseVisualStyleBackColor = True
        '
        'BtnEditStdCapsule804
        '
        Me.BtnEditStdCapsule804 = New System.Windows.Forms.Button()
        Me.BtnEditStdCapsule804.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditStdCapsule804.Name = "BtnEditStdCapsule804"
        Me.BtnEditStdCapsule804.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditStdCapsule804.TabIndex = 186
        Me.BtnEditStdCapsule804.Text = "Edit Capsule..."
        Me.BtnEditStdCapsule804.UseVisualStyleBackColor = True
        '
        'BtnAddStdCapsule813
        '
        Me.BtnAddStdCapsule813 = New System.Windows.Forms.Button()
        Me.BtnAddStdCapsule813.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddStdCapsule813.Name = "BtnAddStdCapsule813"
        Me.BtnAddStdCapsule813.Size = New System.Drawing.Size(82, 22)
        Me.BtnAddStdCapsule813.TabIndex = 185
        Me.BtnAddStdCapsule813.Text = "Add Capsule.."
        Me.BtnAddStdCapsule813.UseVisualStyleBackColor = True
        '
        'TxtStdStdDev822
        '
        Me.TxtStdStdDev822 = New System.Windows.Forms.TextBox()
        Me.TxtStdStdDev822.Location = New System.Drawing.Point(168, 75)
        Me.TxtStdStdDev822.Name = "TxtStdStdDev822"
        Me.TxtStdStdDev822.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdStdDev822.TabIndex = 184
        Me.TxtStdStdDev822.Text = ""
        Me.TxtStdStdDev822.Text = ""
        Me.TxtStdStdDev822.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcStdSetInfo(3)"
        '
        'TxtStdAvgRdg835
        '
        Me.TxtStdAvgRdg835 = New System.Windows.Forms.TextBox()
        Me.TxtStdAvgRdg835.Location = New System.Drawing.Point(63, 75)
        Me.TxtStdAvgRdg835.Name = "TxtStdAvgRdg835"
        Me.TxtStdAvgRdg835.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdAvgRdg835.TabIndex = 183
        Me.TxtStdAvgRdg835.Text = ""
        Me.TxtStdAvgRdg835.Text = ""
        Me.TxtStdAvgRdg835.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcStdSetInfo(3)"
        '
        'GrdStdCapsules944
        '
        Me.GrdStdCapsules944 = New System.Windows.Forms.DataGridView()
        Me.GrdStdCapsules944.Location = New System.Drawing.Point(6, 12)
        Me.GrdStdCapsules944.Name = "GrdStdCapsules944"
        Me.GrdStdCapsules944.Size = New System.Drawing.Size(370, 61)
        Me.GrdStdCapsules944.TabIndex = 189
        Me.GrdStdCapsules944.Text = "GrdStdCapsules944"
        Me.GrdStdCapsules944.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'Label37954
        '
        Me.Label37954 = New System.Windows.Forms.Label()
        Me.Label37954.Location = New System.Drawing.Point(231, 84)
        Me.Label37954.Name = "Label37954"
        Me.Label37954.Size = New System.Drawing.Size(26, 13)
        Me.Label37954.TabIndex = 193
        Me.Label37954.Text = "%"
        Me.Label37954.Text = "%"
        '
        'LblStdSetToFirst972
        '
        Me.LblStdSetToFirst972 = New System.Windows.Forms.Label()
        Me.LblStdSetToFirst972.Location = New System.Drawing.Point(252, 84)
        Me.LblStdSetToFirst972.Name = "LblStdSetToFirst972"
        Me.LblStdSetToFirst972.Size = New System.Drawing.Size(71, 13)
        Me.LblStdSetToFirst972.TabIndex = 192
        Me.LblStdSetToFirst972.Text = "Set To 1st"
        Me.LblStdSetToFirst972.Text = "Set To 1st"
        '
        'LblStdStdDev990
        '
        Me.LblStdStdDev990 = New System.Windows.Forms.Label()
        Me.LblStdStdDev990.Location = New System.Drawing.Point(135, 84)
        Me.LblStdStdDev990.Name = "LblStdStdDev990"
        Me.LblStdStdDev990.Size = New System.Drawing.Size(44, 13)
        Me.LblStdStdDev990.TabIndex = 191
        Me.LblStdStdDev990.Text = "+ / -"
        Me.LblStdStdDev990.Text = "+ / -"
        '
        'LblStdAvgRdg1008
        '
        Me.LblStdAvgRdg1008 = New System.Windows.Forms.Label()
        Me.LblStdAvgRdg1008.Location = New System.Drawing.Point(6, 84)
        Me.LblStdAvgRdg1008.Name = "LblStdAvgRdg1008"
        Me.LblStdAvgRdg1008.Size = New System.Drawing.Size(62, 13)
        Me.LblStdAvgRdg1008.TabIndex = 190
        Me.LblStdAvgRdg1008.Text = "Avg Rdg"
        Me.LblStdAvgRdg1008.Text = "Avg Rdg"
        Me.SSTab1TabPage6.Controls.Add(Me.FrmStdSet764)
        Me.FrmStdSet764.Controls.Add(Me.TxtStdSetToFirst782)
        Me.FrmStdSet764.Controls.Add(Me.BtnDeleteStdCapsule795)
        Me.FrmStdSet764.Controls.Add(Me.BtnEditStdCapsule804)
        Me.FrmStdSet764.Controls.Add(Me.BtnAddStdCapsule813)
        Me.FrmStdSet764.Controls.Add(Me.TxtStdStdDev822)
        Me.FrmStdSet764.Controls.Add(Me.TxtStdAvgRdg835)
        Me.FrmStdSet764.Controls.Add(Me.GrdStdCapsules944)
        Me.FrmStdSet764.Controls.Add(Me.Label37954)
        Me.FrmStdSet764.Controls.Add(Me.LblStdSetToFirst972)
        Me.FrmStdSet764.Controls.Add(Me.LblStdStdDev990)
        Me.FrmStdSet764.Controls.Add(Me.LblStdAvgRdg1008)
        '
        'FrmStdSet1027
        '
        Me.FrmStdSet1027 = New System.Windows.Forms.GroupBox()
        Me.FrmStdSet1027.Location = New System.Drawing.Point(0, 80)
        Me.FrmStdSet1027.Name = "FrmStdSet1027"
        Me.FrmStdSet1027.Size = New System.Drawing.Size(469, 103)
        Me.FrmStdSet1027.TabIndex = 172
        Me.FrmStdSet1027.Text = "FIRST"
        '
        'BtnDeleteStdCapsule1045
        '
        Me.BtnDeleteStdCapsule1045 = New System.Windows.Forms.Button()
        Me.BtnDeleteStdCapsule1045.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteStdCapsule1045.Name = "BtnDeleteStdCapsule1045"
        Me.BtnDeleteStdCapsule1045.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteStdCapsule1045.TabIndex = 177
        Me.BtnDeleteStdCapsule1045.Text = "Delete Capsule"
        Me.BtnDeleteStdCapsule1045.UseVisualStyleBackColor = True
        '
        'TxtStdAvgRdg1054
        '
        Me.TxtStdAvgRdg1054 = New System.Windows.Forms.TextBox()
        Me.TxtStdAvgRdg1054.Location = New System.Drawing.Point(63, 75)
        Me.TxtStdAvgRdg1054.Name = "TxtStdAvgRdg1054"
        Me.TxtStdAvgRdg1054.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdAvgRdg1054.TabIndex = 176
        Me.TxtStdAvgRdg1054.Text = ""
        Me.TxtStdAvgRdg1054.Text = ""
        Me.TxtStdAvgRdg1054.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcStdSetInfo(2)"
        '
        'TxtStdStdDev1067
        '
        Me.TxtStdStdDev1067 = New System.Windows.Forms.TextBox()
        Me.TxtStdStdDev1067.Location = New System.Drawing.Point(168, 75)
        Me.TxtStdStdDev1067.Name = "TxtStdStdDev1067"
        Me.TxtStdStdDev1067.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdStdDev1067.TabIndex = 175
        Me.TxtStdStdDev1067.Text = ""
        Me.TxtStdStdDev1067.Text = ""
        Me.TxtStdStdDev1067.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcStdSetInfo(2)"
        '
        'BtnAddStdCapsule1080
        '
        Me.BtnAddStdCapsule1080 = New System.Windows.Forms.Button()
        Me.BtnAddStdCapsule1080.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddStdCapsule1080.Name = "BtnAddStdCapsule1080"
        Me.BtnAddStdCapsule1080.Size = New System.Drawing.Size(85, 22)
        Me.BtnAddStdCapsule1080.TabIndex = 174
        Me.BtnAddStdCapsule1080.Text = "Add Capsule.."
        Me.BtnAddStdCapsule1080.UseVisualStyleBackColor = True
        '
        'BtnEditStdCapsule1089
        '
        Me.BtnEditStdCapsule1089 = New System.Windows.Forms.Button()
        Me.BtnEditStdCapsule1089.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditStdCapsule1089.Name = "BtnEditStdCapsule1089"
        Me.BtnEditStdCapsule1089.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditStdCapsule1089.TabIndex = 173
        Me.BtnEditStdCapsule1089.Text = "Edit Capsule..."
        Me.BtnEditStdCapsule1089.UseVisualStyleBackColor = True
        '
        'GrdStdCapsules1194
        '
        Me.GrdStdCapsules1194 = New System.Windows.Forms.DataGridView()
        Me.GrdStdCapsules1194.Location = New System.Drawing.Point(6, 12)
        Me.GrdStdCapsules1194.Name = "GrdStdCapsules1194"
        Me.GrdStdCapsules1194.Size = New System.Drawing.Size(370, 61)
        Me.GrdStdCapsules1194.TabIndex = 178
        Me.GrdStdCapsules1194.Text = "GrdStdCapsules1194"
        Me.GrdStdCapsules1194.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'Label371204
        '
        Me.Label371204 = New System.Windows.Forms.Label()
        Me.Label371204.Location = New System.Drawing.Point(231, 84)
        Me.Label371204.Name = "Label371204"
        Me.Label371204.Size = New System.Drawing.Size(47, 13)
        Me.Label371204.TabIndex = 181
        Me.Label371204.Text = "%"
        Me.Label371204.Text = "%"
        '
        'LblStdAvgRdg1222
        '
        Me.LblStdAvgRdg1222 = New System.Windows.Forms.Label()
        Me.LblStdAvgRdg1222.Location = New System.Drawing.Point(6, 84)
        Me.LblStdAvgRdg1222.Name = "LblStdAvgRdg1222"
        Me.LblStdAvgRdg1222.Size = New System.Drawing.Size(62, 13)
        Me.LblStdAvgRdg1222.TabIndex = 180
        Me.LblStdAvgRdg1222.Text = "Avg Rdg"
        Me.LblStdAvgRdg1222.Text = "Avg Rdg"
        '
        'LblStdStdDev1240
        '
        Me.LblStdStdDev1240 = New System.Windows.Forms.Label()
        Me.LblStdStdDev1240.Location = New System.Drawing.Point(135, 84)
        Me.LblStdStdDev1240.Name = "LblStdStdDev1240"
        Me.LblStdStdDev1240.Size = New System.Drawing.Size(41, 13)
        Me.LblStdStdDev1240.TabIndex = 179
        Me.LblStdStdDev1240.Text = "+ / -"
        Me.LblStdStdDev1240.Text = "+ / -"
        Me.SSTab1TabPage6.Controls.Add(Me.FrmStdSet1027)
        Me.FrmStdSet1027.Controls.Add(Me.BtnDeleteStdCapsule1045)
        Me.FrmStdSet1027.Controls.Add(Me.TxtStdAvgRdg1054)
        Me.FrmStdSet1027.Controls.Add(Me.TxtStdStdDev1067)
        Me.FrmStdSet1027.Controls.Add(Me.BtnAddStdCapsule1080)
        Me.FrmStdSet1027.Controls.Add(Me.BtnEditStdCapsule1089)
        Me.FrmStdSet1027.Controls.Add(Me.GrdStdCapsules1194)
        Me.FrmStdSet1027.Controls.Add(Me.Label371204)
        Me.FrmStdSet1027.Controls.Add(Me.LblStdAvgRdg1222)
        Me.FrmStdSet1027.Controls.Add(Me.LblStdStdDev1240)
        '
        'lstPhysicists
        '
        Me.lstPhysicists = New System.Windows.Forms.ListBox()
        Me.lstPhysicists.Location = New System.Drawing.Point(0, 240)
        Me.lstPhysicists.Name = "lstPhysicists"
        Me.lstPhysicists.Size = New System.Drawing.Size(91, 43)
        Me.lstPhysicists.TabIndex = 171
        Me.lstPhysicists.Text = ""
        Me.lstPhysicists.FormattingEnabled = True
        '
        'FrmCtlSet1319
        '
        Me.FrmCtlSet1319 = New System.Windows.Forms.GroupBox()
        Me.FrmCtlSet1319.Location = New System.Drawing.Point(0, 67)
        Me.FrmCtlSet1319.Name = "FrmCtlSet1319"
        Me.FrmCtlSet1319.Size = New System.Drawing.Size(469, 103)
        Me.FrmCtlSet1319.TabIndex = 105
        Me.FrmCtlSet1319.Text = "FIRST"
        '
        'TxtCtlAvgRdg1337
        '
        Me.TxtCtlAvgRdg1337 = New System.Windows.Forms.TextBox()
        Me.TxtCtlAvgRdg1337.Location = New System.Drawing.Point(63, 75)
        Me.TxtCtlAvgRdg1337.Name = "TxtCtlAvgRdg1337"
        Me.TxtCtlAvgRdg1337.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlAvgRdg1337.TabIndex = 110
        Me.TxtCtlAvgRdg1337.Text = ""
        Me.TxtCtlAvgRdg1337.Text = ""
        Me.TxtCtlAvgRdg1337.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcCtlSetInfo(0)"
        '
        'TxtCtlStdDev1350
        '
        Me.TxtCtlStdDev1350 = New System.Windows.Forms.TextBox()
        Me.TxtCtlStdDev1350.Location = New System.Drawing.Point(162, 75)
        Me.TxtCtlStdDev1350.Name = "TxtCtlStdDev1350"
        Me.TxtCtlStdDev1350.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlStdDev1350.TabIndex = 109
        Me.TxtCtlStdDev1350.Text = ""
        Me.TxtCtlStdDev1350.Text = ""
        Me.TxtCtlStdDev1350.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcCtlSetInfo(0)"
        '
        'BtnAddCtlCapsule1363
        '
        Me.BtnAddCtlCapsule1363 = New System.Windows.Forms.Button()
        Me.BtnAddCtlCapsule1363.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddCtlCapsule1363.Name = "BtnAddCtlCapsule1363"
        Me.BtnAddCtlCapsule1363.Size = New System.Drawing.Size(82, 22)
        Me.BtnAddCtlCapsule1363.TabIndex = 108
        Me.BtnAddCtlCapsule1363.Text = "Add Capsule.."
        Me.BtnAddCtlCapsule1363.UseVisualStyleBackColor = True
        '
        'BtnEditCtlCapsule1372
        '
        Me.BtnEditCtlCapsule1372 = New System.Windows.Forms.Button()
        Me.BtnEditCtlCapsule1372.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditCtlCapsule1372.Name = "BtnEditCtlCapsule1372"
        Me.BtnEditCtlCapsule1372.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditCtlCapsule1372.TabIndex = 107
        Me.BtnEditCtlCapsule1372.Text = "Edit Capsule..."
        Me.BtnEditCtlCapsule1372.UseVisualStyleBackColor = True
        '
        'BtnDeleteCtlCapsule1381
        '
        Me.BtnDeleteCtlCapsule1381 = New System.Windows.Forms.Button()
        Me.BtnDeleteCtlCapsule1381.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteCtlCapsule1381.Name = "BtnDeleteCtlCapsule1381"
        Me.BtnDeleteCtlCapsule1381.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteCtlCapsule1381.TabIndex = 106
        Me.BtnDeleteCtlCapsule1381.Text = "Delete Capsule"
        Me.BtnDeleteCtlCapsule1381.UseVisualStyleBackColor = True
        '
        'GrdCtlCapsules1486
        '
        Me.GrdCtlCapsules1486 = New System.Windows.Forms.DataGridView()
        Me.GrdCtlCapsules1486.Location = New System.Drawing.Point(6, 12)
        Me.GrdCtlCapsules1486.Name = "GrdCtlCapsules1486"
        Me.GrdCtlCapsules1486.Size = New System.Drawing.Size(370, 61)
        Me.GrdCtlCapsules1486.TabIndex = 111
        Me.GrdCtlCapsules1486.Text = "GrdCtlCapsules1486"
        Me.GrdCtlCapsules1486.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblCtlAvgRdg1496
        '
        Me.LblCtlAvgRdg1496 = New System.Windows.Forms.Label()
        Me.LblCtlAvgRdg1496.Location = New System.Drawing.Point(6, 84)
        Me.LblCtlAvgRdg1496.Name = "LblCtlAvgRdg1496"
        Me.LblCtlAvgRdg1496.Size = New System.Drawing.Size(62, 13)
        Me.LblCtlAvgRdg1496.TabIndex = 114
        Me.LblCtlAvgRdg1496.Text = "Avg Rdg"
        Me.LblCtlAvgRdg1496.Text = "Avg Rdg"
        '
        'LblCtlStdDev1514
        '
        Me.LblCtlStdDev1514 = New System.Windows.Forms.Label()
        Me.LblCtlStdDev1514.Location = New System.Drawing.Point(129, 84)
        Me.LblCtlStdDev1514.Name = "LblCtlStdDev1514"
        Me.LblCtlStdDev1514.Size = New System.Drawing.Size(41, 13)
        Me.LblCtlStdDev1514.TabIndex = 113
        Me.LblCtlStdDev1514.Text = "+ / -"
        Me.LblCtlStdDev1514.Text = "+ / -"
        '
        'Label381532
        '
        Me.Label381532 = New System.Windows.Forms.Label()
        Me.Label381532.Location = New System.Drawing.Point(225, 84)
        Me.Label381532.Name = "Label381532"
        Me.Label381532.Size = New System.Drawing.Size(26, 16)
        Me.Label381532.TabIndex = 112
        Me.Label381532.Text = "%"
        Me.Label381532.Text = "%"
        Me.SSTab1TabPage0.Controls.Add(Me.lstPhysicists)
        Me.SSTab1TabPage2.Controls.Add(Me.FrmCtlSet1319)
        Me.FrmCtlSet1319.Controls.Add(Me.TxtCtlAvgRdg1337)
        Me.FrmCtlSet1319.Controls.Add(Me.TxtCtlStdDev1350)
        Me.FrmCtlSet1319.Controls.Add(Me.BtnAddCtlCapsule1363)
        Me.FrmCtlSet1319.Controls.Add(Me.BtnEditCtlCapsule1372)
        Me.FrmCtlSet1319.Controls.Add(Me.BtnDeleteCtlCapsule1381)
        Me.FrmCtlSet1319.Controls.Add(Me.GrdCtlCapsules1486)
        Me.FrmCtlSet1319.Controls.Add(Me.LblCtlAvgRdg1496)
        Me.FrmCtlSet1319.Controls.Add(Me.LblCtlStdDev1514)
        Me.FrmCtlSet1319.Controls.Add(Me.Label381532)
        '
        'FrmStdSet1551
        '
        Me.FrmStdSet1551 = New System.Windows.Forms.GroupBox()
        Me.FrmStdSet1551.Location = New System.Drawing.Point(0, 67)
        Me.FrmStdSet1551.Name = "FrmStdSet1551"
        Me.FrmStdSet1551.Size = New System.Drawing.Size(469, 103)
        Me.FrmStdSet1551.TabIndex = 95
        Me.FrmStdSet1551.Text = "FIRST"
        '
        'BtnEditStdCapsule1569
        '
        Me.BtnEditStdCapsule1569 = New System.Windows.Forms.Button()
        Me.BtnEditStdCapsule1569.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditStdCapsule1569.Name = "BtnEditStdCapsule1569"
        Me.BtnEditStdCapsule1569.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditStdCapsule1569.TabIndex = 100
        Me.BtnEditStdCapsule1569.Text = "Edit Capsule..."
        Me.BtnEditStdCapsule1569.UseVisualStyleBackColor = True
        '
        'BtnAddStdCapsule1578
        '
        Me.BtnAddStdCapsule1578 = New System.Windows.Forms.Button()
        Me.BtnAddStdCapsule1578.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddStdCapsule1578.Name = "BtnAddStdCapsule1578"
        Me.BtnAddStdCapsule1578.Size = New System.Drawing.Size(85, 22)
        Me.BtnAddStdCapsule1578.TabIndex = 99
        Me.BtnAddStdCapsule1578.Text = "Add Capsule.."
        Me.BtnAddStdCapsule1578.UseVisualStyleBackColor = True
        '
        'TxtStdStdDev1587
        '
        Me.TxtStdStdDev1587 = New System.Windows.Forms.TextBox()
        Me.TxtStdStdDev1587.Location = New System.Drawing.Point(168, 75)
        Me.TxtStdStdDev1587.Name = "TxtStdStdDev1587"
        Me.TxtStdStdDev1587.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdStdDev1587.TabIndex = 98
        Me.TxtStdStdDev1587.Text = ""
        Me.TxtStdStdDev1587.Text = ""
        Me.TxtStdStdDev1587.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcStdSetInfo(0)"
        '
        'TxtStdAvgRdg1600
        '
        Me.TxtStdAvgRdg1600 = New System.Windows.Forms.TextBox()
        Me.TxtStdAvgRdg1600.Location = New System.Drawing.Point(63, 75)
        Me.TxtStdAvgRdg1600.Name = "TxtStdAvgRdg1600"
        Me.TxtStdAvgRdg1600.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdAvgRdg1600.TabIndex = 97
        Me.TxtStdAvgRdg1600.Text = ""
        Me.TxtStdAvgRdg1600.Text = ""
        Me.TxtStdAvgRdg1600.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcStdSetInfo(0)"
        '
        'BtnDeleteStdCapsule1613
        '
        Me.BtnDeleteStdCapsule1613 = New System.Windows.Forms.Button()
        Me.BtnDeleteStdCapsule1613.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteStdCapsule1613.Name = "BtnDeleteStdCapsule1613"
        Me.BtnDeleteStdCapsule1613.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteStdCapsule1613.TabIndex = 96
        Me.BtnDeleteStdCapsule1613.Text = "Delete Capsule"
        Me.BtnDeleteStdCapsule1613.UseVisualStyleBackColor = True
        '
        'GrdStdCapsules1718
        '
        Me.GrdStdCapsules1718 = New System.Windows.Forms.DataGridView()
        Me.GrdStdCapsules1718.Location = New System.Drawing.Point(6, 12)
        Me.GrdStdCapsules1718.Name = "GrdStdCapsules1718"
        Me.GrdStdCapsules1718.Size = New System.Drawing.Size(370, 61)
        Me.GrdStdCapsules1718.TabIndex = 101
        Me.GrdStdCapsules1718.Text = "GrdStdCapsules1718"
        Me.GrdStdCapsules1718.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblStdStdDev1728
        '
        Me.LblStdStdDev1728 = New System.Windows.Forms.Label()
        Me.LblStdStdDev1728.Location = New System.Drawing.Point(135, 84)
        Me.LblStdStdDev1728.Name = "LblStdStdDev1728"
        Me.LblStdStdDev1728.Size = New System.Drawing.Size(41, 13)
        Me.LblStdStdDev1728.TabIndex = 104
        Me.LblStdStdDev1728.Text = "+ / -"
        Me.LblStdStdDev1728.Text = "+ / -"
        '
        'LblStdAvgRdg1746
        '
        Me.LblStdAvgRdg1746 = New System.Windows.Forms.Label()
        Me.LblStdAvgRdg1746.Location = New System.Drawing.Point(6, 84)
        Me.LblStdAvgRdg1746.Name = "LblStdAvgRdg1746"
        Me.LblStdAvgRdg1746.Size = New System.Drawing.Size(62, 13)
        Me.LblStdAvgRdg1746.TabIndex = 103
        Me.LblStdAvgRdg1746.Text = "Avg Rdg"
        Me.LblStdAvgRdg1746.Text = "Avg Rdg"
        '
        'Label371764
        '
        Me.Label371764 = New System.Windows.Forms.Label()
        Me.Label371764.Location = New System.Drawing.Point(231, 84)
        Me.Label371764.Name = "Label371764"
        Me.Label371764.Size = New System.Drawing.Size(47, 13)
        Me.Label371764.TabIndex = 102
        Me.Label371764.Text = "%"
        Me.Label371764.Text = "%"
        Me.SSTab1TabPage1.Controls.Add(Me.FrmStdSet1551)
        Me.FrmStdSet1551.Controls.Add(Me.BtnEditStdCapsule1569)
        Me.FrmStdSet1551.Controls.Add(Me.BtnAddStdCapsule1578)
        Me.FrmStdSet1551.Controls.Add(Me.TxtStdStdDev1587)
        Me.FrmStdSet1551.Controls.Add(Me.TxtStdAvgRdg1600)
        Me.FrmStdSet1551.Controls.Add(Me.BtnDeleteStdCapsule1613)
        Me.FrmStdSet1551.Controls.Add(Me.GrdStdCapsules1718)
        Me.FrmStdSet1551.Controls.Add(Me.LblStdStdDev1728)
        Me.FrmStdSet1551.Controls.Add(Me.LblStdAvgRdg1746)
        Me.FrmStdSet1551.Controls.Add(Me.Label371764)
        '
        'FrmCtlSet1783
        '
        Me.FrmCtlSet1783 = New System.Windows.Forms.GroupBox()
        Me.FrmCtlSet1783.Location = New System.Drawing.Point(0, 175)
        Me.FrmCtlSet1783.Name = "FrmCtlSet1783"
        Me.FrmCtlSet1783.Size = New System.Drawing.Size(469, 88)
        Me.FrmCtlSet1783.TabIndex = 83
        Me.FrmCtlSet1783.Text = "SECOND"
        '
        'BtnEditCtlCapsule1801
        '
        Me.BtnEditCtlCapsule1801 = New System.Windows.Forms.Button()
        Me.BtnEditCtlCapsule1801.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditCtlCapsule1801.Name = "BtnEditCtlCapsule1801"
        Me.BtnEditCtlCapsule1801.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditCtlCapsule1801.TabIndex = 89
        Me.BtnEditCtlCapsule1801.Text = "Edit Capsule..."
        Me.BtnEditCtlCapsule1801.UseVisualStyleBackColor = True
        '
        'BtnAddCtlCapsule1810
        '
        Me.BtnAddCtlCapsule1810 = New System.Windows.Forms.Button()
        Me.BtnAddCtlCapsule1810.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddCtlCapsule1810.Name = "BtnAddCtlCapsule1810"
        Me.BtnAddCtlCapsule1810.Size = New System.Drawing.Size(82, 22)
        Me.BtnAddCtlCapsule1810.TabIndex = 88
        Me.BtnAddCtlCapsule1810.Text = "Add Capsule.."
        Me.BtnAddCtlCapsule1810.UseVisualStyleBackColor = True
        '
        'TxtCtlSetToFirst1819
        '
        Me.TxtCtlSetToFirst1819 = New System.Windows.Forms.TextBox()
        Me.TxtCtlSetToFirst1819.Location = New System.Drawing.Point(315, 60)
        Me.TxtCtlSetToFirst1819.Name = "TxtCtlSetToFirst1819"
        Me.TxtCtlSetToFirst1819.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlSetToFirst1819.TabIndex = 87
        Me.TxtCtlSetToFirst1819.Text = ""
        Me.TxtCtlSetToFirst1819.Text = ""
        Me.TxtCtlSetToFirst1819.Multiline = "False"
        'Datafield = "SET_TO_FIRST"
        'Datafield = "rdcCtlSetInfo(1)"
        '
        'TxtCtlStdDev1832
        '
        Me.TxtCtlStdDev1832 = New System.Windows.Forms.TextBox()
        Me.TxtCtlStdDev1832.Location = New System.Drawing.Point(162, 60)
        Me.TxtCtlStdDev1832.Name = "TxtCtlStdDev1832"
        Me.TxtCtlStdDev1832.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlStdDev1832.TabIndex = 86
        Me.TxtCtlStdDev1832.Text = ""
        Me.TxtCtlStdDev1832.Text = ""
        Me.TxtCtlStdDev1832.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcCtlSetInfo(1)"
        '
        'TxtCtlAvgRdg1845
        '
        Me.TxtCtlAvgRdg1845 = New System.Windows.Forms.TextBox()
        Me.TxtCtlAvgRdg1845.Location = New System.Drawing.Point(63, 60)
        Me.TxtCtlAvgRdg1845.Name = "TxtCtlAvgRdg1845"
        Me.TxtCtlAvgRdg1845.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlAvgRdg1845.TabIndex = 85
        Me.TxtCtlAvgRdg1845.Text = ""
        Me.TxtCtlAvgRdg1845.Text = ""
        Me.TxtCtlAvgRdg1845.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcCtlSetInfo(1)"
        '
        'BtnDeleteCtlCapsule1858
        '
        Me.BtnDeleteCtlCapsule1858 = New System.Windows.Forms.Button()
        Me.BtnDeleteCtlCapsule1858.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteCtlCapsule1858.Name = "BtnDeleteCtlCapsule1858"
        Me.BtnDeleteCtlCapsule1858.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteCtlCapsule1858.TabIndex = 84
        Me.BtnDeleteCtlCapsule1858.Text = "Delete Capsule"
        Me.BtnDeleteCtlCapsule1858.UseVisualStyleBackColor = True
        '
        'GrdCtlCapsules1963
        '
        Me.GrdCtlCapsules1963 = New System.Windows.Forms.DataGridView()
        Me.GrdCtlCapsules1963.Location = New System.Drawing.Point(6, 12)
        Me.GrdCtlCapsules1963.Name = "GrdCtlCapsules1963"
        Me.GrdCtlCapsules1963.Size = New System.Drawing.Size(370, 46)
        Me.GrdCtlCapsules1963.TabIndex = 90
        Me.GrdCtlCapsules1963.Text = "GrdCtlCapsules1963"
        Me.GrdCtlCapsules1963.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblCtlSetToFirst1973
        '
        Me.LblCtlSetToFirst1973 = New System.Windows.Forms.Label()
        Me.LblCtlSetToFirst1973.Location = New System.Drawing.Point(249, 69)
        Me.LblCtlSetToFirst1973.Name = "LblCtlSetToFirst1973"
        Me.LblCtlSetToFirst1973.Size = New System.Drawing.Size(71, 13)
        Me.LblCtlSetToFirst1973.TabIndex = 94
        Me.LblCtlSetToFirst1973.Text = "Set To 1st"
        Me.LblCtlSetToFirst1973.Text = "Set To 1st"
        '
        'LblCtlStdDev1991
        '
        Me.LblCtlStdDev1991 = New System.Windows.Forms.Label()
        Me.LblCtlStdDev1991.Location = New System.Drawing.Point(129, 69)
        Me.LblCtlStdDev1991.Name = "LblCtlStdDev1991"
        Me.LblCtlStdDev1991.Size = New System.Drawing.Size(44, 13)
        Me.LblCtlStdDev1991.TabIndex = 93
        Me.LblCtlStdDev1991.Text = "+ / -"
        Me.LblCtlStdDev1991.Text = "+ / -"
        '
        'LblCtlAvgRdg2009
        '
        Me.LblCtlAvgRdg2009 = New System.Windows.Forms.Label()
        Me.LblCtlAvgRdg2009.Location = New System.Drawing.Point(6, 69)
        Me.LblCtlAvgRdg2009.Name = "LblCtlAvgRdg2009"
        Me.LblCtlAvgRdg2009.Size = New System.Drawing.Size(62, 13)
        Me.LblCtlAvgRdg2009.TabIndex = 92
        Me.LblCtlAvgRdg2009.Text = "Avg Rdg"
        Me.LblCtlAvgRdg2009.Text = "Avg Rdg"
        '
        'Label382027
        '
        Me.Label382027 = New System.Windows.Forms.Label()
        Me.Label382027.Location = New System.Drawing.Point(225, 69)
        Me.Label382027.Name = "Label382027"
        Me.Label382027.Size = New System.Drawing.Size(26, 16)
        Me.Label382027.TabIndex = 91
        Me.Label382027.Text = "%"
        Me.Label382027.Text = "%"
        Me.SSTab1TabPage2.Controls.Add(Me.FrmCtlSet1783)
        Me.FrmCtlSet1783.Controls.Add(Me.BtnEditCtlCapsule1801)
        Me.FrmCtlSet1783.Controls.Add(Me.BtnAddCtlCapsule1810)
        Me.FrmCtlSet1783.Controls.Add(Me.TxtCtlSetToFirst1819)
        Me.FrmCtlSet1783.Controls.Add(Me.TxtCtlStdDev1832)
        Me.FrmCtlSet1783.Controls.Add(Me.TxtCtlAvgRdg1845)
        Me.FrmCtlSet1783.Controls.Add(Me.BtnDeleteCtlCapsule1858)
        Me.FrmCtlSet1783.Controls.Add(Me.GrdCtlCapsules1963)
        Me.FrmCtlSet1783.Controls.Add(Me.LblCtlSetToFirst1973)
        Me.FrmCtlSet1783.Controls.Add(Me.LblCtlStdDev1991)
        Me.FrmCtlSet1783.Controls.Add(Me.LblCtlAvgRdg2009)
        Me.FrmCtlSet1783.Controls.Add(Me.Label382027)
        '
        'FrmCtlSet2046
        '
        Me.FrmCtlSet2046 = New System.Windows.Forms.GroupBox()
        Me.FrmCtlSet2046.Location = New System.Drawing.Point(0, 268)
        Me.FrmCtlSet2046.Name = "FrmCtlSet2046"
        Me.FrmCtlSet2046.Size = New System.Drawing.Size(469, 88)
        Me.FrmCtlSet2046.TabIndex = 71
        Me.FrmCtlSet2046.Text = "THIRD"
        '
        'BtnEditCtlCapsule2064
        '
        Me.BtnEditCtlCapsule2064 = New System.Windows.Forms.Button()
        Me.BtnEditCtlCapsule2064.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditCtlCapsule2064.Name = "BtnEditCtlCapsule2064"
        Me.BtnEditCtlCapsule2064.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditCtlCapsule2064.TabIndex = 77
        Me.BtnEditCtlCapsule2064.Text = "Edit Capsule..."
        Me.BtnEditCtlCapsule2064.UseVisualStyleBackColor = True
        '
        'BtnAddCtlCapsule2073
        '
        Me.BtnAddCtlCapsule2073 = New System.Windows.Forms.Button()
        Me.BtnAddCtlCapsule2073.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddCtlCapsule2073.Name = "BtnAddCtlCapsule2073"
        Me.BtnAddCtlCapsule2073.Size = New System.Drawing.Size(82, 22)
        Me.BtnAddCtlCapsule2073.TabIndex = 76
        Me.BtnAddCtlCapsule2073.Text = "Add Capsule.."
        Me.BtnAddCtlCapsule2073.UseVisualStyleBackColor = True
        '
        'TxtCtlSetToFirst2082
        '
        Me.TxtCtlSetToFirst2082 = New System.Windows.Forms.TextBox()
        Me.TxtCtlSetToFirst2082.Location = New System.Drawing.Point(315, 60)
        Me.TxtCtlSetToFirst2082.Name = "TxtCtlSetToFirst2082"
        Me.TxtCtlSetToFirst2082.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlSetToFirst2082.TabIndex = 75
        Me.TxtCtlSetToFirst2082.Text = ""
        Me.TxtCtlSetToFirst2082.Text = ""
        Me.TxtCtlSetToFirst2082.Multiline = "False"
        'Datafield = "SET_TO_FIRST"
        'Datafield = "rdcCtlSetInfo(2)"
        '
        'TxtCtlStdDev2095
        '
        Me.TxtCtlStdDev2095 = New System.Windows.Forms.TextBox()
        Me.TxtCtlStdDev2095.Location = New System.Drawing.Point(162, 60)
        Me.TxtCtlStdDev2095.Name = "TxtCtlStdDev2095"
        Me.TxtCtlStdDev2095.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlStdDev2095.TabIndex = 74
        Me.TxtCtlStdDev2095.Text = ""
        Me.TxtCtlStdDev2095.Text = ""
        Me.TxtCtlStdDev2095.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcCtlSetInfo(2)"
        '
        'TxtCtlAvgRdg2108
        '
        Me.TxtCtlAvgRdg2108 = New System.Windows.Forms.TextBox()
        Me.TxtCtlAvgRdg2108.Location = New System.Drawing.Point(63, 60)
        Me.TxtCtlAvgRdg2108.Name = "TxtCtlAvgRdg2108"
        Me.TxtCtlAvgRdg2108.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlAvgRdg2108.TabIndex = 73
        Me.TxtCtlAvgRdg2108.Text = ""
        Me.TxtCtlAvgRdg2108.Text = ""
        Me.TxtCtlAvgRdg2108.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcCtlSetInfo(2)"
        '
        'BtnDeleteCtlCapsule2121
        '
        Me.BtnDeleteCtlCapsule2121 = New System.Windows.Forms.Button()
        Me.BtnDeleteCtlCapsule2121.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteCtlCapsule2121.Name = "BtnDeleteCtlCapsule2121"
        Me.BtnDeleteCtlCapsule2121.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteCtlCapsule2121.TabIndex = 72
        Me.BtnDeleteCtlCapsule2121.Text = "Delete Capsule"
        Me.BtnDeleteCtlCapsule2121.UseVisualStyleBackColor = True
        '
        'GrdCtlCapsules2226
        '
        Me.GrdCtlCapsules2226 = New System.Windows.Forms.DataGridView()
        Me.GrdCtlCapsules2226.Location = New System.Drawing.Point(6, 12)
        Me.GrdCtlCapsules2226.Name = "GrdCtlCapsules2226"
        Me.GrdCtlCapsules2226.Size = New System.Drawing.Size(370, 46)
        Me.GrdCtlCapsules2226.TabIndex = 78
        Me.GrdCtlCapsules2226.Text = "GrdCtlCapsules2226"
        Me.GrdCtlCapsules2226.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblCtlSetToFirst2236
        '
        Me.LblCtlSetToFirst2236 = New System.Windows.Forms.Label()
        Me.LblCtlSetToFirst2236.Location = New System.Drawing.Point(249, 69)
        Me.LblCtlSetToFirst2236.Name = "LblCtlSetToFirst2236"
        Me.LblCtlSetToFirst2236.Size = New System.Drawing.Size(71, 13)
        Me.LblCtlSetToFirst2236.TabIndex = 82
        Me.LblCtlSetToFirst2236.Text = "Set To 1st"
        Me.LblCtlSetToFirst2236.Text = "Set To 1st"
        '
        'LblCtlStdDev2254
        '
        Me.LblCtlStdDev2254 = New System.Windows.Forms.Label()
        Me.LblCtlStdDev2254.Location = New System.Drawing.Point(129, 66)
        Me.LblCtlStdDev2254.Name = "LblCtlStdDev2254"
        Me.LblCtlStdDev2254.Size = New System.Drawing.Size(41, 13)
        Me.LblCtlStdDev2254.TabIndex = 81
        Me.LblCtlStdDev2254.Text = "+ / -"
        Me.LblCtlStdDev2254.Text = "+ / -"
        '
        'LblCtlAvgRdg2272
        '
        Me.LblCtlAvgRdg2272 = New System.Windows.Forms.Label()
        Me.LblCtlAvgRdg2272.Location = New System.Drawing.Point(6, 69)
        Me.LblCtlAvgRdg2272.Name = "LblCtlAvgRdg2272"
        Me.LblCtlAvgRdg2272.Size = New System.Drawing.Size(62, 13)
        Me.LblCtlAvgRdg2272.TabIndex = 80
        Me.LblCtlAvgRdg2272.Text = "Avg Rdg"
        Me.LblCtlAvgRdg2272.Text = "Avg Rdg"
        '
        'Label382290
        '
        Me.Label382290 = New System.Windows.Forms.Label()
        Me.Label382290.Location = New System.Drawing.Point(225, 69)
        Me.Label382290.Name = "Label382290"
        Me.Label382290.Size = New System.Drawing.Size(26, 16)
        Me.Label382290.TabIndex = 79
        Me.Label382290.Text = "%"
        Me.Label382290.Text = "%"
        Me.SSTab1TabPage2.Controls.Add(Me.FrmCtlSet2046)
        Me.FrmCtlSet2046.Controls.Add(Me.BtnEditCtlCapsule2064)
        Me.FrmCtlSet2046.Controls.Add(Me.BtnAddCtlCapsule2073)
        Me.FrmCtlSet2046.Controls.Add(Me.TxtCtlSetToFirst2082)
        Me.FrmCtlSet2046.Controls.Add(Me.TxtCtlStdDev2095)
        Me.FrmCtlSet2046.Controls.Add(Me.TxtCtlAvgRdg2108)
        Me.FrmCtlSet2046.Controls.Add(Me.BtnDeleteCtlCapsule2121)
        Me.FrmCtlSet2046.Controls.Add(Me.GrdCtlCapsules2226)
        Me.FrmCtlSet2046.Controls.Add(Me.LblCtlSetToFirst2236)
        Me.FrmCtlSet2046.Controls.Add(Me.LblCtlStdDev2254)
        Me.FrmCtlSet2046.Controls.Add(Me.LblCtlAvgRdg2272)
        Me.FrmCtlSet2046.Controls.Add(Me.Label382290)
        '
        'FrmCtlSet2309
        '
        Me.FrmCtlSet2309 = New System.Windows.Forms.GroupBox()
        Me.FrmCtlSet2309.Location = New System.Drawing.Point(0, 361)
        Me.FrmCtlSet2309.Name = "FrmCtlSet2309"
        Me.FrmCtlSet2309.Size = New System.Drawing.Size(469, 103)
        Me.FrmCtlSet2309.TabIndex = 59
        Me.FrmCtlSet2309.Text = "FOURTH"
        '
        'BtnEditCtlCapsule2327
        '
        Me.BtnEditCtlCapsule2327 = New System.Windows.Forms.Button()
        Me.BtnEditCtlCapsule2327.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditCtlCapsule2327.Name = "BtnEditCtlCapsule2327"
        Me.BtnEditCtlCapsule2327.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditCtlCapsule2327.TabIndex = 65
        Me.BtnEditCtlCapsule2327.Text = "Edit Capsule..."
        Me.BtnEditCtlCapsule2327.UseVisualStyleBackColor = True
        '
        'BtnAddCtlCapsule2336
        '
        Me.BtnAddCtlCapsule2336 = New System.Windows.Forms.Button()
        Me.BtnAddCtlCapsule2336.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddCtlCapsule2336.Name = "BtnAddCtlCapsule2336"
        Me.BtnAddCtlCapsule2336.Size = New System.Drawing.Size(82, 22)
        Me.BtnAddCtlCapsule2336.TabIndex = 64
        Me.BtnAddCtlCapsule2336.Text = "Add Capsule.."
        Me.BtnAddCtlCapsule2336.UseVisualStyleBackColor = True
        '
        'TxtCtlSetToFirst2345
        '
        Me.TxtCtlSetToFirst2345 = New System.Windows.Forms.TextBox()
        Me.TxtCtlSetToFirst2345.Location = New System.Drawing.Point(315, 75)
        Me.TxtCtlSetToFirst2345.Name = "TxtCtlSetToFirst2345"
        Me.TxtCtlSetToFirst2345.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlSetToFirst2345.TabIndex = 63
        Me.TxtCtlSetToFirst2345.Text = ""
        Me.TxtCtlSetToFirst2345.Text = ""
        Me.TxtCtlSetToFirst2345.Multiline = "False"
        'Datafield = "SET_TO_FIRST"
        'Datafield = "rdcCtlSetInfo(3)"
        '
        'TxtCtlStdDev2358
        '
        Me.TxtCtlStdDev2358 = New System.Windows.Forms.TextBox()
        Me.TxtCtlStdDev2358.Location = New System.Drawing.Point(162, 75)
        Me.TxtCtlStdDev2358.Name = "TxtCtlStdDev2358"
        Me.TxtCtlStdDev2358.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlStdDev2358.TabIndex = 62
        Me.TxtCtlStdDev2358.Text = ""
        Me.TxtCtlStdDev2358.Text = ""
        Me.TxtCtlStdDev2358.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcCtlSetInfo(3)"
        '
        'TxtCtlAvgRdg2371
        '
        Me.TxtCtlAvgRdg2371 = New System.Windows.Forms.TextBox()
        Me.TxtCtlAvgRdg2371.Location = New System.Drawing.Point(63, 75)
        Me.TxtCtlAvgRdg2371.Name = "TxtCtlAvgRdg2371"
        Me.TxtCtlAvgRdg2371.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlAvgRdg2371.TabIndex = 61
        Me.TxtCtlAvgRdg2371.Text = ""
        Me.TxtCtlAvgRdg2371.Text = ""
        Me.TxtCtlAvgRdg2371.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcCtlSetInfo(3)"
        '
        'BtnDeleteCtlCapsule2384
        '
        Me.BtnDeleteCtlCapsule2384 = New System.Windows.Forms.Button()
        Me.BtnDeleteCtlCapsule2384.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteCtlCapsule2384.Name = "BtnDeleteCtlCapsule2384"
        Me.BtnDeleteCtlCapsule2384.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteCtlCapsule2384.TabIndex = 60
        Me.BtnDeleteCtlCapsule2384.Text = "Delete Capsule"
        Me.BtnDeleteCtlCapsule2384.UseVisualStyleBackColor = True
        '
        'GrdCtlCapsules2489
        '
        Me.GrdCtlCapsules2489 = New System.Windows.Forms.DataGridView()
        Me.GrdCtlCapsules2489.Location = New System.Drawing.Point(6, 12)
        Me.GrdCtlCapsules2489.Name = "GrdCtlCapsules2489"
        Me.GrdCtlCapsules2489.Size = New System.Drawing.Size(370, 61)
        Me.GrdCtlCapsules2489.TabIndex = 66
        Me.GrdCtlCapsules2489.Text = "GrdCtlCapsules2489"
        Me.GrdCtlCapsules2489.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblCtlSetToFirst2499
        '
        Me.LblCtlSetToFirst2499 = New System.Windows.Forms.Label()
        Me.LblCtlSetToFirst2499.Location = New System.Drawing.Point(249, 84)
        Me.LblCtlSetToFirst2499.Name = "LblCtlSetToFirst2499"
        Me.LblCtlSetToFirst2499.Size = New System.Drawing.Size(71, 13)
        Me.LblCtlSetToFirst2499.TabIndex = 70
        Me.LblCtlSetToFirst2499.Text = "Set To 1st"
        Me.LblCtlSetToFirst2499.Text = "Set To 1st"
        '
        'LblCtlStdDev2517
        '
        Me.LblCtlStdDev2517 = New System.Windows.Forms.Label()
        Me.LblCtlStdDev2517.Location = New System.Drawing.Point(129, 84)
        Me.LblCtlStdDev2517.Name = "LblCtlStdDev2517"
        Me.LblCtlStdDev2517.Size = New System.Drawing.Size(41, 13)
        Me.LblCtlStdDev2517.TabIndex = 69
        Me.LblCtlStdDev2517.Text = "+ / -"
        Me.LblCtlStdDev2517.Text = "+ / -"
        '
        'LblCtlAvgRdg2535
        '
        Me.LblCtlAvgRdg2535 = New System.Windows.Forms.Label()
        Me.LblCtlAvgRdg2535.Location = New System.Drawing.Point(6, 84)
        Me.LblCtlAvgRdg2535.Name = "LblCtlAvgRdg2535"
        Me.LblCtlAvgRdg2535.Size = New System.Drawing.Size(62, 13)
        Me.LblCtlAvgRdg2535.TabIndex = 68
        Me.LblCtlAvgRdg2535.Text = "Avg Rdg"
        Me.LblCtlAvgRdg2535.Text = "Avg Rdg"
        '
        'Label382553
        '
        Me.Label382553 = New System.Windows.Forms.Label()
        Me.Label382553.Location = New System.Drawing.Point(225, 84)
        Me.Label382553.Name = "Label382553"
        Me.Label382553.Size = New System.Drawing.Size(26, 16)
        Me.Label382553.TabIndex = 67
        Me.Label382553.Text = "%"
        Me.Label382553.Text = "%"
        Me.SSTab1TabPage2.Controls.Add(Me.FrmCtlSet2309)
        Me.FrmCtlSet2309.Controls.Add(Me.BtnEditCtlCapsule2327)
        Me.FrmCtlSet2309.Controls.Add(Me.BtnAddCtlCapsule2336)
        Me.FrmCtlSet2309.Controls.Add(Me.TxtCtlSetToFirst2345)
        Me.FrmCtlSet2309.Controls.Add(Me.TxtCtlStdDev2358)
        Me.FrmCtlSet2309.Controls.Add(Me.TxtCtlAvgRdg2371)
        Me.FrmCtlSet2309.Controls.Add(Me.BtnDeleteCtlCapsule2384)
        Me.FrmCtlSet2309.Controls.Add(Me.GrdCtlCapsules2489)
        Me.FrmCtlSet2309.Controls.Add(Me.LblCtlSetToFirst2499)
        Me.FrmCtlSet2309.Controls.Add(Me.LblCtlStdDev2517)
        Me.FrmCtlSet2309.Controls.Add(Me.LblCtlAvgRdg2535)
        Me.FrmCtlSet2309.Controls.Add(Me.Label382553)
        '
        'FrmCtlSet2572
        '
        Me.FrmCtlSet2572 = New System.Windows.Forms.GroupBox()
        Me.FrmCtlSet2572.Location = New System.Drawing.Point(0, 469)
        Me.FrmCtlSet2572.Name = "FrmCtlSet2572"
        Me.FrmCtlSet2572.Size = New System.Drawing.Size(469, 103)
        Me.FrmCtlSet2572.TabIndex = 47
        Me.FrmCtlSet2572.Text = "LAST"
        '
        'BtnEditCtlCapsule2590
        '
        Me.BtnEditCtlCapsule2590 = New System.Windows.Forms.Button()
        Me.BtnEditCtlCapsule2590.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditCtlCapsule2590.Name = "BtnEditCtlCapsule2590"
        Me.BtnEditCtlCapsule2590.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditCtlCapsule2590.TabIndex = 53
        Me.BtnEditCtlCapsule2590.Text = "Edit Capsule..."
        Me.BtnEditCtlCapsule2590.UseVisualStyleBackColor = True
        '
        'BtnAddCtlCapsule2599
        '
        Me.BtnAddCtlCapsule2599 = New System.Windows.Forms.Button()
        Me.BtnAddCtlCapsule2599.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddCtlCapsule2599.Name = "BtnAddCtlCapsule2599"
        Me.BtnAddCtlCapsule2599.Size = New System.Drawing.Size(82, 22)
        Me.BtnAddCtlCapsule2599.TabIndex = 52
        Me.BtnAddCtlCapsule2599.Text = "Add Capsule.."
        Me.BtnAddCtlCapsule2599.UseVisualStyleBackColor = True
        '
        'TxtCtlSetToFirst2608
        '
        Me.TxtCtlSetToFirst2608 = New System.Windows.Forms.TextBox()
        Me.TxtCtlSetToFirst2608.Location = New System.Drawing.Point(315, 75)
        Me.TxtCtlSetToFirst2608.Name = "TxtCtlSetToFirst2608"
        Me.TxtCtlSetToFirst2608.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlSetToFirst2608.TabIndex = 51
        Me.TxtCtlSetToFirst2608.Text = ""
        Me.TxtCtlSetToFirst2608.Text = ""
        Me.TxtCtlSetToFirst2608.Multiline = "False"
        'Datafield = "SET_TO_FIRST"
        'Datafield = "rdcCtlSetInfo(4)"
        '
        'TxtCtlStdDev2621
        '
        Me.TxtCtlStdDev2621 = New System.Windows.Forms.TextBox()
        Me.TxtCtlStdDev2621.Location = New System.Drawing.Point(165, 75)
        Me.TxtCtlStdDev2621.Name = "TxtCtlStdDev2621"
        Me.TxtCtlStdDev2621.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlStdDev2621.TabIndex = 50
        Me.TxtCtlStdDev2621.Text = ""
        Me.TxtCtlStdDev2621.Text = ""
        Me.TxtCtlStdDev2621.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcCtlSetInfo(4)"
        '
        'TxtCtlAvgRdg2634
        '
        Me.TxtCtlAvgRdg2634 = New System.Windows.Forms.TextBox()
        Me.TxtCtlAvgRdg2634.Location = New System.Drawing.Point(63, 75)
        Me.TxtCtlAvgRdg2634.Name = "TxtCtlAvgRdg2634"
        Me.TxtCtlAvgRdg2634.Size = New System.Drawing.Size(61, 22)
        Me.TxtCtlAvgRdg2634.TabIndex = 49
        Me.TxtCtlAvgRdg2634.Text = ""
        Me.TxtCtlAvgRdg2634.Text = ""
        Me.TxtCtlAvgRdg2634.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcCtlSetInfo(4)"
        '
        'BtnDeleteCtlCapsule2647
        '
        Me.BtnDeleteCtlCapsule2647 = New System.Windows.Forms.Button()
        Me.BtnDeleteCtlCapsule2647.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteCtlCapsule2647.Name = "BtnDeleteCtlCapsule2647"
        Me.BtnDeleteCtlCapsule2647.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteCtlCapsule2647.TabIndex = 48
        Me.BtnDeleteCtlCapsule2647.Text = "Delete Capsule"
        Me.BtnDeleteCtlCapsule2647.UseVisualStyleBackColor = True
        '
        'GrdCtlCapsules2752
        '
        Me.GrdCtlCapsules2752 = New System.Windows.Forms.DataGridView()
        Me.GrdCtlCapsules2752.Location = New System.Drawing.Point(6, 12)
        Me.GrdCtlCapsules2752.Name = "GrdCtlCapsules2752"
        Me.GrdCtlCapsules2752.Size = New System.Drawing.Size(370, 61)
        Me.GrdCtlCapsules2752.TabIndex = 54
        Me.GrdCtlCapsules2752.Text = "GrdCtlCapsules2752"
        Me.GrdCtlCapsules2752.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblCtlSetToFirst2762
        '
        Me.LblCtlSetToFirst2762 = New System.Windows.Forms.Label()
        Me.LblCtlSetToFirst2762.Location = New System.Drawing.Point(249, 84)
        Me.LblCtlSetToFirst2762.Name = "LblCtlSetToFirst2762"
        Me.LblCtlSetToFirst2762.Size = New System.Drawing.Size(71, 13)
        Me.LblCtlSetToFirst2762.TabIndex = 58
        Me.LblCtlSetToFirst2762.Text = "Set To 1st"
        Me.LblCtlSetToFirst2762.Text = "Set To 1st"
        '
        'LblCtlStdDev2780
        '
        Me.LblCtlStdDev2780 = New System.Windows.Forms.Label()
        Me.LblCtlStdDev2780.Location = New System.Drawing.Point(129, 84)
        Me.LblCtlStdDev2780.Name = "LblCtlStdDev2780"
        Me.LblCtlStdDev2780.Size = New System.Drawing.Size(41, 13)
        Me.LblCtlStdDev2780.TabIndex = 57
        Me.LblCtlStdDev2780.Text = "+ / -"
        Me.LblCtlStdDev2780.Text = "+ / -"
        '
        'LblCtlAvgRdg2798
        '
        Me.LblCtlAvgRdg2798 = New System.Windows.Forms.Label()
        Me.LblCtlAvgRdg2798.Location = New System.Drawing.Point(6, 84)
        Me.LblCtlAvgRdg2798.Name = "LblCtlAvgRdg2798"
        Me.LblCtlAvgRdg2798.Size = New System.Drawing.Size(62, 13)
        Me.LblCtlAvgRdg2798.TabIndex = 56
        Me.LblCtlAvgRdg2798.Text = "Avg Rdg"
        Me.LblCtlAvgRdg2798.Text = "Avg Rdg"
        '
        'Label382816
        '
        Me.Label382816 = New System.Windows.Forms.Label()
        Me.Label382816.Location = New System.Drawing.Point(228, 84)
        Me.Label382816.Name = "Label382816"
        Me.Label382816.Size = New System.Drawing.Size(26, 16)
        Me.Label382816.TabIndex = 55
        Me.Label382816.Text = "%"
        Me.Label382816.Text = "%"
        Me.SSTab1TabPage2.Controls.Add(Me.FrmCtlSet2572)
        Me.FrmCtlSet2572.Controls.Add(Me.BtnEditCtlCapsule2590)
        Me.FrmCtlSet2572.Controls.Add(Me.BtnAddCtlCapsule2599)
        Me.FrmCtlSet2572.Controls.Add(Me.TxtCtlSetToFirst2608)
        Me.FrmCtlSet2572.Controls.Add(Me.TxtCtlStdDev2621)
        Me.FrmCtlSet2572.Controls.Add(Me.TxtCtlAvgRdg2634)
        Me.FrmCtlSet2572.Controls.Add(Me.BtnDeleteCtlCapsule2647)
        Me.FrmCtlSet2572.Controls.Add(Me.GrdCtlCapsules2752)
        Me.FrmCtlSet2572.Controls.Add(Me.LblCtlSetToFirst2762)
        Me.FrmCtlSet2572.Controls.Add(Me.LblCtlStdDev2780)
        Me.FrmCtlSet2572.Controls.Add(Me.LblCtlAvgRdg2798)
        Me.FrmCtlSet2572.Controls.Add(Me.Label382816)
        '
        'FrmStdSet2835
        '
        Me.FrmStdSet2835 = New System.Windows.Forms.GroupBox()
        Me.FrmStdSet2835.Location = New System.Drawing.Point(0, 178)
        Me.FrmStdSet2835.Name = "FrmStdSet2835"
        Me.FrmStdSet2835.Size = New System.Drawing.Size(469, 103)
        Me.FrmStdSet2835.TabIndex = 35
        Me.FrmStdSet2835.Text = "LAST"
        '
        'TxtStdAvgRdg2853
        '
        Me.TxtStdAvgRdg2853 = New System.Windows.Forms.TextBox()
        Me.TxtStdAvgRdg2853.Location = New System.Drawing.Point(63, 75)
        Me.TxtStdAvgRdg2853.Name = "TxtStdAvgRdg2853"
        Me.TxtStdAvgRdg2853.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdAvgRdg2853.TabIndex = 41
        Me.TxtStdAvgRdg2853.Text = ""
        Me.TxtStdAvgRdg2853.Text = ""
        Me.TxtStdAvgRdg2853.Multiline = "False"
        'Datafield = "AVG"
        'Datafield = "rdcStdSetInfo(1)"
        '
        'TxtStdStdDev2866
        '
        Me.TxtStdStdDev2866 = New System.Windows.Forms.TextBox()
        Me.TxtStdStdDev2866.Location = New System.Drawing.Point(168, 75)
        Me.TxtStdStdDev2866.Name = "TxtStdStdDev2866"
        Me.TxtStdStdDev2866.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdStdDev2866.TabIndex = 40
        Me.TxtStdStdDev2866.Text = ""
        Me.TxtStdStdDev2866.Text = ""
        Me.TxtStdStdDev2866.Multiline = "False"
        'Datafield = "STD_DEV"
        'Datafield = "rdcStdSetInfo(1)"
        '
        'BtnAddStdCapsule2879
        '
        Me.BtnAddStdCapsule2879 = New System.Windows.Forms.Button()
        Me.BtnAddStdCapsule2879.Location = New System.Drawing.Point(381, 12)
        Me.BtnAddStdCapsule2879.Name = "BtnAddStdCapsule2879"
        Me.BtnAddStdCapsule2879.Size = New System.Drawing.Size(82, 22)
        Me.BtnAddStdCapsule2879.TabIndex = 39
        Me.BtnAddStdCapsule2879.Text = "Add Capsule.."
        Me.BtnAddStdCapsule2879.UseVisualStyleBackColor = True
        '
        'BtnEditStdCapsule2888
        '
        Me.BtnEditStdCapsule2888 = New System.Windows.Forms.Button()
        Me.BtnEditStdCapsule2888.Location = New System.Drawing.Point(381, 36)
        Me.BtnEditStdCapsule2888.Name = "BtnEditStdCapsule2888"
        Me.BtnEditStdCapsule2888.Size = New System.Drawing.Size(82, 22)
        Me.BtnEditStdCapsule2888.TabIndex = 38
        Me.BtnEditStdCapsule2888.Text = "Edit Capsule..."
        Me.BtnEditStdCapsule2888.UseVisualStyleBackColor = True
        '
        'BtnDeleteStdCapsule2897
        '
        Me.BtnDeleteStdCapsule2897 = New System.Windows.Forms.Button()
        Me.BtnDeleteStdCapsule2897.Location = New System.Drawing.Point(381, 60)
        Me.BtnDeleteStdCapsule2897.Name = "BtnDeleteStdCapsule2897"
        Me.BtnDeleteStdCapsule2897.Size = New System.Drawing.Size(82, 22)
        Me.BtnDeleteStdCapsule2897.TabIndex = 37
        Me.BtnDeleteStdCapsule2897.Text = "Delete Capsule"
        Me.BtnDeleteStdCapsule2897.UseVisualStyleBackColor = True
        '
        'TxtStdSetToFirst2906
        '
        Me.TxtStdSetToFirst2906 = New System.Windows.Forms.TextBox()
        Me.TxtStdSetToFirst2906.Location = New System.Drawing.Point(318, 75)
        Me.TxtStdSetToFirst2906.Name = "TxtStdSetToFirst2906"
        Me.TxtStdSetToFirst2906.Size = New System.Drawing.Size(61, 22)
        Me.TxtStdSetToFirst2906.TabIndex = 36
        Me.TxtStdSetToFirst2906.Text = ""
        Me.TxtStdSetToFirst2906.Text = ""
        Me.TxtStdSetToFirst2906.Multiline = "False"
        'Datafield = "SET_TO_FIRST"
        'Datafield = "rdcStdSetInfo(1)"
        '
        'GrdStdCapsules3015
        '
        Me.GrdStdCapsules3015 = New System.Windows.Forms.DataGridView()
        Me.GrdStdCapsules3015.Location = New System.Drawing.Point(6, 12)
        Me.GrdStdCapsules3015.Name = "GrdStdCapsules3015"
        Me.GrdStdCapsules3015.Size = New System.Drawing.Size(370, 61)
        Me.GrdStdCapsules3015.TabIndex = 42
        Me.GrdStdCapsules3015.Text = "GrdStdCapsules3015"
        Me.GrdStdCapsules3015.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LblStdAvgRdg3025
        '
        Me.LblStdAvgRdg3025 = New System.Windows.Forms.Label()
        Me.LblStdAvgRdg3025.Location = New System.Drawing.Point(6, 84)
        Me.LblStdAvgRdg3025.Name = "LblStdAvgRdg3025"
        Me.LblStdAvgRdg3025.Size = New System.Drawing.Size(62, 13)
        Me.LblStdAvgRdg3025.TabIndex = 46
        Me.LblStdAvgRdg3025.Text = "Avg Rdg"
        Me.LblStdAvgRdg3025.Text = "Avg Rdg"
        '
        'LblStdStdDev3043
        '
        Me.LblStdStdDev3043 = New System.Windows.Forms.Label()
        Me.LblStdStdDev3043.Location = New System.Drawing.Point(135, 84)
        Me.LblStdStdDev3043.Name = "LblStdStdDev3043"
        Me.LblStdStdDev3043.Size = New System.Drawing.Size(44, 13)
        Me.LblStdStdDev3043.TabIndex = 45
        Me.LblStdStdDev3043.Text = "+ / -"
        Me.LblStdStdDev3043.Text = "+ / -"
        '
        'LblStdSetToFirst3061
        '
        Me.LblStdSetToFirst3061 = New System.Windows.Forms.Label()
        Me.LblStdSetToFirst3061.Location = New System.Drawing.Point(252, 84)
        Me.LblStdSetToFirst3061.Name = "LblStdSetToFirst3061"
        Me.LblStdSetToFirst3061.Size = New System.Drawing.Size(71, 13)
        Me.LblStdSetToFirst3061.TabIndex = 44
        Me.LblStdSetToFirst3061.Text = "Set To 1st"
        Me.LblStdSetToFirst3061.Text = "Set To 1st"
        '
        'Label373079
        '
        Me.Label373079 = New System.Windows.Forms.Label()
        Me.Label373079.Location = New System.Drawing.Point(231, 84)
        Me.Label373079.Name = "Label373079"
        Me.Label373079.Size = New System.Drawing.Size(26, 13)
        Me.Label373079.TabIndex = 43
        Me.Label373079.Text = "%"
        Me.Label373079.Text = "%"
        Me.SSTab1TabPage1.Controls.Add(Me.FrmStdSet2835)
        Me.FrmStdSet2835.Controls.Add(Me.TxtStdAvgRdg2853)
        Me.FrmStdSet2835.Controls.Add(Me.TxtStdStdDev2866)
        Me.FrmStdSet2835.Controls.Add(Me.BtnAddStdCapsule2879)
        Me.FrmStdSet2835.Controls.Add(Me.BtnEditStdCapsule2888)
        Me.FrmStdSet2835.Controls.Add(Me.BtnDeleteStdCapsule2897)
        Me.FrmStdSet2835.Controls.Add(Me.TxtStdSetToFirst2906)
        Me.FrmStdSet2835.Controls.Add(Me.GrdStdCapsules3015)
        Me.FrmStdSet2835.Controls.Add(Me.LblStdAvgRdg3025)
        Me.FrmStdSet2835.Controls.Add(Me.LblStdStdDev3043)
        Me.FrmStdSet2835.Controls.Add(Me.LblStdSetToFirst3061)
        Me.FrmStdSet2835.Controls.Add(Me.Label373079)
        '
        'Text1
        '
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text1.Location = New System.Drawing.Point(0, 50)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(64, 22)
        Me.Text1.TabIndex = 34
        Me.Text1.Text = ""
        Me.Text1.Text = ""
        Me.Text1.Multiline = "False"
        'Datafield = "READ_DATE"
        'Datafield = "rdcGeneral"
        '
        'Text2
        '
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text2.Location = New System.Drawing.Point(0, 76)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(64, 22)
        Me.Text2.TabIndex = 33
        Me.Text2.Text = ""
        Me.Text2.Text = ""
        Me.Text2.Multiline = "False"
        'Datafield = "STD_IRRADIATION"
        'Datafield = "rdcGeneral"
        '
        'Text3
        '
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.Text3.Location = New System.Drawing.Point(0, 154)
        Me.Text3.Name = "Text3"
        Me.Text3.Size = New System.Drawing.Size(64, 22)
        Me.Text3.TabIndex = 32
        Me.Text3.Text = ""
        Me.Text3.Text = ""
        Me.Text3.Multiline = "False"
        'Datafield = "CTL_IRRADIATION"
        'Datafield = "rdcGeneral"
        '
        'Text5
        '
        Me.Text5 = New System.Windows.Forms.TextBox()
        Me.Text5.Location = New System.Drawing.Point(0, 214)
        Me.Text5.Name = "Text5"
        Me.Text5.Size = New System.Drawing.Size(91, 22)
        Me.Text5.TabIndex = 31
        Me.Text5.Text = ""
        Me.Text5.Text = ""
        Me.Text5.Multiline = "False"
        'Datafield = "READER"
        'Datafield = "rdcGeneral"
        '
        'BtnToggleFifthControlSet
        '
        Me.BtnToggleFifthControlSet = New System.Windows.Forms.Button()
        Me.BtnToggleFifthControlSet.Location = New System.Drawing.Point(0, 577)
        Me.BtnToggleFifthControlSet.Name = "BtnToggleFifthControlSet"
        Me.BtnToggleFifthControlSet.Size = New System.Drawing.Size(139, 25)
        Me.BtnToggleFifthControlSet.TabIndex = 30
        Me.BtnToggleFifthControlSet.Text = "Toggle Fifth Control Set"
        Me.BtnToggleFifthControlSet.UseVisualStyleBackColor = True
        '
        'BtnPrintTLDSessionCheckSheet
        '
        Me.BtnPrintTLDSessionCheckSheet = New System.Windows.Forms.Button()
        Me.BtnPrintTLDSessionCheckSheet.Location = New System.Drawing.Point(0, 557)
        Me.BtnPrintTLDSessionCheckSheet.Name = "BtnPrintTLDSessionCheckSheet"
        Me.BtnPrintTLDSessionCheckSheet.Size = New System.Drawing.Size(166, 25)
        Me.BtnPrintTLDSessionCheckSheet.TabIndex = 28
        Me.BtnPrintTLDSessionCheckSheet.Text = "TLD Session Check Sheet..."
        Me.BtnPrintTLDSessionCheckSheet.UseVisualStyleBackColor = True
        '
        'Frame1
        '
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.Frame1.Location = New System.Drawing.Point(0, 280)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(322, 124)
        Me.Frame1.TabIndex = 19
        Me.Frame1.Text = "Machine Used for Standards"
        '
        'Text7
        '
        Me.Text7 = New System.Windows.Forms.TextBox()
        Me.Text7.Location = New System.Drawing.Point(105, 24)
        Me.Text7.Name = "Text7"
        Me.Text7.Size = New System.Drawing.Size(154, 22)
        Me.Text7.TabIndex = 23
        Me.Text7.Text = ""
        Me.Text7.Text = ""
        Me.Text7.Multiline = "False"
        'Datafield = "STD_MODEL"
        'Datafield = "rdcGeneral"
        '
        'Text4
        '
        Me.Text4 = New System.Windows.Forms.TextBox()
        Me.Text4.Location = New System.Drawing.Point(105, 48)
        Me.Text4.Name = "Text4"
        Me.Text4.Size = New System.Drawing.Size(154, 22)
        Me.Text4.TabIndex = 22
        Me.Text4.Text = ""
        Me.Text4.Text = ""
        Me.Text4.Multiline = "False"
        'Datafield = "STD_SERIAL_NO"
        'Datafield = "rdcGeneral"
        '
        'Text9
        '
        Me.Text9 = New System.Windows.Forms.TextBox()
        Me.Text9.Location = New System.Drawing.Point(105, 72)
        Me.Text9.Name = "Text9"
        Me.Text9.Size = New System.Drawing.Size(154, 22)
        Me.Text9.TabIndex = 21
        Me.Text9.Text = ""
        Me.Text9.Text = ""
        Me.Text9.Multiline = "False"
        'Datafield = "STD_INHOUSE"
        'Datafield = "rdcGeneral"
        '
        'Text12
        '
        Me.Text12 = New System.Windows.Forms.TextBox()
        Me.Text12.Location = New System.Drawing.Point(105, 96)
        Me.Text12.Name = "Text12"
        Me.Text12.Size = New System.Drawing.Size(94, 22)
        Me.Text12.TabIndex = 20
        Me.Text12.Text = ""
        Me.Text12.Text = ""
        Me.Text12.Multiline = "False"
        'Datafield = "STD_BATCH"
        'Datafield = "rdcGeneral"
        '
        'Label33
        '
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label33.Location = New System.Drawing.Point(15, 33)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 13)
        Me.Label33.TabIndex = 27
        Me.Label33.Text = "Model"
        Me.Label33.Text = "Model"
        '
        'Label34
        '
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label34.Location = New System.Drawing.Point(15, 57)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 13)
        Me.Label34.TabIndex = 26
        Me.Label34.Text = "Serial #"
        Me.Label34.Text = "Serial #"
        '
        'Label7
        '
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label7.Location = New System.Drawing.Point(15, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "In-House Des."
        Me.Label7.Text = "In-House Des."
        '
        'Label41
        '
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label41.Location = New System.Drawing.Point(15, 102)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(77, 13)
        Me.Label41.TabIndex = 24
        Me.Label41.Text = "Batch"
        Me.Label41.Text = "Batch"
        Me.SSTab1TabPage0.Controls.Add(Me.Text1)
        Me.SSTab1TabPage0.Controls.Add(Me.Text2)
        Me.SSTab1TabPage0.Controls.Add(Me.Text3)
        Me.SSTab1TabPage0.Controls.Add(Me.Text5)
        Me.SSTab1TabPage2.Controls.Add(Me.BtnToggleFifthControlSet)
        Me.SSTab1TabPage0.Controls.Add(Me.BtnPrintTLDSessionCheckSheet)
        Me.SSTab1TabPage0.Controls.Add(Me.Frame1)
        Me.Frame1.Controls.Add(Me.Text7)
        Me.Frame1.Controls.Add(Me.Text4)
        Me.Frame1.Controls.Add(Me.Text9)
        Me.Frame1.Controls.Add(Me.Text12)
        Me.Frame1.Controls.Add(Me.Label33)
        Me.Frame1.Controls.Add(Me.Label34)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label41)
        '
        'Frame2
        '
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.Frame2.Location = New System.Drawing.Point(0, 416)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(322, 124)
        Me.Frame2.TabIndex = 10
        Me.Frame2.Text = "Machine Used for Controls"
        '
        'Text8
        '
        Me.Text8 = New System.Windows.Forms.TextBox()
        Me.Text8.Location = New System.Drawing.Point(105, 24)
        Me.Text8.Name = "Text8"
        Me.Text8.Size = New System.Drawing.Size(154, 22)
        Me.Text8.TabIndex = 14
        Me.Text8.Text = ""
        Me.Text8.Text = ""
        Me.Text8.Multiline = "False"
        'Datafield = "CTL_MODEL"
        'Datafield = "rdcGeneral"
        '
        'Text10
        '
        Me.Text10 = New System.Windows.Forms.TextBox()
        Me.Text10.Location = New System.Drawing.Point(105, 48)
        Me.Text10.Name = "Text10"
        Me.Text10.Size = New System.Drawing.Size(154, 22)
        Me.Text10.TabIndex = 13
        Me.Text10.Text = ""
        Me.Text10.Text = ""
        Me.Text10.Multiline = "False"
        'Datafield = "CTL_SERIAL_NO"
        'Datafield = "rdcGeneral"
        '
        'Text11
        '
        Me.Text11 = New System.Windows.Forms.TextBox()
        Me.Text11.Location = New System.Drawing.Point(105, 72)
        Me.Text11.Name = "Text11"
        Me.Text11.Size = New System.Drawing.Size(154, 22)
        Me.Text11.TabIndex = 12
        Me.Text11.Text = ""
        Me.Text11.Text = ""
        Me.Text11.Multiline = "False"
        'Datafield = "CTL_INHOUSE"
        'Datafield = "rdcGeneral"
        '
        'Text13
        '
        Me.Text13 = New System.Windows.Forms.TextBox()
        Me.Text13.Location = New System.Drawing.Point(105, 96)
        Me.Text13.Name = "Text13"
        Me.Text13.Size = New System.Drawing.Size(94, 22)
        Me.Text13.TabIndex = 11
        Me.Text13.Text = ""
        Me.Text13.Text = ""
        Me.Text13.Multiline = "False"
        'Datafield = "CTL_BATCH"
        'Datafield = "rdcGeneral"
        '
        'Label8
        '
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label8.Location = New System.Drawing.Point(15, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Serial #"
        Me.Label8.Text = "Serial #"
        '
        'Label35
        '
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label35.Location = New System.Drawing.Point(15, 81)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(86, 13)
        Me.Label35.TabIndex = 17
        Me.Label35.Text = "In-House Des."
        Me.Label35.Text = "In-House Des."
        '
        'Label36
        '
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label36.Location = New System.Drawing.Point(15, 36)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(86, 16)
        Me.Label36.TabIndex = 16
        Me.Label36.Text = "Model"
        Me.Label36.Text = "Model"
        '
        'Label42
        '
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label42.Location = New System.Drawing.Point(15, 102)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(77, 13)
        Me.Label42.TabIndex = 15
        Me.Label42.Text = "Batch"
        Me.Label42.Text = "Batch"
        Me.SSTab1TabPage0.Controls.Add(Me.Frame2)
        Me.Frame2.Controls.Add(Me.Text8)
        Me.Frame2.Controls.Add(Me.Text10)
        Me.Frame2.Controls.Add(Me.Text11)
        Me.Frame2.Controls.Add(Me.Text13)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label35)
        Me.Frame2.Controls.Add(Me.Label36)
        Me.Frame2.Controls.Add(Me.Label42)
        '
        'BtnPrintSessionSummaryReport
        '
        Me.BtnPrintSessionSummaryReport = New System.Windows.Forms.Button()
        Me.BtnPrintSessionSummaryReport.Location = New System.Drawing.Point(0, 578)
        Me.BtnPrintSessionSummaryReport.Name = "BtnPrintSessionSummaryReport"
        Me.BtnPrintSessionSummaryReport.Size = New System.Drawing.Size(172, 22)
        Me.BtnPrintSessionSummaryReport.TabIndex = 8
        Me.BtnPrintSessionSummaryReport.Text = "Session Summary Report"
        Me.BtnPrintSessionSummaryReport.UseVisualStyleBackColor = True
        '
        'cmdAccept
        '
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.cmdAccept.Location = New System.Drawing.Point(8, 564)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(65, 25)
        Me.cmdAccept.TabIndex = 7
        Me.cmdAccept.Text = "Accept"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'Frame9
        '
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.Frame9.Location = New System.Drawing.Point(0, 52)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Size = New System.Drawing.Size(488, 337)
        Me.Frame9.TabIndex = 4
        Me.Frame9.Text = ""
        '
        'txtComment
        '
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.txtComment.Location = New System.Drawing.Point(8, 216)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(473, 113)
        Me.txtComment.TabIndex = 5
        Me.txtComment.Text = ""
        Me.txtComment.Text = ""
        Me.txtComment.Multiline = "True"
        'Datafield = "COMMENTS"
        'Datafield = "RDCComments"
        '
        'GrdComments
        '
        Me.GrdComments = New System.Windows.Forms.DataGridView()
        Me.GrdComments.Location = New System.Drawing.Point(8, 16)
        Me.GrdComments.Name = "GrdComments"
        Me.GrdComments.Size = New System.Drawing.Size(473, 193)
        Me.GrdComments.TabIndex = 6
        Me.GrdComments.Text = "GrdComments"
        Me.GrdComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SSTab1TabPage4.Controls.Add(Me.BtnPrintSessionSummaryReport)
        Me.SSTab1TabPage3.Controls.Add(Me.cmdAccept)
        Me.SSTab1TabPage5.Controls.Add(Me.Frame9)
        Me.Frame9.Controls.Add(Me.txtComment)
        Me.Frame9.Controls.Add(Me.GrdComments)
        '
        'cmdDeleteComment
        '
        Me.cmdDeleteComment = New System.Windows.Forms.Button()
        Me.cmdDeleteComment.Location = New System.Drawing.Point(0, 396)
        Me.cmdDeleteComment.Name = "cmdDeleteComment"
        Me.cmdDeleteComment.Size = New System.Drawing.Size(73, 25)
        Me.cmdDeleteComment.TabIndex = 3
        Me.cmdDeleteComment.Text = "Delete"
        Me.cmdDeleteComment.UseVisualStyleBackColor = True
        '
        'cmdEditComment
        '
        Me.cmdEditComment = New System.Windows.Forms.Button()
        Me.cmdEditComment.Location = New System.Drawing.Point(0, 396)
        Me.cmdEditComment.Name = "cmdEditComment"
        Me.cmdEditComment.Size = New System.Drawing.Size(81, 25)
        Me.cmdEditComment.TabIndex = 2
        Me.cmdEditComment.Text = "Edit"
        Me.cmdEditComment.UseVisualStyleBackColor = True
        '
        'cmdAddComment
        '
        Me.cmdAddComment = New System.Windows.Forms.Button()
        Me.cmdAddComment.Location = New System.Drawing.Point(0, 396)
        Me.cmdAddComment.Name = "cmdAddComment"
        Me.cmdAddComment.Size = New System.Drawing.Size(81, 25)
        Me.cmdAddComment.TabIndex = 1
        Me.cmdAddComment.Text = "Add"
        Me.cmdAddComment.UseVisualStyleBackColor = True
        '
        'GrdSessionSummary
        '
        Me.GrdSessionSummary = New System.Windows.Forms.DataGridView()
        Me.GrdSessionSummary.Location = New System.Drawing.Point(0, 344)
        Me.GrdSessionSummary.Name = "GrdSessionSummary"
        Me.GrdSessionSummary.Size = New System.Drawing.Size(478, 229)
        Me.GrdSessionSummary.TabIndex = 9
        Me.GrdSessionSummary.Text = "GrdSessionSummary"
        Me.GrdSessionSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'LstBatches
        '
        Me.LstBatches = New System.Windows.Forms.ListBox()
        Me.LstBatches.Location = New System.Drawing.Point(0, 180)
        Me.LstBatches.Name = "LstBatches"
        Me.LstBatches.Size = New System.Drawing.Size(64, 30)
        Me.LstBatches.TabIndex = 29
        Me.LstBatches.Text = ""
        Me.LstBatches.FormattingEnabled = True
        '
        'lbl30GyStds
        '
        Me.lbl30GyStds = New System.Windows.Forms.Label()
        Me.lbl30GyStds.Location = New System.Drawing.Point(0, 136)
        Me.lbl30GyStds.Name = "lbl30GyStds"
        Me.lbl30GyStds.Size = New System.Drawing.Size(195, 17)
        Me.lbl30GyStds.TabIndex = 221
        Me.lbl30GyStds.Text = "Date of Irradiation of 30 Gy Stds"
        Me.lbl30GyStds.Text = "Date of Irradiation of 30 Gy Stds"
        '
        'lbl8GyStds
        '
        Me.lbl8GyStds = New System.Windows.Forms.Label()
        Me.lbl8GyStds.Location = New System.Drawing.Point(0, 109)
        Me.lbl8GyStds.Name = "lbl8GyStds"
        Me.lbl8GyStds.Size = New System.Drawing.Size(187, 17)
        Me.lbl8GyStds.TabIndex = 220
        Me.lbl8GyStds.Text = "Date of Irradiation of 8 Gy Stds"
        Me.lbl8GyStds.Text = "Date of Irradiation of 8 Gy Stds"
        '
        'LblStdAvgAccReadings3690
        '
        Me.LblStdAvgAccReadings3690 = New System.Windows.Forms.Label()
        Me.LblStdAvgAccReadings3690.Location = New System.Drawing.Point(0, 576)
        Me.LblStdAvgAccReadings3690.Name = "LblStdAvgAccReadings3690"
        Me.LblStdAvgAccReadings3690.Size = New System.Drawing.Size(155, 13)
        Me.LblStdAvgAccReadings3690.TabIndex = 219
        Me.LblStdAvgAccReadings3690.Text = "Label40"
        Me.LblStdAvgAccReadings3690.Text = "Label40"
        '
        'Label403708
        '
        Me.Label403708 = New System.Windows.Forms.Label()
        Me.Label403708.Location = New System.Drawing.Point(0, 576)
        Me.Label403708.Name = "Label403708"
        Me.Label403708.Size = New System.Drawing.Size(179, 13)
        Me.Label403708.TabIndex = 218
        Me.Label403708.Text = "Avg of all accepted readings:"
        Me.Label403708.Text = "Avg of all accepted readings:"
        '
        'LblStdAvgAccReadings3726
        '
        Me.LblStdAvgAccReadings3726 = New System.Windows.Forms.Label()
        Me.LblStdAvgAccReadings3726.Location = New System.Drawing.Point(0, 576)
        Me.LblStdAvgAccReadings3726.Name = "LblStdAvgAccReadings3726"
        Me.LblStdAvgAccReadings3726.Size = New System.Drawing.Size(155, 13)
        Me.LblStdAvgAccReadings3726.TabIndex = 217
        Me.LblStdAvgAccReadings3726.Text = "Label40"
        Me.LblStdAvgAccReadings3726.Text = "Label40"
        '
        'Label403744
        '
        Me.Label403744 = New System.Windows.Forms.Label()
        Me.Label403744.Location = New System.Drawing.Point(0, 576)
        Me.Label403744.Name = "Label403744"
        Me.Label403744.Size = New System.Drawing.Size(179, 13)
        Me.Label403744.TabIndex = 216
        Me.Label403744.Text = "Avg of all accepted readings:"
        Me.Label403744.Text = "Avg of all accepted readings:"
        '
        'Label1
        '
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label1.Location = New System.Drawing.Point(0, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Date of Reading Session"
        Me.Label1.Text = "Date of Reading Session"
        '
        'Label2
        '
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label2.Location = New System.Drawing.Point(0, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 13)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Date of Irradiation of Standards"
        Me.Label2.Text = "Date of Irradiation of Standards"
        '
        'Label3
        '
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label3.Location = New System.Drawing.Point(0, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "Date of Irradiation of Controls"
        Me.Label3.Text = "Date of Irradiation of Controls"
        '
        'Label4
        '
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label4.Location = New System.Drawing.Point(0, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "TLD Batch(es) Used"
        Me.Label4.Text = "TLD Batch(es) Used"
        '
        'Label5
        '
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label5.Location = New System.Drawing.Point(0, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "TLD Reader"
        Me.Label5.Text = "TLD Reader"
        '
        'Label6
        '
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label6.Location = New System.Drawing.Point(0, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "TLD Checkers (Physicists)"
        Me.Label6.Text = "TLD Checkers (Physicists)"
        '
        'Label9
        '
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label9.Location = New System.Drawing.Point(9, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 164
        Me.Label9.Text = "Standards"
        Me.Label9.Text = "Standards"
        '
        'Label11
        '
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label11.Location = New System.Drawing.Point(99, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 13)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "Dose for x minutes"
        Me.Label11.Text = "Dose for x minutes"
        '
        'Label12
        '
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label12.Location = New System.Drawing.Point(99, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 13)
        Me.Label12.TabIndex = 162
        Me.Label12.Text = "Cobalt decay"
        Me.Label12.Text = "Cobalt decay"
        '
        'Label13
        '
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label13.Location = New System.Drawing.Point(99, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 13)
        Me.Label13.TabIndex = 161
        Me.Label13.Text = "EXPECTED DOSE"
        Me.Label13.Text = "EXPECTED DOSE"
        '
        'Label14
        '
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label14.Location = New System.Drawing.Point(99, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(206, 13)
        Me.Label14.TabIndex = 160
        Me.Label14.Text = "Average of all accepted readings"
        Me.Label14.Text = "Average of all accepted readings"
        '
        'Label15
        '
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label15.Location = New System.Drawing.Point(99, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 159
        Me.Label15.Text = "Fading"
        Me.Label15.Text = "Fading"
        '
        'Label16
        '
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label16.Location = New System.Drawing.Point(99, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 158
        Me.Label16.Text = "Linearity (*)"
        Me.Label16.Text = "Linearity (*)"
        '
        'Label17
        '
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label17.Location = New System.Drawing.Point(99, 244)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(194, 13)
        Me.Label17.TabIndex = 157
        Me.Label17.Text = "Average System Sensitivity (+)"
        Me.Label17.Text = "Average System Sensitivity (+)"
        '
        'Label22
        '
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label22.Location = New System.Drawing.Point(21, 517)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 16)
        Me.Label22.TabIndex = 156
        Me.Label22.Text = "NOTES:"
        Me.Label22.Text = "NOTES:"
        '
        'Label25
        '
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label25.Location = New System.Drawing.Point(288, 67)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 16)
        Me.Label25.TabIndex = 155
        Me.Label25.Text = "Controls"
        Me.Label25.Text = "Controls"
        '
        'Label26
        '
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label26.Location = New System.Drawing.Point(411, 67)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 16)
        Me.Label26.TabIndex = 154
        Me.Label26.Text = "Std/Ctl"
        Me.Label26.Text = "Std/Ctl"
        '
        'Label27
        '
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label27.Location = New System.Drawing.Point(21, 283)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(134, 19)
        Me.Label27.TabIndex = 153
        Me.Label27.Text = "Initial System Sens ="
        Me.Label27.Text = "Initial System Sens ="
        '
        'Label29
        '
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label29.Location = New System.Drawing.Point(198, 283)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 19)
        Me.Label29.TabIndex = 152
        Me.Label29.Text = "Final System Sens ="
        Me.Label29.Text = "Final System Sens ="
        '
        'Label31
        '
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label31.Location = New System.Drawing.Point(378, 283)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 13)
        Me.Label31.TabIndex = 151
        Me.Label31.Text = "n (#) ="
        Me.Label31.Text = "n (#) ="
        '
        'Label32
        '
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label32.Location = New System.Drawing.Point(78, 517)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(389, 19)
        Me.Label32.TabIndex = 150
        Me.Label32.Text = "# n = total number of samples this session where Initial Std=0 and Final Std=n"
        Me.Label32.Text = "# n = total number of samples this session where Initial Std=0 and Final Std=n"
        '
        'Label28
        '
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label28.Location = New System.Drawing.Point(99, 418)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(143, 16)
        Me.Label28.TabIndex = 149
        Me.Label28.Text = "MEASURED DOSE"
        Me.Label28.Text = "MEASURED DOSE"
        '
        'Label30
        '
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label30.Location = New System.Drawing.Point(99, 460)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(215, 13)
        Me.Label30.TabIndex = 148
        Me.Label30.Text = "MEASURED DOSE / EXPECTED DOSE"
        Me.Label30.Text = "MEASURED DOSE / EXPECTED DOSE"
        '
        'LblStdDose
        '
        Me.LblStdDose = New System.Windows.Forms.Label()
        Me.LblStdDose.Location = New System.Drawing.Point(27, 94)
        Me.LblStdDose.Name = "LblStdDose"
        Me.LblStdDose.Size = New System.Drawing.Size(65, 13)
        Me.LblStdDose.TabIndex = 147
        Me.LblStdDose.Text = "Label33"
        Me.LblStdDose.Text = "Label33"
        '
        'LblCtlDose
        '
        Me.LblCtlDose = New System.Windows.Forms.Label()
        Me.LblCtlDose.Location = New System.Drawing.Point(294, 94)
        Me.LblCtlDose.Name = "LblCtlDose"
        Me.LblCtlDose.Size = New System.Drawing.Size(65, 13)
        Me.LblCtlDose.TabIndex = 146
        Me.LblCtlDose.Text = "Label33"
        Me.LblCtlDose.Text = "Label33"
        '
        'LblStdCtlDose
        '
        Me.LblStdCtlDose = New System.Windows.Forms.Label()
        Me.LblStdCtlDose.Location = New System.Drawing.Point(414, 94)
        Me.LblStdCtlDose.Name = "LblStdCtlDose"
        Me.LblStdCtlDose.Size = New System.Drawing.Size(65, 13)
        Me.LblStdCtlDose.TabIndex = 145
        Me.LblStdCtlDose.Text = "Label33"
        Me.LblStdCtlDose.Text = "Label33"
        '
        'LblStdDecay
        '
        Me.LblStdDecay = New System.Windows.Forms.Label()
        Me.LblStdDecay.Location = New System.Drawing.Point(27, 115)
        Me.LblStdDecay.Name = "LblStdDecay"
        Me.LblStdDecay.Size = New System.Drawing.Size(65, 13)
        Me.LblStdDecay.TabIndex = 144
        Me.LblStdDecay.Text = "Label33"
        Me.LblStdDecay.Text = "Label33"
        '
        'LblCtlDecay
        '
        Me.LblCtlDecay = New System.Windows.Forms.Label()
        Me.LblCtlDecay.Location = New System.Drawing.Point(294, 115)
        Me.LblCtlDecay.Name = "LblCtlDecay"
        Me.LblCtlDecay.Size = New System.Drawing.Size(65, 13)
        Me.LblCtlDecay.TabIndex = 143
        Me.LblCtlDecay.Text = "Label33"
        Me.LblCtlDecay.Text = "Label33"
        '
        'LblStdCtlDecay
        '
        Me.LblStdCtlDecay = New System.Windows.Forms.Label()
        Me.LblStdCtlDecay.Location = New System.Drawing.Point(414, 115)
        Me.LblStdCtlDecay.Name = "LblStdCtlDecay"
        Me.LblStdCtlDecay.Size = New System.Drawing.Size(65, 13)
        Me.LblStdCtlDecay.TabIndex = 142
        Me.LblStdCtlDecay.Text = "Label33"
        Me.LblStdCtlDecay.Text = "Label33"
        '
        'LblStdExpectedDose
        '
        Me.LblStdExpectedDose = New System.Windows.Forms.Label()
        Me.LblStdExpectedDose.Location = New System.Drawing.Point(27, 148)
        Me.LblStdExpectedDose.Name = "LblStdExpectedDose"
        Me.LblStdExpectedDose.Size = New System.Drawing.Size(65, 13)
        Me.LblStdExpectedDose.TabIndex = 141
        Me.LblStdExpectedDose.Text = "Label33"
        Me.LblStdExpectedDose.Text = "Label33"
        '
        'LblCtlExpectedDose
        '
        Me.LblCtlExpectedDose = New System.Windows.Forms.Label()
        Me.LblCtlExpectedDose.Location = New System.Drawing.Point(294, 148)
        Me.LblCtlExpectedDose.Name = "LblCtlExpectedDose"
        Me.LblCtlExpectedDose.Size = New System.Drawing.Size(65, 13)
        Me.LblCtlExpectedDose.TabIndex = 140
        Me.LblCtlExpectedDose.Text = "Label33"
        Me.LblCtlExpectedDose.Text = "Label33"
        '
        'LblStdCtlExpectedDose
        '
        Me.LblStdCtlExpectedDose = New System.Windows.Forms.Label()
        Me.LblStdCtlExpectedDose.Location = New System.Drawing.Point(414, 148)
        Me.LblStdCtlExpectedDose.Name = "LblStdCtlExpectedDose"
        Me.LblStdCtlExpectedDose.Size = New System.Drawing.Size(65, 13)
        Me.LblStdCtlExpectedDose.TabIndex = 139
        Me.LblStdCtlExpectedDose.Text = "Label33"
        Me.LblStdCtlExpectedDose.Text = "Label33"
        '
        'LblStdAvgRdg4201
        '
        Me.LblStdAvgRdg4201 = New System.Windows.Forms.Label()
        Me.LblStdAvgRdg4201.Location = New System.Drawing.Point(27, 178)
        Me.LblStdAvgRdg4201.Name = "LblStdAvgRdg4201"
        Me.LblStdAvgRdg4201.Size = New System.Drawing.Size(65, 13)
        Me.LblStdAvgRdg4201.TabIndex = 138
        Me.LblStdAvgRdg4201.Text = "Label33"
        Me.LblStdAvgRdg4201.Text = "Label33"
        '
        'LblStdFading
        '
        Me.LblStdFading = New System.Windows.Forms.Label()
        Me.LblStdFading.Location = New System.Drawing.Point(27, 199)
        Me.LblStdFading.Name = "LblStdFading"
        Me.LblStdFading.Size = New System.Drawing.Size(65, 13)
        Me.LblStdFading.TabIndex = 137
        Me.LblStdFading.Text = "Label33"
        Me.LblStdFading.Text = "Label33"
        '
        'LblStdLinearity
        '
        Me.LblStdLinearity = New System.Windows.Forms.Label()
        Me.LblStdLinearity.Location = New System.Drawing.Point(27, 220)
        Me.LblStdLinearity.Name = "LblStdLinearity"
        Me.LblStdLinearity.Size = New System.Drawing.Size(65, 13)
        Me.LblStdLinearity.TabIndex = 136
        Me.LblStdLinearity.Text = "Label10"
        Me.LblStdLinearity.Text = "Label10"
        '
        'LblStdSensitivity
        '
        Me.LblStdSensitivity = New System.Windows.Forms.Label()
        Me.LblStdSensitivity.Location = New System.Drawing.Point(27, 244)
        Me.LblStdSensitivity.Name = "LblStdSensitivity"
        Me.LblStdSensitivity.Size = New System.Drawing.Size(65, 16)
        Me.LblStdSensitivity.TabIndex = 135
        Me.LblStdSensitivity.Text = "Label10"
        Me.LblStdSensitivity.Text = "Label10"
        '
        'LblCtlAvgRdg4246
        '
        Me.LblCtlAvgRdg4246 = New System.Windows.Forms.Label()
        Me.LblCtlAvgRdg4246.Location = New System.Drawing.Point(294, 322)
        Me.LblCtlAvgRdg4246.Name = "LblCtlAvgRdg4246"
        Me.LblCtlAvgRdg4246.Size = New System.Drawing.Size(65, 13)
        Me.LblCtlAvgRdg4246.TabIndex = 134
        Me.LblCtlAvgRdg4246.Text = "Label10"
        Me.LblCtlAvgRdg4246.Text = "Label10"
        '
        'LblCtlFading
        '
        Me.LblCtlFading = New System.Windows.Forms.Label()
        Me.LblCtlFading.Location = New System.Drawing.Point(294, 343)
        Me.LblCtlFading.Name = "LblCtlFading"
        Me.LblCtlFading.Size = New System.Drawing.Size(65, 13)
        Me.LblCtlFading.TabIndex = 133
        Me.LblCtlFading.Text = "Label10"
        Me.LblCtlFading.Text = "Label10"
        '
        'LblCtlLinearity
        '
        Me.LblCtlLinearity = New System.Windows.Forms.Label()
        Me.LblCtlLinearity.Location = New System.Drawing.Point(294, 364)
        Me.LblCtlLinearity.Name = "LblCtlLinearity"
        Me.LblCtlLinearity.Size = New System.Drawing.Size(65, 13)
        Me.LblCtlLinearity.TabIndex = 132
        Me.LblCtlLinearity.Text = "Label10"
        Me.LblCtlLinearity.Text = "Label10"
        '
        'LblCtlSensitivity
        '
        Me.LblCtlSensitivity = New System.Windows.Forms.Label()
        Me.LblCtlSensitivity.Location = New System.Drawing.Point(294, 388)
        Me.LblCtlSensitivity.Name = "LblCtlSensitivity"
        Me.LblCtlSensitivity.Size = New System.Drawing.Size(65, 13)
        Me.LblCtlSensitivity.TabIndex = 131
        Me.LblCtlSensitivity.Text = "Label10"
        Me.LblCtlSensitivity.Text = "Label10"
        '
        'LblMeasDose
        '
        Me.LblMeasDose = New System.Windows.Forms.Label()
        Me.LblMeasDose.Location = New System.Drawing.Point(294, 412)
        Me.LblMeasDose.Name = "LblMeasDose"
        Me.LblMeasDose.Size = New System.Drawing.Size(65, 13)
        Me.LblMeasDose.TabIndex = 130
        Me.LblMeasDose.Text = "Label10"
        Me.LblMeasDose.Text = "Label10"
        '
        'LblMeasDoseExpDose
        '
        Me.LblMeasDoseExpDose = New System.Windows.Forms.Label()
        Me.LblMeasDoseExpDose.Location = New System.Drawing.Point(294, 460)
        Me.LblMeasDoseExpDose.Name = "LblMeasDoseExpDose"
        Me.LblMeasDoseExpDose.Size = New System.Drawing.Size(65, 13)
        Me.LblMeasDoseExpDose.TabIndex = 129
        Me.LblMeasDoseExpDose.Text = "Label10"
        Me.LblMeasDoseExpDose.Text = "Label10"
        '
        'LblInitSensitivity
        '
        Me.LblInitSensitivity = New System.Windows.Forms.Label()
        Me.LblInitSensitivity.Location = New System.Drawing.Point(147, 283)
        Me.LblInitSensitivity.Name = "LblInitSensitivity"
        Me.LblInitSensitivity.Size = New System.Drawing.Size(56, 16)
        Me.LblInitSensitivity.TabIndex = 128
        Me.LblInitSensitivity.Text = "Label10"
        Me.LblInitSensitivity.Text = "Label10"
        '
        'LblFinalSensitivity
        '
        Me.LblFinalSensitivity = New System.Windows.Forms.Label()
        Me.LblFinalSensitivity.Location = New System.Drawing.Point(318, 283)
        Me.LblFinalSensitivity.Name = "LblFinalSensitivity"
        Me.LblFinalSensitivity.Size = New System.Drawing.Size(62, 13)
        Me.LblFinalSensitivity.TabIndex = 127
        Me.LblFinalSensitivity.Text = "Label18"
        Me.LblFinalSensitivity.Text = "Label18"
        '
        'LblNumSamples
        '
        Me.LblNumSamples = New System.Windows.Forms.Label()
        Me.LblNumSamples.Location = New System.Drawing.Point(423, 283)
        Me.LblNumSamples.Name = "LblNumSamples"
        Me.LblNumSamples.Size = New System.Drawing.Size(62, 13)
        Me.LblNumSamples.TabIndex = 126
        Me.LblNumSamples.Text = "Label10"
        Me.LblNumSamples.Text = "Label10"
        '
        'Label10
        '
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label10.Location = New System.Drawing.Point(99, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 13)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Average System Sensitivity (+)"
        Me.Label10.Text = "Average System Sensitivity (+)"
        '
        'Label18
        '
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label18.Location = New System.Drawing.Point(99, 364)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 13)
        Me.Label18.TabIndex = 124
        Me.Label18.Text = "Linearity (*)"
        Me.Label18.Text = "Linearity (*)"
        '
        'Label19
        '
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label19.Location = New System.Drawing.Point(99, 343)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 13)
        Me.Label19.TabIndex = 123
        Me.Label19.Text = "Fading"
        Me.Label19.Text = "Fading"
        '
        'Label20
        '
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label20.Location = New System.Drawing.Point(99, 322)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(206, 13)
        Me.Label20.TabIndex = 122
        Me.Label20.Text = "Average of all accepted readings"
        Me.Label20.Text = "Average of all accepted readings"
        '
        'Label39
        '
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label39.Location = New System.Drawing.Point(0, 580)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(179, 13)
        Me.Label39.TabIndex = 121
        Me.Label39.Text = "Avg of all accepted readings:"
        Me.Label39.Text = "Avg of all accepted readings:"
        '
        'LblCtlAvgAccReadings
        '
        Me.LblCtlAvgAccReadings = New System.Windows.Forms.Label()
        Me.LblCtlAvgAccReadings.Location = New System.Drawing.Point(0, 580)
        Me.LblCtlAvgAccReadings.Name = "LblCtlAvgAccReadings"
        Me.LblCtlAvgAccReadings.Size = New System.Drawing.Size(155, 13)
        Me.LblCtlAvgAccReadings.TabIndex = 120
        Me.LblCtlAvgAccReadings.Text = "Label40"
        Me.LblCtlAvgAccReadings.Text = "Label40"
        '
        'Label404464
        '
        Me.Label404464 = New System.Windows.Forms.Label()
        Me.Label404464.Location = New System.Drawing.Point(0, 580)
        Me.Label404464.Name = "Label404464"
        Me.Label404464.Size = New System.Drawing.Size(179, 13)
        Me.Label404464.TabIndex = 119
        Me.Label404464.Text = "Avg of all accepted readings:"
        Me.Label404464.Text = "Avg of all accepted readings:"
        '
        'LblStdAvgAccReadings4482
        '
        Me.LblStdAvgAccReadings4482 = New System.Windows.Forms.Label()
        Me.LblStdAvgAccReadings4482.Location = New System.Drawing.Point(0, 580)
        Me.LblStdAvgAccReadings4482.Name = "LblStdAvgAccReadings4482"
        Me.LblStdAvgAccReadings4482.Size = New System.Drawing.Size(155, 13)
        Me.LblStdAvgAccReadings4482.TabIndex = 118
        Me.LblStdAvgAccReadings4482.Text = "Label40"
        Me.LblStdAvgAccReadings4482.Text = "Label40"
        '
        'LblSessionTolerance
        '
        Me.LblSessionTolerance = New System.Windows.Forms.Label()
        Me.LblSessionTolerance.Location = New System.Drawing.Point(360, 460)
        Me.LblSessionTolerance.Name = "LblSessionTolerance"
        Me.LblSessionTolerance.Size = New System.Drawing.Size(125, 49)
        Me.LblSessionTolerance.TabIndex = 117
        Me.LblSessionTolerance.Text = "Label10"
        Me.LblSessionTolerance.Text = "Label10"
        '
        'TxtAccepted
        '
        Me.TxtAccepted = New System.Windows.Forms.Label()
        Me.TxtAccepted.Location = New System.Drawing.Point(8, 572)
        Me.TxtAccepted.Name = "TxtAccepted"
        Me.TxtAccepted.Size = New System.Drawing.Size(83, 25)
        Me.TxtAccepted.TabIndex = 116
        Me.TxtAccepted.Text = "ACCEPTED"
        Me.TxtAccepted.Text = "ACCEPTED"
        Me.SSTab1TabPage5.Controls.Add(Me.cmdDeleteComment)
        Me.SSTab1TabPage5.Controls.Add(Me.cmdEditComment)
        Me.SSTab1TabPage5.Controls.Add(Me.cmdAddComment)
        Me.SSTab1TabPage4.Controls.Add(Me.GrdSessionSummary)
        Me.SSTab1TabPage0.Controls.Add(Me.LstBatches)
        Me.SSTab1TabPage0.Controls.Add(Me.lbl30GyStds)
        Me.SSTab1TabPage0.Controls.Add(Me.lbl8GyStds)
        Me.SSTab1TabPage7.Controls.Add(Me.LblStdAvgAccReadings3690)
        Me.SSTab1TabPage7.Controls.Add(Me.Label403708)
        Me.SSTab1TabPage6.Controls.Add(Me.LblStdAvgAccReadings3726)
        Me.SSTab1TabPage6.Controls.Add(Me.Label403744)
        Me.SSTab1TabPage0.Controls.Add(Me.Label1)
        Me.SSTab1TabPage0.Controls.Add(Me.Label2)
        Me.SSTab1TabPage0.Controls.Add(Me.Label3)
        Me.SSTab1TabPage0.Controls.Add(Me.Label4)
        Me.SSTab1TabPage0.Controls.Add(Me.Label5)
        Me.SSTab1TabPage0.Controls.Add(Me.Label6)
        Me.SSTab1TabPage3.Controls.Add(Me.Label9)
        Me.SSTab1TabPage3.Controls.Add(Me.Label11)
        Me.SSTab1TabPage3.Controls.Add(Me.Label12)
        Me.SSTab1TabPage3.Controls.Add(Me.Label13)
        Me.SSTab1TabPage3.Controls.Add(Me.Label14)
        Me.SSTab1TabPage3.Controls.Add(Me.Label15)
        Me.SSTab1TabPage3.Controls.Add(Me.Label16)
        Me.SSTab1TabPage3.Controls.Add(Me.Label17)
        Me.SSTab1TabPage3.Controls.Add(Me.Label22)
        Me.SSTab1TabPage3.Controls.Add(Me.Label25)
        Me.SSTab1TabPage3.Controls.Add(Me.Label26)
        Me.SSTab1TabPage3.Controls.Add(Me.Label27)
        Me.SSTab1TabPage3.Controls.Add(Me.Label29)
        Me.SSTab1TabPage3.Controls.Add(Me.Label31)
        Me.SSTab1TabPage3.Controls.Add(Me.Label32)
        Me.SSTab1TabPage3.Controls.Add(Me.Label28)
        Me.SSTab1TabPage3.Controls.Add(Me.Label30)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdDose)
        Me.SSTab1TabPage3.Controls.Add(Me.LblCtlDose)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdCtlDose)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdDecay)
        Me.SSTab1TabPage3.Controls.Add(Me.LblCtlDecay)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdCtlDecay)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdExpectedDose)
        Me.SSTab1TabPage3.Controls.Add(Me.LblCtlExpectedDose)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdCtlExpectedDose)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdAvgRdg4201)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdFading)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdLinearity)
        Me.SSTab1TabPage3.Controls.Add(Me.LblStdSensitivity)
        Me.SSTab1TabPage3.Controls.Add(Me.LblCtlAvgRdg4246)
        Me.SSTab1TabPage3.Controls.Add(Me.LblCtlFading)
        Me.SSTab1TabPage3.Controls.Add(Me.LblCtlLinearity)
        Me.SSTab1TabPage3.Controls.Add(Me.LblCtlSensitivity)
        Me.SSTab1TabPage3.Controls.Add(Me.LblMeasDose)
        Me.SSTab1TabPage3.Controls.Add(Me.LblMeasDoseExpDose)
        Me.SSTab1TabPage3.Controls.Add(Me.LblInitSensitivity)
        Me.SSTab1TabPage3.Controls.Add(Me.LblFinalSensitivity)
        Me.SSTab1TabPage3.Controls.Add(Me.LblNumSamples)
        Me.SSTab1TabPage3.Controls.Add(Me.Label10)
        Me.SSTab1TabPage3.Controls.Add(Me.Label18)
        Me.SSTab1TabPage3.Controls.Add(Me.Label19)
        Me.SSTab1TabPage3.Controls.Add(Me.Label20)
        Me.SSTab1TabPage2.Controls.Add(Me.Label39)
        Me.SSTab1TabPage2.Controls.Add(Me.LblCtlAvgAccReadings)
        Me.SSTab1TabPage1.Controls.Add(Me.Label404464)
        Me.SSTab1TabPage1.Controls.Add(Me.LblStdAvgAccReadings4482)
        Me.SSTab1TabPage3.Controls.Add(Me.LblSessionTolerance)
        Me.SSTab1TabPage3.Controls.Add(Me.TxtAccepted)
        '
        'frmPhantomStandardsAndControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 617)
        Me.Controls.Add(Me.SSTab1)
        Me.Name = "frmPhantomStandardsAndControls"
        Me.Text = "frmPhantomStandardsAndControls"
        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents SSTab1 As TabControl
    Friend WithEvents SSTab1TabPage0 As TabPage
    Friend WithEvents SSTab1TabPage1 As TabPage
    Friend WithEvents SSTab1TabPage2 As TabPage
    Friend WithEvents SSTab1TabPage3 As TabPage
    Friend WithEvents SSTab1TabPage4 As TabPage
    Friend WithEvents SSTab1TabPage5 As TabPage
    Friend WithEvents SSTab1TabPage6 As TabPage
    Friend WithEvents SSTab1TabPage7 As TabPage
    Friend WithEvents txt30GyIrrDate As TextBox
    Friend WithEvents txt8GyIrrDate As TextBox
    Friend WithEvents FrmStdSet269 As GroupBox
    Friend WithEvents TxtStdAvgRdg287 As TextBox
    Friend WithEvents TxtStdStdDev300 As TextBox
    Friend WithEvents BtnAddStdCapsule313 As Button
    Friend WithEvents BtnEditStdCapsule322 As Button
    Friend WithEvents BtnDeleteStdCapsule331 As Button
    Friend WithEvents TxtStdSetToFirst340 As TextBox
    Friend WithEvents GrdStdCapsules449 As DataGridView
    Friend WithEvents LblStdAvgRdg459 As Label
    Friend WithEvents LblStdStdDev477 As Label
    Friend WithEvents LblStdSetToFirst495 As Label
    Friend WithEvents Label37513 As Label
    Friend WithEvents FrmStdSet532 As GroupBox
    Friend WithEvents BtnEditStdCapsule550 As Button
    Friend WithEvents BtnAddStdCapsule559 As Button
    Friend WithEvents TxtStdStdDev568 As TextBox
    Friend WithEvents TxtStdAvgRdg581 As TextBox
    Friend WithEvents BtnDeleteStdCapsule594 As Button
    Friend WithEvents GrdStdCapsules699 As DataGridView
    Friend WithEvents LblStdStdDev709 As Label
    Friend WithEvents LblStdAvgRdg727 As Label
    Friend WithEvents Label37745 As Label
    Friend WithEvents FrmStdSet764 As GroupBox
    Friend WithEvents TxtStdSetToFirst782 As TextBox
    Friend WithEvents BtnDeleteStdCapsule795 As Button
    Friend WithEvents BtnEditStdCapsule804 As Button
    Friend WithEvents BtnAddStdCapsule813 As Button
    Friend WithEvents TxtStdStdDev822 As TextBox
    Friend WithEvents TxtStdAvgRdg835 As TextBox
    Friend WithEvents GrdStdCapsules944 As DataGridView
    Friend WithEvents Label37954 As Label
    Friend WithEvents LblStdSetToFirst972 As Label
    Friend WithEvents LblStdStdDev990 As Label
    Friend WithEvents LblStdAvgRdg1008 As Label
    Friend WithEvents FrmStdSet1027 As GroupBox
    Friend WithEvents BtnDeleteStdCapsule1045 As Button
    Friend WithEvents TxtStdAvgRdg1054 As TextBox
    Friend WithEvents TxtStdStdDev1067 As TextBox
    Friend WithEvents BtnAddStdCapsule1080 As Button
    Friend WithEvents BtnEditStdCapsule1089 As Button
    Friend WithEvents GrdStdCapsules1194 As DataGridView
    Friend WithEvents Label371204 As Label
    Friend WithEvents LblStdAvgRdg1222 As Label
    Friend WithEvents LblStdStdDev1240 As Label
    Friend WithEvents lstPhysicists As ListBox
    Friend WithEvents FrmCtlSet1319 As GroupBox
    Friend WithEvents TxtCtlAvgRdg1337 As TextBox
    Friend WithEvents TxtCtlStdDev1350 As TextBox
    Friend WithEvents BtnAddCtlCapsule1363 As Button
    Friend WithEvents BtnEditCtlCapsule1372 As Button
    Friend WithEvents BtnDeleteCtlCapsule1381 As Button
    Friend WithEvents GrdCtlCapsules1486 As DataGridView
    Friend WithEvents LblCtlAvgRdg1496 As Label
    Friend WithEvents LblCtlStdDev1514 As Label
    Friend WithEvents Label381532 As Label
    Friend WithEvents FrmStdSet1551 As GroupBox
    Friend WithEvents BtnEditStdCapsule1569 As Button
    Friend WithEvents BtnAddStdCapsule1578 As Button
    Friend WithEvents TxtStdStdDev1587 As TextBox
    Friend WithEvents TxtStdAvgRdg1600 As TextBox
    Friend WithEvents BtnDeleteStdCapsule1613 As Button
    Friend WithEvents GrdStdCapsules1718 As DataGridView
    Friend WithEvents LblStdStdDev1728 As Label
    Friend WithEvents LblStdAvgRdg1746 As Label
    Friend WithEvents Label371764 As Label
    Friend WithEvents FrmCtlSet1783 As GroupBox
    Friend WithEvents BtnEditCtlCapsule1801 As Button
    Friend WithEvents BtnAddCtlCapsule1810 As Button
    Friend WithEvents TxtCtlSetToFirst1819 As TextBox
    Friend WithEvents TxtCtlStdDev1832 As TextBox
    Friend WithEvents TxtCtlAvgRdg1845 As TextBox
    Friend WithEvents BtnDeleteCtlCapsule1858 As Button
    Friend WithEvents GrdCtlCapsules1963 As DataGridView
    Friend WithEvents LblCtlSetToFirst1973 As Label
    Friend WithEvents LblCtlStdDev1991 As Label
    Friend WithEvents LblCtlAvgRdg2009 As Label
    Friend WithEvents Label382027 As Label
    Friend WithEvents FrmCtlSet2046 As GroupBox
    Friend WithEvents BtnEditCtlCapsule2064 As Button
    Friend WithEvents BtnAddCtlCapsule2073 As Button
    Friend WithEvents TxtCtlSetToFirst2082 As TextBox
    Friend WithEvents TxtCtlStdDev2095 As TextBox
    Friend WithEvents TxtCtlAvgRdg2108 As TextBox
    Friend WithEvents BtnDeleteCtlCapsule2121 As Button
    Friend WithEvents GrdCtlCapsules2226 As DataGridView
    Friend WithEvents LblCtlSetToFirst2236 As Label
    Friend WithEvents LblCtlStdDev2254 As Label
    Friend WithEvents LblCtlAvgRdg2272 As Label
    Friend WithEvents Label382290 As Label
    Friend WithEvents FrmCtlSet2309 As GroupBox
    Friend WithEvents BtnEditCtlCapsule2327 As Button
    Friend WithEvents BtnAddCtlCapsule2336 As Button
    Friend WithEvents TxtCtlSetToFirst2345 As TextBox
    Friend WithEvents TxtCtlStdDev2358 As TextBox
    Friend WithEvents TxtCtlAvgRdg2371 As TextBox
    Friend WithEvents BtnDeleteCtlCapsule2384 As Button
    Friend WithEvents GrdCtlCapsules2489 As DataGridView
    Friend WithEvents LblCtlSetToFirst2499 As Label
    Friend WithEvents LblCtlStdDev2517 As Label
    Friend WithEvents LblCtlAvgRdg2535 As Label
    Friend WithEvents Label382553 As Label
    Friend WithEvents FrmCtlSet2572 As GroupBox
    Friend WithEvents BtnEditCtlCapsule2590 As Button
    Friend WithEvents BtnAddCtlCapsule2599 As Button
    Friend WithEvents TxtCtlSetToFirst2608 As TextBox
    Friend WithEvents TxtCtlStdDev2621 As TextBox
    Friend WithEvents TxtCtlAvgRdg2634 As TextBox
    Friend WithEvents BtnDeleteCtlCapsule2647 As Button
    Friend WithEvents GrdCtlCapsules2752 As DataGridView
    Friend WithEvents LblCtlSetToFirst2762 As Label
    Friend WithEvents LblCtlStdDev2780 As Label
    Friend WithEvents LblCtlAvgRdg2798 As Label
    Friend WithEvents Label382816 As Label
    Friend WithEvents FrmStdSet2835 As GroupBox
    Friend WithEvents TxtStdAvgRdg2853 As TextBox
    Friend WithEvents TxtStdStdDev2866 As TextBox
    Friend WithEvents BtnAddStdCapsule2879 As Button
    Friend WithEvents BtnEditStdCapsule2888 As Button
    Friend WithEvents BtnDeleteStdCapsule2897 As Button
    Friend WithEvents TxtStdSetToFirst2906 As TextBox
    Friend WithEvents GrdStdCapsules3015 As DataGridView
    Friend WithEvents LblStdAvgRdg3025 As Label
    Friend WithEvents LblStdStdDev3043 As Label
    Friend WithEvents LblStdSetToFirst3061 As Label
    Friend WithEvents Label373079 As Label
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents Text3 As TextBox
    Friend WithEvents Text5 As TextBox
    Friend WithEvents BtnToggleFifthControlSet As Button
    Friend WithEvents BtnPrintTLDSessionCheckSheet As Button
    Friend WithEvents Frame1 As GroupBox
    Friend WithEvents Text7 As TextBox
    Friend WithEvents Text4 As TextBox
    Friend WithEvents Text9 As TextBox
    Friend WithEvents Text12 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Frame2 As GroupBox
    Friend WithEvents Text8 As TextBox
    Friend WithEvents Text10 As TextBox
    Friend WithEvents Text11 As TextBox
    Friend WithEvents Text13 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents BtnPrintSessionSummaryReport As Button
    Friend WithEvents cmdAccept As Button
    Friend WithEvents Frame9 As GroupBox
    Friend WithEvents txtComment As TextBox
    Friend WithEvents GrdComments As DataGridView
    Friend WithEvents cmdDeleteComment As Button
    Friend WithEvents cmdEditComment As Button
    Friend WithEvents cmdAddComment As Button
    Friend WithEvents GrdSessionSummary As DataGridView
    Friend WithEvents LstBatches As ListBox
    Friend WithEvents lbl30GyStds As Label
    Friend WithEvents lbl8GyStds As Label
    Friend WithEvents LblStdAvgAccReadings3690 As Label
    Friend WithEvents Label403708 As Label
    Friend WithEvents LblStdAvgAccReadings3726 As Label
    Friend WithEvents Label403744 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents LblStdDose As Label
    Friend WithEvents LblCtlDose As Label
    Friend WithEvents LblStdCtlDose As Label
    Friend WithEvents LblStdDecay As Label
    Friend WithEvents LblCtlDecay As Label
    Friend WithEvents LblStdCtlDecay As Label
    Friend WithEvents LblStdExpectedDose As Label
    Friend WithEvents LblCtlExpectedDose As Label
    Friend WithEvents LblStdCtlExpectedDose As Label
    Friend WithEvents LblStdAvgRdg4201 As Label
    Friend WithEvents LblStdFading As Label
    Friend WithEvents LblStdLinearity As Label
    Friend WithEvents LblStdSensitivity As Label
    Friend WithEvents LblCtlAvgRdg4246 As Label
    Friend WithEvents LblCtlFading As Label
    Friend WithEvents LblCtlLinearity As Label
    Friend WithEvents LblCtlSensitivity As Label
    Friend WithEvents LblMeasDose As Label
    Friend WithEvents LblMeasDoseExpDose As Label
    Friend WithEvents LblInitSensitivity As Label
    Friend WithEvents LblFinalSensitivity As Label
    Friend WithEvents LblNumSamples As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents LblCtlAvgAccReadings As Label
    Friend WithEvents Label404464 As Label
    Friend WithEvents LblStdAvgAccReadings4482 As Label
    Friend WithEvents LblSessionTolerance As Label
    Friend WithEvents TxtAccepted As Label
End Class
