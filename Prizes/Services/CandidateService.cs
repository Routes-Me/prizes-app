using Prizes.Abstraction;
using Prizes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Services
{
    public class CandidateService
    {
        private readonly ICandidatesRepository _candidatesRepository;

        public CandidateService(ICandidatesRepository candidatesRepository)
        {
            _candidatesRepository = candidatesRepository;
        }
        public dynamic AddCandidates(Candidates candidates, string drawsId)
        {
            return _candidatesRepository.AddCandidates(candidates, drawsId);
        }
    }
}
