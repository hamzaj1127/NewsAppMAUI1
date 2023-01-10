using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NewsApp.Models;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=3f9dc2ef595ff2b3cc4e6bc611f6841a&topic"+categoryName.ToLower());

            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
