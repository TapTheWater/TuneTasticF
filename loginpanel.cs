using System;
using System.Drawing;
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
            txtEmail.Text = "Email/Username";
            txtPass.Text = "Password";
            txtEmail.ForeColor = Color.Gray;
            txtPass.ForeColor = Color.Gray;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email/Username")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email/Username";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPass.Text;

            // Check if email and password are not empty
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                string connectionString = "server=localhost;user=root;database=tunetastic;password=;SslMode=None;";

                string query = "SELECT email FROM tb_credentials WHERE email = @Email AND pass = @Password";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Add email and password as parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        con.Open();

                        // Execute the query and check if any rows are returned
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Email and password exist in the database
                                // Perform the necessary actions or redirect to the next page
                                MessageBox.Show("success");
                            }
                            else
                            {
                                // Email and/or password do not exist in the database
                                // Show an error message or take appropriate action
                                MessageBox.Show("error");
                            }
                        }
                    }
                }
            }
            else
            {
                // Email and/or password fields are empty
                // Show an error message or take appropriate action
            }
        }


    }
}
