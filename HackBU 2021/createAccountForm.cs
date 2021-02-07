using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HackBU_2021
{
    public partial class frmCreateAcc : Form
    {
        public ArrayList rawTimes = new ArrayList();
        public long prevTime = 0;
        public ArrayList rawTimes2 = new ArrayList();
        public long prevTime2 = 0;

        public frmCreateAcc()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
            txtPass2.PasswordChar = '*';
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            string password2 = txtPass2.Text;
            if (!usernameMatchesConstraints(username))
            {
                if (password == "")
                {
                    MessageBox.Show("Yeah nice try, noname");
                }
                else
                {
                    MessageBox.Show("Username does not fit constraints. Please try again. >:(");
                }
            }
            else if (!passMatchesConstraints(password))
            {
                if (password == "")
                {
                    MessageBox.Show("You can't just put nothing in there. You don't want a password? :/");
                }
                else
                {
                    MessageBox.Show("Password does not fit constraints. Please try again. >:(");
                    txtPass.Clear();
                    rawTimes.Clear();
                    prevTime = 0;
                    txtPass2.Clear();
                    rawTimes2.Clear();
                    prevTime2 = 0;
                }
            }
            else if (!usernameMatchesConstraints(username)) {
                if (password == "")
                {
                    MessageBox.Show("Yeah nice try, noname");
                }
                else
                {
                    MessageBox.Show("Username does not fit constraints. Please try again. >:(");
                }
            }
            else if (password.Equals(password2)) //check if two passwords match
            {
                string spaces = "";
                //set up times
                for (int i = 0; i <= rawTimes.Count - 1; i++) //add numbers like 55,33,5,2
                {
                    long average = (long)Math.Round(((long)rawTimes[i] + (long)rawTimes2[i]) / 2.0);
                    spaces += average;
                    if (i != rawTimes.Count - 1)
                    {
                        spaces += ",";
                    }
                }
                string stuff = username + " " + password;
                SQLCommands sql = new SQLCommands();
                if (sql.createUser(username, password, spaces) == 1)
                {
                    MessageBox.Show("Username already exists");
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again. >:(");
                txtPass.Clear();
                rawTimes.Clear();
                prevTime = 0;
                txtPass2.Clear();
                rawTimes2.Clear();
                prevTime2 = 0;
            }
        }

        private bool passMatchesConstraints(string password) //when we want to add constraints to password like requiring # and caps
        {
            char[] forbiddenLetters = {'\'', ';'};
            if (password.IndexOfAny(forbiddenLetters) != -1 || password.Length <= 2)
            {
                return false;
            }
            return true;
        }
        private bool usernameMatchesConstraints(string username) //when we want to add constraints to password like requiring # and caps
        {
            char[] forbiddenLetters = { '\'', ';' };
            if (username.IndexOfAny(forbiddenLetters) != -1 || username.Length <= 2)
            {
                return false;
            }
            return true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e) //event when key pressed in password
        {
            long unixTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long thisTime = 0;
            if (prevTime != 0)
            {
                thisTime = unixTime - prevTime; //this is a different format/use than either of the other ones
                rawTimes.Add(thisTime); //save times between keypresses
            }
            prevTime = unixTime;
        }
        private void txtPass2_KeyPress(object sender, KeyPressEventArgs e) //event when key pressed in password2
        {
            long unixTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long thisTime = 0;
            if (prevTime2 != 0)
            {
                thisTime = unixTime - prevTime2; //this is a different format/use than either of the other ones
                rawTimes2.Add(thisTime); //save times between keypresses
            }
            prevTime2 = unixTime;
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back || txtPass.SelectionLength > 0)
            {
                MessageBox.Show("no typos! gotta power through like a real computer scientist");
                txtPass.Clear();
                rawTimes.Clear();
                prevTime = 0;
            }
        }
        private void txtPass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || txtPass2.SelectionLength > 0)
            {
                MessageBox.Show("no typos! gotta power through like a real computer scientist");
                txtPass2.Clear();
                rawTimes2.Clear();
                prevTime2 = 0;
            }
        }
    }
}
