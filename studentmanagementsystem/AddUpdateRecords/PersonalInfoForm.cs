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
            CoursesForm courses = new CoursesForm();
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
