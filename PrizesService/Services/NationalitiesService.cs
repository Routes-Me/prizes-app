using PrizesService.Abstraction;
using PrizesService.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrizesService.Services
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
