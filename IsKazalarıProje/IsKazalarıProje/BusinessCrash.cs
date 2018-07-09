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
    public partial class BusinessCrash : Form
    {
        public BusinessCrash()
        {
            InitializeComponent();
        }

        public string KullaniciAdi { get; set; }

        private void BusinessCrash_FormClosing(object sender, FormClosingEventArgs e)
        {
            Default anaFrm = (Default)this.MdiParent;
            anaFrm.işKazasıBildirToolStripMenuItem.Enabled = true;
            this.Hide();
        }

        private void BusinessCrash_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txtUserName.Text = KullaniciAdi;
        }

        public void clear()
        {
            txtNameSurname.Text = "";
            txtYas.Text = "";
            txtKilo.Text = "";
            txtboy.Text = "";
            txtBolum.Text = "";
            txtKazaNedeni.Text = "";
            txtKazaYeri.Text = "";
            txtKazaAciklama.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string NameSurname = txtNameSurname.Text;

            if (txtYas.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!");
                return;
            }
            int yas = Convert.ToInt32(txtYas.Text);

            string kilo = txtKilo.Text.Replace(".","").Replace(",","").Replace(" ","");
            string boy = txtboy.Text.Replace(".", "").Replace(",", "").Replace(" ", "");
            string bolum = txtBolum.Text;
            string kazaNedeni = txtKazaNedeni.Text;
            string kazaYeri = txtKazaYeri.Text;
            string kazaAciklama = txtKazaAciklama.Text;

            if(string.IsNullOrEmpty(NameSurname) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(kilo) || string.IsNullOrEmpty(boy) || string.IsNullOrEmpty(bolum) || string.IsNullOrEmpty(kazaNedeni) || string.IsNullOrEmpty(kazaYeri) || string.IsNullOrEmpty(kazaAciklama))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın!");
                return;
            }

            if(Convert.ToInt32(yas) <= 15)
            {
                MessageBox.Show("Yaş 15 ten küçük olamaz");
                return;
            }
            if (Convert.ToInt32(kilo) <= 0)
            {
                MessageBox.Show("Kilo Doğru Formatta değildir");
                return;
            }
            if (Convert.ToInt32(boy) <= 0)
            {
                MessageBox.Show("Boy Doğru Formatta değildir");
                return;
            }
            if (kazaAciklama.Length <= 15)
            {
                MessageBox.Show("Kaza Açıklaması minimum 12 karakter olmalıdır!");
                return;
            }

            DateTime now = DateTime.Now;
            using (BusinessCrashEntities db = new BusinessCrashEntities())
            {
                try
                {
                    CrashUsers cu = new CrashUsers();
                    cu.UserName = UserName;
                    cu.NameSurname = NameSurname;
                    cu.Age = yas;
                    cu.Weight = kilo;
                    cu.Height = boy;
                    cu.Class = bolum;
                    cu.CrashWhy = kazaNedeni;
                    cu.CrashPlace = kazaYeri;
                    cu.CrashAbout = kazaAciklama;
                    cu.DateTime = now;

                    db.CrashUsers.Add(cu);
                    db.SaveChanges();

                    MessageBox.Show("Kayıt Başarıyla Oluşturuldu");
                    clear();
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt oluştururken hata oluştu");
                    return;
                }

            }








            }
    }
}
