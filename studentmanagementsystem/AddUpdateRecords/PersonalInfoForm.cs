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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
