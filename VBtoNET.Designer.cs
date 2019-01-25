namespace VBtoNET
{
    partial class VBtoNET
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDataBinding = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.rtbNET = new System.Windows.Forms.RichTextBox();
            this.rtbVB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFixedSQL = new System.Windows.Forms.TextBox();
            this.btnFixSQL = new System.Windows.Forms.Button();
            this.txtFixSQL = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDeleteControlType = new System.Windows.Forms.ComboBox();
            this.txtDeleteControlText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteDesigner = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbControlType = new System.Windows.Forms.ComboBox();
            this.txtAddControlText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddToDesigner = new System.Windows.Forms.Button();
            this.btnAddText = new System.Windows.Forms.Button();
            this.txtAddText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnRemoveText = new System.Windows.Forms.Button();
            this.txtRemoveText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSubforms = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnDataBinding);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnCopyToClipboard);
            this.tabPage1.Controls.Add(this.txtFormName);
            this.tabPage1.Controls.Add(this.rtbNET);
            this.tabPage1.Controls.Add(this.rtbVB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Designer Fix";
            // 
            // btnDataBinding
            // 
            this.btnDataBinding.Location = new System.Drawing.Point(718, 509);
            this.btnDataBinding.Name = "btnDataBinding";
            this.btnDataBinding.Size = new System.Drawing.Size(104, 23);
            this.btnDataBinding.TabIndex = 20;
            this.btnDataBinding.Text = "Copy DataBinding";
            this.btnDataBinding.UseVisualStyleBackColor = true;
            this.btnDataBinding.Click += new System.EventHandler(this.btnDataBinding_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(828, 508);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Copy Code to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(427, 508);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(115, 23);
            this.btnCopyToClipboard.TabIndex = 17;
            this.btnCopyToClipboard.Text = "Copy to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(270, 511);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(100, 20);
            this.txtFormName.TabIndex = 16;
            // 
            // rtbNET
            // 
            this.rtbNET.Location = new System.Drawing.Point(108, 235);
            this.rtbNET.Name = "rtbNET";
            this.rtbNET.Size = new System.Drawing.Size(730, 271);
            this.rtbNET.TabIndex = 11;
            this.rtbNET.Text = "";
            // 
            // rtbVB
            // 
            this.rtbVB.Location = new System.Drawing.Point(108, 3);
            this.rtbVB.Name = "rtbVB";
            this.rtbVB.Size = new System.Drawing.Size(730, 213);
            this.rtbVB.TabIndex = 10;
            this.rtbVB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Form Name";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(27, 508);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 14;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NET Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "VB Code";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 563);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.txtFixedSQL);
            this.tabPage2.Controls.Add(this.btnFixSQL);
            this.tabPage2.Controls.Add(this.txtFixSQL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fix SQL";
            // 
            // txtFixedSQL
            // 
            this.txtFixedSQL.Location = new System.Drawing.Point(86, 269);
            this.txtFixedSQL.Multiline = true;
            this.txtFixedSQL.Name = "txtFixedSQL";
            this.txtFixedSQL.Size = new System.Drawing.Size(719, 207);
            this.txtFixedSQL.TabIndex = 2;
            // 
            // btnFixSQL
            // 
            this.btnFixSQL.Location = new System.Drawing.Point(73, 504);
            this.btnFixSQL.Name = "btnFixSQL";
            this.btnFixSQL.Size = new System.Drawing.Size(75, 23);
            this.btnFixSQL.TabIndex = 1;
            this.btnFixSQL.Text = "Fix SQL";
            this.btnFixSQL.UseVisualStyleBackColor = true;
            this.btnFixSQL.Click += new System.EventHandler(this.btnFixSQL_Click);
            // 
            // txtFixSQL
            // 
            this.txtFixSQL.Location = new System.Drawing.Point(73, 37);
            this.txtFixSQL.Multiline = true;
            this.txtFixSQL.Name = "txtFixSQL";
            this.txtFixSQL.Size = new System.Drawing.Size(733, 202);
            this.txtFixSQL.TabIndex = 0;
            this.txtFixSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFixSQL_KeyDown);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cmbDeleteControlType);
            this.tabPage3.Controls.Add(this.txtDeleteControlText);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnDeleteDesigner);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cmbControlType);
            this.tabPage3.Controls.Add(this.txtAddControlText);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnAddToDesigner);
            this.tabPage3.Controls.Add(this.btnAddText);
            this.tabPage3.Controls.Add(this.txtAddText);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtPath);
            this.tabPage3.Controls.Add(this.lblPath);
            this.tabPage3.Controls.Add(this.btnRemoveText);
            this.tabPage3.Controls.Add(this.txtRemoveText);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(947, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add/Remove Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Control type";
            // 
            // cmbDeleteControlType
            // 
            this.cmbDeleteControlType.FormattingEnabled = true;
            this.cmbDeleteControlType.Items.AddRange(new object[] {
            "ComboBox",
            "ListBox",
            "TextBox",
            "Label",
            "RadioButton",
            "GroupBox",
            "DataGridView"});
            this.cmbDeleteControlType.Location = new System.Drawing.Point(210, 366);
            this.cmbDeleteControlType.Name = "cmbDeleteControlType";
            this.cmbDeleteControlType.Size = new System.Drawing.Size(121, 21);
            this.cmbDeleteControlType.TabIndex = 16;
            // 
            // txtDeleteControlText
            // 
            this.txtDeleteControlText.Location = new System.Drawing.Point(210, 393);
            this.txtDeleteControlText.Name = "txtDeleteControlText";
            this.txtDeleteControlText.Size = new System.Drawing.Size(505, 20);
            this.txtDeleteControlText.TabIndex = 15;
            this.txtDeleteControlText.Text = ".AutoCompleteMode = System.Windows.Forms.AutoCompleteModeAppend";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Delete Text";
            // 
            // btnDeleteDesigner
            // 
            this.btnDeleteDesigner.Location = new System.Drawing.Point(217, 419);
            this.btnDeleteDesigner.Name = "btnDeleteDesigner";
            this.btnDeleteDesigner.Size = new System.Drawing.Size(84, 34);
            this.btnDeleteDesigner.TabIndex = 13;
            this.btnDeleteDesigner.Text = "Delete From Designer";
            this.btnDeleteDesigner.UseVisualStyleBackColor = true;
            this.btnDeleteDesigner.Click += new System.EventHandler(this.btnDeleteDesigner_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Control type";
            // 
            // cmbControlType
            // 
            this.cmbControlType.FormattingEnabled = true;
            this.cmbControlType.Items.AddRange(new object[] {
            "ComboBox",
            "ListBox",
            "TextBox",
            "Label",
            "RadioButton",
            "GroupBox",
            "DataGridView"});
            this.cmbControlType.Location = new System.Drawing.Point(214, 251);
            this.cmbControlType.Name = "cmbControlType";
            this.cmbControlType.Size = new System.Drawing.Size(121, 21);
            this.cmbControlType.TabIndex = 11;
            // 
            // txtAddControlText
            // 
            this.txtAddControlText.Location = new System.Drawing.Point(214, 278);
            this.txtAddControlText.Name = "txtAddControlText";
            this.txtAddControlText.Size = new System.Drawing.Size(501, 20);
            this.txtAddControlText.TabIndex = 10;
            this.txtAddControlText.Text = ".AutoCompleteMode = System.Windows.Forms.AutoCompleteModeAppend";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Add Text";
            // 
            // btnAddToDesigner
            // 
            this.btnAddToDesigner.Location = new System.Drawing.Point(221, 304);
            this.btnAddToDesigner.Name = "btnAddToDesigner";
            this.btnAddToDesigner.Size = new System.Drawing.Size(84, 34);
            this.btnAddToDesigner.TabIndex = 8;
            this.btnAddToDesigner.Text = "Add To Designer";
            this.btnAddToDesigner.UseVisualStyleBackColor = true;
            this.btnAddToDesigner.Click += new System.EventHandler(this.btnAddToDesigner_Click);
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(566, 143);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(75, 23);
            this.btnAddText.TabIndex = 7;
            this.btnAddText.Text = "Add Text";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // txtAddText
            // 
            this.txtAddText.Location = new System.Drawing.Point(541, 97);
            this.txtAddText.Name = "txtAddText";
            this.txtAddText.Size = new System.Drawing.Size(100, 20);
            this.txtAddText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Add Text to Load Event";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(214, 177);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(100, 20);
            this.txtPath.TabIndex = 4;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(116, 184);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(54, 13);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Start Path";
            // 
            // btnRemoveText
            // 
            this.btnRemoveText.Location = new System.Drawing.Point(214, 129);
            this.btnRemoveText.Name = "btnRemoveText";
            this.btnRemoveText.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveText.TabIndex = 2;
            this.btnRemoveText.Text = "Remove Text";
            this.btnRemoveText.UseVisualStyleBackColor = true;
            this.btnRemoveText.Click += new System.EventHandler(this.btnRemoveText_Click);
            // 
            // txtRemoveText
            // 
            this.txtRemoveText.Location = new System.Drawing.Point(214, 90);
            this.txtRemoveText.Name = "txtRemoveText";
            this.txtRemoveText.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Remove Text";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.treeView1);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.txtSubforms);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(947, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DialogFlow";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtSubforms
            // 
            this.txtSubforms.Location = new System.Drawing.Point(67, 47);
            this.txtSubforms.Multiline = true;
            this.txtSubforms.Name = "txtSubforms";
            this.txtSubforms.Size = new System.Drawing.Size(542, 253);
            this.txtSubforms.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(661, 61);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(264, 344);
            this.treeView1.TabIndex = 2;
            // 
            // VBtoNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 580);
            this.Controls.Add(this.tabControl1);
            this.Name = "VBtoNET";
            this.Text = "VBtoNET v3.1";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.RichTextBox rtbNET;
        private System.Windows.Forms.RichTextBox rtbVB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDataBinding;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnFixSQL;
        private System.Windows.Forms.TextBox txtFixSQL;
        private System.Windows.Forms.TextBox txtFixedSQL;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnRemoveText;
        private System.Windows.Forms.TextBox txtRemoveText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.TextBox txtAddText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddToDesigner;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbControlType;
        private System.Windows.Forms.TextBox txtAddControlText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDeleteControlType;
        private System.Windows.Forms.TextBox txtDeleteControlText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteDesigner;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSubforms;
        private System.Windows.Forms.TreeView treeView1;
    }
}