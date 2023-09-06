using Microsoft.EntityFrameworkCore;
using Store.Application.Interfaces.Repositories;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repositories
{
    public class ProductRepositoryAsync : IProductRepositoryAsync
    {
        private readonly StoreContext _context;
        public ProductRepositoryAsync(StoreContext context)
        {
            _context = context;
        }
        public async Task<bool> AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            var res = await _context.SaveChangesAsync();
            return res > 0;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<List<Product>> GetProductByCategoryAsync(int categoryId)
        {
            return await _context.Products.Where(x => x.CategoryId == categoryId).ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            var prod = await _context.Products.FirstOrDefaultAsync(x => x.Id == product.Id);
            prod = product;
            _context.Entry(prod).State = EntityState.Modified;
            var res = await _context.SaveChangesAsync();
            return res > 0;
        }
    }
}
