using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using studentmanagementsystem.content;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace studentmanagementsystem.Queries
{
    internal class SQLQueries
    {

        // Main SQL connection
        string stringConnection = "Server=localhost;Database=plspdb;User=root;Password=1234;";

        public DataTable LoadDBContent(string Department, string YearLevel, string Program, string Sex, string Status)
        {
            DataTable dataTable = new DataTable();
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT DISTINCT Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, Phone_Number, YearLevel, Section, Program, Department, Status FROM Student_Information ";
                if (Department != "All")
                {
                    query += "WHERE Department = @Department ";
                }
                if (YearLevel != "All")
                {
                    if (!query.Contains("WHERE"))
                    {
                        query += "WHERE YearLevel = @YearLevel ";
                    }
                    query += "AND YearLevel = @YearLevel ";
                }
                if (Program != "All")
                {
                    if (!query.Contains("WHERE"))
                    {
                        query += "WHERE Program = @Program ";
                    }
                    query += "AND Program = @Program ";
                }
                if (Sex != "All")
                {
                    if (!query.Contains("WHERE"))
                    {
                        query += "WHERE Sex = @Sex ";
                    }
                    query += "AND Sex = @Sex ";
                }
                if (Status != "All")
                {
                    if (!query.Contains("WHERE"))
                    {
                        query += "WHERE Status = @Status ";
                    }
                    query += "AND Status = @Status ";
                }
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Department", Department);
                    command.Parameters.AddWithValue("@YearLevel", YearLevel);
                    command.Parameters.AddWithValue("@Program", Program);
                    command.Parameters.AddWithValue("@Sex", Sex);
                    command.Parameters.AddWithValue("@Status", Status);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public bool[] CheckUser(string Username, string Password)
        {
            bool isValid = false;
            bool isAdmin = false;
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM Administrator;";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["Username"].ToString() == Username && reader["Password"].ToString() == Password)
                            {
                                isValid = true;
                                if (reader["Type"].ToString() == "admin")
                                {
                                    isAdmin = true;
                                }
                            }
                        }
                    }
                }
            }
            return new bool[] {isValid, isAdmin};
        }

        public void AddUserAccount(string Username , string Password)
        {
            using (var connection = new MySqlConnection(stringConnection))
            {
                string Type = "user";
                connection.Open();
                string query = "INSERT INTO Administrator(Username, Password, Type) VALUES(@Username, @Password, @Type);";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Type", Type);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable SearchRecord(string SearchInput)
        {
            DataTable dataTable = new DataTable();
            SearchInput.Trim();
            if (!string.IsNullOrEmpty(SearchInput))
            {
                // SQL query divided into smaller parts for better readability
                string query = @"
                SELECT DISTINCT Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, Phone_Number, YearLevel, Section, Program, Department, Status FROM Student_Information 
                WHERE 
                (Student_ID LIKE @search) OR
                (Student_Name LIKE @search) OR
                (Birthdate LIKE @search) OR
                (Address LIKE @search) OR
                (Email LIKE @search) OR
                (Phone_Number LIKE @search)";

                using (var connection = new MySqlConnection(stringConnection))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@search", "%" + SearchInput + "%"); // Using LIKE to allow partial matching
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        dataAdapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return dataTable;

        }
        public string[] ViewStudentInformation(string id)
        {
            string[] records = new string[100];
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT DISTINCT Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, Phone_Number, YearLevel, Section, Program, Department, Status FROM Student_Information " + 
                                "WHERE Student_ID = @id;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    using (var reader = command.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            //if (id == reader["Student_ID"].ToString())
                            //{
                                records[0] = reader["Student_ID"].ToString() ?? "Null";
                                records[1] = reader["Student_Name"].ToString() ?? "Null";
                                records[2] = reader["Age"].ToString() ?? "Null";
                                records[3] = reader["Sex"].ToString() ?? "Null";
                                records[4] = reader["Birthdate"].ToString() ?? "Null";
                                records[5] = reader["Address"].ToString() ?? "Null";
                                records[6] = reader["Email"].ToString() ?? "Null";
                                records[7] = reader["Phone_Number"].ToString() ?? "Null";
                                records[8] = reader["YearLevel"].ToString() ?? "Null";
                                records[9] = reader["Section"].ToString() ?? "Null";
                                records[10] = reader["Program"].ToString() ?? "Null";
                                records[11] = reader["Department"].ToString() ?? "Null";
                                records[12] = reader["Status"].ToString() ?? "Null";
                            //}
                        }
                    }
                }
            }
            return records;
        }
        public DataTable ViewCourseInformation(string id)
        {
            DataTable dataTable = new DataTable();
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT c.Course_Code, " +
                   "c.Course_Name, " +
                   "c.Day, " +
                   "c.Time, " +
                   "c.Units " +
                   "FROM Student_Information AS si " +
                   "JOIN Courses AS c ON c.course_id = si.course_id " +
                   "WHERE si.Student_ID = @id;";


                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
        public List<string> ViewSkillInformation(string id)
        {
            List<string> records = new List<string>();
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT s.Skill_Name " +
                   "FROM Student_Information AS si " +
                   "JOIN Skills AS s ON s.skill_id = si.skill_id " +
                   "WHERE si.Student_ID = @id;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            records.Add(reader["Skill_name"].ToString() ?? "Null");
                        }
                    }
                }
            }
            return records;
        }

        public DataTable LoadDepartmentCourses(string department)
        {
            DataTable dataTable = new DataTable();
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = @"
                    SELECT DISTINCT 
                        c.Course_Code,
                        c.Course_Name,
                        c.Units
                    FROM 
                        Student_Information AS si
                    JOIN 
                        Courses AS c 
                        ON c.course_id = si.course_id
                    WHERE
                        si.Department = @department;
                ";



                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@department", department);
                    command.ExecuteNonQuery();
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }


        public void AddStudentInformation(string[] personalInformation, string[] CourseCodes, string[] CourseDescriptions, string[] Times, string[] Days, string[] Units, string skillsets)
        {
            try
            {
                for (int i = 0; i < CourseCodes.Length; i++)
                {
                    using (MySqlConnection connection = new MySqlConnection(stringConnection))
                    {
                        // ADD course information
                        connection.Open();

                        string queryCourse = @"
                            INSERT INTO courses (
                                Course_Code, Course_Name, Day, Time, Units
                            ) VALUES (@Course_Code, @Course_Name, @Day, @Time, @Units);
                            SELECT LAST_INSERT_ID();
                            ";
                        int courseId = 0;
                        using (MySqlCommand cmd1 = new MySqlCommand(queryCourse, connection))
                        {
                            cmd1.Parameters.Clear();

                            cmd1.Parameters.AddWithValue("@Course_Code", CourseCodes[i]);
                            cmd1.Parameters.AddWithValue("@Course_Name", CourseDescriptions[i]);
                            cmd1.Parameters.AddWithValue("@Day", Days[i]);
                            cmd1.Parameters.AddWithValue("@Time", Times[i]);
                            cmd1.Parameters.AddWithValue("@Units", Convert.ToInt32(Units[i]));
                            courseId = Convert.ToInt32(cmd1.ExecuteScalar()); // Get the last inserted skill_id

                        }

                        // Add skills information

                        string querySkill = "INSERT INTO skills (Skill_Name) VALUES (@Skill_Name); SELECT LAST_INSERT_ID();";
                        int skillId = 0;
                        using (MySqlCommand cmd2 = new MySqlCommand(querySkill, connection))
                        {
                            cmd2.Parameters.AddWithValue("@Skill_Name", skillsets);
                            skillId = Convert.ToInt32(cmd2.ExecuteScalar()); // Get the last inserted skill_id
                        }

                        // ADD student information
                        string queryStudent = @"INSERT INTO student_information 
                        (Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, Phone_Number, 
                        Yearlevel, Section, Program, Department, Status, Course_ID, Skill_ID ) 
                        VALUES (@Student_ID, @Student_Name, @Age, @Sex, @Birthdate, @Address, @Email, @Phone_Number, 
                        @Yearlevel, @Section, @Program, @Department, @Status, @Course_ID, @Skill_ID);
                        ";
                        using (MySqlCommand cmd3 = new MySqlCommand(queryStudent, connection))
                        {
                            cmd3.Parameters.Clear();

                            cmd3.Parameters.AddWithValue("@Student_ID", personalInformation[0]);
                            cmd3.Parameters.AddWithValue("@Student_Name", personalInformation[1]);
                            cmd3.Parameters.AddWithValue("@Age", Convert.ToInt32(personalInformation[2]));
                            cmd3.Parameters.AddWithValue("@Sex", personalInformation[3]);
                            cmd3.Parameters.AddWithValue("@Birthdate", personalInformation[4]);
                            cmd3.Parameters.AddWithValue("@Address", personalInformation[5]);
                            cmd3.Parameters.AddWithValue("@Email", personalInformation[6]);
                            cmd3.Parameters.AddWithValue("@Phone_Number", Convert.ToInt64(personalInformation[7]));
                            cmd3.Parameters.AddWithValue("@Yearlevel", personalInformation[8]);
                            cmd3.Parameters.AddWithValue("@Section", personalInformation[9]);
                            cmd3.Parameters.AddWithValue("@Program", personalInformation[10]);
                            cmd3.Parameters.AddWithValue("@Department", personalInformation[11]);
                            cmd3.Parameters.AddWithValue("@Status", personalInformation[12]);
                            cmd3.Parameters.AddWithValue("@Course_ID", courseId);
                            cmd3.Parameters.AddWithValue("@Skill_ID", skillId);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "huauha");
            }
        }
        public void DeleteStudentInformation(string id)
        {
            string query = "DELETE FROM student_information WHERE Student_ID = @id;";


            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
