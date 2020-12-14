using PrizesService.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrizesService.Abstraction
{
    public interface IUserRepository
    {
        dynamic AddUsers(UsersModel usersModel);
    }
}
