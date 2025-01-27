using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem.AddUpdateRecords
{
    public partial class CoursesForm : Form
    {
        string[] personalInformation;
        public CoursesForm(string[] personalInformation)
        {
            InitializeComponent();
            this.personalInformation = personalInformation;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            //Course
            AddUpdateProgressBar.Value = 35;
        }

        private void NextToSkillsBtn_Click(object sender, EventArgs e)
        {
            // decalration of records for declaration
            string[] CourseCodes = new string[100];
            string[] CourseDescriptions = new string[100];
            string[] Times = new string[100];
            string[] Days = new string[100];
            string[] Units = new string[100];


            CourseCodes[0] = CC1.Text;
            CourseCodes[1] = CC2.Text;
            CourseCodes[2] = CC3.Text;
            CourseCodes[3] = CC4.Text;
            CourseCodes[4] = CC5.Text;
            CourseCodes[5] = CC6.Text;
            CourseCodes[6] = CC7.Text;
            CourseCodes[7] = CC8.Text;
            CourseCodes[8] = CC9.Text;

            CourseDescriptions[0] = CD1.Text;
            CourseDescriptions[1] = CD2.Text;
            CourseDescriptions[2] = CD3.Text;
            CourseDescriptions[3] = CD4.Text;
            CourseDescriptions[4] = CD5.Text;
            CourseDescriptions[5] = CD6.Text;
            CourseDescriptions[6] = CD7.Text;
            CourseDescriptions[7] = CD8.Text;
            CourseDescriptions[8] = CD9.Text;

            Times[0] = T1.Text;
            Times[1] = T2.Text;
            Times[2] = T3.Text;
            Times[3] = T4.Text;
            Times[4] = T5.Text;
            Times[5] = T6.Text;
            Times[6] = T7.Text;
            Times[7] = T8.Text;
            Times[8] = T9.Text;

            Days[0] = D1.Text;
            Days[1] = D2.Text;
            Days[2] = D3.Text;
            Days[3] = D4.Text;
            Days[4] = D5.Text;
            Days[5] = D6.Text;
            Days[6] = D7.Text;
            Days[7] = D8.Text;
            Days[8] = D9.Text;

            Units[0] = U1.Text;
            Units[1] = U2.Text;
            Units[2] = U3.Text;
            Units[3] = U4.Text;
            Units[4] = U5.Text;
            Units[5] = U6.Text;
            Units[6] = U7.Text;
            Units[7] = U8.Text;
            Units[8] = U9.Text;

            // go to skills form
            this.Hide();
            SkillsForm skills = new SkillsForm(personalInformation, CourseCodes, CourseDescriptions, Times, Days, Units);
            skills.Show();
        }
    }
}
