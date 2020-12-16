using Prizes.Abstraction;
using Prizes.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Services
{
    public class NationalitiesService
    {
        private readonly INationalitiesRepository _nationalitiesRepository;

        public NationalitiesService(INationalitiesRepository nationalitiesRepository)
        {
            _nationalitiesRepository = nationalitiesRepository;
        }

        public Task<List<NationalitiesModel>> GetNationalitiesList()
        {
            return Task.FromResult(_nationalitiesRepository.GetAllNationalities());
        }
    }
}
