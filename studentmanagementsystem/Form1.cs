using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentmanagementsystem.account;

namespace studentmanagementsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RoundedCornersHelper.ApplyRoundedCorners(FormPnl, 20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login(this)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            FormPnl.Controls.Clear();
            FormPnl.Controls.Add(login);
            login.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
