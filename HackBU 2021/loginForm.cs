﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackBU_2021
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUser.KeyPress += txtUser_KeyPress;
        }

<<<<<<< HEAD:HackBU 2021/loginForm.cs
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
=======

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");//this goes away soon
                e.Handled = true;

            }
        }

>>>>>>> 8c289ca91e6e4f3e91802998d29abc70a1dbb79c:HackBU 2021/Form1.cs
    }
}
