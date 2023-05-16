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
        }
        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {

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
