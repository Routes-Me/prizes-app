using Prizes.Abstraction;
using Prizes.Models.DBModels;
using Prizes.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly prizesserviceContext _context;
        public UserRepository(prizesserviceContext context)
        {
            _context = context;
        }
        public dynamic AddUsers(UsersModel usersModel)
        {
            try
            {
                var nationalityData = _context.Nationalities.Where(x => x.NationalityId == usersModel.NationalityId).FirstOrDefault();
                if(nationalityData == null)
                {
                    return "Users not found";
                }

                Users users = new Users();
                users.Name = usersModel.Name;
                users.Email = usersModel.Email;
                users.PhoneNumber = usersModel.PhoneNumber;
                users.DateOfBirth = usersModel.DateOfBirth;
                _context.Users.Add(users);
                _context.SaveChanges();

                UsersNationalities usersNationalities = new UsersNationalities();
                usersNationalities.NationalityId = usersModel.NationalityId.GetValueOrDefault();
                usersNationalities.UserId = users.UserId;
                _context.UsersNationalities.Add(usersNationalities);
                _context.SaveChanges();
                return "success";
            }
            catch (Exception)
            {
                return "exceptions";
            }
        }
    }
}
