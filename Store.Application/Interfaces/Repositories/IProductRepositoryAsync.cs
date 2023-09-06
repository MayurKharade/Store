using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Interfaces.Repositories
{
    public interface IProductRepositoryAsync
    {
        Task<bool> AddProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<Product> GetProductByIdAsync(int id);
        Task<List<Product>> GetAllProductsAsync();
        Task<List<Product>> GetProductByCategoryAsync(int categoryId);
    }
}
