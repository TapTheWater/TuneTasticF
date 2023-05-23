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
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.progresssong = new System.Windows.Forms.ProgressBar();
            this.btn_play = new System.Windows.Forms.Button();
            this.label_volume = new System.Windows.Forms.Label();
            this.label_trackstart = new System.Windows.Forms.Label();
            this.label_trackend = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.track_list = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.player1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.audioVisualization1 = new CSAudioVisualization.AudioVisualization();
            this.button6 = new System.Windows.Forms.Button();
            this.lblRecorderMode = new System.Windows.Forms.Label();
            this.cboRecorderMode = new System.Windows.Forms.ComboBox();
            this.lblAudioSource = new System.Windows.Forms.Label();
            this.cboAudioSource = new System.Windows.Forms.ComboBox();
            this.panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_control
            // 
            this.panel_control.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_control.Controls.Add(this.player);
            this.panel_control.Controls.Add(this.btn_pause);
            this.panel_control.Controls.Add(this.btn_prev);
            this.panel_control.Controls.Add(this.btn_next);
            this.panel_control.Controls.Add(this.track_volume);
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
            this.panel_control.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_control_Paint);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(693, 52);
            this.player.TabIndex = 46;
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
            this.label_volume.Size = new System.Drawing.Size(40, 16);
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
            this.label_trackstart.Size = new System.Drawing.Size(38, 16);
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
            this.label_trackend.Size = new System.Drawing.Size(38, 16);
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
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Black;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Iceberg", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.White;
            this.btn_open.Location = new System.Drawing.Point(0, 12);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(189, 54);
            this.btn_open.TabIndex = 44;
            this.btn_open.Text = "Import Songs";
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click_1);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.Black;
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.Cursor = System.Windows.Forms.Cursors.Default;
            this.track_list.Font = new System.Drawing.Font("Iceberg", 11F);
            this.track_list.ForeColor = System.Drawing.SystemColors.Window;
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 18;
            this.track_list.Location = new System.Drawing.Point(18, 95);
            this.track_list.Margin = new System.Windows.Forms.Padding(4);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(631, 360);
            this.track_list.TabIndex = 0;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(239, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 48);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(439, 523);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 50);
            this.button2.TabIndex = 55;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(632, 536);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(177, 45);
            this.trackBar1.TabIndex = 54;
            this.trackBar1.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 593);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(748, 12);
            this.progressBar1.TabIndex = 53;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            this.progressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progresssong_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(385, 525);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 46);
            this.button3.TabIndex = 52;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(810, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "100%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "00:00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(835, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(584, 511);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(314, 525);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 46);
            this.button4.TabIndex = 57;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Iceberg", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(-37, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 43);
            this.button5.TabIndex = 60;
            this.button5.Text = "Songs";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // player1
            // 
            this.player1.Enabled = true;
            this.player1.Location = new System.Drawing.Point(892, -1);
            this.player1.Name = "player1";
            this.player1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player1.OcxState")));
            this.player1.Size = new System.Drawing.Size(10, 10);
            this.player1.TabIndex = 58;
            this.player1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.player1_PlayStateChange);
            this.player1.Enter += new System.EventHandler(this.player1_Enter);
            // 
            // audioVisualization1
            // 
            this.audioVisualization1.AudioSource = null;
            this.audioVisualization1.BackColor = System.Drawing.Color.Black;
            this.audioVisualization1.BarCount = 50;
            this.audioVisualization1.BarSpacing = 2;
            this.audioVisualization1.ColorBase = System.Drawing.Color.Green;
            this.audioVisualization1.ColorMax = System.Drawing.Color.Red;
            this.audioVisualization1.DeviceIndex = 0;
            this.audioVisualization1.FileName = null;
            this.audioVisualization1.HighQuality = true;
            this.audioVisualization1.Interval = 40;
            this.audioVisualization1.IsXLogScale = true;
            this.audioVisualization1.Location = new System.Drawing.Point(658, 110);
            this.audioVisualization1.Margin = new System.Windows.Forms.Padding(5);
            this.audioVisualization1.MaximumFrequency = 10000;
            this.audioVisualization1.MessageArgs = null;
            this.audioVisualization1.Name = "audioVisualization1";
            this.audioVisualization1.pic3DGraph = null;
            this.audioVisualization1.Size = new System.Drawing.Size(234, 360);
            this.audioVisualization1.TabIndex = 61;
            this.audioVisualization1.UseAverage = true;
            this.audioVisualization1.UserKey = "Your registration key";
            this.audioVisualization1.UserName = "Your email";
            this.audioVisualization1.VisMode = CSAudioVisualization.GraphMode.ModeSpectrum;
            this.audioVisualization1.Load += new System.EventHandler(this.audioVisualization1_Load);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Iceberg", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(817, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 62;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblRecorderMode
            // 
            this.lblRecorderMode.AutoSize = true;
            this.lblRecorderMode.Font = new System.Drawing.Font("Iceberg", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderMode.ForeColor = System.Drawing.Color.White;
            this.lblRecorderMode.Location = new System.Drawing.Point(657, 17);
            this.lblRecorderMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecorderMode.Name = "lblRecorderMode";
            this.lblRecorderMode.Size = new System.Drawing.Size(78, 13);
            this.lblRecorderMode.TabIndex = 66;
            this.lblRecorderMode.Text = "Recorder Mode";
            // 
            // cboRecorderMode
            // 
            this.cboRecorderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecorderMode.Font = new System.Drawing.Font("Iceberg", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRecorderMode.FormattingEnabled = true;
            this.cboRecorderMode.Location = new System.Drawing.Point(767, 14);
            this.cboRecorderMode.Margin = new System.Windows.Forms.Padding(4);
            this.cboRecorderMode.Name = "cboRecorderMode";
            this.cboRecorderMode.Size = new System.Drawing.Size(125, 20);
            this.cboRecorderMode.TabIndex = 65;
            this.cboRecorderMode.SelectedIndexChanged += new System.EventHandler(this.cboRecorderMode_SelectedIndexChanged);
            // 
            // lblAudioSource
            // 
            this.lblAudioSource.AutoSize = true;
            this.lblAudioSource.Font = new System.Drawing.Font("Iceberg", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudioSource.ForeColor = System.Drawing.Color.White;
            this.lblAudioSource.Location = new System.Drawing.Point(671, 50);
            this.lblAudioSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAudioSource.Name = "lblAudioSource";
            this.lblAudioSource.Size = new System.Drawing.Size(70, 13);
            this.lblAudioSource.TabIndex = 64;
            this.lblAudioSource.Text = "Audio Source";
            // 
            // cboAudioSource
            // 
            this.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioSource.Font = new System.Drawing.Font("Iceberg", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAudioSource.FormattingEnabled = true;
            this.cboAudioSource.Location = new System.Drawing.Point(767, 46);
            this.cboAudioSource.Margin = new System.Windows.Forms.Padding(4);
            this.cboAudioSource.Name = "cboAudioSource";
            this.cboAudioSource.Size = new System.Drawing.Size(125, 20);
            this.cboAudioSource.TabIndex = 63;
            // 
            // searchpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(906, 634);
            this.Controls.Add(this.lblRecorderMode);
            this.Controls.Add(this.cboRecorderMode);
            this.Controls.Add(this.lblAudioSource);
            this.Controls.Add(this.cboAudioSource);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.audioVisualization1);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "searchpanel";
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.searchpanel_FormClosing);
            this.Load += new System.EventHandler(this.searchpanel_Load);
            this.panel_control.ResumeLayout(false);
            this.panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.ProgressBar progresssong;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label label_trackstart;
        private System.Windows.Forms.Label label_trackend;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_pause;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private AxWMPLib.AxWindowsMediaPlayer player1;
        private System.Windows.Forms.Button button5;
        private CSAudioVisualization.AudioVisualization audioVisualization1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblRecorderMode;
        private System.Windows.Forms.ComboBox cboRecorderMode;
        private System.Windows.Forms.Label lblAudioSource;
        private System.Windows.Forms.ComboBox cboAudioSource;
    }
}