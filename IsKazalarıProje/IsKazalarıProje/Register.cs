using IsKazalarıProje.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsKazalarıProje
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        public void ClearForm()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPasswordRetry.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Surname = txtSurname.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            string PasswordRetry = txtPasswordRetry.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(PasswordRetry))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!", "Uyarı");
                return;
            }

            if (Password != PasswordRetry)
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                return;
            }

            using (BusinessCrashEntities db = new BusinessCrashEntities())
            {
                var UserControl = (db.Users.Where(x => x.UserName == UserName)).FirstOrDefault();
                if (UserControl != null)
                {
                    MessageBox.Show("Sistemde böyle bir kullanıcı zaten kayıtlıdır.");
                    return;
                }

                var ImageControl = (db.Users.Where(x => x.ImagePath == lblImageName.Text)).FirstOrDefault();

                if(ImageControl!=null)
                {
                    MessageBox.Show("Sistemde Bu isimde resim kayıtlıdır.");
                    return;
                }

                DateTime Now = DateTime.Now;

                try
                {
                    Users u = new Users();

                    u.Name = Name;
                    u.Surname = Surname;
                    u.UserName = UserName;
                    u.Password = Password;
                    u.CreateDate = Now;
                    u.IsAdmin = false;
                    u.IsFreeze = true;
                    u.ImagePath = lblImageName.Text;

                    db.Users.Add(u);
                    db.SaveChanges();

                    pictureBox1.Image.Save("../../UserImage/" + lblImageName.Text);

                    MessageBox.Show("Kayıt başarıyla eklendi");
                    ClearForm();

                    Login l = new Login();
                    l.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı Eklenirken Hata Oluştu " + ex.InnerException);
                    return;
                }


              

            }


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Jpg Dosyası |*.jpg| Png Dosyası |*.png| JPEG Dosyası |*.jpeg";
            file.FilterIndex = 1;

            if (file.ShowDialog() == DialogResult.Cancel)
                return;
          
            lblImageName.Text = file.SafeFileName.ToString();
            pictureBox1.Image = Image.FromFile(file.FileName);
            
        }
    }
}
