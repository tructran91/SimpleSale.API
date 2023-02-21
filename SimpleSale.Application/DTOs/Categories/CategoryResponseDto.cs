namespace SimpleSale.Application.DTOs.Categories
{
    public class CategoryResponseDto : ContentDto
    {
        public string DisplayName { get; set; }

        public bool IncludeInMenu { get; set; }

        public int DisplayOrder { get; set; }

        public Guid? ParentId { get; set; }

        public CategoryResponseDto? Parent { get; set; }

        public IList<CategoryResponseDto> Children { get; set; } = new List<CategoryResponseDto>();
    }
}
