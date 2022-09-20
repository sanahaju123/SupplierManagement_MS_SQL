using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SupplierManagement.BusinessLayer.ViewModels
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Quantity { get; set; }
        public int SupplierId { get; set; }
    }
}
