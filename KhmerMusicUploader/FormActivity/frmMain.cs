using KhmerMusicUploader.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhmerMusicUploader.FormActivity
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        protected override void OnResize(EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            frmSingerInfor frm = new frmSingerInfor();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {
            frmMusic frm = new frmMusic();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
