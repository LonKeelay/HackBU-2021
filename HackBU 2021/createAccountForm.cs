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
            string password2 = txtPass2.Text;
            if(password.Equals(password2)) //check if two passwords match
            {
                string stuff = "Username: " + username + " Password: " + password;
                //System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteLines.txt", stuff); //save us and ps to txt file
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt", true))
                {
                    file.WriteLine(stuff);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again. >:(");    
            }
        }

        private bool passMatchesConstraints(string password) //when we want to add constraints to password like requiring # and caps
        {
            return true;
        }
    }
}
