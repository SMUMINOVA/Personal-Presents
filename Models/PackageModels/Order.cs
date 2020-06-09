using System;

namespace PersonalPresents.Models.PackageModels
{
    public class Order
    {
        public int Id{get;set;}
        public string Presents{get;set;}
        public double Price{get;set;}
        public string Adress{get;set;}
        public string PhoneNumber{get;set;}
        public DateTime Date{get;set;}

        public int PaymentId{get;set;}
        public Payment payment{get;set;}

        public int UserId{get;set;}
        public User user{get;set;}
    }
}