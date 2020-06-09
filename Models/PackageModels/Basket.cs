namespace PersonalPresents.Models.PackageModels
{
    public class Basket
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public double Price{get;set;}
        public int Count{get;set;}
        public string Description{get;set;}

        public int UserId{get;set;}
        public User user{get;set;}
    }
}