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
            try
            {
                var result = await _supplierDbContext.SupplierDatas.AddAsync(supplierData);
                await _supplierDbContext.SaveChangesAsync();
                return supplierData;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<SupplierData> FindSupplierById(int supplierId)
        {
            try
            {
                return await _supplierDbContext.SupplierDatas.FindAsync(supplierId);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<SupplierData> UpdateSupplier(SupplierViewModel model)
        {
            var supplier = await _supplierDbContext.SupplierDatas.FindAsync(model.SupplierID);
            try
            {
                supplier.SupplierCompanyName = model.SupplierCompanyName;
                supplier.Email = model.Email;
                supplier.PhoneNumber = model.PhoneNumber;
                supplier.Address = model.Address;
                supplier.ContactPerson = model.ContactPerson;
               

                _supplierDbContext.SupplierDatas.Update(supplier);
                await _supplierDbContext.SaveChangesAsync();
                return supplier;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<IEnumerable<SupplierData>> ListAllSupplier()
        {
            try
            {
                var result = _supplierDbContext.SupplierDatas.
                OrderByDescending(x => x.SupplierID).Take(10).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<SupplierData> DeleteSupplierById(int supplierId)
        {
            var supplier= await _supplierDbContext.SupplierDatas.FindAsync(supplierId);
            try
            {
                _supplierDbContext.SupplierDatas.Remove(supplier);
                await _supplierDbContext.SaveChangesAsync();
                return supplier;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

    }
}