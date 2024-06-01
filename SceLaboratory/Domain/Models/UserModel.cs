using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{

    public class UserModel
    {
        private readonly IUserRepository userRepository;

        public UserModel()
        {
            userRepository = new UserRepository();
        }

        public User LoginUser(string user, string pass)
        {
            return userRepository.Login(user, pass);
        }
    }
}
