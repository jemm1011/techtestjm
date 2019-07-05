using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TechTestJM.Support.JsonHelper
{
    public class JsonRequestHelper : IJsonRequestHelper
    {        
        public async Task<T> Get<T>(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                var response = await httpClient.GetStringAsync(new Uri(url));
                return JsonConvert.DeserializeObject<T>(response);
            }                
        }
    }
}
