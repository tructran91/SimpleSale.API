namespace SimpleSale.Core.Entities
{
    public class Content : EntityBase
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string? MetaTitle { get; set; }

        public string? MetaKeywords { get; set; }

        public string? MetaDescription { get; set; }

        public string? Description { get; set; }

        public bool IsPublished { get; set; }
    }
}
