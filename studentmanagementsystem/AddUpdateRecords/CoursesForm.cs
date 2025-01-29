using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.AddUpdateRecords
{
    public partial class CoursesForm : Form
    {
        string[] personalInformation;
        string ID;
        public CoursesForm(string[] personalInformation, string ID)
        {
            InitializeComponent();
            this.personalInformation = personalInformation;
            this.ID = ID;
        }
        SQLQueries queries = new SQLQueries();
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            //Course
            AddUpdateProgressBar.Value = 35;
            List<List<string>> courseInfo = queries.ReadCourseInformation(ID);
            // Fill Course Codes
            CC1.Text = courseInfo[0][0];
            CD1.Text = courseInfo[1][0];
            D1.Text = courseInfo[2][0];
            T1.Text = courseInfo[3][0];
            U1.Text = courseInfo[4][0];

            CC2.Text = courseInfo[0][1];
            CD2.Text = courseInfo[1][1];
            D2.Text = courseInfo[2][1];
            T2.Text = courseInfo[3][1];
            U2.Text = courseInfo[4][1];

            CC3.Text = courseInfo[0][2];
            CD3.Text = courseInfo[1][2];
            D3.Text = courseInfo[2][2];
            T3.Text = courseInfo[3][2];
            U3.Text = courseInfo[4][2];

            CC4.Text = courseInfo[0][3];
            CD4.Text = courseInfo[1][3];
            D4.Text = courseInfo[2][3];
            T4.Text = courseInfo[3][3];
            U4.Text = courseInfo[4][3];

            CC5.Text = courseInfo[0][4];
            CD5.Text = courseInfo[1][4];
            D5.Text = courseInfo[2][4];
            T5.Text = courseInfo[3][4];
            U5.Text = courseInfo[4][4];

            CC6.Text = courseInfo[0][5];
            CD6.Text = courseInfo[1][5];
            D6.Text = courseInfo[2][5];
            T6.Text = courseInfo[3][5];
            U6.Text = courseInfo[4][5];

            CC7.Text = courseInfo[0][6];
            CD7.Text = courseInfo[1][6];
            D7.Text = courseInfo[2][6];
            T7.Text = courseInfo[3][6];
            U7.Text = courseInfo[4][6];

            CC8.Text = courseInfo[0][7];
            CD8.Text = courseInfo[1][7];
            D8.Text = courseInfo[2][7];
            T8.Text = courseInfo[3][7];
            U8.Text = courseInfo[4][7];

            CC9.Text = courseInfo[0][8];
            CD9.Text = courseInfo[1][8];
            D9.Text = courseInfo[2][8];
            T9.Text = courseInfo[3][8];
            U9.Text = courseInfo[4][8];

        }

        private void NextToSkillsBtn_Click(object sender, EventArgs e)
        {
            // decalration of records for declaration
            List<List<string>> courseInfo = new List<List<string>>();

            // Add sets of 8 strings for each category
            courseInfo.Add(new List<string> { CC1.Text, CC2.Text, CC3.Text, CC4.Text, CC5.Text, CC6.Text, CC7.Text, CC8.Text });
            courseInfo.Add(new List<string> { CD1.Text, CD2.Text, CD3.Text, CD4.Text, CD5.Text, CD6.Text, CD7.Text, CD8.Text });
            courseInfo.Add(new List<string> { T1.Text, T2.Text, T3.Text, T4.Text, T5.Text, T6.Text, T7.Text, T8.Text });
            courseInfo.Add(new List<string> { D1.Text, D2.Text, D3.Text, D4.Text, D5.Text, D6.Text, D7.Text, D8.Text });
            courseInfo.Add(new List<string> { U1.Text, U2.Text, U3.Text, U4.Text, U5.Text, U6.Text, U7.Text, U8.Text });

            // go to skills form
            this.Hide();
            SkillsForm skills = new SkillsForm(personalInformation, courseInfo, ID);
            skills.Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
