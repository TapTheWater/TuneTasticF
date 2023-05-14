using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TuneTastic
{
    
    public partial class loginpanel : Form
    {
        MySqlConnection con;
        string mysqlconnect = "server=localhost;user=root;database=tunetastic;password=";
        MySqlCommand cmd;
        string query;
        MySqlDataAdapter adapt;
        public loginpanel()
        {
            InitializeComponent();
            
        }
      

        private void loginpanel_Load(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailOrUsername = txtEmail.Texts;
            string password = txtPass.Texts;

            // Check if email/username and password are not empty
            if (!string.IsNullOrEmpty(emailOrUsername) && !string.IsNullOrEmpty(password))
            {
                string connectionString = "server=localhost;user=root;database=tunetastic;password=;SslMode=None;";

                string query = "SELECT email FROM tb_credentials WHERE (email = @EmailOrUsername OR username = @EmailOrUsername) AND pass = @Password";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Add email/username and password as parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@EmailOrUsername", emailOrUsername);
                        cmd.Parameters.AddWithValue("@Password", password);

                        con.Open();

                        // Execute the query and check if any rows are returned
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Email/username and password exist in the database
                                // Perform the necessary actions or redirect to the next page
                                MessageBox.Show("You're now logged in.");
                                Form1 form1 = new Form1();
                                form1.Show();
                                form1.Shown += (s, ev) =>
                                {
                                    // Close the parent form when form1 is shown
                                    ParentForm.Hide(); // Hide the parent form instead of closing it
                                };
                                form1.Show();
                            }
                            else
                            {
                                // Email/username and/or password do not exist in the database
                                // Show an error message or take appropriate action
                                MessageBox.Show("Invalid email/username or password.");
                            }
                        }
                    }
                }
            }
            else
            {
                // Email/username and/or password fields are empty
                // Show an error message or take appropriate action
                MessageBox.Show("Please enter your credentials.");
            }

        }

        private void txtEmai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
