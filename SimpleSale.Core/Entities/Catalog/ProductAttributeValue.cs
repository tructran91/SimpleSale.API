namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductAttributeValue : EntityBase
    {
        public Guid AttributeId { get; set; }

        public ProductAttribute Attribute { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public string Value { get; set; }
    }
}
