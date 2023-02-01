namespace SimpleSale.API.ViewModels.Product
{
    public class ProductRequestViewModel : ContentViewModel
    {
        public string? Id { get; set; }

        public bool IncludeInMenu { get; set; }

        public int DisplayOrder { get; set; }

        public string? ParentId { get; set; }
    }
}
