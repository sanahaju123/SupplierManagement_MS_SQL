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
    public class SupplierRepository : ISupplierRepository
    {
        private readonly SupplierDbContext _supplierDbContext;
        public SupplierRepository(SupplierDbContext supplierDbContext)
        {
            _supplierDbContext = supplierDbContext;
        }

        public async Task<SupplierData> AddSupplier(SupplierData supplierData)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<SupplierData> FindSupplierById(int supplierId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<SupplierData> UpdateSupplier(SupplierViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SupplierData>> ListAllSupplier()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<SupplierData> DeleteSupplierById(int supplierId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

    }
}