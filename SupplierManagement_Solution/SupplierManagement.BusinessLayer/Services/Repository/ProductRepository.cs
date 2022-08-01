using SupplierManagement.BusinessLayer.ViewModels;
using SupplierManagement.DataLayer;
using SupplierManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierManagement.BusinessLayer.Services.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SupplierDbContext _supplierDbContext;
        public ProductRepository(SupplierDbContext supplierDbContext)
        {
            _supplierDbContext = supplierDbContext;
        }

        public async Task<ProductData> AddProduct(ProductData productData)
        {
            try
            {
                var result = await _supplierDbContext.ProductDatas.AddAsync(productData);
                await _supplierDbContext.SaveChangesAsync();
                return productData;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<ProductData> FindProductById(int productId)
        {
            try
            {
                return await _supplierDbContext.ProductDatas.FindAsync(productId);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<ProductData> UpdateProduct(ProductViewModel model)
        {
            var product = await _supplierDbContext.ProductDatas.FindAsync(model.ProductID);
            try
            {
                product.ProductName = model.ProductName;
                product.Price = model.Price;
                product.Quantity = model.Quantity;
                product.SupplierId = model.SupplierId;

                _supplierDbContext.ProductDatas.Update(product);
                await _supplierDbContext.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<IEnumerable<ProductData>> ListAllProducts()
        {
            try
            {
                var result = _supplierDbContext.ProductDatas.
                OrderByDescending(x => x.ProductID).Take(10).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<ProductData> DeleteProductById(int productId)
        {
            var product = await _supplierDbContext.ProductDatas.FindAsync(productId);
            try
            {
                _supplierDbContext.ProductDatas.Remove(product);
                await _supplierDbContext.SaveChangesAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}