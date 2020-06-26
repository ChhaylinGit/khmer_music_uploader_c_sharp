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
        private bool isImageSelected = false;
        public string updateKey = "";

        public frmSinger()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(firebaseConfig);
        }

        private bool empty()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txtFilePath.Text.Trim()))
            {
                MessageBox.Show("Please select image!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtFullname.Text.Trim()))
            {
                MessageBox.Show("Please input fullname!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullname.Focus();
            }else if(string.IsNullOrEmpty(cboGender.Text) || cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                result = false;
            }
            return result;
        }

        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            if (!empty())
            {
                if (string.IsNullOrEmpty(updateKey))
                {
                    if (await duplicate() == false)
                    {
                        uploadSinger();
                    }
                    else
                    {
                        lblPercentage.Text = "0%";
                        MessageBox.Show("Duplicate singer name!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    updateSinger();
                }
            }
        }

        private async Task<bool> duplicate()
        {
            lblPercentage.Text = "Checking duplicate......";
            bool result = false;
            var singerList = await FirebaseConnection.firebaseClient.Child("Singer").OnceAsync<Singer>();
            foreach (var item in singerList)
            {
                if (item.Object.fullname.Equals(txtFullname.Text.Trim()))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private async void uploadSinger()
        {
            var singer = new Singer
            {
                fullname = txtFullname.Text.Trim(),
                gender = cboGender.Text,
                imageUrl = await getImageUrl()
            };
            var pushId = FirebasePushIDGenerator.GeneratePushID();
            SetResponse response = await client.SetTaskAsync("Singer/" + pushId, singer);
            Singer result = response.ResultAs<Singer>();
            MessageBox.Show("New singer have uploaded successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear();
            frmSingerInfor frmSingerInfor = (frmSingerInfor)Application.OpenForms["frmSingerInfor"];
            frmSingerInfor.loadSinger("");
        }

        private async void updateSinger()
        {
            var singer = new Singer
            {
                fullname = txtFullname.Text.Trim(),
                gender = cboGender.Text,
                imageUrl = isImageSelected ? await getImageUrl() : txtFilePath.Text.Trim()
            };
            var response = await client.UpdateTaskAsync("Singer/" + updateKey, singer);
            Singer result = response.ResultAs<Singer>();
            MessageBox.Show("New singer have updated successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmSingerInfor frmSingerInfor = (frmSingerInfor)Application.OpenForms["frmSingerInfor"];
            frmSingerInfor.loadSinger("");
            this.Close();
        }

        private void clear()
        {
            picSinger.Image = Properties.Resources.default_user;
            txtFileName.Clear();
            txtFilePath.Clear();
            txtFullname.Clear();
            pgBar.Value = 0;
            lblPercentage.Text = "0%";
            cboGender.SelectedIndex = -1;
            isImageSelected = false;
        }

        private async Task<string> getImageUrl()
        {
            var stream = File.Open(txtFilePath.Text, FileMode.Open);
            var task = new FirebaseStorage("khmer-music-library.appspot.com").Child("Singer").Child(txtFileName.Text).PutAsync(stream);
            task.Progress.ProgressChanged += (s, em) => pgBar.Value = em.Percentage;
            task.Progress.ProgressChanged += (s, em) => lblPercentage.Text = em.Percentage + " %";
            string downloadUrl = await task;
            return downloadUrl;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image(*.jpg; *.jpeg; *.bmp; *.png;)|*.jpg; *.jpeg; *.bmp; *.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = open.FileName;
                txtFileName.Text = open.SafeFileName.Replace(" ",string.Empty);
                picSinger.LoadAsync(txtFilePath.Text);
                isImageSelected = true;
            }
        }
        

        private void frmSinger_Load(object sender, EventArgs e)
        {

        }
    }
}
