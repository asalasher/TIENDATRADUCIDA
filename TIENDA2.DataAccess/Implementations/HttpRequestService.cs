using System.Text;
using System.Text.Json;

namespace TIENDA2.DataAccess.Implementations
{
    public class HttpRequestService : IHttpRequestService
    {
        private readonly HttpClient _httpClient;
        private readonly Encoding _encoding;
        private readonly string _mediaType;

        public HttpRequestService()
        {
            _httpClient = new HttpClient();
            _encoding = Encoding.UTF8;
            _mediaType = "application/json";
        }

        public async Task<string?> Get(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // TODO - _logger.LogError(ex.Message);
                return null;
            }
        }

        public async Task<string?> Post(string url, object body)
        {
            try
            {
                StringContent jsonContent = new(
                   JsonSerializer.Serialize(body),
                   _encoding,
                   _mediaType);

                HttpResponseMessage response = await _httpClient.PostAsync(
                   url,
                   jsonContent);

                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // TODO - _logger.LogError(ex.Message);
                return null;
            }
        }

    }
}
