using BLLOrder.Models; 
namespace Dewan.QuickOrder.Client.Domain.Services
{
    public interface ICreditNoteService
    {
        void DeleteCreditNote(int creditNoteId);
        List<CreditNote> getActiveCreditNotes(int transactionId);
        void InserrtCreditNote(CreditNote creditNote, int transactionId);
        CreditNote GetCreditNoteById(int id);
    }
}