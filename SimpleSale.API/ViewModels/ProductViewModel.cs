namespace SimpleSale.API.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public Guid? CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}
