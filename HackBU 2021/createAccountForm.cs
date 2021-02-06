using System;
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
    public partial class frmCreateAcc : Form
    {
        public frmCreateAcc()
        {
            InitializeComponent();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            string[] stuff = {username, password};
            System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", stuff);
            frmPass pass = new frmPass();
            pass.Show();
        }
    }
}
