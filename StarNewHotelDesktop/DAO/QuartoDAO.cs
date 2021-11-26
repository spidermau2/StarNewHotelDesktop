using Newtonsoft.Json;
using RestSharp;
using StarNewHotelDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StarNewHotelDesktop.Utils.Constans;

namespace StarNewHotelDesktop.DAO
{
    class QuartoDAO : ICRUD<List<QuartoModel>, QuartoModel>
    {
        private static readonly string _baseUrl = $"{baseUrl}/Quartos";

        public List<QuartoModel> Get()
        {
            var client = new RestClient(_baseUrl)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            List<QuartoModel> quartos = JsonConvert.DeserializeObject<List<QuartoModel>>(response.Content);
            return quartos;
        }

        public List<QuartoModel> GetOcupados()
        {
            var client = new RestClient($"{_baseUrl}/Ocupados")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            List<QuartoModel> quartos = JsonConvert.DeserializeObject<List<QuartoModel>>(response.Content);
            return quartos;
        }

        public QuartoModel Get(int id)
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
