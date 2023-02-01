﻿using SimpleSale.Core.Enum;

namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductLink
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public Guid LinkedProductId { get; set; }

        public Product LinkedProduct { get; set; }

        public ProductLinkType LinkType { get; set; }
    }
}
