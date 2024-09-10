using BLLOrder.Enumes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Models
{
    public class TransactionItem:BaseModel
    {
        private int _transactionId;
        private string _name;
        private int _measurementUnitId;
        private string _measurementUnitName;
        private string _quantity = "0";
        private string _price;
        private int _taxGroupId;
        private decimal _discountAmount;
        private decimal _total;
        private int _parentTransactionId;
        private int _itemId;
        private decimal _discountValue;
        private DiscountTypeEnum _discountType;
        private bool _isDeleted;
        private int _parentGroupId;
        private decimal _taxValue;


        public int TransactionId
        {
            get => _transactionId;
            set => SetProperty(ref _transactionId, value);
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public int MeasurementUnitId
        {
            get => _measurementUnitId;
            set => SetProperty(ref _measurementUnitId, value);
        }

        public string MeasurementUnitName
        {
            get => _measurementUnitName;
            set => SetProperty(ref _measurementUnitName, value);
        }

        public string Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        public string Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public int TaxGroupId
        {
            get => _taxGroupId;
            set => SetProperty(ref _taxGroupId, value);
        }

        public decimal DiscountAmount
        {
            get => _discountAmount;
            set => SetProperty(ref _discountAmount, value);
        }

        public decimal Total
        {
            get => _total;
            set => SetProperty(ref _total, value);
        }

        public int ParentTransactionId
        {
            get => _parentTransactionId;
            set => SetProperty(ref _parentTransactionId, value);
        }

        public int ItemID
        {
            get => _itemId;
            set => SetProperty(ref _itemId, value);
        }

        public decimal DiscountValue
        {
            get => _discountValue;
            set => SetProperty(ref _discountValue, value);
        }

        public DiscountTypeEnum DiscountType
        {
            get => _discountType;
            set => SetProperty(ref _discountType, value);
        }

        public bool IsDeleted
        {
            get => _isDeleted;
            set => SetProperty(ref _isDeleted, value);
        }

        public int ParentGroupId
        {
            get => _parentGroupId;
            set => SetProperty(ref _parentGroupId, value);
        }

        public decimal TaxValue
        {
            get => _taxValue;
            set => SetProperty(ref _taxValue, value);
        }
    }
}
