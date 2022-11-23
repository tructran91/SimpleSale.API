using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductOptionValue : EntityBase
    {
        public Guid OptionId { get; set; }

        public ProductOption Option { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public string Value { get; set; }

        public string DisplayType { get; set; }

        public int SortIndex { get; set; }
    }
}
