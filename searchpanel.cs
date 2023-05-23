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
using CSAudioVisualization;

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
            btn_open.FlatStyle = FlatStyle.Flat;
            btn_open.FlatAppearance.BorderSize = 0;
            btn_open.FlatAppearance.MouseDownBackColor = Color.DarkGray;

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.Black;
            button5.FlatAppearance.MouseDownBackColor = Color.Black;

            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.DarkGray;
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
                progressBar1.Maximum = (int)player1.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player1.Ctlcontrols.currentPosition;
            }
            try
            {
                label1.Text = player1.Ctlcontrols.currentPositionString;
                label2.Text = player1.Ctlcontrols.currentItem.durationString.ToString();
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
                track_list.Items.AddRange(files);
                paths = track_list.Items.OfType<string>().ToArray();

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

        private void searchpanel_Load(object sender, EventArgs e)
        {
            foreach (CSAudioVisualization.Mode mode in Enum.GetValues(typeof(CSAudioVisualization.Mode)))
            {
                cboRecorderMode.Items.Add(audioVisualization1.GetEnumValue(mode));
            }
            cboRecorderMode.SelectedItem = audioVisualization1.GetEnumValue(audioVisualization1.Mode);

            button6.Text = "Start";
        }

        private void audioVisualization1_Load(object sender, EventArgs e)
        {

        }

        private void searchpanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            audioVisualization1.Stop();

            audioVisualization1.Dispose();

            audioVisualization1 = null;
        }

        private void player1_Enter(object sender, EventArgs e)
        {

        }

        private void player1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Start")
            {
                //Set the mode:
                audioVisualization1.Mode = (CSAudioVisualization.Mode)Enum.Parse(typeof(CSAudioVisualization.Mode), cboRecorderMode.Text);

                //Set the device index:
                audioVisualization1.DeviceIndex = cboAudioSource.SelectedIndex;

                //Set the quality:
                audioVisualization1.HighQuality = true;

                //Set the interval:
                audioVisualization1.Interval = 10;

                //Set the background color:
                audioVisualization1.BackColor = Color.Black;

                //Set the base color:
                audioVisualization1.ColorBase = Color.DarkGray;

                //Set the max color:
                audioVisualization1.ColorMax = Color.Gray;

                //Start:
                audioVisualization1.Start();
                button6.Text = "Stop";
            }
            else if (button6.Text == "Stop")
            {
                audioVisualization1.Stop();
                button6.Text = "Start";
            }
        }

        private void cboRecorderMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CSAudioVisualization.Mode mode = (CSAudioVisualization.Mode)Enum.Parse(typeof(CSAudioVisualization.Mode), cboRecorderMode.Text);

            //Get the audio devices:
            cboAudioSource.DataSource = audioVisualization1.GetDevices(mode);

            //Try to set the default device:
            int default_device_index = audioVisualization1.GetDeviceDefaultIndex(mode);

            if (default_device_index != -1)
                //Set the default device index:
                cboAudioSource.SelectedIndex = default_device_index;
            else
                //LineIn will always return -1:
                cboAudioSource.SelectedIndex = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel_control_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
