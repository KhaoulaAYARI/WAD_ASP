using BLL.Entities;
using BLL.Mappers;
using Commun.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = DAL.Services;

namespace BLL.Services
{
    public class UserService:IUserRepository<User>
    {
        private DAL.Services.UserService _service;
        public UserService()
        {
            _service = new DAL.Services.UserService();
        }

        public Guid CheckPassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get()
        {
            return _service.Get().Select(dal => dal.ToBLL());
        }
        public User Get(Guid user_id) 
        {
            return _service.Get(user_id).ToBLL();
        }

        public Guid Insert(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
