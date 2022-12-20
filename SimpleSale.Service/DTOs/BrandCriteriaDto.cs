using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Application.DTOs
{
    public class BrandCriteriaDto
    {
        public Guid Id { get; set; }

        public bool? IsPublished { get; set; }

        public bool? IsFavorite { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
