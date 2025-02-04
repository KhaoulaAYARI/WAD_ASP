using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Auth
{
    public class AuthLoginForm
    {
        [DisplayName("Email: ")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Mot de passe: ")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        [MaxLength(32, ErrorMessage = "Le champ doit contenir max32 caractéres")]
        //[RegularExpression(@¨^.*(?=.* [a - z])(?=.* [A-Z])",ErrorMessage = "Le mot de passe n est pas fort" )]
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
