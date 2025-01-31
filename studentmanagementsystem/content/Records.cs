using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.content
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();

        }
        SQLQueries queries = new SQLQueries();
        private void Records_Load(object sender, EventArgs e)
        {
            StudentDepartment.SelectedItem = "All";
            StudentProgram.SelectedItem = "All";
            StudentYearLevel.SelectedItem = "All";
            StudentSex.SelectedItem = "All";
            StudentStatus.SelectedItem = "All";
            LoadPersonalInformation();
        }

        private void LoadPersonalInformation()
        {
            try
            {
                string department = StudentDepartment.SelectedItem.ToString();
                string yearLevel = StudentYearLevel.SelectedItem.ToString();
                string program = StudentProgram.SelectedItem.ToString();
                string sex = StudentSex.SelectedItem.ToString();
                string status = StudentStatus.SelectedItem.ToString();
                PersonalInformationRecords.DataSource = queries.LoadDBContent(department, yearLevel, program, sex, status, "Active");
                ulong totalrecords = queries.ToTalRecords(department, yearLevel, program, sex, status, "Active");
                TotalRecords.Text = "Total Records: " + totalrecords.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StudentProgram.Items.Clear();
            StudentProgram.Items.Add("All");
            StudentProgram.SelectedItem = "All";
            string departmentSelected = StudentDepartment.SelectedItem.ToString();
            switch (departmentSelected)
            {
                case "All":
                    StudentProgram.Items.Add("BSIE");
                    StudentProgram.Items.Add("BSCPE");
                    StudentProgram.Items.Add("BSN");
                    StudentProgram.Items.Add("BPED");
                    StudentProgram.Items.Add("BEED");
                    StudentProgram.Items.Add("BSED");
                    StudentProgram.Items.Add("BSAIS");
                    StudentProgram.Items.Add("BSMA");
                    StudentProgram.Items.Add("BSA");
                    StudentProgram.Items.Add("BSIT");
                    StudentProgram.Items.Add("BSIS");
                    StudentProgram.Items.Add("BPA");
                    StudentProgram.Items.Add("BSECO");
                    StudentProgram.Items.Add("BSPOLSCI");
                    StudentProgram.Items.Add("BPSY");
                    StudentProgram.Items.Add("BSCOM");
                    StudentProgram.Items.Add("BSHM");
                    StudentProgram.Items.Add("BSTM");
                    break;
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
                    StudentProgram.Items.Add("BSPSY");
                    StudentProgram.Items.Add("BSCOM");
                    break;
                case "CTHM":
                    StudentProgram.Items.Add("BSHM");
                    StudentProgram.Items.Add("BSTM");
                    break;
            }
            LoadPersonalInformation();
        }

        private void StudentYearLevel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPersonalInformation();
        }

        private void StudentProgram_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPersonalInformation();
        }

        private void StudentStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPersonalInformation();
        }

        private void StudentSex_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPersonalInformation();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            PersonalInformationRecords.DataSource = queries.SearchRecord(SearchInput.Text);
        }

        private void ViewMoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = PersonalInformationRecords.SelectedRows[0].Cells[0].Value.ToString();
                string[] studentRecords = queries.ViewStudentInformation(id);
                DataTable courseRecords = queries.ViewCourseInformation(id);
                string skillRecords = queries.ViewSkillInformation(id);
                ViewRecord viewRecord = new ViewRecord(studentRecords, courseRecords, skillRecords);

                viewRecord.Show();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
