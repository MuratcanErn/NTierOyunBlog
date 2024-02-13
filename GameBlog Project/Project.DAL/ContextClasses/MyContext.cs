using Project.ENTITES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")//App.config'te verdiğimiz name "MyConnection"(Veritabanı Bağlantısı)
        {
                
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserProfileMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new DisslikeMap());
            
            modelBuilder.Configurations.Add(new GameMap());
            modelBuilder.Configurations.Add(new LikeMap());

        }
        
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUsersProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Disslike> Disslikes { get; set; }
       
        public DbSet<Like> Likes { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
