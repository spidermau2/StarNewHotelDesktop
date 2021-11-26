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
    public class ClienteDAO : ICRUD<List<ClienteModel>, ClienteModel>
    {
        private static readonly string _baseUrl = $"{baseUrl}/Clientes";

        public List<ClienteModel> Get() 
        {
            var client = new RestClient(_baseUrl)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            List<ClienteModel> clientes = JsonConvert.DeserializeObject<List<ClienteModel>>(response.Content);
            return clientes;
        }

        public ClienteModel Get(int id)
        {
            var client = new RestClient($"{_baseUrl}/{id}")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            List<ClienteModel> clientes = JsonConvert.DeserializeObject<List<ClienteModel>>(response.Content);
            return clientes.FirstOrDefault();
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
