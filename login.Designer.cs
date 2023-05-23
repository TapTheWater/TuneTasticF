namespace TuneTastic
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbLogin = new System.Windows.Forms.RadioButton();
            this.rbRegister = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(855, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(773, 228);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 346);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbLogin
            // 
            this.rbLogin.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLogin.AutoSize = true;
            this.rbLogin.BackColor = System.Drawing.Color.Black;
            this.rbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbLogin.FlatAppearance.BorderSize = 0;
            this.rbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbLogin.Location = new System.Drawing.Point(848, 178);
            this.rbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLogin.Name = "rbLogin";
            this.rbLogin.Size = new System.Drawing.Size(70, 35);
            this.rbLogin.TabIndex = 2;
            this.rbLogin.Text = "Login";
            this.rbLogin.UseVisualStyleBackColor = false;
            this.rbLogin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbRegister
            // 
            this.rbRegister.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRegister.AutoSize = true;
            this.rbRegister.BackColor = System.Drawing.Color.Black;
            this.rbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbRegister.FlatAppearance.BorderSize = 4;
            this.rbRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbRegister.Location = new System.Drawing.Point(971, 175);
            this.rbRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRegister.Name = "rbRegister";
            this.rbRegister.Size = new System.Drawing.Size(101, 43);
            this.rbRegister.TabIndex = 3;
            this.rbRegister.Text = "Register";
            this.rbRegister.UseVisualStyleBackColor = false;
            this.rbRegister.CheckedChanged += new System.EventHandler(this.rbRegister_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1195, 623);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1193, 620);
            this.Controls.Add(this.rbRegister);
            this.Controls.Add(this.rbLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.RadioButton rbLogin;
        public System.Windows.Forms.RadioButton rbRegister;
    }
}