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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //txtUser.KeyPress += txtUser_KeyPress;
        }


        /**private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");//this goes away soon
                e.Handled = true;

            }
        }*/


        private void btnLogin_Click(object sender, EventArgs e)
        {
            SQLCommands sql = new SQLCommands();
            string username = txtUser.Text;
            string password = txtPass.Text;
            string stuff = username + " " + password;
            /*
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");
            */
            bool login = sql.login(username, password, "1,2") == 0;
            if (login)
            {
                MessageBox.Show("Welcome " + username + "! You have succesfully logged in.");
            }
            else
            {
                MessageBox.Show("Your username or password is incorrect you cringe machine.");
            }
            /*
            for(int i = 0; i < lines.Length; i++)
            {
                if(lines[i].Equals(stuff))
                {
                    MessageBox.Show("Welcome " + username + "! You have succesfully logged in."); 
                    login = true;
                }
            }
            if(!login)
            {
                MessageBox.Show("Your username or password is incorrect you cringe machine."); 
            }
            */

        }
    }
}
