using ASP_MVC.Models.User;
using BLL.Entities;

namespace ASP_MVC.Mappers
{
    internal static class Mapper
    {
        public static UserEditForm ToEditForm (this User user)
        {
            if (user == null) throw new ArgumentNullException ("user");
            return new UserEditForm()
            {
                FirstName = user.First_Name,
                LastName = user.Last_Name,
            
                Email = user.Email
            };
        }
        public static User ToBLL(this UserEditForm user) 
        {
            if (user == null) throw new ArgumentNullException("user");
            return new User(
                Guid.Empty,
                user.FirstName,
                user.LastName,
                user.Email,
                "********",
                DateTime.Now,
                null
                );
        }
        public static UserDelete ToDelete (this User user)
        {
            if (user == null) throw new ArgumentNullException("user");
            return new UserDelete()
            {
                FirstName = user.First_Name,
                LastName = user.Last_Name,

                Email = user.Email
            };
        }
    }
}
