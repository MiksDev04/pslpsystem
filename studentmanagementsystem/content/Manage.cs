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
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.content
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }
        SQLQueries queries = new SQLQueries();
        private void Manage_Load(object sender, EventArgs e)
        {
            DataManagement_GridView.DataSource = queries.LoadDBContent("All", "All", "All", "All", "All");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalInfo = new PersonalInfoForm();
            personalInfo.Show();
        }

        private void UpdateRecordBtn_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalInfo = new PersonalInfoForm();
            personalInfo.Show();
        }

        private void PersonalInformationRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataManagement_GridView.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to permanently delete this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        queries.DeleteStudentInformation(DataManagement_GridView.SelectedRows[0].Cells[0].Value.ToString());
                        DataManagement_GridView.DataSource = queries.LoadDBContent("All", "All", "All", "All", "All");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
