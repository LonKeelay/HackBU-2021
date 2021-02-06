
namespace HackBU_2021
{
    partial class frmCreateAcc
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.lblPass2 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(130, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(206, 22);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(130, 43);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(206, 22);
            this.txtPass.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 17);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(12, 43);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(73, 17);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Password:";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(12, 100);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(324, 29);
            this.btnCreateAcc.TabIndex = 8;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // lblPass2
            // 
            this.lblPass2.AutoSize = true;
            this.lblPass2.Location = new System.Drawing.Point(11, 72);
            this.lblPass2.Name = "lblPass2";
            this.lblPass2.Size = new System.Drawing.Size(113, 17);
            this.lblPass2.TabIndex = 10;
            this.lblPass2.Text = "Password Again:";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(130, 72);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(206, 22);
            this.txtPass2.TabIndex = 9;
            // 
            // frmCreateAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 142);
            this.Controls.Add(this.lblPass2);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Name = "frmCreateAcc";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Label lblPass2;
        private System.Windows.Forms.TextBox txtPass2;
    }
}