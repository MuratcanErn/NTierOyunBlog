using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Comment:BaseEntity
    {
        public Comment()
        {
            Comments = new List<Comment>();
        }
        public override string ToString()
        {
            return $"Başlık: {Title} Yorum=>{Description}";
        }
        public string Description { get; set; }
        public int AppUserID { get; set; }
        public string Title { get; set; }
        public List<Comment> Comments { get; set; }
        public int GameID { get; set; }
        //Relational Properties
        public virtual Game Game { get; set; }    
        public  virtual List<Like> Likes{ get; set; }
        public virtual List<Disslike> Disslikes { get; set; }
        public virtual AppUser AppUser { get; set; }
      

    }
}
