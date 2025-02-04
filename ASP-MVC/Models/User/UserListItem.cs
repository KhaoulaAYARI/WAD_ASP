using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.User
{
    public class UserListItem
    {
        [ScaffoldColumn(false)]
        public Guid User_Id { get; set; }
        [DisplayName("Prénom: ")]
        public string FirstName {  get; set; }
        [DisplayName("Nom de famille: ")]
        public string LastName { get; set; }

    }
}
