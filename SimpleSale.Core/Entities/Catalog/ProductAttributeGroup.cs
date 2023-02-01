namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductAttributeGroup
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IList<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
    }
}
