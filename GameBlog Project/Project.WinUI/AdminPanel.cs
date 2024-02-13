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
    public partial class AdminPanel : Form
    {
        CommentRepository _commentRepository;
        GameRepository _gameRepository;
        AppUsersRepository _appUserRepository;
        CategoryRepository _categoryRepository;
        AppUser User;
        public AdminPanel(AppUser user)
        {
            InitializeComponent();
            User = user;
            _commentRepository = new CommentRepository();
            _gameRepository = new GameRepository();
            _appUserRepository = new AppUsersRepository();
            _categoryRepository = new CategoryRepository();
            lstUyeler.DataSource = _appUserRepository.GetActives();
            cmbKategoriler.DataSource = _categoryRepository.GetAll();           
            cmbKullanicilar.DataSource = _appUserRepository.GetAll();
            cmbKullanicilar.SelectedIndex = -1;




        }

        private void btnOyunEkle_Click(object sender, EventArgs e)
        {
            if (txtOyunIsmi.Text != string.Empty && cmbKategoriler.SelectedIndex>-1)
            {
                Game g = new Game()
                {
                    Name = txtOyunIsmi.Text,
                    Category = (cmbKategoriler.SelectedItem as Category)
                };
                _gameRepository.Add(g);
                MessageBox.Show("Ekleme işlemi başarılı","TAKE(1)GameBlog");
            }
            else
            {
                MessageBox.Show("Oyun ismi giriniz");
            }

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriEkle.Text!=string.Empty)
            {
                Category c = new Category()
                {
                    CategoryName = txtKategoriEkle.Text
                };
                _categoryRepository.Add(c);
                cmbKategoriler.DataSource = _categoryRepository.GetAll();
                MessageBox.Show("Ekleme işlemi başarılı","TAKE(1)GameBlog");
            }
            else
            {
                MessageBox.Show("Kategori girilmedi", "TAKE(1)GameBlog");
            }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            if (lstUyeler.SelectedIndex > -1)
            {
                _appUserRepository.Delete(lstUyeler.SelectedItem as AppUser);
                lstUyeler.DataSource = _appUserRepository.GetActives();
                MessageBox.Show("Silme işlemi başarılı", "TAKE(1)GameBlog");

            }
            else
            {
                MessageBox.Show("Lütfen işlem yapılcak üye seçiniz", "TAKE(1)GameBlog");
            }
        }

        private void btnYorumSil_Click(object sender, EventArgs e)
        {                                               
            if (lstYorumlar.SelectedIndex>-1)
            {
               _commentRepository.Delete(lstYorumlar.SelectedItem as Comment);
                MessageBox.Show("Silme işlemi başarılı", "TAKE(1)GameBlog");
            }
            else
            {
                MessageBox.Show("Lütfen yorum seçiniz", "TAKE(1)GameBlog");
            }
            
         
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            MainPage mg = new MainPage(User); //Basildiginda form1 formuna gecis yapsın ve kendini kapatsın...
            mg.Show();
            this.Hide();
        }

       

        

        private void btnYorumGetir_Click(object sender, EventArgs e)
        {

            if (cmbKullanicilar.SelectedIndex > -1)
            {
                AppUser uss = (cmbKullanicilar.SelectedItem as AppUser);
                lstYorumlar.DataSource = _commentRepository.Where(x => (x.Status != ENTITES.Enums.DataStatus.Deleted&&x.AppUserID==uss.ID));

            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı seç");
            }

        }
    }
}
