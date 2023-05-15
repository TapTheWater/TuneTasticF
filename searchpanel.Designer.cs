namespace TuneTastic
{
    partial class searchpanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchpanel));
            this.panel_control = new System.Windows.Forms.Panel();
            this.btn_open = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.progresssong = new System.Windows.Forms.ProgressBar();
            this.btn_play = new System.Windows.Forms.Button();
            this.label_volume = new System.Windows.Forms.Label();
            this.label_trackstart = new System.Windows.Forms.Label();
            this.label_trackend = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_pause = new System.Windows.Forms.Button();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_control.Controls.Add(this.btn_pause);
            this.panel_control.Controls.Add(this.btn_open);
            this.panel_control.Controls.Add(this.track_list);
            this.panel_control.Controls.Add(this.btn_prev);
            this.panel_control.Controls.Add(this.btn_next);
            this.panel_control.Controls.Add(this.track_volume);
            this.panel_control.Controls.Add(this.player);
            this.panel_control.Controls.Add(this.progresssong);
            this.panel_control.Controls.Add(this.btn_play);
            this.panel_control.Controls.Add(this.label_volume);
            this.panel_control.Controls.Add(this.label_trackstart);
            this.panel_control.Controls.Add(this.label_trackend);
            this.panel_control.Controls.Add(this.pictureBox8);
            this.panel_control.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_control.Location = new System.Drawing.Point(-8, -20);
            this.panel_control.Margin = new System.Windows.Forms.Padding(2);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(693, 542);
            this.panel_control.TabIndex = 6;
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Location = new System.Drawing.Point(487, 350);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(147, 41);
            this.btn_open.TabIndex = 44;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click_1);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.Cursor = System.Windows.Forms.Cursors.Default;
            this.track_list.ForeColor = System.Drawing.SystemColors.Window;
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(63, 58);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(571, 286);
            this.track_list.TabIndex = 43;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // btn_prev
            // 
            this.btn_prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_prev.BackgroundImage")));
            this.btn_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_prev.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_prev.Location = new System.Drawing.Point(169, 444);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(2);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(38, 39);
            this.btn_prev.TabIndex = 42;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_next.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_next.Location = new System.Drawing.Point(326, 444);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(49, 41);
            this.btn_next.TabIndex = 41;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(475, 453);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(133, 45);
            this.track_volume.TabIndex = 40;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(693, 36);
            this.player.TabIndex = 39;
            this.player.Visible = false;
            // 
            // progresssong
            // 
            this.progresssong.Location = new System.Drawing.Point(136, 501);
            this.progresssong.Name = "progresssong";
            this.progresssong.Size = new System.Drawing.Size(488, 10);
            this.progresssong.TabIndex = 37;
            this.progresssong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progresssong_MouseDown);
            // 
            // btn_play
            // 
            this.btn_play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_play.BackgroundImage")));
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_play.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_play.Location = new System.Drawing.Point(284, 446);
            this.btn_play.Margin = new System.Windows.Forms.Padding(2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(28, 37);
            this.btn_play.TabIndex = 36;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // label_volume
            // 
            this.label_volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_volume.AutoSize = true;
            this.label_volume.ForeColor = System.Drawing.Color.LightGray;
            this.label_volume.Location = new System.Drawing.Point(613, 454);
            this.label_volume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(33, 13);
            this.label_volume.TabIndex = 35;
            this.label_volume.Text = "100%";
            // 
            // label_trackstart
            // 
            this.label_trackstart.AutoSize = true;
            this.label_trackstart.ForeColor = System.Drawing.Color.LightGray;
            this.label_trackstart.Location = new System.Drawing.Point(82, 498);
            this.label_trackstart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_trackstart.Name = "label_trackstart";
            this.label_trackstart.Size = new System.Drawing.Size(34, 13);
            this.label_trackstart.TabIndex = 34;
            this.label_trackstart.Text = "00:00";
            // 
            // label_trackend
            // 
            this.label_trackend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_trackend.AutoSize = true;
            this.label_trackend.ForeColor = System.Drawing.Color.LightGray;
            this.label_trackend.Location = new System.Drawing.Point(645, 500);
            this.label_trackend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_trackend.Name = "label_trackend";
            this.label_trackend.Size = new System.Drawing.Size(34, 13);
            this.label_trackend.TabIndex = 33;
            this.label_trackend.Text = "00:00";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(446, 449);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_pause
            // 
            this.btn_pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pause.BackgroundImage")));
            this.btn_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_pause.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_pause.Location = new System.Drawing.Point(228, 449);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(31, 30);
            this.btn_pause.TabIndex = 45;
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // searchpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 503);
            this.Controls.Add(this.panel_control);
            this.Name = "searchpanel";
            this.Text = "Search";
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TrackBar track_volume;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.ProgressBar progresssong;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label label_trackstart;
        private System.Windows.Forms.Label label_trackend;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_pause;
    }
}