using System.Collections.Generic;

namespace PersonalPresents.Models.PresentModels
{
    //модель для работы с категорией роль человека которому ищут подарок по отношению к покупателю
    public class RoleForUser
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public List<Present> Presents{get;set;}
    }
}