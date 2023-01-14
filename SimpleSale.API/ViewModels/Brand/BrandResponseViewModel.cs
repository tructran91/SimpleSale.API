using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleSale.API.ViewModels.Brand
{
    public class BrandResponseViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string? Slug { get; set; }

        public bool IsPublished { get; set; }
    }
}
