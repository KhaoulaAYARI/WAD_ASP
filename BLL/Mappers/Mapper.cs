using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;
using D = DAL.Entities;

namespace BLL.Mappers
{
    internal static class Mapper
    {
        public static BLL.Entities.User ToBLL(this DAL.Entities.User user)
        {
            if (user is null) throw new ArgumentNullException(nameof(user));
            return new BLL.Entities.User(user.User_Id, user.First_Name, user.Last_Name, user.Email, user.Password, user.CreatedAt, user.DisabledAt);
        }
    }
}
