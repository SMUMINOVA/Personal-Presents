using System.Collections.Generic;

namespace PersonalPresents.Models.PresentModels
{
    //модель для работы с категорией профессия
    public class Profession
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public List<Present> Presents{get;set;}
    }
}