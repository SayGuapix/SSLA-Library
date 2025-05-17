using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibreriaUniversitaria.DAL
{
    public class FirebaseHelper
    {
        private readonly string _baseUrl = "https://libreria-universitaria-default-rtdb.firebaseio.com/";

        private readonly HttpClient _client = new HttpClient();

        public async Task<T> ReadAsync<T>(string path)
        {
            var response = await _client.GetAsync($"{_baseUrl}{path}.json");
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<string> CreateAsync<T>(string path, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync($"{_baseUrl}{path}.json", content);
            return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> UpdateAsync<T>(string path, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"{_baseUrl}{path}.json", content);
            return await response.Content.ReadAsStringAsync();
        }

    }
}
