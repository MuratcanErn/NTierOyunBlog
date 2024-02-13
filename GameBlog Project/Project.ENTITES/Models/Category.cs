using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITES.Models
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return $"{CategoryName}";
        }
        //Relational Properties
        public virtual  List<Game> Games { get; set; }

    }
}
