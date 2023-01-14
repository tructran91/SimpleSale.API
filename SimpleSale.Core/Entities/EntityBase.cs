using System.ComponentModel.DataAnnotations;

namespace SimpleSale.Core.Entities
{
    public class EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LatestUpdatedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
