using System.Collections.Generic;

namespace PersonalPresents.Models.PackageModels
{
    public class Payment
    {
        public int Id{get;set;}
        public string Name{get;set;}

        public List<Order> orders{get;set;}
    }
}