using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//wowwwwwwwwww testing tiiiimmmmeeeeee comiiiiittttt and puuuuuuuuushhhhhhhhhh
namespace HackBU_2021
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtUser.KeyPress += txtUser_KeyPress;
        }


        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");//this goes away soon
                e.Handled = true;

            }
        }

    }
}
