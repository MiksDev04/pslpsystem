using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using studentmanagementsystem.content;

namespace studentmanagementsystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadContentPnl(new Dashboard(), DashboardBtn);
        }

        private void LoadContentPnl(Form form, Guna2TileButton btn)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MainPnl.Controls.Clear();
            MainPnl.Controls.Add(form);
            form.Show();
            ActivePnl.Height = btn.Height;
            ActivePnl.Top = btn.Top;

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            LoadContentPnl(new Dashboard(), DashboardBtn);
        }

        private void RecordsBtn_Click(object sender, EventArgs e)
        {
            LoadContentPnl(new Records(), RecordsBtn);
        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {
            LoadContentPnl(new Course(), CourseBtn);
        }

        private void SkillsBtn_Click(object sender, EventArgs e)
        {
            LoadContentPnl(new Skills(), SkillsBtn);
        }

        private void ManageBtn_Click(object sender, EventArgs e)
        {
            LoadContentPnl(new Manage(), ManageBtn);
        }

        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            LoadContentPnl(new Profile(), ProfileBtn);
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
