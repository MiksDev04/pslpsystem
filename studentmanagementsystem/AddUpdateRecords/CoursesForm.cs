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
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            AddUpdateProgressBar.Value = 35;
        }

        private void NextToSkillsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SkillsForm skills = new SkillsForm();
            skills.Show();
        }
    }
}
