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
                LoadCoursesInformation.DataSource = queries.LoadDepartmentCourses(department, StudentYearLevel.SelectedItem.ToString(), StudentProgram.SelectedItem.ToString());
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
                    StudentProgram.Items.Add("BSIE");
                    StudentProgram.Items.Add("BSCPE");
                    break;
                case "CNAHS":
                    StudentProgram.Items.Add("BSN");
                    break;
                case "CHK":
                    StudentProgram.Items.Add("BPED");
                    break;
                case "CTED":
                    StudentProgram.Items.Add("BEED");
                    StudentProgram.Items.Add("BSED");
                    break;
                case "COA":
                    StudentProgram.Items.Add("BSAIS");
                    StudentProgram.Items.Add("BSMA");
                    StudentProgram.Items.Add("BSA");
                    break;
                case "CCST":
                    StudentProgram.Items.Add("BSIT");
                    StudentProgram.Items.Add("BSIS");
                    break;
                case "CAS":
                    StudentProgram.Items.Add("BPA");
                    StudentProgram.Items.Add("BSECO");
                    StudentProgram.Items.Add("BSPOLSCI");
                    StudentProgram.Items.Add("BPSY");
                    StudentProgram.Items.Add("BSCOM");
                    break;
                case "CTHM":
                    StudentProgram.Items.Add("BSHM");
                    StudentProgram.Items.Add("BSTM");
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
