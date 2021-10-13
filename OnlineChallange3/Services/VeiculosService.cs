using Newtonsoft.Json;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineChallange3
{
    public class VeiculosService : IVeiculosService

    {
        public VeiculosService() { }

        public List<Marcas> GetMarcas()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://desafioonline.webmotors.com.br/api/OnlineChallenge/Make");

            HttpResponseMessage response = HttpClientInstance.GetHttpClientInstance().SendAsync(request).Result;

            return JsonConvert.DeserializeObject<List<Marcas>>(response.Content.ReadAsStringAsync().Result);
        }


        public List<Modelos> GetModelos(int id)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://desafioonline.webmotors.com.br/api/OnlineChallenge/Model?MakeID="+id);

            HttpResponseMessage response = HttpClientInstance.GetHttpClientInstance().SendAsync(request).Result;

            return JsonConvert.DeserializeObject<List<Modelos>>(response.Content.ReadAsStringAsync().Result);
        }

        public List<Veiculos> GetVeiculos(int veiculosID)
        {
            throw new NotImplementedException();
        }

        public List<Veiculos> GetVersoes(int id)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://desafioonline.webmotors.com.br/api/OnlineChallenge/Version?ModelID=" + id);

            HttpResponseMessage response = HttpClientInstance.GetHttpClientInstance().SendAsync(request).Result;

            return JsonConvert.DeserializeObject<List<Veiculos>>(response.Content.ReadAsStringAsync().Result);
        }
    }

}
