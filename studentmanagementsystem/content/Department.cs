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

namespace studentmanagementsystem.content
{
    public partial class Department : Form
    {
        private Main main;
        public Department(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Department_Load(object sender, EventArgs e)
        {
        }


        private void LoadCourses(string department)
        {
            Courses courses = new Courses(department)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            main.MainPnl.Controls.Clear();
            main.MainPnl.Controls.Add(courses);
            courses.Show();
        }
        private void GoToCOA(object sender, EventArgs e)
        {
            LoadCourses("COA");
            //OnBorder(COAPnl);
        }

        private void GoToCAS(object sender, EventArgs e)
        {
            LoadCourses("CAS");
            //OnBorder(CASPnl);
        }

        private void GoToCBA(object sender, EventArgs e)
        {
            LoadCourses("CBA");
            //OnBorder(CBAPnl);
        }

        private void GoToCCST(object sender, EventArgs e)
        {
            LoadCourses("CCST");
            //OnBorder(CCSTPnl);
        }

        private void GoToCOE(object sender, EventArgs e)
        {
            LoadCourses("COE");
            //OnBorder(COEPnl);
        }

        private void GoToCHK(object sender, EventArgs e)
        {
            LoadCourses("CHK");
            //OnBorder(CHKPnl);
        }

        private void GoToCNAHS(object sender, EventArgs e)
        {
            LoadCourses("CNAHS");
            //OnBorder(CNAHSPnl);
        }

        private void GoToCTHM(object sender, EventArgs e)
        {
            LoadCourses("CTHM");
            //OnBorder(CTHMPnl);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
