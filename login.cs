using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneTastic
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
            rbLogin.FlatAppearance.BorderSize = 0;
            rbLogin.FlatStyle = FlatStyle.Flat;
            rbLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rbLogin.FlatAppearance.CheckedBackColor = Color.Transparent;

            rbRegister.FlatAppearance.BorderSize = 0;
            rbRegister.FlatStyle = FlatStyle.Flat;
            rbRegister.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rbRegister.FlatAppearance.CheckedBackColor = Color.Transparent;

            if (rbLogin.Checked == true)
            {
                rbLogin.FlatAppearance.BorderColor = Color.Blue;
                rbLogin.Font = new Font(rbLogin.Font, FontStyle.Underline);
            }
            else
            {
                rbLogin.FlatAppearance.BorderColor = SystemColors.ControlDark;
                rbLogin.Font = new Font(rbLogin.Font, FontStyle.Regular);
            }

            rbLogin.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //underline
            RadioButton radioButton = (RadioButton)sender;
            if (rbLogin.Checked == true)
            {
                rbLogin.FlatAppearance.BorderColor = Color.Blue;
                rbLogin.Font = new Font(rbLogin.Font, FontStyle.Underline);
            }
            else
            {
                rbLogin.FlatAppearance.BorderColor = SystemColors.ControlDark;
                rbLogin.Font = new Font(rbLogin.Font, FontStyle.Regular);
            }

            //change panel
            if (rbLogin.Checked == true)
            {
                openChildFormInPanel(new loginpanel());
            }
            
        }

        private void rbRegister_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (rbRegister.Checked)
            {
                rbRegister.FlatAppearance.BorderColor = Color.Blue;
                rbRegister.Font = new Font(rbRegister.Font, FontStyle.Underline);
            }
            else
            {
                rbRegister.FlatAppearance.BorderColor = SystemColors.ControlDark;
                rbRegister.Font = new Font(rbRegister.Font, FontStyle.Regular);
            }

            // change panel
            if (rbRegister.Checked == true)
            {
                openChildFormInPanel(new registerpanel());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
