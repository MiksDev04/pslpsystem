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

namespace studentmanagementsystem.content
{
    public partial class Courses : Form
    {
        private string department;
        public Courses(string department)
        {
            InitializeComponent();
            this.department = department;
        }

        SQLQueries queries = new SQLQueries();
        private void Courses_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCoursesPnl.DataSource = queries.LoadDepartmentCourses(department);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
