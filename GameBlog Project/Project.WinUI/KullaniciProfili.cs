using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
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
    public partial class KullaniciProfili : Form
    {
        AppUser user;
        AppUsersRepository _appUserRepository;
        public KullaniciProfili(AppUser user)
        {
            InitializeComponent();
           
            txtIsim.Text = user.Profile.FirstName;
            txtSoyisim.Text = user.Profile.LastName;
            txtEmail.Text = user.Profile.Email;
            txtKullaniciAdi.Text = user.UserName;
            dtpDogumTarihi.Value = user.Profile.BirthDate;
            this.user = user;
            _appUserRepository = new AppUsersRepository();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text != string.Empty && txtSoyisim.Text != string.Empty && txtKullaniciAdi.Text != string.Empty && txtSifre.Text != string.Empty && txtEmail.Text != string.Empty && txtSifre.Text.Length <= 8 && txtSifre.Text==txtSifreTekrar.Text)// kullanıcının bilgilerini bos bırakmamasını ve sifrenin en az 8 karakter icermesini sagladık...
            {
                user.Profile.FirstName = txtIsim.Text;
                user.Profile.LastName= txtSoyisim.Text;
                user.Profile.Email = txtEmail.Text;
                user.UserName = txtKullaniciAdi.Text;
                user.Password = txtSifre.Text;
                user.Profile.BirthDate = dtpDogumTarihi.Value;

                _appUserRepository.Update(user);
                MessageBox.Show("Güncellendi");

            }
           
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage(user);
            this.Hide();
            mp.Show();
        }
    }
}
