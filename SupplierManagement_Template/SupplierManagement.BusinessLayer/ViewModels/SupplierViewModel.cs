using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SupplierManagement.BusinessLayer.ViewModels
{
    public class SupplierViewModel
    {
        public int SupplierID { get; set; }
        public string SupplierCompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
