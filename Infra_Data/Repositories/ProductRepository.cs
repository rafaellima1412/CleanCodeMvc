using Domain.Entities;
using Domain.Interfaces;
using Infra_Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infra_Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public async Task<Product> CreateAsync(Product entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Product> GetByID(int? id)
        {
            return await _context.Products.Include(x => x.Category).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetListGeneric()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> RemoveAsync(Product entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
