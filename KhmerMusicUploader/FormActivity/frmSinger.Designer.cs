namespace KhmerMusicUploader.FormActivity
{
    partial class frmSinger
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
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.picSinger = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSinger)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.Location = new System.Drawing.Point(21, 168);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(150, 41);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "ជ្រើសរើស";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(290, 25);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(140, 30);
            this.txtFullname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "ឈ្មោះអ្នកចំរៀង";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(290, 70);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(140, 30);
            this.cboGender.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = " ភេទ";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Battambang", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Location = new System.Drawing.Point(326, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 41);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picSinger
            // 
            this.picSinger.Image = global::KhmerMusicUploader.Properties.Resources.user_male_circle_filled_50px2;
            this.picSinger.Location = new System.Drawing.Point(21, 12);
            this.picSinger.Name = "picSinger";
            this.picSinger.Size = new System.Drawing.Size(150, 150);
            this.picSinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSinger.TabIndex = 0;
            this.picSinger.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 217);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(462, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(416, 192);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(28, 22);
            this.lblPercentage.TabIndex = 8;
            this.lblPercentage.Text = "0%";
            // 
            // frmSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 240);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.picSinger);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSinger";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "អ្នកចំរៀង";
            ((System.ComponentModel.ISupportInitialize)(this.picSinger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSinger;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPercentage;
    }
}