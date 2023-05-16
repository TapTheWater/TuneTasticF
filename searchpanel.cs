﻿using System;
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
            track_volume.Value = 50;
            label_volume.Text = "50%";
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
            player.settings.volume = track_volume.Value;
            label_volume.Text=track_volume.Value.ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progresssong.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progresssong.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                label_trackstart.Text = player.Ctlcontrols.currentPositionString;
                label_trackend.Text = player.Ctlcontrols.currentItem.durationString.ToString();
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
            player.Ctlcontrols.play();
        }

        private void progresssong_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progresssong.Width;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();

        }

        private void panel_control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                LoadSongs(files);

                SongLoaded?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
