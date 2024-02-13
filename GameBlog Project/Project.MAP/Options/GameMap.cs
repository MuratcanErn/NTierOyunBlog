using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class GameMap:BaseMap<Game>
    {
        public GameMap()
        {
            Property(x => x.Name).HasColumnName("Ad").IsRequired();
           
        }
    }
}
