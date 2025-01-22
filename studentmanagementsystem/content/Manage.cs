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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {

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
    }
}
