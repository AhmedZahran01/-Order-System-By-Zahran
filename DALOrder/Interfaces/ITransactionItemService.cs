using BLLOrder.Models;
 
namespace Dewan.QuickOrder.Client.Abstract.Services
{
    public interface ITransactionItemService
    {
        ObservableCollection<TransactionItem> GetTransactionItems(int parentTransactionId);
        void InsertTransactionItem(TransactionItem transactionItem);
        bool DeleteTransactionItem(TransactionItem transactionItem);        
        bool UpdateTransactionItem(int transactionId, string Quantity, int MeasurementUnitId, string MeasurementUnitName);

    }   
}
