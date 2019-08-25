using System;

namespace component
{
    partial class login
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
            this.loginContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loginContent.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginContent
            // 
            this.loginContent.BackColor = System.Drawing.Color.White;
            this.loginContent.Controls.Add(this.label1);
            this.loginContent.Controls.Add(this.button1);
            this.loginContent.Controls.Add(this.passwordPanel);
            this.loginContent.Controls.Add(this.usernamePanel);
            this.loginContent.Location = new System.Drawing.Point(268, 78);
            this.loginContent.Name = "loginContent";
            this.loginContent.Size = new System.Drawing.Size(339, 365);
            this.loginContent.TabIndex = 0;
            this.loginContent.Paint += new System.Windows.Forms.PaintEventHandler(this.loginContent_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(94, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(69, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.passwordPanel.Controls.Add(this.passTextBox);
            this.passwordPanel.Location = new System.Drawing.Point(69, 213);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(200, 50);
            this.passwordPanel.TabIndex = 1;
            // 
            // passTextBox
            // 
            this.passTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.ForeColor = System.Drawing.Color.Gray;
            this.passTextBox.Location = new System.Drawing.Point(0, 16);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(200, 17);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.Text = "Password";
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.usernamePanel.Controls.Add(this.userTextBox);
            this.usernamePanel.Location = new System.Drawing.Point(69, 144);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(200, 50);
            this.usernamePanel.TabIndex = 0;
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.Color.Gray;
            this.userTextBox.Location = new System.Drawing.Point(3, 16);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(194, 17);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.Text = "Username";
            this.userTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(729, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "Form1";
            this.loginContent.ResumeLayout(false);
            this.loginContent.PerformLayout();
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button button2;
    }
}

