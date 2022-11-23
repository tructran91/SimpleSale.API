using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductCategory : EntityBase
    {
        public int DisplayOrder { get; set; }

        public Guid CategoryId { get; set; }

        public Guid ProductId { get; set; }

        public Category Category { get; set; }

        public Product Product { get; set; }
    }
}
