using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineChallange3
{
    public class HttpClientInstance
    {
        
        private HttpClientInstance() 
        { 
        
        }
        public static HttpClient GetHttpClientInstance()
        {
            HttpClient httpClient = new HttpClient();         
           return httpClient;
        }

    }

}
