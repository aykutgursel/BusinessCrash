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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Default anaFrm = (Default)this.MdiParent;
            anaFrm.profilToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        public string KullaniciAdi { get; set; }
        private void Profile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            using (BusinessCrashEntities db = new BusinessCrashEntities())
            {
                var u = (db.Users.Where(x => x.UserName == KullaniciAdi)).FirstOrDefault();

                txtName.Text = u.Name;
                txtSurname.Text = u.Surname;
                txtUserName.Text = u.UserName;
                txtPassword.Text = u.Password;
                txtPasswordRetry.Text = u.Password;
                if (u.ImagePath != null && u.ImagePath != "")
                    pictureBox1.Image = Image.FromFile("../../UserImage/" + u.ImagePath);



            }


        }

        private void ImageUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Jpg Dosyası |*.jpg| Png Dosyası |*.png| JPEG Dosyası |*.jpeg";
            file.FilterIndex = 1;

            if (file.ShowDialog() == DialogResult.Cancel)
                return;
            label7.Text = file.SafeFileName.ToString();
            pictureBox1.Image = Image.FromFile(file.FileName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordRetry.Text)
            {
                MessageBox.Show("Parolalar eşleşmiyor!");
                return;
            }

            using (BusinessCrashEntities db = new BusinessCrashEntities())
            {

                var ImageControl = (db.Users.Where(x => x.ImagePath == label7.Text)).FirstOrDefault();

                if (ImageControl != null && label7.Text!="")
                {
                    MessageBox.Show("Sistemde Bu isimde resim kayıtlıdır.");
                    return;
                }
                var u = (db.Users.Where(x => x.UserName == KullaniciAdi)).FirstOrDefault();

                u.Name = txtName.Text;
                u.Surname = txtSurname.Text;
                u.UserName = txtUserName.Text;
                u.Password = txtPassword.Text;

                if (label7.Text == "")
                    u.ImagePath = u.ImagePath;
                else
                {
                    pictureBox1.Image.Save("../../UserImage/" + label7.Text);
                    u.ImagePath = label7.Text;
                }

                db.SaveChanges();

                MessageBox.Show("Profil Başarıyla güncellendi");
            }
        }
    }
}
