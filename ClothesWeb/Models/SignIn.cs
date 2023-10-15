using System.ComponentModel.DataAnnotations;

namespace ClothesWeb.Models
{
    public class SignIn
    {
        [Key]
        [Required(ErrorMessage = "Vui lòng nhập Username!")]
        [Display(Name = "User")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Password!")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
