namespace component
{
    partial class bookSession
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
            this.trainingTypeBox = new System.Windows.Forms.ComboBox();
            this.sessionListBox = new System.Windows.Forms.ListBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trainingTypeBox
            // 
            this.trainingTypeBox.FormattingEnabled = true;
            this.trainingTypeBox.Location = new System.Drawing.Point(26, 33);
            this.trainingTypeBox.Name = "trainingTypeBox";
            this.trainingTypeBox.Size = new System.Drawing.Size(121, 21);
            this.trainingTypeBox.TabIndex = 0;
            // 
            // sessionListBox
            // 
            this.sessionListBox.FormattingEnabled = true;
            this.sessionListBox.Location = new System.Drawing.Point(26, 89);
            this.sessionListBox.Name = "sessionListBox";
            this.sessionListBox.Size = new System.Drawing.Size(221, 95);
            this.sessionListBox.TabIndex = 1;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(172, 31);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 2;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(172, 214);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(75, 23);
            this.bookBtn.TabIndex = 3;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // bookSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.sessionListBox);
            this.Controls.Add(this.trainingTypeBox);
            this.Name = "bookSession";
            this.Text = "bookSession";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trainingTypeBox;
        private System.Windows.Forms.ListBox sessionListBox;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Label label1;
    }
}