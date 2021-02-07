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
        public long[] fixedTimes;
        public long prevTime = 0;
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
            string spaces = "";
            /*
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");
            */
            for (int i = 0; i < rawTimes.Count - 1; i++) //add numbers like 55,33,5,2
            {
                spaces += rawTimes[i];
                if (i != rawTimes.Count - 1)
                {
                    spaces += ",";
                }
                //long newTime = (long)rawTimes[i+1] - (long)rawTimes[i];
                //fixedTimes.Add((long)rawTimes[i + 1] - (long)rawTimes[i]);
                System.Diagnostics.Debug.WriteLine((long)rawTimes[i + 1] - (long)rawTimes[i]);
            }
            bool login = sql.login(username, password, spaces) == 0;
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
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.KeyChar);
            long unixTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long thisTime = 0;
            if (prevTime != 0)
            {
                thisTime = unixTime - prevTime; //this is a different format/use than either of the other ones
                                                //DateTime localDate = DateTime.Now;
                rawTimes.Add(thisTime);
                System.Diagnostics.Debug.WriteLine(thisTime);

            }
            prevTime = unixTime;
        }
    }
    
}
