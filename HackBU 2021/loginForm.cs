﻿using System;
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
    public partial class frmLogin : Form
    {
        public ArrayList rawTimes = new ArrayList();
        public static int chance;
        public long[] fixedTimes;
        public long prevTime = 0;
        public frmLogin()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SQLCommands sql = new SQLCommands();
            string username = txtUser.Text;
            string password = txtPass.Text;
            string stuff = username + " " + password;
            string spaces = "";
            for (int i = 0; i <= rawTimes.Count - 1; i++) //add numbers like 55,33,5,2
            {
                spaces += rawTimes[i];
                if (i != rawTimes.Count - 1)
                {
                    spaces += ",";
                }
            }
            chance = sql.login(username, password, spaces);
            bool passed = chance >= -1;
            if (passed)
            {
                frmAccount account = new frmAccount();
                account.Show(); // need to pass info later!!
                Close();
            }
            else
            {
                switch (sql.login(username, password, spaces))
                {
                    case -2:
                        MessageBox.Show("We don't have that username. Make an account, loser.");
                        break;
                    case -3:
                        MessageBox.Show("Your password is incorrect.");
                        rawTimes.Clear();
                        prevTime = 0;
                        this.txtPass.Clear(); //needed this
                        break;
                    case -4:
                        MessageBox.Show("Your password doesn't have the right timing....  :(");
                        rawTimes.Clear();
                        prevTime = 0;
                        this.txtPass.Clear();
                        break;
                    default:
                        MessageBox.Show("something default went wrong (STOP BREAKING OUR PROGRAM!!!)");
                        break;
                }
                
            }
        }
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            long unixTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long thisTime = 0;
            if (prevTime != 0)
            {
                thisTime = unixTime - prevTime; //this is a different format/use than either of the other ones
                rawTimes.Add(thisTime);
            }
            prevTime = unixTime;
        }
        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || txtPass.SelectionLength > 0)
            {
                MessageBox.Show("no typos! gotta power through like a real computer scientist");
                txtPass.Clear();
                prevTime = 0;
                rawTimes.Clear();
            }
        }

    }
    
}
