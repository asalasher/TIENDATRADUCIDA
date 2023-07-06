using TIENDA2.domain;
using TIENDA2.domain.Contracts;
using TIENDA2.domain.Entities;

namespace TIENDA2.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IRepositoryProduct _repositoryProducts;
        private readonly IRepositoryTranslations _repositoryTranslations;

        public ProductServices(
            IRepositoryProduct repositoryProducts,
            IRepositoryTranslations repositoryTranslations
            )
        {
            _repositoryProducts = repositoryProducts;
            _repositoryTranslations = repositoryTranslations;
        }

        public async Task<List<AvailableProductDTO>> GetAvailableProductsByLanguage(string language)
        {
            var availableProducts = new List<AvailableProductDTO>();

            IEnumerable<Producto>? products = await _repositoryProducts.GetAll();
            IEnumerable<ProductTranslations>? productTranslations = await _repositoryTranslations.GetAll();
            if (products == null || productTranslations == null || !products.Any())
            {
                return availableProducts;
            }

            foreach (var product in products)
            {
                IDictionary<string, string>? translations = productTranslations
                    .FirstOrDefault(x => x.IdProduct == product.Id)?
                    .Translations;

                if (translations is not null && translations.ContainsKey(language))
                {
                    availableProducts.Add(new AvailableProductDTO
                    {
                        Nombre = translations[language],
                        Precio = $"{product.Price}€",
                        Ratio = $"{product.Rate}/10",
                    });
                }
            }
            return availableProducts;
        }
    }
}