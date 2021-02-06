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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateAcc account = new frmCreateAcc();
            account.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
