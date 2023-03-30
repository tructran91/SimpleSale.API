using SimpleSale.Core.Enums;

namespace SimpleSale.Core.Entities.Catalog
{
    public class Media : EntityBase
    {
        public string? Caption { get; set; }

        public int FileSize { get; set; }

        public string? FileName { get; set; }

        public MediaType MediaType { get; set; }

        public IList<ProductMedia> Products { get; set; } = new List<ProductMedia>();
    }
}
