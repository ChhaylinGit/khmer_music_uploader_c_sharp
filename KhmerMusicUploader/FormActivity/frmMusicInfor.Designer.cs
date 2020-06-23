namespace KhmerMusicUploader.FormActivity
{
    partial class frmMusicInfor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSinger = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.col_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_music = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_singer_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(777, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "ទាញយកថ្មី";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ស្វែងរកៈ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(69, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(134, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvMusic
            // 
            this.dgvMusic.AllowUserToAddRows = false;
            this.dgvMusic.AllowUserToDeleteRows = false;
            this.dgvMusic.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_edit,
            this.col_no,
            this.col_key,
            this.col_music,
            this.col_duration,
            this.col_singer_key,
            this.col_singer,
            this.col_url});
            this.dgvMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMusic.Location = new System.Drawing.Point(0, 57);
            this.dgvMusic.Name = "dgvMusic";
            this.dgvMusic.ReadOnly = true;
            this.dgvMusic.RowTemplate.Height = 30;
            this.dgvMusic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusic.Size = new System.Drawing.Size(946, 430);
            this.dgvMusic.TabIndex = 6;
            this.dgvMusic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusic_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboSinger);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 57);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "អ្នកចំរៀង";
            // 
            // cboSinger
            // 
            this.cboSinger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSinger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSinger.FormattingEnabled = true;
            this.cboSinger.Location = new System.Drawing.Point(267, 17);
            this.cboSinger.Name = "cboSinger";
            this.cboSinger.Size = new System.Drawing.Size(137, 27);
            this.cboSinger.TabIndex = 4;
            this.cboSinger.SelectionChangeCommitted += new System.EventHandler(this.cboSinger_SelectionChangeCommitted);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Location = new System.Drawing.Point(858, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "បន្ថែមថ្មី";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pgBar
            // 
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(100, 16);
            this.pgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // col_edit
            // 
            this.col_edit.HeaderText = "";
            this.col_edit.Name = "col_edit";
            this.col_edit.ReadOnly = true;
            this.col_edit.Text = "កែប្រែ";
            this.col_edit.UseColumnTextForButtonValue = true;
            this.col_edit.Width = 60;
            // 
            // col_no
            // 
            this.col_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_no.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_no.HeaderText = " លរ";
            this.col_no.Name = "col_no";
            this.col_no.ReadOnly = true;
            this.col_no.Width = 52;
            // 
            // col_key
            // 
            this.col_key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_key.HeaderText = "key";
            this.col_key.Name = "col_key";
            this.col_key.ReadOnly = true;
            this.col_key.Width = 55;
            // 
            // col_music
            // 
            this.col_music.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_music.HeaderText = "បទចំរៀង";
            this.col_music.Name = "col_music";
            this.col_music.ReadOnly = true;
            this.col_music.Width = 78;
            // 
            // col_duration
            // 
            this.col_duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_duration.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_duration.HeaderText = "រយៈពេល";
            this.col_duration.Name = "col_duration";
            this.col_duration.ReadOnly = true;
            this.col_duration.Width = 76;
            // 
            // col_singer_key
            // 
            this.col_singer_key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_singer_key.HeaderText = "singer_key";
            this.col_singer_key.Name = "col_singer_key";
            this.col_singer_key.ReadOnly = true;
            this.col_singer_key.Width = 95;
            // 
            // col_singer
            // 
            this.col_singer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_singer.HeaderText = "អ្នកចំរៀង";
            this.col_singer.Name = "col_singer";
            this.col_singer.ReadOnly = true;
            this.col_singer.Width = 77;
            // 
            // col_url
            // 
            this.col_url.HeaderText = "url";
            this.col_url.Name = "col_url";
            this.col_url.ReadOnly = true;
            // 
            // frmMusicInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 509);
            this.Controls.Add(this.dgvMusic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMusicInfor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "បទចំរៀង";
            this.Load += new System.EventHandler(this.frmMusicInfor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMusic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pgBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSinger;
        private System.Windows.Forms.DataGridViewButtonColumn col_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_music;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_singer_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_singer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_url;
    }
}