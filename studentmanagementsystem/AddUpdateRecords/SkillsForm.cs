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
    public partial class SkillsForm : Form
    {
        public SkillsForm()
        {
            InitializeComponent();
        }

        private void Skills_Load(object sender, EventArgs e)
        {
            AddUpdateProgressBar.Value = 70;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void NextToSuccessBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuccessfulForm successfulForm = new SuccessfulForm();
            successfulForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void S1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void S2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void S3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void S4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void S5_TextChanged(object sender, EventArgs e)
        {

        }

        private void s10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void S9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void S8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
