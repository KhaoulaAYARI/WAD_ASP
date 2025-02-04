using System.ComponentModel;

namespace ASP_MVC.Models.User
{
    public class UserDelete
    {
        [DisplayName("Prenom: ")]
        public string FirstName { get; set; }
        [DisplayName("Nom: ")]

        public string LastName { get; set; }

        [DisplayName("EMAIL: ")]
        public string Email { get; set; }
    }
}
