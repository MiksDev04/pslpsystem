﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.account
{
    public partial class Register : Form
    {
        private Form1 form1;

        public Register(Form1 form1)
        {
            InitializeComponent();
            RoundedCornersHelper.ApplyRoundedCorners(RegisterUsername, 12);
            RoundedCornersHelper.ApplyRoundedCorners(RegisterPassword, 12);
            RoundedCornersHelper.ApplyRoundedCorners(RegisterConfirmPassword, 12);
            RoundedCornersHelper.ApplyRoundedCorners(RegisterBtn, 12);
            this.form1 = form1;
        }
        SQLQueries queries = new SQLQueries();

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string Username = RegisterUsername.Text;
            string Password = RegisterPassword.Text;
            string ConfirmPassword = RegisterConfirmPassword.Text;
            if (Username != "" && Password != "" && ConfirmPassword != "")
            {
                if (Password != ConfirmPassword)
                {
                    MessageBox.Show("Please make sure to confirm the password properly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    queries.AddUserAccount(Username, Password);
                    MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginFormOpen();
                }
            } else
            {
                MessageBox.Show("Enter username and password to continue", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginFormOpen()
        {
            Login login = new Login(form1)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            form1.FormPnl.Controls.Clear();
            form1.FormPnl.Controls.Add(login);
            login.Show();
        }

        private void GoToLogin_Click(object sender, EventArgs e)
        {
            LoginFormOpen();
        }
    }
}
