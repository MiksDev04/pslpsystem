using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace studentmanagementsystem.content
{
    public partial class Department : Form
    {
        private Main main;
        public Department(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Department_Load(object sender, EventArgs e)
        {
            //RemoveBorder(null);
        }

        private void RemoveBorder(object sender, EventArgs e)
        {
            // Border
            COAPnl.BorderColor = System.Drawing.SystemColors.Control;
            CASPnl.BorderColor = System.Drawing.SystemColors.Control;
            CBAPnl.BorderColor = System.Drawing.SystemColors.Control;
            CCSTPnl.BorderColor = System.Drawing.SystemColors.Control;
            COEPnl.BorderColor = System.Drawing.SystemColors.Control;
            CNAHSPnl.BorderColor = System.Drawing.SystemColors.Control;
            CTHMPnl.BorderColor = System.Drawing.SystemColors.Control;
            CHKPnl.BorderColor = System.Drawing.SystemColors.Control;
            // Bakcground
            COAPnl.FillColor = System.Drawing.SystemColors.ControlLightLight;
            CASPnl.FillColor = System.Drawing.SystemColors.ControlLightLight;
            CBAPnl.FillColor = System.Drawing.SystemColors.ControlLightLight;
            CCSTPnl.FillColor = System.Drawing.SystemColors.ControlLightLight;
            COEPnl.FillColor = System.Drawing.SystemColors.ControlLightLight;
            CNAHSPnl.FillColor = System.Drawing.SystemColors.ControlLightLight;
            CTHMPnl.FillColor = System.Drawing.SystemColors.ControlLightLight;
            CHKPnl.FillColor = System.Drawing.SystemColors.ControlLightLight;

        }
        private void OnBorder(Guna2Panel pnl)
        {

            pnl.BorderColor = System.Drawing.Color.Maroon;
            pnl.FillColor = System.Drawing.Color.IndianRed;
        }

        private void GoToYearLevel()
        {
            
        }
        private void GoToCOA(object sender, EventArgs e)
        {
            
            OnBorder(COAPnl);
        }

        private void GoToCAS(object sender, EventArgs e)
        {
            OnBorder(CASPnl);
        }

        private void GoToCBA(object sender, EventArgs e)
        {
            OnBorder(CBAPnl);
        }

        private void GoToCCST(object sender, EventArgs e)
        {
            OnBorder(CCSTPnl);
        }

        private void GoToCOE(object sender, EventArgs e)
        {
            OnBorder(COEPnl);
        }

        private void GoToCHK(object sender, EventArgs e)
        {
            OnBorder(CHKPnl);
        }

        private void GoToCNAHS(object sender, EventArgs e)
        {
            OnBorder(CNAHSPnl);
        }

        private void GoToCTHM(object sender, EventArgs e)
        {
            OnBorder(CTHMPnl);
        }

        
    }
}
