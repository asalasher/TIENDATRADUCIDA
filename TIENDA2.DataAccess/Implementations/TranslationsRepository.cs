using System.Text.Json;
using TIENDA2.domain.Entities;

namespace TIENDA2.DataAccess.Implementations
{
    public class TranslationsRepository
    {
        private readonly IHttpRequestService _httpRequestService;
        private readonly string _baseUrl;

        public TranslationsRepository(IHttpRequestService httpRequestService)
        {
            _httpRequestService = httpRequestService;
            _baseUrl = "myUrl";
        }

        public async Task<IEnumerable<ProductTranslations>?> GetAll()
        {
            string? payload = await _httpRequestService.Get(_baseUrl);
            if (payload is null)
            {
                return new List<ProductTranslations>();
            }
            return JsonSerializer.Deserialize<List<ProductTranslations>>(payload);
        }

        public Task<ProductTranslations> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductTranslations> Add(Producto entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductTranslations>> AddBulk(IEnumerable<ProductTranslations> entities)
        {
            throw new NotImplementedException();
        }

        public Task<ProductTranslations> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductTranslations>> DeleteBulk(IEnumerable<int> entities)
        {
            throw new NotImplementedException();
        }

        public Task<Producto> Update(Producto entity)
        {
            throw new NotImplementedException();
        }

    }
}
