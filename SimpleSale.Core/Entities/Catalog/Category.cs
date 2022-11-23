using System.ComponentModel.DataAnnotations;

namespace SimpleSale.Core.Entities.Catalog
{
    public class Category : Content
    {
        public int DisplayOrder { get; set; }

        public long? ParentId { get; set; }

        public Category Parent { get; set; }

        public IList<Category> Children { get; set; } = new List<Category>();

        public Media ThumbnailImage { get; set; }
    }
}
