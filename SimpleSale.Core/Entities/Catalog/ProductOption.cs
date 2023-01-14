namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductOption : EntityBase
    {
        public ProductOption()
        {

        }

        public ProductOption(Guid id)
        {
            Id = id;
        }

        public string Name { get; set; }
    }
}
