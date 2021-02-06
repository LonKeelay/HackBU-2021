
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
<<<<<<< HEAD:HackBU 2021/loginForm.Designer.cs
            this.lblUser.Location = new System.Drawing.Point(12, 15);
=======
            this.lblUser.Location = new System.Drawing.Point(17, 17);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
>>>>>>> 8c289ca91e6e4f3e91802998d29abc70a1dbb79c:HackBU 2021/Form1.Designer.cs
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
<<<<<<< HEAD:HackBU 2021/loginForm.Designer.cs
            this.lblPass.Location = new System.Drawing.Point(12, 43);
=======
            this.lblPass.Location = new System.Drawing.Point(17, 46);
            this.lblPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
>>>>>>> 8c289ca91e6e4f3e91802998d29abc70a1dbb79c:HackBU 2021/Form1.Designer.cs
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(56, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password:";
            // 
            // txtUser
            // 
<<<<<<< HEAD:HackBU 2021/loginForm.Designer.cs
            this.txtUser.Location = new System.Drawing.Point(95, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 22);
=======
            this.txtUser.Location = new System.Drawing.Point(80, 15);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(184, 20);
>>>>>>> 8c289ca91e6e4f3e91802998d29abc70a1dbb79c:HackBU 2021/Form1.Designer.cs
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
<<<<<<< HEAD:HackBU 2021/loginForm.Designer.cs
            this.txtPass.Location = new System.Drawing.Point(95, 40);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(194, 22);
            this.txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(15, 68);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(274, 28);
            this.btnLogin.TabIndex = 4;
=======
            this.txtPass.Location = new System.Drawing.Point(80, 44);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(184, 20);
            this.txtPass.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 82);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(119, 27);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(146, 82);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 27);
            this.btnLogin.TabIndex = 5;
>>>>>>> 8c289ca91e6e4f3e91802998d29abc70a1dbb79c:HackBU 2021/Form1.Designer.cs
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD:HackBU 2021/loginForm.Designer.cs
            this.ClientSize = new System.Drawing.Size(303, 109);
=======
            this.ClientSize = new System.Drawing.Size(283, 126);
>>>>>>> 8c289ca91e6e4f3e91802998d29abc70a1dbb79c:HackBU 2021/Form1.Designer.cs
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
<<<<<<< HEAD:HackBU 2021/loginForm.Designer.cs
            this.Name = "frmLogin";
=======
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
>>>>>>> 8c289ca91e6e4f3e91802998d29abc70a1dbb79c:HackBU 2021/Form1.Designer.cs
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.KeyPreview = true;

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