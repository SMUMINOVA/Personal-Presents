using System.Collections.Generic;

namespace PersonalPresents.Models.PresentModels
{
    //модель для работы с категорией праздники
    public class Festival
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public List<Present> Presents{get;set;}        
    }
}