namespace SimpleSale.Application.DTOs.Categories
{
    public class CategoryDto : SEOContentDto
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string? Description { get; set; }

        public bool IsPublished { get; set; }

        public string DisplayName { get; set; }

        public bool IncludeInMenu { get; set; }

        public int DisplayOrder { get; set; }

        public Guid? ParentId { get; set; }

        //public CategoryDto? Parent { get; set; }

        //public IList<CategoryDto> Children { get; set; } = new List<CategoryDto>();
    }
}
