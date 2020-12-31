using Prizes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Abstraction
{
   public interface INationalitiesRepository
    {
        List<Nationalities> GetAllNationalities();
    }
}
