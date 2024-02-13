using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Disslike:BaseEntity
    {
       
        public int AppUserID { get; set; }


        // Relational Propertiess

        public virtual AppUser AppUser { get; set; }


    }
}
