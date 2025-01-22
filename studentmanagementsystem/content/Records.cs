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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LoadPersonalInformation();
        }
    }
}
