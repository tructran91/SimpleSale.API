namespace SimpleSale.API.Models.Products
{
    public class ProductResponseModel : SEOContentViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string? Slug { get; set; }

        public string? Description { get; set; }

        public bool IsPublished { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        public Guid? CategoryId { get; set; }
    }
}
