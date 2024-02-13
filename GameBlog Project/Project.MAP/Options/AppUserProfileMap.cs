using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AppUserProfileMap:BaseMap<AppUserProfile>
    {
        public AppUserProfileMap()
        {
            Property(x => x.FirstName).HasColumnName("Ad").IsRequired();
            Property(x => x.LastName).HasColumnName("Soyad").IsRequired();
            Property(x => x.Email).HasColumnName("Mail").IsRequired();
            Property(x => x.BirthDate).HasColumnName("DogumTarih").IsRequired();
        }
    }
}
