using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentmanagementsystem.Queries;

namespace studentmanagementsystem.content
{
    public partial class Profile : Form
    {
        private int AccountID;
        private string username;
        private string password;
        public Profile(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

        }
       
        SQLQueries queries = new SQLQueries();
        private void Profile_Load(object sender, EventArgs e)
        {
            Username.Text = username;
            Password.Text = password;
            AccountID = queries.GetAccountID(username, password);
        }

        private void EditAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                queries.UpdateAccount(Username.Text, Password.Text, AccountID);
                MessageBox.Show("Account update successful");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
