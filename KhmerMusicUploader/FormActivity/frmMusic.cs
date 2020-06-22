using Firebase.Database.Query;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhmerMusicUploader.Model
{
    public partial class frmMusic : Form
    {
        private IFirebaseConfig firebaseConfig = FirebaseConnection.config;
        private IFirebaseClient client;
        private string imageSingerUrl;
        private Dictionary<string, string> singerDictionaryList = new Dictionary<string, string>();
        public frmMusic()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(firebaseConfig);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3(*.mp3;)|*.mp3;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtMP3Path.Text = open.FileName;
                txtFileName.Text = open.SafeFileName;
            }
        }

        private async Task<string> getImageUrl(string singerid)
        {
            string str="";
            var query = await FirebaseConnection.firebaseClient.Child("Singer").OrderByKey().EqualTo(singerid).OnceAsync<Singer>();
            foreach (var item in query)
            {
                str = item.Object.imageUrl;
            }
            return str;
        }

        private async void loadcomboBoxAsync()
        {
            var singerList = await FirebaseConnection.firebaseClient.Child("Singer").OnceAsync<Singer>();
            foreach (var item in singerList)
            {
                singerDictionaryList.Add(item.Key, item.Object.fullname);
            }
            cboSinger.DataSource = new BindingSource(singerDictionaryList,null); ;
            cboSinger.DisplayMember = "Value";
            cboSinger.ValueMember = "Key";
            cboSinger.SelectedIndex = -1;
        }   
        private void frmMusic_Load(object sender, EventArgs e)
        {
            loadcomboBoxAsync();
        }

        

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var music = new Music
            {
                singerID = cboSinger.SelectedValue.ToString(),
                singerName = cboSinger.Text,
                mp3Uri = await getMusicUrl(),
                duration = txtDuration.Text.Trim(),
                musicTitle = txtTitle.Text.Trim(),
                singerImageUrl = await getImageUrl(cboSinger.SelectedValue.ToString())
            };
        }

        private async Task<string> getMusicUrl()
        {
            var stream = File.Open(txtMP3Path.Text, FileMode.Open);
            var task = new FirebaseStorage("khmer-music-library.appspot.com").Child("Music").Child(txtFileName.Text).PutAsync(stream);
            task.Progress.ProgressChanged += (s, em) => pgBar.Value = em.Percentage;
            task.Progress.ProgressChanged += (s, em) => lblPercentage.Text = em.Percentage + " %";
            string downloadUrl = await task;
            return downloadUrl;
        }

        private async void cboSinger_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await getImageUrl(cboSinger.SelectedValue.ToString());
        }
    }
}
