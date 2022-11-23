using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductAttribute : EntityBase
    {
        public string Name { get; set; }

        public Guid GroupId { get; set; }

        public ProductAttributeGroup Group { get; set; }
    }
}
