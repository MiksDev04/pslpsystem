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
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.content
{
    public partial class Dashboard : Form
    {
        private Main main;
        public Dashboard(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        SQLQueries queries = new SQLQueries();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LastAddedStudents.DataSource = queries.LastAddedStudentRecords();
            TotalStudents.Text = queries.ToTalRecords("All", "All", "All", "All", "All", "Active").ToString();

        }
        private void LoadContentPnl(Form form, Guna2TileButton btn)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.Fill;
            main.MainPnl.Controls.Clear();
            main.MainPnl.Controls.Add(form);
            form.Show();
            main.ActivePnl.Height = btn.Height;
            main.ActivePnl.Top = btn.Top;
        }


        private void GoToRecords(object sender, EventArgs e)
        {
            LoadContentPnl(new Records(), main.RecordsBtn);
        }

        private void GoToCourses(object sender, EventArgs e)
        {
            LoadContentPnl(new Department(main), main.DepartmentBtn);
        }

        private void GoToSkills(object sender, EventArgs e)
        {
            LoadContentPnl(new Skills(), main.SkillsBtn);

        }

      
    }
}
