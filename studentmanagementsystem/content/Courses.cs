using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Utilities.Encoders;
using studentmanagementsystem.Queries;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace studentmanagementsystem.content
{
    public partial class Courses : Form
    {
        private string department;
        public Courses(string department)
        {
            InitializeComponent();
            this.department = department;
        }

        SQLQueries queries = new SQLQueries();
        private void Courses_Load(object sender, EventArgs e)
        {
            StudentYearLevel.SelectedItem = "All";
            StudentDepartment();
            LoadCourseInformation();
        }

        private void LoadCourseInformation()
        {
            try
            {
                DepartmentLbl.Text = department + " Offered Courses";
                LoadCoursesPnl.DataSource = queries.LoadDepartmentCourses(department, StudentYearLevel.SelectedItem.ToString(), StudentProgram.SelectedItem.ToString());
                ulong totalrecords = Convert.ToUInt64(queries.TotalCourses(department, StudentYearLevel.SelectedItem.ToString(), StudentProgram.SelectedItem.ToString()));
                TotalRecords.Text = "Total Records: " + totalrecords.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentDepartment()
        {
            StudentProgram.Items.Clear();
            StudentProgram.Items.Add("All");
            StudentProgram.SelectedItem = "All";
            switch (department)
            {
                case "COE":
                    StudentProgram.Items.Add("Bachelor of Science in Computer Engineering");
                    StudentProgram.Items.Add("Bachelor of Science in Industrial Engineering");
                    break;
                case "CNAHS":
                    StudentProgram.Items.Add("Bachelor of Science in Nursing");
                    break;
                case "CHK":
                    StudentProgram.Items.Add("Bachelor of Physical Education");
                    break;
                case "CBA":
                    StudentProgram.Items.Add("Bachelor of Science in Business Administration");
                    StudentProgram.Items.Add("Bachelor of Science in Entrepreneurship");
                    StudentProgram.Items.Add("Bachelor of Science in Office Administration");
                    break;
                case "COA":
                    StudentProgram.Items.Add("Bachelor of Science in Accountancy");
                    StudentProgram.Items.Add("Bachelor of Science in Accounting Information System");
                    StudentProgram.Items.Add("Bachelor of Science in Management Accounting");
                    break;
                case "CCST":
                    StudentProgram.Items.Add("Bachelor of Science in Information Technology");
                    StudentProgram.Items.Add("Bachelor of Science in Information Systems");
                    break;
                case "CAS":
                    StudentProgram.Items.Add("Bachelor of Science in Psychology");
                    StudentProgram.Items.Add("Bachelor of Arts in Communication");
                    StudentProgram.Items.Add("Bachelor of Science in Economics");
                    StudentProgram.Items.Add("Bachelor of Public Administration");
                    StudentProgram.Items.Add("Bachelor of Arts in Political Science");
                    break;
                case "CTHM":
                    StudentProgram.Items.Add("Bachelor of Science in Hospitality Management");
                    StudentProgram.Items.Add("Bachelor of Science in Tourism Management");
                    break;
            }

            LoadCourseInformation();
        }

     

        private void StudentProgram_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourseInformation();
        }

        private void StudentYearLevel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourseInformation();
        }
    }
}
