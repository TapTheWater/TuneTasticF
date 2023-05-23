using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TuneTastic
{
    public partial class registerpanel : Form
    {
        public registerpanel()
        {
            InitializeComponent();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {

        }

        private void registerpanel_Load(object sender, EventArgs e)
        {
            
            checkBox2.Checked = true;  

            Image originalImage = Properties.Resources.passshow; // Replace "icon.png" with your actual image file path or use Properties.Resources.IconName to load from resources

            // Resize the image to 20x20 pixels
            Image resizedImage = new Bitmap(20, 15);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, 20, 15);
            }

            checkBox2.Appearance = Appearance.Button;
            checkBox2.Image = resizedImage;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.FlatAppearance.BorderSize = 0;
            checkBox2.FlatAppearance.CheckedBackColor = Color.White;
            checkBox2.FlatAppearance.MouseDownBackColor = Color.White;

          
        }

        public void ResetRadioButtons()
        {
            if (ParentForm is login mainForm)
            {
                mainForm.rbRegister.Checked = false;
                mainForm.rbLogin.Checked = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Texts;
            string email = txtEmail.Texts;
            string password = txtPass.Texts;

            if (username != "")
            {
                string connectionString = "server=localhost;user=root;database=tunetastic;password=;SslMode=None;";

                string usernameCheckQuery = "SELECT COUNT(*) FROM tb_credentials WHERE username = @Username";
                string emailCheckQuery = "SELECT COUNT(*) FROM tb_credentials WHERE email = @Email";
                string query = "INSERT INTO tb_credentials (username, email, password) SELECT @Username, @Email, @Password FROM dual WHERE NOT EXISTS (SELECT 1 FROM tb_credentials WHERE username = @Username)";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand usernameCheckCmd = new MySqlCommand(usernameCheckQuery, con))
                    {
                        usernameCheckCmd.Parameters.AddWithValue("@Username", username);
                        con.Open();
                        int usernameCount = Convert.ToInt32(usernameCheckCmd.ExecuteScalar());

                        if (usernameCount > 0)
                        {
                            // Username already exists in the database
                            MessageBox.Show("Username is already in use. Please choose a different username.");
                            txtUsername.Texts = "";
                        }
                        else
                        {
                            // Username does not exist, proceed with checking email
                            if (email != "")
                            {
                                using (MySqlCommand emailCheckCmd = new MySqlCommand(emailCheckQuery, con))
                                {
                                    emailCheckCmd.Parameters.AddWithValue("@Email", email);
                                    int emailCount = Convert.ToInt32(emailCheckCmd.ExecuteScalar());

                                    if (emailCount > 0)
                                    {
                                        // Email already exists in the database
                                        MessageBox.Show("Email is already in use. Please use a different email.");
                                        txtEmail.Texts = "";
                                    }
                                    else
                                    {
                                        // Email does not exist, proceed with checking password
                                        if (password != "")
                                        {
                                            if (password.Length >= 8)
                                            {
                                                using (MySqlCommand insertCmd = new MySqlCommand(query, con))
                                                {
                                                    insertCmd.Parameters.AddWithValue("@Username", username);
                                                    insertCmd.Parameters.AddWithValue("@Email", email);
                                                    insertCmd.Parameters.AddWithValue("@Password", password);

                                                    int rowsAffected = insertCmd.ExecuteNonQuery();

                                                    if (rowsAffected > 0)
                                                    {
                                                        // Data successfully inserted into the database
                                                        MessageBox.Show("User registered successfully.");
                                                        ResetRadioButtons();
                                                    }
                                                    else
                                                    {
                                                        // Failed to insert data into the database
                                                        MessageBox.Show("Failed to register user.");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter 8 or more characters!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please input a password!");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please input an email!");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input a username!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.CheckedChanged += (s, _) =>
            {
                if (checkBox2.Checked == true)
                {
                    txtPass.PasswordChar = true; // Mask password characters
                    Image originalImage = Properties.Resources.passshow; // Replace "icon.png" with your actual image file path or use Properties.Resources.IconName to load from resources

                    // Resize the image to 20x20 pixels
                    Image resizedImage = new Bitmap(20, 15);
                    using (Graphics g = Graphics.FromImage(resizedImage))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(originalImage, 0, 0, 20, 15);
                    }

                    checkBox2.Appearance = Appearance.Button;
                    checkBox2.Image = resizedImage;
                    checkBox2.FlatAppearance.BorderSize = 0;
                    checkBox2.FlatAppearance.CheckedBackColor = Color.White;
                    checkBox2.FlatAppearance.MouseDownBackColor = Color.White;

                }
                else
                {
                    txtPass.PasswordChar = false; // Show password characters
                    Image originalImage = Properties.Resources.passhide; // Replace "icon.png" with your actual image file path or use Properties.Resources.IconName to load from resources

                    // Resize the image to 20x20 pixels
                    Image resizedImage = new Bitmap(20, 15);
                    using (Graphics g = Graphics.FromImage(resizedImage))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(originalImage, 0, 0, 20, 15);
                    }

                    checkBox2.Appearance = Appearance.Button;
                    checkBox2.Image = resizedImage;
                    checkBox2.FlatAppearance.BorderSize = 0;
                    checkBox2.FlatAppearance.CheckedBackColor = Color.White;
                    checkBox2.FlatAppearance.MouseDownBackColor = Color.White;
                }
            };
        }
    }
}
