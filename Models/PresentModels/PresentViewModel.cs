using Microsoft.AspNetCore.Http;

namespace PersonalPresents.Models.PresentModels
{
    public class PresentViewModel
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public double Price{get;set;}
        public string Description{get;set;}
        
        public IFormFile ImgPath{get;set;}
        public string Img{get;set;}

        public int RoleId{get;set;}

        public int GenderId{get;set;}

        public int ProfessionId{get;set;}

        public int InterestId{get;set;}

        public int FestivalId{get;set;}
    }
}