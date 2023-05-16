using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneTastic
{
    public partial class searchpanel : Form
    {
        public event EventHandler SongLoaded;
        public void LoadSongs(string[] songPaths)
        {
            track_list.Items.AddRange(songPaths);
        }
        public searchpanel()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            label3.Text = "50%";
        }
        string[] paths, files;


        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }

        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player1.settings.volume = trackBar1.Value;
            label3.Text = trackBar1.Value.ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progresssong.Maximum = (int)player1.Ctlcontrols.currentItem.duration;
                progresssong.Value = (int)player1.Ctlcontrols.currentPosition;
            }
            try
            {
                label_trackstart.Text = player1.Ctlcontrols.currentPositionString;
                label_trackend.Text = player1.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {

            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void btn_open_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }

            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player1.Ctlcontrols.play();
        }

        private void progresssong_MouseDown(object sender, MouseEventArgs e)
        {
            player1.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progresssong.Width;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player1.Ctlcontrols.pause();
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player1.URL = paths[track_list.SelectedIndex];
            player1.Ctlcontrols.play();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void panel_control_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
