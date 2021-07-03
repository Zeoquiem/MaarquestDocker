using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic
{
    public class MaarquestApiContext : IMaarquestApiContext
    {
        private readonly HttpClient _httpClient;
        private static JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public MaarquestApiContext(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("MaarquestApi");
        }

        public async Task<T> HttpGetItemAsync<T>(string urlApi)
        {
            T result = default(T);

            var response = await _httpClient.GetAsync(urlApi);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Exception ex = new Exception("appel API : " + urlApi + "/ return : " + response.ToString());
                throw (ex);
            }
            else
            {
                result = await response.Content.ReadFromJsonAsync<T>();
            }

            return result;
        }


        public async Task<T> HttpCreateAsync<T>(string urlApi, T item)
        {
            T result = default(T);

            //HTTP GET
            var response = await _httpClient.PostAsJsonAsync(urlApi, item);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<T>();
            }
            else
            {
                Exception ex = new Exception("appel API : " + urlApi + "/ return : " + response.ToString());
                throw (ex);
            }
            return result;
        }

        public async Task<T> HttpUpdateAsync<T>(string urlApi, T item)
        {
            T result = default(T);

            //HTTP GET
            var response = await _httpClient.PutAsJsonAsync(urlApi, item);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<T>();
            }
            else
            {
                Exception ex = new Exception("appel API : " + urlApi + "/ return : " + response.ToString());
                throw (ex);
            }
            return result;
        }

        public async Task<T> HttpUpdatePostAsync<T>(string urlApi, T item)
        {
            T result = default(T);

            //HTTP GET
            var response = await _httpClient.PostAsJsonAsync(urlApi, item);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<T>();
            }
            else
            {
                Exception ex = new Exception("appel API : " + urlApi + "/ return : " + response.ToString());
                throw (ex);
            }

            return result;
        }

        public async Task<int> HttpSetValueAsync(string urlApi)
        {
            int result = 0;

            //HTTP GET
            var response = await _httpClient.PutAsync(urlApi, null);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<int>();
            }
            else
            {
                Exception ex = new Exception("appel API : " + urlApi + "/ return : " + response.ToString());
                throw (ex);
            }
            return result;
        }

        public async Task<int> HttpDeleteAsync(string urlApi)
        {
            int result = 0;

            //HTTP GET
            var response = await _httpClient.DeleteAsync(urlApi);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<int>();
            }
            else
            {
                Exception ex = new Exception("appel API : " + urlApi + "/ return : " + response.ToString());
                throw (ex);
            }
            return result;
        }
    }
}