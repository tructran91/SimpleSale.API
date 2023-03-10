namespace SimpleSale.API.Models.Categories
{
    public class CategoryRequestModel : SEOContentViewModel
    {
        public string? Id { get; set; }

        public string Name { get; set; }

        public string? Slug { get; set; }

        public string? Description { get; set; }

        public string? DisplayName { get; set; }

        public bool IsPublished { get; set; }

        public bool IncludeInMenu { get; set; }

        public int DisplayOrder { get; set; }

        public string? ParentId { get; set; }
    }
}
