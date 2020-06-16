using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace PersonalPresents.Models.PresentModels
{
    public class Present
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public double Price{get;set;}
        public string Description{get;set;}
        
        public string Img{get;set;}
        [NotMapped]
        public IFormFile ImgFile{get;set;}

        public int RoleId{get;set;}
        public RoleForUser role{get;set;}

        public int GenderId{get;set;}
        public Gender gender{get;set;}

        public int ProfessionId{get;set;}
        public Profession profession{get;set;}

        public int InterestId{get;set;}
        public Interest interest{get;set;}

        public int FestivalId{get;set;}
        public Festival festival{get;set;}

    }
}