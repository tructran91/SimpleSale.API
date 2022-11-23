namespace SimpleSale.Core.Entities.Catalog
{
    public class EntityBase
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LatestUpdatedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
