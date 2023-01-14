namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductAttributeGroup : EntityBase
    {
        public string Name { get; set; }

        public IList<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
    }
}
