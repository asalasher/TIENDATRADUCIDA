using TIENDA2.DataAccess.DataEntities;
using TIENDA2.domain.Entities;

namespace TIENDA2.DataAccess
{
    public static class ProductMapper
    {
        public static Producto Map(ProductFromJson productFromJson)
        {
            return new Producto
            {
                Id = productFromJson.Id,
                Price = productFromJson.Price,
                Rate = productFromJson.Rate,
                Discontinued = productFromJson.Discontinued == "yes",
            };
        }
    }

    public static class ProductTranslationMapper
    {
        public static ProductTranslations Map(TranslationsFromJson translationsFromJson)
        {

            Dictionary<string, string> translations = translationsFromJson
                .Translations?
                .ToDictionary(kvp => kvp.Key.ToUpper(), kvp => kvp.Value)
                ?? new Dictionary<string, string>();

            var productTranslations = new ProductTranslations
            {
                IdProduct = translationsFromJson.IdProduct,
                Translations = translations,
            };

            return productTranslations;
        }

    }

}
