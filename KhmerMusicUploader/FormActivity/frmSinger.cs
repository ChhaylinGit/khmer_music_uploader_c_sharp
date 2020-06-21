using Firebase.Storage;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using KhmerMusicUploader.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhmerMusicUploader.FormActivity
{
    public partial class frmSinger : Form
    {
        private IFirebaseConfig firebaseConfig = FirebaseConnection.config;
        private IFirebaseClient client;
        private string photoFileName = "";
        private bool isPhotoSelect = false;

        public frmSinger()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(firebaseConfig);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream memory = new MemoryStream();
            picSinger.Image.Save(memory,ImageFormat.Jpeg);
            byte[] img = memory.GetBuffer();
            string output = Convert.ToBase64String(img);
            var imgModel = new SingerProfile
            {
                image = output
            };

            var stream = File.Open(photoFileName,FileMode.Open);
            var task = new FirebaseStorage("khmer-music-library.appspot.com").Child("Singer").Child("PhotoName").PutAsync(stream);
            task.Progress.ProgressChanged += (s, em) => progressBar1.Value = em.Percentage;
            task.Progress.ProgressChanged += (s, em) => lblPercentage.Text = em.Percentage + " %";
            var downloadUrl = await task;
            var singer = new Singer
            {
                fullname = txtFullname.Text.Trim(),
                gender = cboGender.Text,
                imageUrl = downloadUrl
            };
            var pushId = FirebasePushIDGenerator.GeneratePushID();
            SetResponse response = await client.SetTaskAsync("Singer/"+ pushId, singer);
            Singer result = response.ResultAs<Singer>();
            
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image(*.jpg; *.jpeg; *.bmp;)|*.jpg; *.jpeg; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.photoFileName = open.FileName;
                picSinger.LoadAsync(photoFileName);
            }
        }
        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
    }
}
