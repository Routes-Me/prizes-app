using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prizes.Models
{
    public class Response
    {
        public bool status { get; set; }
        public string message { get; set; }
        public int statusCode { get; set; }
    }

    public class NationalitiesResponse : Response
    {
        public Pagination pagination { get; set; }
        public List<Nationalities> data { get; set; }
    }
}
