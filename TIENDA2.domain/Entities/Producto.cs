namespace TIENDA2.domain.Entities
{
    public class Producto
    {
        public int? Id { get; set; }
        public decimal? Price { get; set; }
        public int? Rate { get; set; }
        public bool? Discontinued { get; set; }
    }
}