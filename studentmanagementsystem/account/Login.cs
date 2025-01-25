using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentmanagementsystem.content;
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.account
{
    public partial class Login : Form
    {
        private Form1 form1;

        public Login(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        SQLQueries queries = new SQLQueries();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            string Username = LoginUsername.Text;
            string Password = LoginPassword.Text;
            if (Username != "" && Password != "")
            {
                bool[] bools = queries.CheckUser(Username, Password);
                if (bools[0])
                {
                    if (bools[1])
                    {
                        main.ProfileBtn.Text = "Admin";
                        main.ManageBtn.Visible = true;
                    }
                    main.Show();
                    form1.Hide();
                } else
                {
                    MessageBox.Show("Invalid account please try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
