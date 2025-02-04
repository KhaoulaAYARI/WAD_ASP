using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.User
{
    public class UserEditForm
    {
        [DisplayName("Prénom: ")]
        [Required(ErrorMessage = "Le champ est obligatoire")]
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
    }
}
