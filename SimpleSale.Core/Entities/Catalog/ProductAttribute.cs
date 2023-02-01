﻿namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductAttribute
    {
        public Guid Id { get; set; }

        public Guid GroupId { get; set; }

        public ProductAttributeGroup Group { get; set; }

        public string Name { get; set; }
    }
}
