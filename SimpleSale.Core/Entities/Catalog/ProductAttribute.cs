namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductAttribute : EntityBase
    {
        public string Name { get; set; }

        public Guid GroupId { get; set; }

        public ProductAttributeGroup Group { get; set; }
    }
}
