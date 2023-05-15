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
        public searchpanel()
        {
            InitializeComponent();
        }
        string[] paths, files;
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files=ofd.FileNames;
                paths=ofd.FileNames;
                for(int x=0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }
    }
}
