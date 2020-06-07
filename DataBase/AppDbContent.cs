using Microsoft.EntityFrameworkCore;
using PersonalPresents.Models;

namespace PersonalPresents.DataBase
{
    public class AppDbContent : DbContext
    {
        public DbSet<User> Users{get;set;}
        public DbSet<Role> Roles{get;set;}
        public AppDbContent(DbContextOptions<AppDbContent> op) : base(op){
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder build){
            build.Entity<Role>().HasData(
                new Role{ Id = 1, Name = "admin"},
                new Role{ Id = 2, Name = "user"}
            );
            build.Entity<User>().HasData(
                new User{ Id = 1, Email = "admin@mail.ru", Password = "123456", RoleId = 1}
            );
        }
    }
}