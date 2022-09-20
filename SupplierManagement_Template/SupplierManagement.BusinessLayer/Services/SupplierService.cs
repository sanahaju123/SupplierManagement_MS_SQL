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
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
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

        public async Task<SupplierData> DeleteSupplierById(int supplierId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SupplierData>> ListAllSupplier()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}