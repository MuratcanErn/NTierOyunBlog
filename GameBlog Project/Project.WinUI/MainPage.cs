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
using System.Windows.Navigation;

namespace Project.WinUI
{
    public partial class MainPage : Form
    {
        AppUser User;
        AppUsersRepository _appUsersRepository;
        CommentRepository _commentRepository;
        GameRepository _gameRepository;
     
   

        public MainPage(AppUser user)
        {
            _gameRepository = new GameRepository();
            _appUsersRepository = new AppUsersRepository();
            _commentRepository = new CommentRepository();
            InitializeComponent();
            User = user;
            lblUserName.Text = User.UserName;
            lblStatu.Text = StatuYazdır();
            cmbKategori.DataSource = _gameRepository.GetActives();


        }


        public string StatuYazdır()
        {
            return $"Kullanıcı Sayısı:{_appUsersRepository.GetActives().Count} \n Yorum Sayısı:{_commentRepository.GetActives().Count} \n {DateTime.Now}";
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            List<Comment> copComments = _commentRepository.GetActives().OrderByDescending(x => x.Likes.Count).Take(3).ToList();

            AltIkiYorumGoster();
            lblComment1.Text= YorumIcerikGetir(copComments[0]);
            lblComment1.Tag= copComments[0];
            lblComment2.Text = YorumIcerikGetir(copComments[1]);
            lblComment2.Tag = copComments[1];
            lblComment3.Text = YorumIcerikGetir(copComments[2]);
            lblComment3.Tag = copComments[2];


        }

        private string  YorumIcerikGetir(Comment comment)
        {
            return $"Oyun:{comment.Game.Name} \n Başlık:{comment.Title}\n Yorum:{comment.Description} \n Beğeni Sayısı: {comment.Likes.Count}  ";
        }

       

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenIndex = comboBox1.SelectedIndex;
            if(secilenIndex>-1)
            {
                if(secilenIndex == 0)
                {
                    KullaniciProfili kp=new KullaniciProfili(User);
                    kp.Show();
                    this.Hide();
                }
                else if(secilenIndex == 1)
                {
                    Form1 form1 = new Form1();
                    Hide();
                    form1.ShowDialog();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex > -1)
            {
                groupBox1.Visible = true;
            }
            else MessageBox.Show("Yorum yapmak için Oyun seçiniz");

        }

        private void btnYorumYap_Click(object sender, EventArgs e)
        {
            if (txtYorum.Text!=null&& txtTitle.Text!=null&&cmbKategori.SelectedIndex>-1)
            {
                Comment comment = new Comment
                {
                    Title = txtTitle.Text,
                    Description = txtYorum.Text,
                    Game=cmbKategori.SelectedItem as Game ,
                    AppUser= User
                    
                };
                _commentRepository.Add(comment);
                MessageBox.Show("Başarılı");
            }
            else MessageBox.Show("başarısız");

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text!=string.Empty)
            {
                Comment c = _commentRepository.GetActives().Where(x => x.Title.Contains(txtAra.Text)).FirstOrDefault();
                if (c != null)
                {
                    AltIkiYorumGizle();
                    lblComment1.Text = YorumIcerikGetir(c);

                }
            }
          
          

        }
        
        private void AltIkiYorumGoster()
        {
           
            lblComment2.Visible = true;
            lblComment3.Visible = true;
        }
        private void AltIkiYorumGizle()
        {

            lblComment2.Visible = false;
            lblComment3.Visible = false;
        }


        private void btnSayfaYenile_Click(object sender, EventArgs e)
        {
            MainPage_Load(sender,e);
        }

        private void btnLike1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
