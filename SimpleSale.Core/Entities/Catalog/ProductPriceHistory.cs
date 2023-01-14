namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductPriceHistory : EntityBase
    {
        public Product Product { get; set; }

        public decimal? Price { get; set; }

        public decimal? OldPrice { get; set; }

        public decimal? SpecialPrice { get; set; }

        public DateTime? SpecialPriceStart { get; set; }

        public DateTime? SpecialPriceEnd { get; set; }
    }
}
