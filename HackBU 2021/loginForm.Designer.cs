﻿
namespace HackBU_2021
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(17, 17);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Location = new System.Drawing.Point(12, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(16, 53);
            this.lblPass.Location = new System.Drawing.Point(12, 43);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(73, 17);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // txtUser
            this.txtUser.Location = new System.Drawing.Point(127, 15);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Location = new System.Drawing.Point(95, 12);
            this.txtUser.Size = new System.Drawing.Size(257, 22);
            this.txtUser.Size = new System.Drawing.Size(194, 22);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            this.txtPass.Location = new System.Drawing.Point(127, 49);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Location = new System.Drawing.Point(95, 40);
            this.txtPass.Size = new System.Drawing.Size(257, 22);
            this.txtPass.Size = new System.Drawing.Size(194, 22);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(20, 84);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Location = new System.Drawing.Point(15, 68);
            this.btnLogin.Size = new System.Drawing.Size(365, 34);
            this.btnLogin.Size = new System.Drawing.Size(274, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(404, 134);
            this.ClientSize = new System.Drawing.Size(303, 109);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        public event System.Windows.Forms.KeyEventHandler KeyDown;
        
    }
}