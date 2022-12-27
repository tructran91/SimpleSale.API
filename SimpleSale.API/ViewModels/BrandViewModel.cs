using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleSale.API.ViewModels
{
    public class BrandViewModel
    {
        public string? Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        public string? Slug { get; set; }

        [Required]
        [DisplayName("Is Published")]
        public bool IsPublished { get; set; }
    }
}
