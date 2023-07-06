using System.Text.Json;
using TIENDA2.domain.Contracts;
using TIENDA2.domain.Entities;

namespace TIENDA2.DataAccess.Implementations
{
    public class ProductsRepository : IRepositoryProduct
    {
        private readonly IHttpRequestService _httpRequestService;
        private readonly string _baseUrl;

        public ProductsRepository(IHttpRequestService httpRequestService)
        {
            _httpRequestService = httpRequestService;
            _baseUrl = "myUrl";
        }

        public async Task<IEnumerable<Producto>?> GetAll()
        {
            string? payload = await _httpRequestService.Get(_baseUrl);
            if (payload is null)
            {
                //return Enumerable.Empty<Producto>();
                return new List<Producto>();
            }
            return JsonSerializer.Deserialize<List<Producto>>(payload);
        }

        public Task<Producto> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Producto> Add(Producto entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Producto>> AddBulk(IEnumerable<Producto> entities)
        {
            throw new NotImplementedException();
        }

        public Task<Producto> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Producto>> DeleteBulk(IEnumerable<int> entities)
        {
            throw new NotImplementedException();
        }

        public Task<Producto> Update(Producto entity)
        {
            throw new NotImplementedException();
        }
    }
}