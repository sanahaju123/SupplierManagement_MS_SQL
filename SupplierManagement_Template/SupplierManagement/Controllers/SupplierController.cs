using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplierManagement.BusinessLayer.Interfaces;
using SupplierManagement.BusinessLayer.ViewModels;
using SupplierManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplierManagement.Controllers
{
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        private readonly IProductService _productService;
        public SupplierController(ISupplierService supplierService, IProductService productService)
        {
            _supplierService = supplierService;
            _productService = productService;
        }

        #region SupplierRegion
        /// <summary>
        /// Add a new Supplier
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Supplier/Add-Supplier")]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSupplier([FromBody] SupplierViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a existing Supplier
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Supplier/Update-Supplier")]
        public async Task<IActionResult> UpdateSupplier([FromBody] SupplierViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a existing Supplier
        /// </summary>
        /// <param name="SupplierId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Supplier/Delete-Supplier/{SupplierId}")]
        public async Task<IActionResult> DeleteSupplier(int SupplierId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Supplier by Id
        /// </summary>
        /// <param name="SupplierId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Supplier/Get-Supplier/{SupplierId}")]
        public async Task<IActionResult> GetSupplierById(int SupplierId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// List All Suppliers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Supplier/All-Suppliers")]
        public async Task<IEnumerable<SupplierData>> ListAllSuppliers()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        #endregion


        #region Product
        /// <summary>
        /// Add a new Product
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Product/Add-Product")]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProduct([FromBody] ProductViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update a existing Product
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("product/Update-product")]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Delete a existing Product
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Product/Delete-Product/{ProductId}")]
        public async Task<IActionResult> DeleteProduct(int ProductId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Product by Id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Product/Get-Product/{ProductId}")]
        public async Task<IActionResult> GetProductById(int ProductId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// List All Products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Product/All-Products")]
        public async Task<IEnumerable<ProductData>> ListAllProducts()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        #endregion
    }
}
