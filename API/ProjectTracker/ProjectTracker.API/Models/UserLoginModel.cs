using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.API.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adını giriniz ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz ")]
        public string Password { get; set; }
    }
}
