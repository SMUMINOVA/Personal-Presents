using System.Collections.Generic;

namespace PersonalPresents.Models.PresentModels
{
    public class Profession
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public List<Present> Presents{get;set;}
    }
}