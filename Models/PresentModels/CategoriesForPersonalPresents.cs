using System.Collections.Generic;

namespace PersonalPresents.Models.PresentModels
{
    public class CategoriesForPersonalPresents
    {
        public double Price{get;set;}

        public int RoleId{get;set;}

        public int GenderId{get;set;}

        public int ProfessionId{get;set;}
        
        public List<int> InterestId{get;set;}

        public int FestivalId{get;set;}
    }
}