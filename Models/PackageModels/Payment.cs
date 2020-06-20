using System.Collections.Generic;

namespace PersonalPresents.Models.PackageModels
{
    //модель для определения способа оплаты
    public class Payment
    {
        public int Id{get;set;}
        public string Name{get;set;}

        public List<Order> orders{get;set;}
    }
}