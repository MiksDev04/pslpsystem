using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.content
{
    public partial class Skills : Form
    {
        public Skills()
        {
            InitializeComponent();
        }

        SQLQueries queries = new SQLQueries();
        private void Skills_Load(object sender, EventArgs e)
        { 

            MosSkillfulStudents.DataSource = queries.MostSkillfulStudent();
            SetUpStudentSkillsChart();          
            //MosSkillfulStudents.Columns[MosSkillfulStudents.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void SetUpStudentSkillsChart()
        {
            // Create the chart area
            StudentSkillsChart.ChartAreas.Add(new ChartArea("MainArea"));
            StudentSkillsChart.Series.Add("SkillsPerYear");

            // Set the chart type to Column
            StudentSkillsChart.Series["SkillsPerYear"].ChartType = SeriesChartType.Column;

            // Set chart appearance
            StudentSkillsChart.Series["SkillsPerYear"].Color = System.Drawing.Color.CornflowerBlue;
            StudentSkillsChart.Series["SkillsPerYear"].BorderWidth = 2;

            // Add axis titles
            StudentSkillsChart.ChartAreas["MainArea"].AxisX.Title = "Year Level";
            StudentSkillsChart.ChartAreas["MainArea"].AxisY.Title = "Number of Skills";
            StudentSkillsChart.Titles.Add("Student Skills by Year Level");

            // Fetch data from the database
            var skillCounts = GetSkillsCountPerYearLevel();

            // Add data to the chart with labels "1st Year", "2nd Year", etc.
            StudentSkillsChart.Series["SkillsPerYear"].Points.AddXY("1st Year", skillCounts.ContainsKey(1) ? skillCounts[1] : 0);
            StudentSkillsChart.Series["SkillsPerYear"].Points.AddXY("2nd Year", skillCounts.ContainsKey(2) ? skillCounts[2] : 0);
            StudentSkillsChart.Series["SkillsPerYear"].Points.AddXY("3rd Year", skillCounts.ContainsKey(3) ? skillCounts[3] : 0);
            StudentSkillsChart.Series["SkillsPerYear"].Points.AddXY("4th Year", skillCounts.ContainsKey(4) ? skillCounts[4] : 0);

        }
        private Dictionary<int, int> GetSkillsCountPerYearLevel()
        {
            var skillCounts = new Dictionary<int, int>();

            queries.LoadSkillChart(skillCounts);

            return skillCounts;
        }
    }
}
