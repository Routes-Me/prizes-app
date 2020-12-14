using PrizesService.Abstraction;
using PrizesService.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrizesService.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task AddUsers(UsersModel usersModel)
        {
            var users = _userRepository.AddUsers(usersModel);
            return users;
        }
    }
}
