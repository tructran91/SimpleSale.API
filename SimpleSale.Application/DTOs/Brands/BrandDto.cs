﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Application.DTOs.Brands
{
    public class BrandDto
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string? Slug { get; set; }

        public bool IsPublished { get; set; }
    }
}
