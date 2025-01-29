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
        List<List<string>> courseInfo;
        string ID;
        public SkillsForm(string[] personalInformation, List<List<string>> courseInfo, string ID)
        {
            InitializeComponent();
            this.personalInformation = personalInformation;
            this.courseInfo = courseInfo;
            this.ID = ID;
        }
        SQLQueries queries = new SQLQueries();
        private void Skills_Load(object sender, EventArgs e)
        {
            AddUpdateProgressBar.Value = 70;
            SkillSets.Text = queries.ReadSkillInformation(ID);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void NextToSuccessBtn_Click(object sender, EventArgs e)
        {
            if(ID == "")
            {
                AddRecordInformation();
            } else
            {
                UpdateRecordInformation();
            }
        }
        
        private void AddRecordInformation()
        {
            string skillSets = SkillSets.Text;
            queries.AddStudentInformation(personalInformation, courseInfo, skillSets);
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

        private void UpdateRecordInformation()
        {
            string skillSets = SkillSets.Text;
            queries.UpdateStudentInformation(personalInformation, courseInfo, skillSets, ID);
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
