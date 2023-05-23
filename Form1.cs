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
  
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }
        

        private searchpanel searchPanel;

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openChildFormInPanel(new homepanel());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (searchPanel == null || searchPanel.IsDisposed)
            {
                searchPanel = new searchpanel();
                searchPanel.SongLoaded += SearchPanel_SongLoaded;
            }
            openChildFormInPanel(searchPanel);
        }
        private void SearchPanel_SongLoaded(object sender, EventArgs e)
        {
            // Handle any actions after songs are loaded in the searchpanel
            // For example, you can perform additional logic or update UI elements.
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new homepanel());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new favoritepanel());
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new favoritepanel());
        }

        private void btn_friend_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new favoritepanel());
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new settingspanel());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new profilepanel());
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {

        }
    }
}
