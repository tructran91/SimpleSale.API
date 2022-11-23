using SimpleSale.Core.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSale.Application.Interfaces
{
    public interface IBrandService
    {
        Task Create(Brand brand);

        Task Update(Brand brand);

        Task Delete(Guid id);
    }
}
