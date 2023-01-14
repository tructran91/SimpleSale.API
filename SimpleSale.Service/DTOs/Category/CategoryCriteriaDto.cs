namespace SimpleSale.Application.DTOs.Category
{
    public class CategoryCriteriaDto
    {
        public Guid Id { get; set; }

        public bool? IsPublished { get; set; }

        public bool? IsFavorite { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
