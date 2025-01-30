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
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.content
{
    public partial class PersonalInfoForm : Form
    {
        private string ID;
        public PersonalInfoForm(string iD)
        {
            InitializeComponent();
            ID = iD;
        }
        SQLQueries queries = new SQLQueries();

        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            AddUpdateProgressBar.Value = 5;

            string[] studentInformation = queries.ReadStudentInformation(ID);
            StudentID.Text = studentInformation[0];
            FullName.Text = studentInformation[1];
            Age.Text = studentInformation[2];
            string sex = studentInformation[3];
            if (sex == "Male")
            {
                Male.Checked = true;
            }
            else if (sex == "Female")
            {
                Female.Checked = true;
            }

            BirthDate.Text = studentInformation[4];
            Address.Text = studentInformation[5];
            Email.Text = studentInformation[6];
            Phone.Text = studentInformation[7];
            YearLevel.SelectedItem = studentInformation[8];
            Section.Text = studentInformation[9];
            Program.Text = studentInformation[10];
            Department.SelectedItem = studentInformation[11];
            string status = studentInformation[12];
            if (status == "Regular")
            {
                Regular.Checked = true;
            }
            else if (status == "Irregular")
            {
                Irregular.Checked = true;
            }
        }

        private void NextToCourseInfo_Click(object sender, EventArgs e)
        {
            if (ID == "")
            {
                GoToAddStudentInformation();
            } else {
                GoToUpdateStudentInformation();
            }
        }
        private void GoToAddStudentInformation()
        {
            string sex = "";
            if (Male.Checked)
            {
                sex = "Male";
            }
            else if (Female.Checked)
            {
                sex = "Female";
            }
            string status = "";
            if (Regular.Checked)
            {
                status = "Regular";
            }
            else if (Irregular.Checked)
            {
                status = "Irregular";
            }

            string[] personalInformation = new string[50];
            personalInformation[0] = StudentID.Text;
            personalInformation[1] = FullName.Text;
            personalInformation[2] = Age.Text;
            personalInformation[3] = sex;
            personalInformation[4] = BirthDate.Value.ToString();
            personalInformation[5] = Address.Text;
            personalInformation[6] = Email.Text;
            personalInformation[7] = Phone.Text;
            personalInformation[8] = YearLevel.SelectedItem?.ToString() ?? "N/A";
            personalInformation[9] = Section.Text;
            personalInformation[10] = Program.Text;
            personalInformation[11] = Department.SelectedItem?.ToString() ?? "N/A";
            personalInformation[12] = status;


            CoursesForm courses = new CoursesForm(personalInformation, ID);
            this.Hide();
            courses.Show();
        }

        private void GoToUpdateStudentInformation()
        {
            string sex = "";
            if (Male.Checked)
            {
                sex = "Male";
            }
            else if (Female.Checked)
            {
                sex = "Female";
            }
            string status = "";
            if (Regular.Checked)
            {
                status = "Regular";
            }
            else if (Irregular.Checked)
            {
                status = "Irregular";
            }

            string[] personalInformation = new string[50];
            personalInformation[0] = StudentID.Text;
            personalInformation[1] = FullName.Text;
            personalInformation[2] = Age.Text;
            personalInformation[3] = sex;
            personalInformation[4] = BirthDate.Value.ToString();
            personalInformation[5] = Address.Text;
            personalInformation[6] = Email.Text;
            personalInformation[7] = Phone.Text;
            personalInformation[8] = YearLevel.SelectedItem?.ToString() ?? "N/A";
            personalInformation[9] = Section.Text;
            personalInformation[10] = Program.Text;
            personalInformation[11] = Department.SelectedItem?.ToString() ?? "N/A";
            personalInformation[12] = status;


            CoursesForm courses = new CoursesForm(personalInformation, ID);
            this.Hide();
            courses.Show();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
