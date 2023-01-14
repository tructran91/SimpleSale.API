namespace SimpleSale.Core.Entities.Catalog
{
    public class Brand : EntityBase
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public bool IsPublished { get; set; }
    }
}
