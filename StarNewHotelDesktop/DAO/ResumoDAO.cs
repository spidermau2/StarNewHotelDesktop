using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarNewHotelDesktop.Models;
using static StarNewHotelDesktop.Utils.Constans;

namespace StarNewHotelDesktop.DAO
{
    class ResumoDAO : ICRUD<List<ResumoModel>, ResumoModel>
    {
        private static readonly string _baseUrl = $"{baseUrl}/Resumo";
        public List<ResumoModel> Get()
        {
            var client = new RestClient(_baseUrl)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            List<ResumoModel> resumos = JsonConvert.DeserializeObject<List<ResumoModel>>(response.Content);
            return resumos;
        }

        public ResumoModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(object item)
        {
            var client = new RestClient(_baseUrl)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            var body = JsonConvert.SerializeObject(item);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response.StatusCode == System.Net.HttpStatusCode.Created;
        }

        public bool Put(object item)
        {
            throw new NotImplementedException();
        }
        public bool Delete()
        {
            throw new NotImplementedException();
        }
    }
}
