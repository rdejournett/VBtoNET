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
            this.rtbVB = new System.Windows.Forms.RichTextBox();
            this.rtbNET = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbVB
            // 
            this.rtbVB.Location = new System.Drawing.Point(102, 33);
            this.rtbVB.Name = "rtbVB";
            this.rtbVB.Size = new System.Drawing.Size(730, 213);
            this.rtbVB.TabIndex = 0;
            this.rtbVB.Text = "";
            // 
            // rtbNET
            // 
            this.rtbNET.Location = new System.Drawing.Point(102, 265);
            this.rtbNET.Name = "rtbNET";
            this.rtbNET.Size = new System.Drawing.Size(730, 271);
            this.rtbNET.TabIndex = 1;
            this.rtbNET.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VB Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NET Code";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(21, 536);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Form Name";
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(237, 540);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(156, 20);
            this.txtFormName.TabIndex = 8;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(421, 540);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(147, 23);
            this.btnCopyToClipboard.TabIndex = 9;
            this.btnCopyToClipboard.Text = "Copy Results to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // VBtoNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 565);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbNET);
            this.Controls.Add(this.rtbVB);
            this.Name = "VBtoNET";
            this.Text = "VBtoNET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbVB;
        private System.Windows.Forms.RichTextBox rtbNET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.Button btnCopyToClipboard;
    }
}