using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Game:BaseEntity
    {
        public string  Name { get; set; }       
        public int CategoryID { get; set; }

        //Relational Properties
        public virtual Category Category { get; set; }
        public virtual List<Comment>  Comments { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }


    }
}
