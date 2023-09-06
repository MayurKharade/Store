using AutoMapper;
using Store.Application.Interfaces.Repositories;
using Store.Application.ViewModels;
using Store.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Application.Features.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepositoryAsync _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepositoryAsync productRepository, IMapper mapper = null)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<bool> AddProductAsync(ProductViewModel product)
        {
           return await _productRepository.AddProductAsync(_mapper.Map<Product>(product));
        }

        public async Task<List<ProductViewModel>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllProductsAsync();
            return _mapper.Map<List<ProductViewModel>>(products);
        }

        public async Task<List<ProductViewModel>> GetProductByCategoryAsync(int categoryId)
        {
            var products = await _productRepository.GetProductByCategoryAsync(categoryId);
            return _mapper.Map<List<ProductViewModel>>(products);
        }

        public async Task<ProductViewModel> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            return _mapper.Map<ProductViewModel>(product);
        }

        public async Task<bool> UpdateProductAsync(ProductViewModel product)
        {
            return await _productRepository.UpdateProductAsync(_mapper.Map<Product>(product));
        }
    }
}
