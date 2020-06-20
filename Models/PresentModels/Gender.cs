using System.Collections.Generic;

namespace PersonalPresents.Models.PresentModels
{
    //модель для работы с категорией пол
    public class Gender
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public List<Present> Presents{get;set;}
    }
}