using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class KayitOl : Form
    {
        AppUsersRepository _appUserRepository;
     
        public KayitOl()
        {
            InitializeComponent();
            _appUserRepository = new AppUsersRepository();
           
        }       
        private void btnUyeOL_Click(object sender, EventArgs e)
        {
          
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor", "TAKE(1)GameBlog");
                return;
            }
            if (txtIsim.Text !=string.Empty && txtSoyisim.Text !=string.Empty && txtKullaniciAdi.Text!=string.Empty && txtSifre.Text!=string.Empty && txtEmail.Text!=string.Empty && txtSifre.Text.Length>8)// kullanıcının bilgilerini bos bırakmamasını ve sifrenin en az 8 karakter icermesini sagladık....
            {
                AppUserProfile ap = new AppUserProfile()
                {
                    FirstName = txtIsim.Text.ToLower(), // kullanıcı değerlerini atadık...
                    LastName = txtSoyisim.Text.ToLower(),
                    BirthDate = dtpDogumTarihi.Value,
                    Email = txtEmail.Text.ToLower()
                };
                AppUser au = new AppUser()
                {
                    UserName = txtKullaniciAdi.Text.ToLower(),
                    Password = txtSifre.Text,//Sifrede Tolower metodlu degil guvenlik amaclı(buyuk kucuk harf)..
                    Profile = ap
                };
                try
                {
                    _appUserRepository.Add(au);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen boşluk bırakmayınız");
                
            }          

        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {        
            Form1 g = new Form1(); //Basildiginda form1 formuna gecis yapsın ve kendini kapatsın...
            g.Show();
            this.Hide();
        }
    }
}
