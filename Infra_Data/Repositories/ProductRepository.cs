using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_Data.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        public Task<Product> CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByID(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetListGeneric()
        {
            throw new NotImplementedException();
        }

        public Task<Product> RemoveAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
