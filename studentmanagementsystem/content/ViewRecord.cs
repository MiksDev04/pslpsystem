using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem.content
{
    public partial class ViewRecord : Form
    {
        private string[] studentRecord; 
        private DataTable courseRecord;
        private string skillRecord;
        public ViewRecord(string[] studentRecord, DataTable courseRecord,string skillRecord)
        {
            InitializeComponent();
            this.studentRecord = studentRecord;
            this.courseRecord = courseRecord;
            this.skillRecord = skillRecord;
        }

        private void ViewRecord_Load(object sender, EventArgs e)
        {
            StudentID.Text += studentRecord[0];
            FullName.Text += studentRecord[1];
            Age.Text += studentRecord[2];
            Sex.Text += studentRecord[3];
            Birthdate.Text += studentRecord[4];
            Address.Text += studentRecord[5];
            Email.Text += studentRecord[6];
            YearLevel.Text += studentRecord[7];
            Section.Text += studentRecord[8];
            Program.Text += studentRecord[9];
            Department.Text += studentRecord[10];
            Status.Text += studentRecord[11];
            ViewCourseInformation.DataSource = courseRecord;
            SkillSets.Text = skillRecord;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
    }
}
