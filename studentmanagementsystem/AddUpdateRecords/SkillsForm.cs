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
    public partial class SkillsForm : Form
    {
        string[] personalInformation;
        string[] CourseCodes;
        string[] CourseDescriptions;
        string[] Times;
        string[] Days;
        string[] Units;
        public SkillsForm(string[] personalInformation, string[] CourseCodes, string[] CourseDescriptions, string[] Times, string[] Days, string[] Units)
        {
            InitializeComponent();
            this.personalInformation = personalInformation;
            this.CourseCodes = CourseCodes;
            this.CourseDescriptions = CourseDescriptions;
            this.Times = Times;
            this.Days = Days;
            this.Units = Units;
        }
        SQLQueries queries = new SQLQueries();
        private void Skills_Load(object sender, EventArgs e)
        {
            AddUpdateProgressBar.Value = 70;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void NextToSuccessBtn_Click(object sender, EventArgs e)
        {
            string skillSets = SkillSets.Text;
            queries.AddStudentInformation(personalInformation, CourseCodes, CourseDescriptions, Times, Days, Units, skillSets);
            this.Hide();
            string id = personalInformation[0];
            try
            {
                string[] studentRecords = queries.ViewStudentInformation(id);
                DataTable courseRecords = queries.ViewCourseInformation(id);
                string skillRecords = queries.ViewSkillInformation(id);
                SuccessfulForm successfulForm = new SuccessfulForm(studentRecords, courseRecords, skillRecords);
                successfulForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
