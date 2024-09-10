using BLLOrder.Models;

namespace Dewan.QuickOrder.Client.Abstract.Services
{
    public interface ITransactionService
    {
        List<Transaction> GetAllTransactions();
        Transaction GetTransactionById(int id);
        void InsertTransaction(Transaction transaction);
        void UpdateTransaction(Transaction transaction);
        List<Transaction> SearchBySerial(string serial);
    }
}
