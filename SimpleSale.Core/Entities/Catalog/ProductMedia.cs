﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Core.Entities.Catalog
{
    public class ProductMedia : EntityBase
    {
        public long ProductId { get; set; }

        public Product Product { get; set; }

        public long MediaId { get; set; }

        public Media Media { get; set; }

        public int DisplayOrder { get; set; }
    }
}
