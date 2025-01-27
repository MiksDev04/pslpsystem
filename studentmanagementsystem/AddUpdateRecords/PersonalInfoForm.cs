using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentmanagementsystem.AddUpdateRecords;

namespace studentmanagementsystem.content
{
    public partial class PersonalInfoForm : Form
    {
        public PersonalInfoForm()
        {
            InitializeComponent();
        }

        private void NextToCourseInfo_Click(object sender, EventArgs e)
        {
            string[] personalInformation = new string[50];
            personalInformation[0] = StudentID.Text;
            personalInformation[1] = FullName.Text;
            personalInformation[2] = Birthdate.Text;
            personalInformation[3] = Age.Text;
            personalInformation[4] = Address.Text;
            personalInformation[5] = Email.Text;
            personalInformation[6] = Phone.Text;
            personalInformation[7] = Year_Section.Text;
            personalInformation[8] = Program.Text;
            personalInformation[9] = Department.Text;
            personalInformation[10] = Gender.Text;
            personalInformation[11] = Status.Text;
           
            CoursesForm courses = new CoursesForm(personalInformation);
            this.Hide();
            courses.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            AddUpdateProgressBar.Value = 5;

        }
    }
}
