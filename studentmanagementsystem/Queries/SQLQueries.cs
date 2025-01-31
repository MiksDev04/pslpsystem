using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using studentmanagementsystem.content;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace studentmanagementsystem.Queries
{
    internal class SQLQueries
    {

        // Main SQL connection
        string stringConnection = "Server=localhost;Database=plspdb;User=root;Password=1234;";

        public DataTable LoadDBContent(string Department, string YearLevel, string Program, string Sex, string Status, string State)
        {
            DataTable dataTable = new DataTable();
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT DISTINCT Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, YearLevel, Section, Program, Department, Status FROM Student_Information ";
                FilterRecords(ref query, ref Department, ref YearLevel, ref Program, ref Sex, ref Status, ref State);
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Department", Department);
                    command.Parameters.AddWithValue("@YearLevel", YearLevel);
                    command.Parameters.AddWithValue("@Program", Program);
                    command.Parameters.AddWithValue("@Sex", Sex);
                    command.Parameters.AddWithValue("@Status", Status);
                    command.Parameters.AddWithValue("@State", State);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public DataTable LastAddedStudentRecords()
        {
            DataTable dataTable = new DataTable();
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = @"
                    WITH RankedStudents AS (
                        SELECT Student_ID, Student_Name, Age, Sex, Birthdate, 
                               Address, Email, YearLevel, Section, 
                               Program, Department, Status,
                               ROW_NUMBER() OVER (PARTITION BY Student_ID ORDER BY ID DESC) AS RowNum
                        FROM Student_Information
                    )
                    SELECT Student_ID, Student_Name, Age, Sex, Birthdate, 
                           Address, Email, YearLevel, Section, 
                           Program, Department, Status
                    FROM RankedStudents WHERE RowNum = 1 LIMIT 10;

                    ";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }


        public DataTable MostSkillfulStudent()
        {
            DataTable dataTable = new DataTable();
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = @"
                SELECT DISTINCT si.Student_ID, si.Student_Name, si.Program, si.YearLevel, si.Section, si.Department, 
                sk.Skill_Name
                FROM Student_Information si
                JOIN Skills sk ON si.skill_id = sk.skill_id
                ORDER BY LENGTH(sk.Skill_Name) DESC
                LIMIT 10;
                    ";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        private void FilterRecords(ref string query, ref string Department, ref string YearLevel, ref string Program, ref string Sex, ref string Status, ref string State)
        {
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
            if (!query.Contains("WHERE"))
            {
                query += "WHERE State = @State";
            } else
            {
                query += "AND State = @State";
            }
            
        }

        public ulong TotalSkills()
        {
            ulong total = 0;
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();

                // Corrected query to count distinct combinations of columns
                string query = "SELECT COUNT(DISTINCT skill_id) FROM plspdb.skills;";
                using (var command = new MySqlCommand(query, connection))
                {
                    // Execute the query and get the total count of distinct records
                    total = Convert.ToUInt64(command.ExecuteScalar());

                }
            }

            return total;
        }
        public ulong ToTalRecords(string Department, string YearLevel, string Program, string Sex, string Status, string State)
        {
            ulong total = 0;
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();

                // Corrected query to count distinct combinations of columns
                string query = "SELECT  COUNT(DISTINCT Student_ID, Student_Name) FROM Student_Information ";
                FilterRecords(ref query, ref Department, ref YearLevel, ref Program, ref Sex, ref Status, ref State);
                using (var command = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Department", Department);
                    command.Parameters.AddWithValue("@YearLevel", YearLevel);
                    command.Parameters.AddWithValue("@Program", Program);
                    command.Parameters.AddWithValue("@Sex", Sex);
                    command.Parameters.AddWithValue("@Status", Status);
                    command.Parameters.AddWithValue("@State", State);

                    // Execute the query and get the total count of distinct records
                    total = Convert.ToUInt64(command.ExecuteScalar());

                }
            }

            return total;
        }

        public ulong TotalCourses(string department, string yearlevel, string program)
        {
            ulong total = 0;
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();

                // Corrected query to count distinct combinations of columns
                string query = @"
                    SELECT COUNT(DISTINCT Course_Code, Course_Name, Units) 
                    FROM 
	                    student_information as si
                    Join 
	                    courses as c
                    ON 
	                    si.course_id = c.course_id
                    WHERE si.Department = @Department ";
                if (yearlevel != "All")
                {
                    query += "AND YearLevel = @YearLevel ";
                }
                if (program != "All")
                {
                    query += "AND Program = @Program ";
                }
                using (var command = new MySqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@YearLevel", yearlevel);
                    command.Parameters.AddWithValue("@Program", program);

                    // Execute the query and get the total count of distinct records
                    total = Convert.ToUInt64(command.ExecuteScalar());

                }
            }

            return total;
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
                SELECT DISTINCT Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, YearLevel, Section, Program, Department, Status FROM Student_Information 
                WHERE 
                (Student_ID LIKE @search) OR
                (Student_Name LIKE @search) OR
                (Birthdate LIKE @search) OR
                (Address LIKE @search) OR
                (Email LIKE @search)";

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
                string query = "SELECT DISTINCT Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, YearLevel, Section, Program, Department, Status FROM Student_Information " + 
                                "WHERE Student_ID = @id;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    using (var reader = command.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            records[0] = reader["Student_ID"].ToString() ?? "Null";
                            records[1] = reader["Student_Name"].ToString() ?? "Null";
                            records[2] = reader["Age"].ToString() ?? "Null";
                            records[3] = reader["Sex"].ToString() ?? "Null";
                            records[4] = reader["Birthdate"].ToString() ?? "Null";
                            records[5] = reader["Address"].ToString() ?? "Null";
                            records[6] = reader["Email"].ToString() ?? "Null";
                            records[7] = reader["YearLevel"].ToString() ?? "Null";
                            records[8] = reader["Section"].ToString() ?? "Null";
                            records[9] = reader["Program"].ToString() ?? "Null";
                            records[10] = reader["Department"].ToString() ?? "Null";
                            records[11] = reader["Status"].ToString() ?? "Null";
                            
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
        public string ViewSkillInformation(string id)
        {
            string skills = "";
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
                            skills = reader["Skill_name"].ToString() ?? "Null";
                        }
                    }
                }
            }
            return skills;
        }

        public DataTable LoadDepartmentCourses(string department, string yearlevel, string program)
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
                        Department = @Department 
                ";

                if (yearlevel != "All")
                {
                    query += "AND YearLevel = @YearLevel ";
                }
                if (program != "All")
                {
                    query += "AND Program = @Program ";
                }



                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@YearLevel", yearlevel);
                    command.Parameters.AddWithValue("@Program", program);
                    command.ExecuteNonQuery();
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }


        public void AddStudentInformation(string[] personalInformation, List<List<string>> courseInfo, string skillsets)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();
                    // Add skill information only once
                    string querySkill = @"INSERT IGNORE INTO skills (Skill_Name) VALUES (@Skill_Name); 
                                  SELECT LAST_INSERT_ID();";
                    int skillId = 0;
                    using (MySqlCommand cmd2 = new MySqlCommand(querySkill, connection))
                    {
                        cmd2.Parameters.AddWithValue("@Skill_Name", skillsets?.ToString() ?? "N/A");
                        skillId = Convert.ToInt32(cmd2.ExecuteScalar());
                    }
                    for (int i = 0; i < courseInfo[0].Count; i++)
                    {
                        if (!string.IsNullOrEmpty(courseInfo[0][i]))
                        {

                            // Add course information if it doesn't already exist
                            string queryCourse = @"INSERT IGNORE INTO courses (Course_Code, Course_Name, Day, Time, Units) 
                                VALUES (@Course_Code, @Course_Name, @Day, @Time, @Units);
                                SELECT LAST_INSERT_ID();";
                            int courseId = 0;
                            using (MySqlCommand cmd1 = new MySqlCommand(queryCourse, connection))
                            {
                                cmd1.Parameters.AddWithValue("@Course_Code", courseInfo[0][i]?.ToString() ?? "N/A");
                                cmd1.Parameters.AddWithValue("@Course_Name", courseInfo[1][i]?.ToString() ?? "N/A");
                                cmd1.Parameters.AddWithValue("@Day", courseInfo[2][i]?.ToString() ?? "N/A");
                                cmd1.Parameters.AddWithValue("@Time", courseInfo[3][i]?.ToString() ?? "N/A");
                                cmd1.Parameters.AddWithValue("@Units", courseInfo[4][i]?.ToString() ?? "0");
                                courseId = Convert.ToInt32(cmd1.ExecuteScalar());
                            }

                            

                            // Add student information
                            string queryStudent = @"INSERT INTO student_information 
                                (Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, Phone_Number, 
                                    Yearlevel, Section, Program, Department, Status, Course_ID, Skill_ID) 
                                VALUES (@Student_ID, @Student_Name, @Age, @Sex, @Birthdate, @Address, @Email, 
                                @Yearlevel, @Section, @Program, @Department, @Status, 
                                @Course_ID, @Skill_ID);";
                            using (MySqlCommand cmd3 = new MySqlCommand(queryStudent, connection))
                            {
                                cmd3.Parameters.AddWithValue("@Student_ID", personalInformation[0]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Student_Name", personalInformation[1]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Age", Convert.ToInt32(personalInformation[2]?.ToString() ?? "0"));
                                cmd3.Parameters.AddWithValue("@Sex", personalInformation[3]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Birthdate", DateTime.TryParse(personalInformation[4]?.ToString(), out var birthdate) ? birthdate : DateTime.MinValue);
                                cmd3.Parameters.AddWithValue("@Address", personalInformation[5]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Email", personalInformation[6]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Yearlevel", personalInformation[7]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Section", personalInformation[8]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Program", personalInformation[9]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Department", personalInformation[10]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Status", personalInformation[11]?.ToString() ?? "N/A");
                                cmd3.Parameters.AddWithValue("@Course_ID", courseId);
                                cmd3.Parameters.AddWithValue("@Skill_ID", skillId);
                                cmd3.ExecuteNonQuery();
                            }
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " TRY AGAIN...");
            }
        }
        public void ArchiveStudentInformation(string id)
        {
            string query = "UPDATE student_information SET State = 'Archived' WHERE Student_ID = @id;";
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

        public void RestoreStudentInformation(string id)
        {
            string query = "UPDATE student_information SET State = 'Active' WHERE Student_ID = @id;";
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

        public void UpdateStudentInformation(string[] personalInformation, List<List<string>> courseInfo, string skillsets, string studentID)
        {
            using (MySqlConnection connection = new MySqlConnection(stringConnection))
            {
                connection.Open();

                // Update student personal information
                string queryStudent = @"
                UPDATE student_information
                SET Student_ID = @NEWID,
                    Student_Name = @Student_Name,
                    Age = @Age,
                    Sex = @Sex,
                    Birthdate = @Birthdate,
                    Address = @Address,
                    Email = @Email,
                    Yearlevel = @Yearlevel,
                    Section = @Section,
                    Program = @Program,
                    Department = @Department,
                    Status = @Status
                WHERE Student_ID = @Student_ID;";

                using (MySqlCommand cmd = new MySqlCommand(queryStudent, connection))
                {
                    cmd.Parameters.AddWithValue("@NEWID", personalInformation[0] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Student_Name", personalInformation[1] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(personalInformation[2] ?? "0"));
                    cmd.Parameters.AddWithValue("@Sex", personalInformation[3] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Birthdate", DateTime.TryParse(personalInformation[4], out var birthdate) ? birthdate : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", personalInformation[5] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Email", personalInformation[6] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Yearlevel", personalInformation[7] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Section", personalInformation[8] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Program", personalInformation[9] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Department", personalInformation[10] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Status", personalInformation[11] ?? "N/A");
                    cmd.Parameters.AddWithValue("@Student_ID", studentID.ToString());

                    cmd.ExecuteNonQuery();
                }

                // Get Skill_ID based on the Skill_Name provided
                string getSkillIdQuery = @"SELECT sk.skill_id
                    FROM 
	                    student_information s
                    JOIN 
	                    skills sk 
                    ON 
	                    s.skill_id = sk.Skill_id
                    WHERE 
	                    student_id = @Student_ID;";
                int skillID = 0;


                using (MySqlCommand getSkillCmd = new MySqlCommand(getSkillIdQuery, connection))
                {
                    getSkillCmd.Parameters.AddWithValue("@Student_ID", personalInformation[0].ToString());
                    using (var reader = getSkillCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            skillID = Convert.ToInt32(reader["skill_id"]);
                        }
                    }

                    // If skill exists, update Skill_ID in student_information
                    string updateStudentSkillQuery = @"
                        UPDATE skills 
                        SET skill_name = @Skill_Name
                        WHERE skill_id = @skill_id;";

                    using (MySqlCommand updateSkillCmd = new MySqlCommand(updateStudentSkillQuery, connection))
                    {
                        updateSkillCmd.Parameters.AddWithValue("@Skill_Name", skillsets?.ToString() ?? "N/A");
                        updateSkillCmd.Parameters.AddWithValue("@skill_id", Convert.ToInt32(skillID));
                        updateSkillCmd.ExecuteNonQuery();
                    }


                    string courseID = @"
                        SELECT c.Course_ID , si.Student_ID
                        FROM Student_Information as si
	                    JOIN Courses as c ON c.course_id = si.course_id
                        WHERE si.Student_ID = @Student_ID;";
                    List<int> courseIDArr = new List<int>();
                    using (MySqlCommand getCourseID = new MySqlCommand(courseID, connection))
                    {
                        getCourseID.Parameters.AddWithValue("@Student_ID", personalInformation[0]?.ToString());
                        using (var reader = getCourseID.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                courseIDArr.Add(Convert.ToInt32(reader["Course_ID"]));
                            }
                        }
                    }
                    for (int i = 0; i < courseIDArr.Count; i++)
                    {
                        string courseUpdate = @"
                            UPDATE courses 
                            SET 
                            Course_Code = @Course_Code,
                            Course_Name = @Course_Name,
                            DAY = @DAY,
                            Time = @Time,
                            Units = @Units
                            WHERE course_id = @course_id";
                        using (MySqlCommand cmd = new MySqlCommand(courseUpdate, connection))
                        {
                            cmd.Parameters.AddWithValue("@Course_Code", courseInfo[0][i]?.ToString() ?? "N/A");
                            cmd.Parameters.AddWithValue("@Course_Name", courseInfo[1][i]?.ToString() ?? "N/A");
                            cmd.Parameters.AddWithValue("@DAY", courseInfo[2][i]?.ToString() ?? "N/A");
                            cmd.Parameters.AddWithValue("@Time", courseInfo[3][i]?.ToString() ?? "N/A");
                            cmd.Parameters.AddWithValue("@Units", courseInfo[4][i]?.ToString() ?? "0");
                            cmd.Parameters.AddWithValue("@course_id", Convert.ToInt32(courseIDArr[i]));
                            cmd.ExecuteNonQuery();
                        }
                    }
                   
                }
            }
        }



        public string[] ReadStudentInformation(string id)
        {
            string[] StudentInformation = new string[100];
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT DISTINCT Student_ID, Student_Name, Age, Sex, Birthdate, Address, Email, YearLevel, Section, Program, Department, Status FROM Student_Information WHERE Student_ID = @id";


                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentInformation[0] = reader["Student_ID"].ToString() ?? "Null";
                            StudentInformation[1] = reader["Student_Name"].ToString() ?? "Null";
                            StudentInformation[2] = reader["Age"].ToString() ?? "Null";
                            StudentInformation[3] = reader["Sex"].ToString() ?? "Null";
                            StudentInformation[4] = reader["Birthdate"].ToString() ?? "Null";
                            StudentInformation[5] = reader["Address"].ToString() ?? "Null";
                            StudentInformation[6] = reader["Email"].ToString() ?? "Null";
                            StudentInformation[7] = reader["YearLevel"].ToString() ?? "Null";
                            StudentInformation[8] = reader["Section"].ToString() ?? "Null";
                            StudentInformation[9] = reader["Program"].ToString() ?? "Null";
                            StudentInformation[10] = reader["Department"].ToString() ?? "Null";
                            StudentInformation[11] = reader["Status"].ToString() ?? "Null";
                        }
                    }
                }
            }
            return StudentInformation;
        }

        public List<List<string>> ReadCourseInformation(string ID)
        {
            List<List<string>> courseInfo = new List<List<string>>();
            for (int j = 0; j < 5; j++) // Assuming 5 lists (Course_Code, Course_Name, DAY, Time, Units)
            {
                courseInfo.Add(new List<string>(new string[10])); // Initialize each inner list with 9 empty strings
            }
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();
                   
                    string query = @"
                        SELECT
                            c.Course_Code,
                            c.Course_Name,
                            c.DAY,
                            c.Time,
                            c.Units
                        FROM 
                            Student_Information AS si
                        JOIN 
                            Courses AS c 
                            ON c.course_id = si.course_id
                        WHERE
                            si.Student_ID = @Student_ID
                        ";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Student_ID", ID);
                        command.ExecuteNonQuery();
                        using (var reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                courseInfo[0][i] = reader["Course_Code"].ToString() ?? "";
                                courseInfo[1][i] = reader["Course_Name"].ToString() ?? "";
                                courseInfo[2][i] = reader["DAY"].ToString() ?? "";
                                courseInfo[3][i] = reader["Time"].ToString() ?? "";
                                courseInfo[4][i] = reader["Units"].ToString() ?? "";
                                i++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return courseInfo;
        }
        public string ReadSkillInformation(string ID)
        {
            string skillSets = "";
            try
            {
                using (var connection = new MySqlConnection(stringConnection))
                {
                    connection.Open();

                    string query = @"
                        SELECT 
	                        s.Skill_Name
                        FROM Student_Information as si
	                        JOIN Skills as s ON s.skill_id = si.skill_id
                        WHERE Student_ID = @Student_ID;
                        ";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Student_ID", ID);
                        command.ExecuteNonQuery();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                skillSets = reader["Skill_Name"].ToString() ?? "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return skillSets;
        }
        public int GetAccountID(string username, string password)
        {
            int ID = 0;
            using (MySqlConnection connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = @"
                    SELECT ID FROM Administrator WHERE Username = @Username AND Password = @Password;
                    ";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username?.ToString());
                    cmd.Parameters.AddWithValue("@Password", password?.ToString());
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ID = Convert.ToInt32(reader["ID"]);
                        }
                    }
                }
            }
            return ID;
        }
        public void UpdateAccount(string username, string password, int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = @"
                    UPDATE administrator 
                    SET 
                        Username = @Username, Password = @Password
                    WHERE ID = @ID;
                    ";
                using (MySqlCommand cmd = new MySqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username?.ToString());
                    cmd.Parameters.AddWithValue("@Password", password?.ToString());
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Dictionary<int, int> LoadSkillChart(Dictionary<int, int> skillCounts)
        {
            string query = @"
                SELECT si.YearLevel, COUNT(DISTINCT sk.Skill_ID) AS SkillCount
                FROM Student_Information si
                JOIN Skills sk ON si.Skill_ID = sk.Skill_ID
                GROUP BY si.YearLevel
                ORDER BY si.YearLevel;";

            using (MySqlConnection conn = new MySqlConnection(stringConnection))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
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
            return skillCounts;

        }
    }
}
