using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Interfaces
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
