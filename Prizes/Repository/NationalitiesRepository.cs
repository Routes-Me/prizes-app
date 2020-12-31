using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Prizes.Abstraction;
using Prizes.Models;
using Prizes.Models.Common;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Prizes.Repository
{
    public class NationalitiesRepository : INationalitiesRepository
    {
        private readonly AppSettings _appSettings;
        private readonly Dependencies _dependencies;
        public NationalitiesRepository(IOptions<AppSettings> appSettings, IOptions<Dependencies> dependencies)
        {
            _appSettings = appSettings.Value;
            _dependencies = dependencies.Value;
        }
        public List<Nationalities> GetAllNationalities()
        {
            List<Nationalities> nationalities = new List<Nationalities>();
            try
            {
                var client = new RestClient(_appSettings.Host + _dependencies.GetNationalities);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var result = response.Content;
                    var promotionData = JsonConvert.DeserializeObject<NationalitiesResponse>(result);
                    nationalities.AddRange(promotionData.data);
                }
                return nationalities;
            }
            catch (Exception)
            {
                return nationalities;
            }
        }
    }
}
