namespace component
{
    partial class addDriver
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
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.licenseBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.CheckBox();
            this.nBox = new System.Windows.Forms.CheckBox();
            this.wbox = new System.Windows.Forms.CheckBox();
            this.eBox = new System.Windows.Forms.CheckBox();
            this.sBox = new System.Windows.Forms.CheckBox();
            this.numberTextBox = new component.telephoneBox(this.components);
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.logoutBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(281, 50);
            this.headerPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Driver";
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutBtn.Location = new System.Drawing.Point(747, 13);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 29);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.fnameTextBox);
            this.panel1.Location = new System.Drawing.Point(33, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 42);
            this.panel1.TabIndex = 2;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.fnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.fnameTextBox.Location = new System.Drawing.Point(3, 13);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(194, 17);
            this.fnameTextBox.TabIndex = 1;
            this.fnameTextBox.Text = "First Name";
            this.fnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.lnameTextBox);
            this.panel2.Location = new System.Drawing.Point(33, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 3;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.lnameTextBox.Location = new System.Drawing.Point(3, 13);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(194, 17);
            this.lnameTextBox.TabIndex = 1;
            this.lnameTextBox.Text = "Last Name";
            this.lnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.numberTextBox);
            this.panel3.Location = new System.Drawing.Point(33, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.Location = new System.Drawing.Point(179, 400);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 35);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBtn.Location = new System.Drawing.Point(83, 400);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 35);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // licenseBox
            // 
            this.licenseBox.AutoSize = true;
            this.licenseBox.FlatAppearance.BorderSize = 0;
            this.licenseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.licenseBox.Location = new System.Drawing.Point(43, 230);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.Size = new System.Drawing.Size(96, 17);
            this.licenseBox.TabIndex = 5;
            this.licenseBox.Text = "Driving License";
            this.licenseBox.UseVisualStyleBackColor = true;
            this.licenseBox.CheckedChanged += new System.EventHandler(this.licenseBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Geographical tests";
            // 
            // cBox
            // 
            this.cBox.AutoSize = true;
            this.cBox.FlatAppearance.BorderSize = 0;
            this.cBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBox.Location = new System.Drawing.Point(50, 275);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(95, 17);
            this.cBox.TabIndex = 7;
            this.cBox.Text = "Central London";
            this.cBox.UseVisualStyleBackColor = true;
            // 
            // nBox
            // 
            this.nBox.AutoSize = true;
            this.nBox.FlatAppearance.BorderSize = 0;
            this.nBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nBox.Location = new System.Drawing.Point(50, 298);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(88, 17);
            this.nBox.TabIndex = 8;
            this.nBox.Text = "North London";
            this.nBox.UseVisualStyleBackColor = true;
            // 
            // wbox
            // 
            this.wbox.AutoSize = true;
            this.wbox.FlatAppearance.BorderSize = 0;
            this.wbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wbox.Location = new System.Drawing.Point(50, 321);
            this.wbox.Name = "wbox";
            this.wbox.Size = new System.Drawing.Size(87, 17);
            this.wbox.TabIndex = 9;
            this.wbox.Text = "West London";
            this.wbox.UseVisualStyleBackColor = true;
            // 
            // eBox
            // 
            this.eBox.AutoSize = true;
            this.eBox.FlatAppearance.BorderSize = 0;
            this.eBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eBox.Location = new System.Drawing.Point(50, 344);
            this.eBox.Name = "eBox";
            this.eBox.Size = new System.Drawing.Size(83, 17);
            this.eBox.TabIndex = 10;
            this.eBox.Text = "East London";
            this.eBox.UseVisualStyleBackColor = true;
            // 
            // sBox
            // 
            this.sBox.AutoSize = true;
            this.sBox.FlatAppearance.BorderSize = 0;
            this.sBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sBox.Location = new System.Drawing.Point(50, 367);
            this.sBox.Name = "sBox";
            this.sBox.Size = new System.Drawing.Size(90, 17);
            this.sBox.TabIndex = 11;
            this.sBox.Text = "South London";
            this.sBox.UseVisualStyleBackColor = true;
            // 
            // numberTextBox
            // 
            this.numberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberTextBox.ForeColor = System.Drawing.Color.Black;
            this.numberTextBox.Location = new System.Drawing.Point(48, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 13);
            this.numberTextBox.TabIndex = 12;
            // 
            // addDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(281, 448);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.eBox);
            this.Controls.Add(this.wbox);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addDriver";
            this.Text = "addDriver";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox licenseBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBox;
        private System.Windows.Forms.CheckBox nBox;
        private System.Windows.Forms.CheckBox wbox;
        private System.Windows.Forms.CheckBox eBox;
        private System.Windows.Forms.CheckBox sBox;
        private telephoneBox numberTextBox;
    }
}