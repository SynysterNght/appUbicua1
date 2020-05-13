using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace appUbicua1.Helpers
{
    public class ApiService
    {
        public async Task<List<T>> Get<T>(string urlBase, string servicePrefix,string controller) 
        {
            try
            {
                var client = new HttpClient();
                var url = string.Format("{0}{1}", servicePrefix, controller);
                client.BaseAddress = new Uri(urlBase);
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch 
            {
                return null;
            }
        }


    }
}
