using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Interfaces
{
    public interface ICreditNoteService
    {
        void DeleteCreditNote(int creditNoteId);
        List<CreditNote> getActiveCreditNotes(int transactionId);
        void InserrtCreditNote(CreditNote creditNote, int transactionId);
        CreditNote GetCreditNoteById(int id);
    }
}
