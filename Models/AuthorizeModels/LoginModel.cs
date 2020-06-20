using System.ComponentModel.DataAnnotations;

namespace PersonalPresents.Models
{
    //модель для взятия информации для входа
    public class LoginModel
    {
        [Required (ErrorMessage = "Не указан Email")]
        public string Email{get;set;}
        [Required (ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}