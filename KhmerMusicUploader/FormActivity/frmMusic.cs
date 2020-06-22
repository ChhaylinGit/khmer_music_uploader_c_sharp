using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhmerMusicUploader.Model
{
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3(*.mp3;)|*.mp3;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtMP3Path.Text = open.FileName;
            }
        }

        private async void loadcomboBoxAsync()
        {
            var singerList = await FirebaseConnection.firebaseClient.Child("Singer").OnceAsync<Singer>();
            cboSinger.DataSource = singerList;
            cboSinger.DisplayMember = "";
            cboSinger.ValueMember = "Key";
        }   
        private void frmMusic_Load(object sender, EventArgs e)
        {
            loadcomboBoxAsync();
        }
    }
}
