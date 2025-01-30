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
            StudentSkillsChart.Series["SkillsPerYear"].Points.AddXY("1st Year", skillCounts[1]);
            StudentSkillsChart.Series["SkillsPerYear"].Points.AddXY("2nd Year", skillCounts[2]);
            StudentSkillsChart.Series["SkillsPerYear"].Points.AddXY("3rd Year", skillCounts[3]);
            StudentSkillsChart.Series["SkillsPerYear"].Points.AddXY("4th Year", skillCounts[4]);
        }
        private Dictionary<int, int> GetSkillsCountPerYearLevel()
        {
            var skillCounts = new Dictionary<int, int>
            {
                { 1, 20 }, // Example: 20 skills for 1st Year students
                { 2, 35 }, // Example: 35 skills for 2nd Year students
                { 3, 50 }, // Example: 50 skills for 3rd Year students
                { 4, 40 }  // Example: 40 skills for 4th Year students
            };

            // If pulling from a database, replace the above dictionary with a database query
            /*
            string query = @"
                SELECT si.YearLevel, COUNT(sk.Skill_ID) AS SkillCount
                FROM Student_Information si
                JOIN Skills sk ON si.Student_ID = sk.Student_ID
                GROUP BY si.YearLevel
                ORDER BY si.YearLevel";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int yearLevel = reader.GetInt32(0);  // YearLevel
                            int skillCount = reader.GetInt32(1); // SkillCount
                            skillCounts[yearLevel] = skillCount;
                        }
                    }
                }
            }
            */

            return skillCounts;
        }
    }
}
