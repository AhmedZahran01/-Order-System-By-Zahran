using BLLOrder.Enumes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Models
{
    public class Transaction:BaseModel
    {
        private int _id;
        private string _serial;
        private decimal _total;
        private decimal _tax;
        private decimal _discount;
        private decimal _paid;
        private decimal _remaining;
        private bool _isDeleted;
        private string _contact;
        private DateTime _date;
        private ObservableCollection<TransactionItem> _transactionItems;
        private int _taxGroupId;
        private DiscountTypeEnum _discountBefore;
        private DiscountTypeEnum _discountAfter;
        private decimal _discountBeforeValue;
        private decimal _discountAfterValue;


        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        public string Serial
        {
            get => _serial;
            set => SetProperty(ref _serial, value);
        }

        public decimal Total
        {
            get => _total;
            set => SetProperty(ref _total, value);
        }

        public decimal Tax
        {
            get => _tax;
            set => SetProperty(ref _tax, value);
        }

        public decimal Discount
        {
            get => _discount;
            set => SetProperty(ref _discount, value);
        }

        public decimal Paid
        {
            get => _paid;
            set
            {
                SetProperty(ref _paid, value);
                Remaining = Total - Paid;
            }
        }

        public decimal Remaining
        {
            get => _remaining;
            set => SetProperty(ref _remaining, value);
        }

        public bool IsDeleted
        {
            get => _isDeleted;
            set => SetProperty(ref _isDeleted, value);
        }

        public string Contact
        {
            get => _contact;
            set => SetProperty(ref _contact, value);
        }

        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public ObservableCollection<TransactionItem> TransactionItems
        {
            get => _transactionItems;
            set => SetProperty(ref _transactionItems, value);
        }

        public int TaxGroupId
        {
            get => _taxGroupId;
            set => SetProperty(ref _taxGroupId, value);
        }

        public DiscountTypeEnum DiscountBefore
        {
            get => _discountBefore;
            set => SetProperty(ref _discountBefore, value);
        }

        public DiscountTypeEnum DiscountAfter
        {
            get => _discountAfter;
            set => SetProperty(ref _discountAfter, value);
        }

        public decimal DiscountBeforeValue
        {
            get => _discountBeforeValue;
            set => SetProperty(ref _discountBeforeValue, value);
        }

        public decimal DiscountAfterValue
        {
            get => _discountAfterValue;
            set => SetProperty(ref _discountAfterValue, value);
        }

        public override string? ToString()
        {
            return Serial;
        }
    }
}
