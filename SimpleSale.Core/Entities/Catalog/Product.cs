namespace SimpleSale.Core.Entities.Catalog
{
    public class Product : Content
    {
        public string? ShortDescription { get; set; }

        public decimal Price { get; set; }

        public decimal? OldPrice { get; set; }

        public decimal? SpecialPrice { get; set; }

        public DateTime? SpecialPriceStart { get; set; }

        public DateTime? SpecialPriceEnd { get; set; }

        public bool IsCallForPricing { get; set; }

        public bool IsAllowToOrder { get; set; }

        public int StockQuantity { get; set; }

        public string? Sku { get; set; }

        public int DisplayOrder { get; set; }

        public Guid? BrandId { get; set; }

        public Brand Brand { get; set; }

        public Media ThumbnailImage { get; set; }

        public IList<ProductMedia> Medias { get; set; } = new List<ProductMedia>();

        public IList<ProductLink> ProductLinks { get; set; } = new List<ProductLink>();

        public IList<ProductLink> LinkedProductLinks { get; set; } = new List<ProductLink>();

        public IList<ProductAttributeValue> AttributeValues { get; set; } = new List<ProductAttributeValue>();

        //public IList<ProductOptionValue> OptionValues { get; set; } = new List<ProductOptionValue>();

        public IList<ProductCategory> Categories { get; set; } = new List<ProductCategory>();

        //public IList<ProductPriceHistory> PriceHistories { get; set; } = new List<ProductPriceHistory>();
    }
}
