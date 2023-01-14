namespace SimpleSale.API.ViewModels.Category
{
    public class CategoryResponseViewModel : ContentViewModel
    {
        public Guid Id { get; set; }

        public string DisplayName { get; set; }

        public bool IncludeInMenu { get; set; }

        public int DisplayOrder { get; set; }

        public Guid? ParentId { get; set; }
    }
}
