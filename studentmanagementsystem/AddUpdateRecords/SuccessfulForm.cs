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
    public partial class SuccessfulForm : Form
    {
        public SuccessfulForm()
        {
            InitializeComponent();
        }

        private void SuccessfulForm_Load(object sender, EventArgs e)
        {
            AddUpdateProgressBar.Value = 100;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
