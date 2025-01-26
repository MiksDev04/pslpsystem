using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace studentmanagementsystem.Queries
{
    internal class SQLQueries
    {

        // Main SQL connection
        string stringConnection = "Server=localhost;Database=universitydb;User=root;Password=;";

        public DataTable LoadDBContent(string Department, string YearLevel, string Program, string Sex, string Status)
        {
            DataTable dataTable = new DataTable();
            using (var connection = new MySqlConnection(stringConnection))
            {
                connection.Open();
                string query = "SELECT * FROM Personal_Information ";
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
                    query += "AND Status = @Status";
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
                SELECT * FROM Personal_Information
                WHERE 
                (Student_ID LIKE @search) OR
                (Student_Name LIKE @search) OR
                (Birthdate LIKE @search) OR
                (Address LIKE @search) OR
                (Email LIKE @search) OR
                (Phone_Number LIKE @search)";

                MessageBox.Show("HUHUHUUHUH");
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
    }
}
