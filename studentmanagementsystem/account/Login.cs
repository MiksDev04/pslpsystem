using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem.account
{
    public partial class Login : Form
    {
        private Form1 form1;

        public Login(Form1 form1)
        {
            InitializeComponent();
            RoundedCornersHelper.ApplyRoundedCorners(LoginUsername, 12);
            RoundedCornersHelper.ApplyRoundedCorners(LoginPassword, 12);
            RoundedCornersHelper.ApplyRoundedCorners(LoginBtn, 12);
            this.form1 = form1;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginUsername.Text != "" && LoginPassword.Text != "")
            {
                Main main = new Main();
                main.Show();
                form1.Hide();
            }
            else
            {
                MessageBox.Show("Enter username and password to continue", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GoToRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(form1)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            form1.FormPnl.Controls.Clear();
            form1.FormPnl.Controls.Add(register);
            register.Show();
        }
    }
}
