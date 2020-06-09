using System.Collections.Generic;
using PersonalPresents.Models.PackageModels;

namespace PersonalPresents.Models
{
    public class User
    {
        public int Id{get;set;}
        public string Email{get;set;}
        public string Password{get;set;}

        public int RoleId{get;set;}
        public Role Role{get;set;}

        public List<Basket> baskets{get;set;}

        public List<Order> orders{get;set;}
    }
}