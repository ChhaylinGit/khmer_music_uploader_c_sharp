using Firebase.Database;
using Firebase.Database.Query;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using KhmerMusicUploader.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhmerMusicUploader.FormActivity
{
    public partial class frmSingerInfor : Form
    {
        private IFirebaseConfig firebaseConfig = FirebaseConnection.config;
        private IFirebaseClient client;
      
        public frmSingerInfor()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(firebaseConfig);
        }
        private void frmSingerInfor_Load(object sender, EventArgs e)
        {
            loadSinger("");
        }
        public async void loadSinger(string searchText)
        {
            int rowIndex = 0;
            pgBar.Visible = true;
            var singerList = await FirebaseConnection.firebaseClient.Child("Singer").OnceAsync<Singer>();
            dgvSinger.Rows.Clear();
            foreach (var item in singerList)
            {
                if (!string.IsNullOrEmpty(searchText))
                {
                    if (item.Object.fullname.Contains(searchText))
                    {
                        rowIndex++;
                        dgvSinger.Rows.Add(null, rowIndex, item.Key, item.Object.fullname, item.Object.gender, item.Object.imageUrl);
                    }
                }
                else
                {
                    rowIndex++;
                    dgvSinger.Rows.Add(null, rowIndex, item.Key, item.Object.fullname, item.Object.gender,item.Object.imageUrl);
                }    
            }
            pgBar.Visible = false;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    loadSinger(txtSearch.Text.Trim());
                    btnRefresh.Enabled = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadSinger("");
            btnRefresh.Enabled = false;
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void dgvSinger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvSinger.Columns["col_edit"].Index)
                {
                    Cursor = Cursors.WaitCursor;
                    frmSinger frm = new frmSinger();
                    frm.txtFullname.Text = dgvSinger.CurrentRow.Cells["col_name"].Value.ToString();
                    frm.cboGender.Text = dgvSinger.CurrentRow.Cells["col_gen"].Value.ToString();
                    frm.updateKey = dgvSinger.CurrentRow.Cells["col_key"].Value.ToString();
                    frm.txtFilePath.Text = dgvSinger.CurrentRow.Cells["col_image_url"].Value.ToString();
                    if (isUrl(dgvSinger.CurrentRow.Cells["col_image_url"].Value.ToString()))
                    {
                        frm.picSinger.Load(dgvSinger.CurrentRow.Cells["col_image_url"].Value.ToString());
                    }
                    Cursor = Cursors.Default;
                    frm.ShowDialog();
                }
            }
           
        }

        private bool isUrl(string uriName)
        {
            Uri uriResult;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            return result;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frmSinger().ShowDialog();
        }
    }
}
