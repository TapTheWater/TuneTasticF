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
            this.track_list = new System.Windows.Forms.ListBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.Cursor = System.Windows.Forms.Cursors.Default;
            this.track_list.ForeColor = System.Drawing.SystemColors.Window;
            this.track_list.FormattingEnabled = true;
            this.track_list.Location = new System.Drawing.Point(50, 45);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(571, 286);
            this.track_list.TabIndex = 0;
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Imprima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Location = new System.Drawing.Point(215, 337);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(225, 56);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(677, 428);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.track_list);
            this.Name = "search";
            this.Text = "Search";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Button btn_open;
    }
}