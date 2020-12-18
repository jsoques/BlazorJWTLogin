using System.ComponentModel.DataAnnotations;

namespace JWTLogin.Models
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(5)]
        public string Password { get; set; }

    }
}