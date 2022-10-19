namespace NotepadCSharp.NotepadForm
{
    partial class ReplaceDialoge
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDirectionDown = new System.Windows.Forms.RadioButton();
            this.radDirectionUp = new System.Windows.Forms.RadioButton();
            this.chkMatchWholeWord = new System.Windows.Forms.CheckBox();
            this.chkMatchcase = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindText = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDirectionDown);
            this.groupBox1.Controls.Add(this.radDirectionUp);
            this.groupBox1.Location = new System.Drawing.Point(194, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 57);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // radDirectionDown
            // 
            this.radDirectionDown.AutoSize = true;
            this.radDirectionDown.Location = new System.Drawing.Point(68, 27);
            this.radDirectionDown.Name = "radDirectionDown";
            this.radDirectionDown.Size = new System.Drawing.Size(64, 21);
            this.radDirectionDown.TabIndex = 1;
            this.radDirectionDown.Text = "Down";
            this.radDirectionDown.UseVisualStyleBackColor = true;
            // 
            // radDirectionUp
            // 
            this.radDirectionUp.AutoSize = true;
            this.radDirectionUp.Checked = true;
            this.radDirectionUp.Location = new System.Drawing.Point(6, 27);
            this.radDirectionUp.Name = "radDirectionUp";
            this.radDirectionUp.Size = new System.Drawing.Size(47, 21);
            this.radDirectionUp.TabIndex = 0;
            this.radDirectionUp.TabStop = true;
            this.radDirectionUp.Text = "Up";
            this.radDirectionUp.UseVisualStyleBackColor = true;
            // 
            // chkMatchWholeWord
            // 
            this.chkMatchWholeWord.AutoSize = true;
            this.chkMatchWholeWord.Location = new System.Drawing.Point(12, 97);
            this.chkMatchWholeWord.Name = "chkMatchWholeWord";
            this.chkMatchWholeWord.Size = new System.Drawing.Size(150, 21);
            this.chkMatchWholeWord.TabIndex = 12;
            this.chkMatchWholeWord.Text = "Match Whole Word";
            this.chkMatchWholeWord.UseVisualStyleBackColor = true;
            // 
            // chkMatchcase
            // 
            this.chkMatchcase.AutoSize = true;
            this.chkMatchcase.Location = new System.Drawing.Point(12, 70);
            this.chkMatchcase.Name = "chkMatchcase";
            this.chkMatchcase.Size = new System.Drawing.Size(104, 21);
            this.chkMatchcase.TabIndex = 11;
            this.chkMatchcase.Text = "Match Case";
            this.chkMatchcase.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(394, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 26);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(394, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(105, 26);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find Next";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find What";
            // 
            // txtFindText
            // 
            this.txtFindText.Location = new System.Drawing.Point(121, 12);
            this.txtFindText.Name = "txtFindText";
            this.txtFindText.Size = new System.Drawing.Size(267, 22);
            this.txtFindText.TabIndex = 7;
            this.txtFindText.TextChanged += new System.EventHandler(this.txtFindText_TextChanged);
            this.txtFindText.Enter += new System.EventHandler(this.txtFindText_Enter);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(394, 40);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(105, 26);
            this.btnReplace.TabIndex = 16;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Replace With";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(121, 40);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(267, 22);
            this.txtReplace.TabIndex = 14;
            this.txtReplace.Enter += new System.EventHandler(this.txtReplace_Enter);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(394, 72);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(105, 26);
            this.btnReplaceAll.TabIndex = 17;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // ReplaceDialoge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 152);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMatchWholeWord);
            this.Controls.Add(this.chkMatchcase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceDialoge";
            this.ShowIcon = false;
            this.Text = "Replace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceDialoge_FormClosing);
            this.Load += new System.EventHandler(this.ReplaceDialoge_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDirectionDown;
        private System.Windows.Forms.RadioButton radDirectionUp;
        private System.Windows.Forms.CheckBox chkMatchWholeWord;
        private System.Windows.Forms.CheckBox chkMatchcase;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindText;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnReplaceAll;
    }
}