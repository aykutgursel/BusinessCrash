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
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }

        public string KullaniciAdi { get; set; }
        public string Message { get; set; }
        public bool status { get; set; }

        private void Default_Load(object sender, EventArgs e)
        {

            if (status)
            {
                using (BusinessCrashEntities db = new BusinessCrashEntities())
                {
                    var UserMenuControl = (db.Users.Where(x => x.UserName == KullaniciAdi)).FirstOrDefault();
                    lblNameSurname.Text = Message;
                    if (UserMenuControl.IsAdmin)
                    {
                      
                    }
                    else
                    {
                        kullanıcıDüzenleToolStripMenuItem.Visible = false;
                    }


                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void kullanıcıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BekleyenKullanicilar bk = new BekleyenKullanicilar();
            bk.MdiParent = this;
        
            kullanıcıDüzenleToolStripMenuItem.Enabled = false;
            bk.Show();
        }

        private void işKazasıBildirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusinessCrash bk = new BusinessCrash();
            bk.MdiParent = this;
            bk.KullaniciAdi = KullaniciAdi;
            işKazasıBildirToolStripMenuItem.Enabled = false;
            bk.Show();
        }

        private void kazalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crash c = new Crash();
            c.MdiParent = this;
            kazalarToolStripMenuItem.Enabled = false;
            c.Show();
        }

        private void uygulamadanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile c = new Profile();
            c.KullaniciAdi = KullaniciAdi;
            c.MdiParent = this;
            profilToolStripMenuItem.Enabled = false;
            c.Show();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BekleyenKullanicilar bk = new BekleyenKullanicilar();
            bk.Hide();
        }
    }
}
