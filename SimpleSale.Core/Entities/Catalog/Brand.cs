using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Core.Entities.Catalog
{
    public class Brand : EntityBase
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public bool IsPublished { get; set; }
    }
}
