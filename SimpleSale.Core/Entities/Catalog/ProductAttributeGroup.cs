using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductAttributeGroup : EntityBase
    {
        public string Name { get; set; }

        public IList<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
    }
}
