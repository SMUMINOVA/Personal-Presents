using Microsoft.EntityFrameworkCore;
using PersonalPresents.Models;
using PersonalPresents.Models.PackageModels;
using PersonalPresents.Models.PresentModels;

namespace PersonalPresents.DataBase
{
    //класс для работы с бд
    public class AppDbContent : DbContext
    {
        public DbSet<User> Users{get;set;}
        public DbSet<Role> Roles{get;set;}


        public DbSet<Present> Presents{get;set;}
        public DbSet<Festival> Festivals{get;set;}
        public DbSet<Gender> Genders{get;set;}
        public DbSet<Interest> Interests{get;set;}
        public DbSet<Profession> Professions{get;set;}
        public DbSet<RoleForUser> RoleForUsers{get;set;}

        public DbSet<Order> Orders{get;set;}
        public DbSet<Basket> Baskets{get;set;}
        public DbSet<Payment> Payments{get;set;}
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
            build.Entity<Payment>().HasData(
                new Payment{ Id = 1, Name = "cash"},
                new Payment{ Id = 2, Name = "card"}
            );
            build.Entity<Gender>().HasData(
                new Gender {Id = 1, Name = "Man"},
                new Gender {Id = 2, Name = "Woman"},  
                new Gender {Id = 3, Name = "Doesn't matter"}         
            );
            build.Entity<RoleForUser>().HasData(
                new RoleForUser {Id = 1, Name = "Mother"},
                new RoleForUser {Id = 2, Name = "Father"},
                new RoleForUser {Id = 3, Name = "Brother"},
                new RoleForUser {Id = 4, Name = "Sister"},
                new RoleForUser {Id = 5, Name = "Grandmother"},
                new RoleForUser {Id = 6, Name = "Grandfather"},
                new RoleForUser {Id = 7, Name = "Wife"},
                new RoleForUser {Id = 8, Name = "Husbend"},
                new RoleForUser {Id = 9, Name = "Boyfriend"},
                new RoleForUser {Id = 10, Name = "Girlfriend"},
                new RoleForUser {Id = 11, Name = "Friend"},
                new RoleForUser {Id = 12, Name = "Boss"},
                new RoleForUser {Id = 13, Name = "Сolleague"},
                new RoleForUser {Id = 14, Name = "Other"},
                new RoleForUser {Id = 15, Name = "Doesn't matter"}
            );
            build.Entity<Profession>().HasData(
                new Profession {Id = 1, Name = "Teacher"},
                new Profession {Id = 2, Name = "Driver"},
                new Profession {Id = 3, Name = "Doctor"},
                new Profession {Id = 4, Name = "Trainer"},
                new Profession {Id = 5, Name = "ITSpecialist"},
                new Profession {Id = 6, Name = "Builder"},
                new Profession {Id = 7, Name = "Lawyer"},
                new Profession {Id = 8, Name = "Accountant"},
                new Profession {Id = 9, Name = "Military"},
                new Profession {Id = 10, Name = "Oilman"},
                new Profession {Id = 11, Name = "Sailor"},
                new Profession {Id = 12, Name = "LawOfficer"},
                new Profession {Id = 13, Name = "Other"},
                new Profession {Id = 14, Name = "Doesn't matter"}               
            );
            build.Entity<Interest>().HasData(
                new Interest {Id = 1, Name = "Traveler"},
                new Interest {Id = 2, Name = "Geek"},
                new Interest {Id = 3, Name = "Hunter/fisherman"},
                new Interest {Id = 4, Name = "Athlete"},
                new Interest {Id = 5, Name = "Cars"},
                new Interest {Id = 6, Name = "Fan"},
                new Interest {Id = 7, Name = "For home"},
                new Interest {Id = 8, Name = "Other"}                
            );
            build.Entity<Festival>().HasData(
                new Festival {Id = 1, Name = "New Year"},
                new Festival {Id = 2, Name = "23rd of February"},
                new Festival {Id = 3, Name = "8th of March"},
                new Festival {Id = 4, Name = "Teacher's Day"},
                new Festival {Id = 5, Name = "Happy Birhtday"},
                new Festival {Id = 6, Name = "Anniversary"},
                new Festival {Id = 7, Name = "Wedding"},
                new Festival {Id = 8, Name = "Valentine's Day"},
                new Festival {Id = 9, Name = "Wedding anniversary"},
                new Festival {Id = 10, Name = "High school graduation"},
                new Festival {Id = 11, Name = "Housewarming"},
                new Festival {Id = 12, Name = "Birth of a child"},
                new Festival {Id = 13, Name = "To visit"},
                new Festival {Id = 14, Name = "1st of September"},
                new Festival {Id = 15, Name = "Other"}         ,
                new Festival {Id = 16, Name = "Doesn't matter"}
            );
        }
    }
}