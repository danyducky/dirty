using System.ComponentModel.DataAnnotations;

namespace Openskill.Models.Auth
{
    public class AuthLoginModel
    {
        [Required(ErrorMessage = "Введите почту")]
        [EmailAddress(ErrorMessage = "Введите корректную почту")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Введите пароль")]
        [MinLength(6, ErrorMessage = "Минимальная длина пароля - 6 символов")]
        public string Password { get; set; }
    }
}
