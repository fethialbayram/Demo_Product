using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Lütfen parolayı giriniz")]
        public string? Password { get; set; }
    }
}
