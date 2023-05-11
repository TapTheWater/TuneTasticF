using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (txtEmail.Text != "Email" && txtEmail.Text != "" && txtPass.Text != "Password" && txtPass.Text != "")
            {
                query = "SELECT email FROM tb_credentials WHERE email = '" + email + "'";
                con = new MySqlConnection(mysqlconnect);
                con.Open();
                cmd = new MySqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    string emailsql = email;
                }
                    if (txtEmail.Text == emailsql)
                    {

                    }

            }
        }
    }
}
