using Prizes.Abstraction;
using Prizes.Models.DBModels;
using Prizes.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Repository
{
    public class NationalitiesRepository : INationalitiesRepository
    {
        private readonly prizesserviceContext _context;
        public NationalitiesRepository(prizesserviceContext context)
        {
            _context = context;
        }
        public List<NationalitiesModel> GetAllNationalities()
        {
            List<NationalitiesModel> nationalities = new List<NationalitiesModel>();
            try
            {
                nationalities = (from item in _context.Nationalities
                                 select new NationalitiesModel()
                                 {
                                     NationalityId = item.NationalityId,
                                     Name = item.Name,
                                 }).ToList();

                return nationalities;
            }
            catch (Exception)
            {
                return nationalities;
            }
        }
    }
}
