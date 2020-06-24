using Firebase.Database.Query;
using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using KhmerMusicUploader.FormActivity;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
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

        private Dictionary<string, string> singerDictionaryList = new Dictionary<string, string>();
        public string musicKey;
        private bool isMusicSelected = false;
        private string musicPath,duration,singerKey,musicTitle;

        public frmMusic(string musicPath, string duration, string singerKey, string musicTitle)
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(firebaseConfig);
            this.musicPath = musicPath;
            this.duration = duration;
            this.singerKey = singerKey;
            this.musicTitle = musicTitle;
        }
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

                txtDuration.Text = getMusicDuration(open.FileName);
                this.isMusicSelected = true;
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

            if (!string.IsNullOrEmpty(musicKey)) { getValue(); }

        }   
        private void frmMusic_Load(object sender, EventArgs e)
        {
            loadcomboBoxAsync();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!empty())
            {
                if (string.IsNullOrEmpty(singerKey))
                {
                    uploadMusic();
                }
                else
                {
                    updateMusic();
                }
            }
        }
        public void getValue()
        {
            txtMP3Path.Text = musicPath;
            txtDuration.Text = duration;
            cboSinger.SelectedValue = singerKey;
            txtTitle.Text = musicTitle;
        }
        private async void updateMusic()
        {
            await client.DeleteTaskAsync("Music/" + singerKey + "/" + musicKey);
            btnSave.Enabled = false;
            var music = new Music
            {
                singerID = cboSinger.SelectedValue.ToString(),
                singerName = cboSinger.Text,
                mp3Uri = this.isMusicSelected ? await getMusicUrl() : txtMP3Path.Text,
                duration = txtDuration.Text.Trim(),
                musicTitle = txtTitle.Text.Trim(),
                singerImageUrl = await getImageUrl(cboSinger.SelectedValue.ToString())
            };
            var response = await client.UpdateTaskAsync("Music/" +cboSinger.SelectedValue.ToString()+"/"+ musicKey, music);
            Music result = response.ResultAs<Music>();
            MessageBox.Show("New music have updated successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = true;
            frmMusicInfor frmSingerInfor = (frmMusicInfor)Application.OpenForms["frmMusicInfor"];
            frmSingerInfor.loadMusicInfor("");
            this.singerKey = "";
            this.musicKey = "";
            this.Close();
        }
        private async void uploadMusic()
        {
            btnSave.Enabled = false;
            var music = new Music
            {
                singerID = cboSinger.SelectedValue.ToString(),
                singerName = cboSinger.Text,
                mp3Uri = await getMusicUrl(),
                duration = txtDuration.Text.Trim(),
                musicTitle = txtTitle.Text.Trim(),
                singerImageUrl = await getImageUrl(cboSinger.SelectedValue.ToString())
            };

            var pushId = FirebasePushIDGenerator.GeneratePushID();
            SetResponse response = await client.SetTaskAsync("Music/" + cboSinger.SelectedValue.ToString() + "/" + pushId, music);
            Music result = response.ResultAs<Music>();
            MessageBox.Show("New music have uploaded successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
        }
        
        private void clear()
        {
            txtMP3Path.Clear();
            txtFileName.Clear();
            txtTitle.Clear();
            txtDuration.Clear();
            cboSinger.SelectedIndex = -1;
            pgBar.Value = 0;
            lblPercentage.Text = "0%";
            btnSave.Enabled = true;
        }
        private bool empty()
        {
            bool result=true;
            if (string.IsNullOrEmpty(txtMP3Path.Text.Trim()))
            {
                MessageBox.Show("Please select music!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cboSinger.SelectedIndex == -1 || string.IsNullOrEmpty(cboSinger.Text))
            {
                MessageBox.Show("Please select singer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                MessageBox.Show("Please input music title!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
            }
            else {
                result = false;
            }
            return result;
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

            txtTitle.Focus();
        }
        private static string getMusicDuration(string filePath)
        {
            TimeSpan time;
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                time = TimeSpan.FromTicks((long)t);
            }
            DateTime dtime = DateTime.Today.Add(time);
            return dtime.ToString("mm:ss");

        }
    }
}
