﻿using System;
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
                    StudentProgram.Items.Add("Bachelor of Science in Computer Engineering");
                    StudentProgram.Items.Add("Bachelor of Science in Industrial Engineering");
                    StudentProgram.Items.Add("Bachelor of Science in Nursing");
                    StudentProgram.Items.Add("Bachelor of Physical Education");
                    StudentProgram.Items.Add("Bachelor of Science in Business Administration");
                    StudentProgram.Items.Add("Bachelor of Science in Entrepreneurship");
                    StudentProgram.Items.Add("Bachelor of Science in Office Administration");
                    StudentProgram.Items.Add("Bachelor of Science in Accountancy");
                    StudentProgram.Items.Add("Bachelor of Science in Accounting Information System");
                    StudentProgram.Items.Add("Bachelor of Science in Management Accounting");
                    StudentProgram.Items.Add("Bachelor of Science in Information Technology");
                    StudentProgram.Items.Add("Bachelor of Science in Information Systems");
                    StudentProgram.Items.Add("Bachelor of Science in Psychology");
                    StudentProgram.Items.Add("Bachelor of Arts in Communication");
                    StudentProgram.Items.Add("Bachelor of Science in Economics");
                    StudentProgram.Items.Add("Bachelor of Public Administration");
                    StudentProgram.Items.Add("Bachelor of Arts in Political Science");
                    StudentProgram.Items.Add("Bachelor of Science in Hospitality Management");
                    StudentProgram.Items.Add("Bachelor of Science in Tourism Management");
                    break;
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
