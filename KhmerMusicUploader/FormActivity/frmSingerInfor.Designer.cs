namespace KhmerMusicUploader.FormActivity
{
    partial class frmSingerInfor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvSinger = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.col_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_image_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinger)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 57);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(732, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "ទាញយក";
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
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Location = new System.Drawing.Point(813, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "បន្ថែមថ្មី";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvSinger
            // 
            this.dgvSinger.AllowUserToAddRows = false;
            this.dgvSinger.AllowUserToDeleteRows = false;
            this.dgvSinger.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSinger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_edit,
            this.col_no,
            this.col_key,
            this.col_name,
            this.col_gen,
            this.col_image_url});
            this.dgvSinger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinger.Location = new System.Drawing.Point(0, 57);
            this.dgvSinger.Name = "dgvSinger";
            this.dgvSinger.ReadOnly = true;
            this.dgvSinger.RowTemplate.Height = 30;
            this.dgvSinger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinger.Size = new System.Drawing.Size(901, 383);
            this.dgvSinger.TabIndex = 2;
            this.dgvSinger.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinger_CellClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(901, 22);
            this.statusStrip1.TabIndex = 4;
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
            this.col_key.Visible = false;
            this.col_key.Width = 55;
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_name.HeaderText = "ឈ្មោះអ្នកចំរៀង";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 105;
            // 
            // col_gen
            // 
            this.col_gen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_gen.HeaderText = "ភេទ";
            this.col_gen.Name = "col_gen";
            this.col_gen.ReadOnly = true;
            this.col_gen.Width = 53;
            // 
            // col_image_url
            // 
            this.col_image_url.HeaderText = "Image Url";
            this.col_image_url.Name = "col_image_url";
            this.col_image_url.ReadOnly = true;
            this.col_image_url.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_image_url.Width = 150;
            // 
            // frmSingerInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 462);
            this.Controls.Add(this.dgvSinger);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSingerInfor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ព័ត៌មានអ្នកចំរៀង";
            this.Load += new System.EventHandler(this.frmSingerInfor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinger)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvSinger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pgBar;
        private System.Windows.Forms.DataGridViewButtonColumn col_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_image_url;
    }
}