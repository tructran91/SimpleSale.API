using SimpleSale.Core.Entities.Catalog;
using SimpleSale.Core.Repositories;
using SimpleSale.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Infrastructure.Repository
{
    public class BrandRepository :Repository<Brand>, IBrandRepository
    {
        public BrandRepository(SimpleSaleDbContext dbContext) : base(dbContext)
        {
        }
    }
}
