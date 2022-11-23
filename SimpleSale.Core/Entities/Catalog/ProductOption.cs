using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductOption : EntityBase
    {
        public ProductOption()
        {

        }

        public ProductOption(Guid id)
        {
            Id = id;
        }

        public string Name { get; set; }
    }
}
