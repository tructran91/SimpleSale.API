namespace SimpleSale.Core.Entities.Catalog
{
    public class Category : Content
    {
        public bool IncludeInMenu { get; set; }

        public int DisplayOrder { get; set; }

        public Guid? ParentId { get; set; }

        public Category? Parent { get; set; }

        public IList<Category> Children { get; set; } = new List<Category>();
    }
}
