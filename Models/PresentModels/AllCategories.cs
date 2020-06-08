using System.Collections.Generic;

namespace PersonalPresents.Models.PresentModels
{
    public class AllCategories
    {
        public Present Present{get;set;}
        public List<Gender> Gender{get;set;}
        public List<Festival> Festival{get;set;}
        public List<Interest> Interest{get;set;}
        public List<Profession> Profession{get;set;}
        public List<RoleForUser> RoleForUser{get;set;}
    }
}