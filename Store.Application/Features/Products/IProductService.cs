using Store.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Features.Products
{
    public interface IProductService
    {
        Task<bool> AddProductAsync(ProductViewModel product);
        Task<bool> UpdateProductAsync(ProductViewModel product);
        Task<ProductViewModel> GetProductByIdAsync(int id);
        Task<List<ProductViewModel>> GetAllProductsAsync();
        Task<List<ProductViewModel>> GetProductByCategoryAsync(int categoryId);
    }
}
