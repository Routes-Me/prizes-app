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
    public class CandidatesRepository : ICandidatesRepository
    {
        private readonly AppSettings _appSettings;
        private readonly Dependencies _dependencies;
        public CandidatesRepository(IOptions<AppSettings> appSettings, IOptions<Dependencies> dependencies)
        {
            _appSettings = appSettings.Value;
            _dependencies = dependencies.Value;
        }
        public dynamic AddCandidates(Candidates candidates, string drawsId)
        {
            try
            {
                var paramstr = _dependencies.PostCandidates.Replace("|id|", drawsId);
                var urlString = _appSettings.Host + paramstr;
                Console.WriteLine("url addCandidate : "+urlString);
                var client = new RestClient(urlString);
                var request = new RestRequest(Method.POST);
                string jsonToSend = JsonConvert.SerializeObject(candidates);
                request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
                request.RequestFormat = DataFormat.Json;
                IRestResponse response = client.Execute(request);
                if (response.StatusCode != HttpStatusCode.Created)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
