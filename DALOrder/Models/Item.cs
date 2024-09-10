using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Models
{
    public class Item
    {

        public int ItemID { get; set; }
        public int ParentGroupID { get; set; }
        public string Name { get; set; }
        public string ItemFullName { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; } = "/Assets/Images/item.png";
        public int MeasurementUnit { get; set; }
        public int TaxGroup { get; set; }
        public int DiscountType { get; set; }
        public decimal DiscountValue { get; set; }
        public string Notes { get; set; }
        public string PromoCode { get; set; }
        public int Quantity { get; set; }

        private bool _isDeleted = false;
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }

    }
}
