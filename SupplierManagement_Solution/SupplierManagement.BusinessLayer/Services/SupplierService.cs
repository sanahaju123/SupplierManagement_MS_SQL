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
            return await _supplierRepository.AddSupplier(supplierData);
        }

        public async Task<SupplierData> FindSupplierById(int supplierId)
        {
            return await _supplierRepository.FindSupplierById(supplierId);
        }

        public async Task<SupplierData> UpdateSupplier(SupplierViewModel model)
        {
            return await _supplierRepository.UpdateSupplier(model);
        }

        public async Task<SupplierData> DeleteSupplierById(int supplierId)
        {
            return await _supplierRepository.DeleteSupplierById(supplierId);
        }

        public async Task<IEnumerable<SupplierData>> ListAllSupplier()
        {
            return await _supplierRepository.ListAllSupplier();
        }
    }
}