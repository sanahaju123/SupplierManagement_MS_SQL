using SupplierManagement.BusinessLayer.Interfaces;
using SupplierManagement.BusinessLayer.Services.Repository;
using SupplierManagement.BusinessLayer.ViewModels;
using SupplierManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SupplierManagement.BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

       
        public async Task<ProductData> AddProduct(ProductData productData)
        {
            return await _productRepository.AddProduct(productData);
        }

        public async Task<ProductData> FindProductById(int productId)
        {
            return await _productRepository.FindProductById(productId);
        }

        public async Task<ProductData> DeleteProductById(int productId)
        {
            return await _productRepository.DeleteProductById(productId);
        }

        public async Task<ProductData> UpdateProduct(ProductViewModel model)
        {
            return await _productRepository.UpdateProduct(model);
        }

        public async Task<IEnumerable<ProductData>> ListAllProducts()
        {
            return await _productRepository.ListAllProducts();
        }
    }
}