namespace TIENDA2.DataAccess.DataEntities
{
    public class TranslationsFromJson
    {
        public int? IdProduct { get; set; }
        public IEnumerable<KeyValuePair<string, string>>? Translations { get; set; }
    }
}
