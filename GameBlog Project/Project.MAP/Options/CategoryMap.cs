using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
         
            Property(x=>x.CategoryName).HasColumnName("CategoriAdi").IsRequired();
        }
    }
}
