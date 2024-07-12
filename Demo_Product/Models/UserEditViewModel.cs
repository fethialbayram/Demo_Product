﻿using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen isim giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyisim giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet giriniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen parola giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen parolayı onaylayınız")]
        [Compare("Password", ErrorMessage = "Lütfen parolaların eşleştiğinden emin olunuz")]
        public string ConfirmPassword { get; set; }
    }
}
