namespace TuneTastic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.progresssong = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label_trackstart = new System.Windows.Forms.Label();
            this.label_trackend = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_friend = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_playlist = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_friend);
            this.panel2.Controls.Add(this.btn_setting);
            this.panel2.Controls.Add(this.btn_profile);
            this.panel2.Controls.Add(this.btn_playlist);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Font = new System.Drawing.Font("Iceberg", 12F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 681);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 497);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.btn_prev);
            this.panel3.Controls.Add(this.btn_next);
            this.panel3.Controls.Add(this.track_volume);
            this.panel3.Controls.Add(this.player);
            this.panel3.Controls.Add(this.progresssong);
            this.panel3.Controls.Add(this.btn_play);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label_trackstart);
            this.panel3.Controls.Add(this.label_trackend);
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(199, 480);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 201);
            this.panel3.TabIndex = 5;
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(636, 89);
            this.track_volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(177, 56);
            this.track_volume.TabIndex = 40;
            // 
            // progresssong
            // 
            this.progresssong.Location = new System.Drawing.Point(87, 148);
            this.progresssong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progresssong.Name = "progresssong";
            this.progresssong.Size = new System.Drawing.Size(748, 12);
            this.progresssong.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(820, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "100%";
            // 
            // label_trackstart
            // 
            this.label_trackstart.AutoSize = true;
            this.label_trackstart.ForeColor = System.Drawing.Color.LightGray;
            this.label_trackstart.Location = new System.Drawing.Point(16, 146);
            this.label_trackstart.Name = "label_trackstart";
            this.label_trackstart.Size = new System.Drawing.Size(38, 16);
            this.label_trackstart.TabIndex = 34;
            this.label_trackstart.Text = "00:00";
            // 
            // label_trackend
            // 
            this.label_trackend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_trackend.AutoSize = true;
            this.label_trackend.ForeColor = System.Drawing.Color.LightGray;
            this.label_trackend.Location = new System.Drawing.Point(863, 146);
            this.label_trackend.Name = "label_trackend";
            this.label_trackend.Size = new System.Drawing.Size(38, 16);
            this.label_trackend.TabIndex = 33;
            this.label_trackend.Text = "00:00";
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
            this.btn_prev.Location = new System.Drawing.Point(315, 78);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(51, 48);
            this.btn_prev.TabIndex = 42;
            this.btn_prev.UseVisualStyleBackColor = true;
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
            this.btn_next.Location = new System.Drawing.Point(437, 78);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(65, 50);
            this.btn_next.TabIndex = 41;
            this.btn_next.UseVisualStyleBackColor = true;
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
            this.btn_play.Location = new System.Drawing.Point(388, 80);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(37, 46);
            this.btn_play.TabIndex = 36;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(597, 89);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 32;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(173, 92);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(231, 92);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 30;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(527, 90);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // btn_friend
            // 
            this.btn_friend.BackColor = System.Drawing.Color.Black;
            this.btn_friend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_friend.FlatAppearance.BorderSize = 0;
            this.btn_friend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_friend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_friend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_friend.Font = new System.Drawing.Font("Iceberg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_friend.ForeColor = System.Drawing.Color.White;
            this.btn_friend.Image = ((System.Drawing.Image)(resources.GetObject("btn_friend.Image")));
            this.btn_friend.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_friend.Location = new System.Drawing.Point(0, 504);
            this.btn_friend.Margin = new System.Windows.Forms.Padding(4);
            this.btn_friend.Name = "btn_friend";
            this.btn_friend.Size = new System.Drawing.Size(204, 59);
            this.btn_friend.TabIndex = 6;
            this.btn_friend.Text = "      Friends";
            this.btn_friend.UseVisualStyleBackColor = false;
            this.btn_friend.Click += new System.EventHandler(this.btn_friend_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.Black;
            this.btn_setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Iceberg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.Image = ((System.Drawing.Image)(resources.GetObject("btn_setting.Image")));
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_setting.Location = new System.Drawing.Point(0, 563);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(4);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(204, 59);
            this.btn_setting.TabIndex = 5;
            this.btn_setting.Text = "       Settings";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.Black;
            this.btn_profile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Iceberg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_profile.Location = new System.Drawing.Point(0, 622);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(204, 59);
            this.btn_profile.TabIndex = 4;
            this.btn_profile.Text = "     Profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_playlist
            // 
            this.btn_playlist.BackColor = System.Drawing.Color.Black;
            this.btn_playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_playlist.FlatAppearance.BorderSize = 0;
            this.btn_playlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_playlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playlist.Font = new System.Drawing.Font("Iceberg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playlist.ForeColor = System.Drawing.Color.White;
            this.btn_playlist.Image = ((System.Drawing.Image)(resources.GetObject("btn_playlist.Image")));
            this.btn_playlist.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_playlist.Location = new System.Drawing.Point(0, 182);
            this.btn_playlist.Margin = new System.Windows.Forms.Padding(4);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(204, 59);
            this.btn_playlist.TabIndex = 3;
            this.btn_playlist.Text = "       Playlists";
            this.btn_playlist.UseVisualStyleBackColor = false;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Iceberg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(0, 123);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "        Favorite";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Black;
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Iceberg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_search.Location = new System.Drawing.Point(0, 64);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(204, 59);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "      Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Black;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Iceberg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(204, 64);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "    Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(924, 35);
            this.player.TabIndex = 39;
            this.player.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_playlist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_friend;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progresssong;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_trackstart;
        private System.Windows.Forms.Label label_trackend;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TrackBar track_volume;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

