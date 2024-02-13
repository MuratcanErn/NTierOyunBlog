using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class AppUser:BaseEntity
    {
        public  bool Admin { get; set; }// Eğer kullanıcı adminse değeri true olacak.
        public string UserName { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $"{UserName}";
        }

        //Relation Properties

        public virtual  AppUserProfile Profile { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }
        public virtual List<Disslike> Disslikes { get; set; }
    }
}
