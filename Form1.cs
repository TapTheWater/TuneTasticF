using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace TuneTastic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            panel_home.Controls.Add(childForm);
            panel_home.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_open_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new searchpanel());
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {

        }
    }
}

