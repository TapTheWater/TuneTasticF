namespace TuneTastic
{
    partial class MainPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datagrid_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_songname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagrid_album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datagrid_Number,
            this.datagrid_songname,
            this.datagrid_singer,
            this.datagrid_album});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(673, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // datagrid_Number
            // 
            this.datagrid_Number.HeaderText = "Number";
            this.datagrid_Number.Name = "datagrid_Number";
            // 
            // datagrid_songname
            // 
            this.datagrid_songname.HeaderText = "Song Name";
            this.datagrid_songname.Name = "datagrid_songname";
            // 
            // datagrid_singer
            // 
            this.datagrid_singer.HeaderText = "Singer";
            this.datagrid_singer.Name = "datagrid_singer";
            // 
            // datagrid_album
            // 
            this.datagrid_album.HeaderText = "Album";
            this.datagrid_album.Name = "datagrid_album";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(673, 390);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_songname;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_singer;
        private System.Windows.Forms.DataGridViewTextBoxColumn datagrid_album;
    }
}