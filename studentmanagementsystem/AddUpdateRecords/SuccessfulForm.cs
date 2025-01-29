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

namespace studentmanagementsystem.AddUpdateRecords
{
    public partial class SuccessfulForm : Form
    {

        private string[] studentRecord;
        private DataTable courseRecord;
        private string skillRecord;
        public SuccessfulForm(string[] studentRecord, DataTable courseRecord, string skillRecord)
        {
            InitializeComponent();
            this.studentRecord = studentRecord;
            this.courseRecord = courseRecord;
            this.skillRecord = skillRecord;
        }
        SQLQueries queries = new SQLQueries();
        private void SuccessfulForm_Load(object sender, EventArgs e)
        {
            AddUpdateProgressBar.Value = 100;
            StudentID.Text += studentRecord[0];
            FullName.Text += studentRecord[1];
            Age.Text += studentRecord[2];
            Sex.Text += studentRecord[3];
            Birthdate.Text += studentRecord[4];
            Address.Text += studentRecord[5];
            Email.Text += studentRecord[6];
            PhoneNumber.Text += studentRecord[7];
            YearLevel.Text += studentRecord[8];
            Section.Text += studentRecord[9];
            Program.Text += studentRecord[10];
            Department.Text += studentRecord[11];
            Status.Text += studentRecord[12];
            ViewCourseInformation.DataSource = courseRecord;
            SkillSets.Text = skillRecord;
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            Manage.dataGrid.DataSource = queries.LoadDBContent("All", "All", "All", "All", "All", "Active");
            ulong totalrecords = queries.ToTalRecords("All", "All", "All", "All", "All", "Active");
            Manage.totalrecords.Text = "Total Records: " + totalrecords.ToString();
            this.Hide();
        }
    }
}
