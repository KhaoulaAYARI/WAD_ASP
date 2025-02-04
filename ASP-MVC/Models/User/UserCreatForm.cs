using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.User
{
    public class UserCreatForm
    {

        [DisplayName("Prénom: ")]
        [Required(ErrorMessage ="Le champ est obligatoire")]
        [MaxLength(64, ErrorMessage = "Le champ doit contenir max64 caractéres")]
        [MinLength(2, ErrorMessage = "Le champ doit contenir min 2 caractéres")]

        public string FirstName { get; set; }

        [DisplayName("Nom de famille: ")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        [MaxLength(64, ErrorMessage = "Le champ doit contenir max64 caractéres")]
        [MinLength(2, ErrorMessage = "Le champ doit contenir min 2 caractéres")]


        public string LastName { get; set; }

        [DisplayName("Nom de famille: ")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Mot de passe: ")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        [MaxLength(32, ErrorMessage = "Le champ doit contenir max32 caractéres")]
        //[RegularExpression(@¨^.*(?=.* [a - z])(?=.* [A-Z])",ErrorMessage = "Le mot de passe n est pas fort" )]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [DisplayName("Confirmer Mot de passe: ")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
        [MinLength(2, ErrorMessage = "Le champ doit contenir min 2 caractéres")]
        [Compare(nameof(Password),ErrorMessage ="La confirmation ne correspond pas au (Mot de passe)")]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }

        [DisplayName("En cochant cette case, vous acceptez les termes de condition d'utilisation ")]
        [Required(ErrorMessage = "Vous devez lire et accepter les termes de condition d'utilisation!")]
        public bool Consent {  get; set; }


    }
}
