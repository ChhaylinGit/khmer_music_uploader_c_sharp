using Firebase.Database.Query;
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
    public partial class frmMusicInfor : Form
    {
        private Dictionary<string, string> singerDictionaryList = new Dictionary<string, string>();
        public frmMusicInfor()
        {
            InitializeComponent();
        }

        private async void loadcomboBoxAsync()
        {
            var singerList = await FirebaseConnection.firebaseClient.Child("Singer").OnceAsync<Singer>();
            foreach (var item in singerList)
            {
                singerDictionaryList.Add(item.Key, item.Object.fullname);
            }
            cboSinger.DataSource = new BindingSource(singerDictionaryList, null); ;
            cboSinger.DisplayMember = "Value";
            cboSinger.ValueMember = "Key";
            cboSinger.SelectedIndex = -1;
        }

        public async void loadMusicInfor(string searchText)
        {
            int rowIndex = 0;
            pgBar.Visible = true;
            var singerKeyList = await FirebaseConnection.firebaseClient.Child("Music").OnceAsync<Music>();
            dgvMusic.Rows.Clear();
            foreach (var singerItem in singerKeyList)
            {
                var musicKeyList = await FirebaseConnection.firebaseClient.Child("Music").Child(singerItem.Key).OnceAsync<Music>();
                foreach (var musicItem in musicKeyList)
                {
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        if (musicItem.Object.musicTitle.Contains(searchText) || musicItem.Object.singerName.Contains(searchText))
                        {
                            rowIndex++;
                            dgvMusic.Rows.Add(null, rowIndex, musicItem.Key, musicItem.Object.musicTitle, musicItem.Object.duration,musicItem.Object.singerID, musicItem.Object.singerName,musicItem.Object.mp3Uri);
                        }
                    }
                    else
                    {
                        rowIndex++;
                        dgvMusic.Rows.Add(null, rowIndex, musicItem.Key, musicItem.Object.musicTitle, musicItem.Object.duration, musicItem.Object.singerID, musicItem.Object.singerName, musicItem.Object.mp3Uri);
                    }
                }
            }
            pgBar.Visible = false;
        }

        private void frmMusicInfor_Load(object sender, EventArgs e)
        {
            loadMusicInfor("");
            loadcomboBoxAsync();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMusicInfor("");
            btnRefresh.Enabled = false;
            txtSearch.Clear();
            cboSinger.SelectedIndex = -1;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    loadMusicInfor(txtSearch.Text.Trim());
                    btnRefresh.Enabled = true;
                }
            }
        }

        private void cboSinger_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadMusicInfor(cboSinger.Text);
            btnRefresh.Enabled = true;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frmMusic().ShowDialog();
        }

        private void dgvMusic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvMusic.Columns["col_edit"].Index)
                {
                    Cursor = Cursors.WaitCursor;
                    frmMusic frm = new frmMusic
                        (
                            dgvMusic.CurrentRow.Cells["col_url"].Value.ToString(),
                            dgvMusic.CurrentRow.Cells["col_duration"].Value.ToString(),
                            dgvMusic.CurrentRow.Cells["col_singer_key"].Value.ToString(),
                            dgvMusic.CurrentRow.Cells["col_music"].Value.ToString()
                        );
                    frm.musicKey = dgvMusic.CurrentRow.Cells["col_key"].Value.ToString();
                    frm.ShowDialog();
                    Cursor = Cursors.Default;
                }
            }
        }
    }
}
