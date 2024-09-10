using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Interfaces
{
    public interface ITransactionItemService
    {
        ObservableCollection<TransactionItem> GetTransactionItems(int parentTransactionId);
        void InsertTransactionItem(TransactionItem transactionItem);
        bool DeleteTransactionItem(TransactionItem transactionItem);
        bool UpdateTransactionItem(int transactionId, string Quantity, int MeasurementUnitId, string MeasurementUnitName);

    }
}
