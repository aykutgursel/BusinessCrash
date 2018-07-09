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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Password = txtPassword.Text;

            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Lütfen boş alan bırakmayın !");
                return;
            }

            using (BusinessCrashEntities db = new BusinessCrashEntities())
            {
                Users u = (db.Users.Where(x => x.UserName == UserName && x.Password == Password)).FirstOrDefault();

                if (u == null)
                {
                    MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış !");
                    return;
                }

                if (u.IsFreeze == true)
                {
                    MessageBox.Show("Bu kullanıcı onaylanmamıştır !");
                    return;
                }

                string rol = "";
                if (u.IsAdmin)
                    rol = "Admin";
                else
                    rol = "Kullanıcı";


                Default d = new Default();
                d.KullaniciAdi = UserName;
                d.status = true;
                d.Message = "Merhaba " + u.Name + " " + u.Surname + " | Yetkiniz : " + rol; 
                d.Show();
                this.Hide();


            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
