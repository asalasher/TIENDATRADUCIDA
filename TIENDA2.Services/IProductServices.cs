using TIENDA2.domain;

namespace TIENDA2.Services
{
    public interface IProductServices
    {
        Task<List<AvailableProductDTO>> GetAvailableProductsByLanguage(string language);
    }
}