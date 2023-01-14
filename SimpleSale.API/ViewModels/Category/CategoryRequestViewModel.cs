namespace SimpleSale.API.ViewModels.Category
{
    public class CategoryRequestViewModel : ContentViewModel
    {
        public string? Id { get; set; }

        public bool IncludeInMenu { get; set; }

        public int DisplayOrder { get; set; }

        public string? ParentId { get; set; }
    }
}
