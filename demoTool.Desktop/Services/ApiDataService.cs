using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace demoTool.Desktop.Services
{
    public class ApiDataService : IDataService
    {
        private const string ApiUrl = "https://api.example.com/items";
        private readonly HttpClient _httpClient;

        public ApiDataService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<object>> FetchDataAsync()
        {
            var response = await _httpClient.GetAsync(ApiUrl);
            response.EnsureSuccessStatusCode();

            var responseString =  await response.Content.ReadAsStringAsync();
            
            return Enumerable.Empty<IEnumerable<object>>();
        }
    }
}
