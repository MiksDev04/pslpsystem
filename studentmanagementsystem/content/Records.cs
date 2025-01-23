using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace studentmanagementsystem.content
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();

        }
        string stringConnection = "Server=localhost;Database=universitydb;User=root;Password=;";
        private void Records_Load(object sender, EventArgs e)
        {
            StudentDepartment.Text = "All";
            StudentProgram.Text = "All";
            StudentYearLevel.Text = "All";
            StudentSex.Text = "All";
            StudentStatus.Text = "All";
            StudentProgram.Items.Clear();
            StudentProgram.Items.Add("All");
            StudentProgram.SelectedItem = "All";
            LoadPersonalInformation();
        }

        private void LoadPersonalInformation()
        {
            DataTable dataTable = new DataTable(); 
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM Personal_Information;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        PersonalInformationRecords.DataSource = dataTable;
                    }
                }
            }
        }

        private void StudentDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StudentProgram.Items.Clear();
            StudentProgram.Items.Add("All");
            StudentProgram.SelectedItem = "All";
            string departmentSelected = StudentDepartment.SelectedItem.ToString();
            switch (departmentSelected)
            {
                case "COE":
                    StudentProgram.Items.Add("Bachelor of Science in Computer Engineering");
                    StudentProgram.Items.Add("Bachelor of Science in Industrial Engineering");
                    break;
                case "CONAHS":
                    StudentProgram.Items.Add("Bachelor of Science in Nursing");
                    break;
                case "CHK":
                    StudentProgram.Items.Add("Bachelor of Physical Education");
                    break;
                case "CBA":
                    StudentProgram.Items.Add("Bachelor of Science in Business Administration");
                    StudentProgram.Items.Add("Bachelor of Science in Entrepreneurship");
                    StudentProgram.Items.Add("Bachelor of Science in Office Administration");
                    break;
                case "COA":
                    StudentProgram.Items.Add("Bachelor of Science in Accountancy");
                    StudentProgram.Items.Add("Bachelor of Science in Accounting Information System");
                    StudentProgram.Items.Add("Bachelor of Science in Management Accounting");
                    break;
                case "CCST":
                    StudentProgram.Items.Add("Bachelor of Science in Information Technology");
                    StudentProgram.Items.Add("Bachelor of Science in Information Systems");
                    break;
                case "CAS":
                    StudentProgram.Items.Add("Bachelor of Science in Psychology");
                    StudentProgram.Items.Add("Bachelor of Arts in Communication");
                    StudentProgram.Items.Add("Bachelor of Science in Economics");
                    StudentProgram.Items.Add("Bachelor of Public Administration");
                    StudentProgram.Items.Add("Bachelor of Arts in Political Science");
                    break;
                case "CTHM":
                    StudentProgram.Items.Add("Bachelor of Science in Hospitality Management");
                    StudentProgram.Items.Add("Bachelor of Science in Tourism Management");
                    break;
            }

        }
    }
}
