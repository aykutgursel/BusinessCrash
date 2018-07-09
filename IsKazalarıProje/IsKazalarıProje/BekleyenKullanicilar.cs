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
    public partial class BekleyenKullanicilar : Form
    {
        public BekleyenKullanicilar()
        {
            InitializeComponent();
        }

        private void BekleyenKullanicilar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Default anaFrm = (Default)this.MdiParent;
            anaFrm.kullanıcıDüzenleToolStripMenuItem.Enabled = true;
            this.Hide();
      
        }

        public class Uyeler
        {
            public string Adı { get; set; }
            public string Soyadı { get; set; }
            public string KullanıcıAdı { get; set; }
            public DateTime? OlusturmaTarihi { get; set; }
        }


        public void getUser()
        {
            using (BusinessCrashEntities db = new BusinessCrashEntities())
            {

                dataGridView1.DataSource = (from u in db.Users
                                            where u.IsFreeze == true
                                            select new Uyeler
                                            {
                                                Adı = u.Name,
                                                Soyadı = u.Surname,
                                                KullanıcıAdı = u.UserName,
                                                OlusturmaTarihi = u.CreateDate
                                            }).ToList();

            }
        }

        private void BekleyenKullanicilar_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            this.WindowState = FormWindowState.Maximized;

            getUser();


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                btnActive.Enabled = true;
                string KullaniciAdi = dataGridView1.SelectedRows[0].Cells["KullanıcıAdı"].Value.ToString();



                using (BusinessCrashEntities db = new BusinessCrashEntities())
                {
                    try
                    {
                        var k = db.Users.Where(x => x.UserName == KullaniciAdi).FirstOrDefault();
                        k.IsFreeze = false;

                        db.SaveChanges();
                        MessageBox.Show(KullaniciAdi + " kullanıcısı başarıyla aktif edilmiştir");
                        getUser();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kayıt güncellenirken hata oluştu!");
                        return;
                    }
               
                }
            }
            else
            {
                btnActive.Enabled = false;
            }
        }
    }
}
