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
    }
}
