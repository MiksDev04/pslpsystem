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
using Org.BouncyCastle.Utilities.Encoders;
using studentmanagementsystem.Queries;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace studentmanagementsystem.content
{
    public partial class Manage : Form
    {
        public static DataGridView dataGrid;
        public static Label totalrecords;
        public Manage()
        {
            InitializeComponent();
            dataGrid = this.DataManagement_GridView;
            totalrecords = this.TotalRecords;
        }
        SQLQueries queries = new SQLQueries();
        private void Manage_Load(object sender, EventArgs e)
        {
            ViewStudentState.SelectedItem = "Active";
            DataManagement_GridView.DataSource = queries.LoadDBContent("All", "All", "All", "All", "All", "Active");
            ulong totalrecords = queries.ToTalRecords("All", "All", "All", "All", "All", "Active");
            TotalRecords.Text = "Total Records: " + totalrecords.ToString();
        }

  

        private void AddRecordBtn_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalInfo = new PersonalInfoForm("");
            personalInfo.Show();
        }

        private void UpdateRecordBtn_Click(object sender, EventArgs e)
        {
            PersonalInfoForm personalInfo = new PersonalInfoForm(DataManagement_GridView.SelectedRows[0].Cells[0].Value.ToString());
            personalInfo.Show();
        }

  

        private void ArchiveRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataManagement_GridView.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to archive this record?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        queries.ArchiveStudentInformation(DataManagement_GridView.SelectedRows[0].Cells[0].Value.ToString());
                        DataManagement_GridView.DataSource = queries.LoadDBContent("All", "All", "All", "All", "All", "Active");
                        ulong totalrecords = queries.ToTalRecords("All", "All", "All", "All", "All", "Active");
                        TotalRecords.Text = "Total Records: " + totalrecords.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to archive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewStudentState_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ViewStudentState.SelectedItem.ToString() == "Archived")
            {
                RestoreStudentBtn.Visible = true;
            } else
            {
                RestoreStudentBtn.Visible = false;
            }
            string State = ViewStudentState.SelectedItem.ToString();
            DataManagement_GridView.DataSource = queries.LoadDBContent("All", "All", "All", "All", "All", State);
            ulong totalrecords = queries.ToTalRecords("All", "All", "All", "All", "All", State);
            TotalRecords.Text = "Total Records: " + totalrecords.ToString();

        }

        private void RestoreStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataManagement_GridView.SelectedRows[0].Cells[0].Value.ToString() != "")
                {
                    DialogResult = MessageBox.Show("Are you sure you want to restore this record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.Yes)
                    {
                        queries.RestoreStudentInformation(DataManagement_GridView.SelectedRows[0].Cells[0].Value.ToString());
                        DataManagement_GridView.DataSource = queries.LoadDBContent("All", "All", "All", "All", "All", "Archived");
                        ulong totalrecords = queries.ToTalRecords("All", "All", "All", "All", "All", "Archived");
                        TotalRecords.Text = "Total Records: " + totalrecords.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row to restore", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DataManagement_GridView.DataSource = queries.SearchRecord(SearchInput.Text);
        }
    }
}
