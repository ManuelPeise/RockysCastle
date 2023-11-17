using Logic.Shared.Interfaces;
using Newtonsoft.Json;
using System.Net;


namespace Logic.Shared
{
    public abstract class HttpClientBase : IHttpClient
    {
        private readonly HttpClient _httpClient;

        protected HttpClientBase(string baseUrl)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };

        }

        public async Task<T> GetAsync<T>(string url, List<KeyValuePair<string, object>>? urlParameters = null, List<KeyValuePair<string, object>>? headers = null)
        {
            var requestUrl = BuildUri($"{_httpClient.BaseAddress}{url}", urlParameters);

            using (var requestMessage = GetRequestMessage(requestUrl, HttpMethod.Get, headers))
            {
                var response = await _httpClient.SendAsync(requestMessage);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(json);
                }
            }

            return default(T);
        }

        public Uri BuildUri(string url, List<KeyValuePair<string, object>> parameters)
        {
            var queryString = from parameter in parameters
                              select $"{parameter.Key}={parameter.Value}";

            return new Uri($"{url}?{string.Join("&", queryString)}");
        }

        private HttpRequestMessage GetRequestMessage(Uri url, HttpMethod method, List<KeyValuePair<string, object>>? headers)
        {
            return new HttpRequestMessage
            {
                Method = method,
                RequestUri = url,
                Version = HttpVersion.Version11,
            };
        }
    }
}
