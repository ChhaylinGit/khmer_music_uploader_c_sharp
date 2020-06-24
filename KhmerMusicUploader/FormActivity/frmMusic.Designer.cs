namespace KhmerMusicUploader.Model
{
    partial class frmMusic
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
            this.cboSinger = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtMP3Path = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblPercentage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSinger
            // 
            this.cboSinger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSinger.FormattingEnabled = true;
            this.cboSinger.Location = new System.Drawing.Point(129, 99);
            this.cboSinger.Name = "cboSinger";
            this.cboSinger.Size = new System.Drawing.Size(242, 27);
            this.cboSinger.TabIndex = 0;
            this.cboSinger.SelectionChangeCommitted += new System.EventHandler(this.cboSinger_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "អ្នកចំរៀង";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(129, 175);
            this.txtDuration.Name = "txtDuration";

            this.txtDuration.ReadOnly = true;

            this.txtDuration.Size = new System.Drawing.Size(242, 27);
            this.txtDuration.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "រយៈពេល";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ចំណងជើង";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(129, 137);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(242, 27);
            this.txtTitle.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(12, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 33);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "ទាញយកបទចំរៀង";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtMP3Path
            // 
            this.txtMP3Path.Font = new System.Drawing.Font("Khmer OS Battambang", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP3Path.Location = new System.Drawing.Point(129, 13);
            this.txtMP3Path.Name = "txtMP3Path";
            this.txtMP3Path.ReadOnly = true;
            this.txtMP3Path.Size = new System.Drawing.Size(526, 32);
            this.txtMP3Path.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Battambang", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(255, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Khmer OS Battambang", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(129, 56);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(526, 32);
            this.txtFileName.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgBar,
            this.lblPercentage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(670, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pgBar
            // 
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(100, 16);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(23, 17);
            this.lblPercentage.Text = "0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KhmerMusicUploader.Properties.Resources.source;
            this.pictureBox1.Location = new System.Drawing.Point(384, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 301);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMP3Path);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSinger);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusic";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "បទចំរៀង";
            this.Load += new System.EventHandler(this.frmMusic_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.TextBox txtMP3Path;
   
        private System.Windows.Forms.TextBox txtFileName;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pgBar;
        private System.Windows.Forms.ToolStripStatusLabel lblPercentage;
        private System.Windows.Forms.PictureBox pictureBox1;

        public System.Windows.Forms.ComboBox cboSinger;
        public System.Windows.Forms.TextBox txtDuration;
        public System.Windows.Forms.TextBox txtTitle;
 

    }
}