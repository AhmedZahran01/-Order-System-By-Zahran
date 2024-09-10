using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrder.Services
{
    public class CreditNoteService
    {
        private List<CreditNote> _creditNotes;

        public CreditNoteService()
        {
            _creditNotes = new List<CreditNote>();

        }

        public List<CreditNote> getActiveCreditNotes(int transactionId)
        {
            return _creditNotes.Where(creditNote =>
                                   creditNote.TransactionId == transactionId && !creditNote.IsDeleted)
             .ToList(); ;
        }

        public void InserrtCreditNote(CreditNote creditNote, int transactionId)
        {
            if (creditNote != null)
            {
                creditNote.TransactionId = transactionId;
                _creditNotes.Add(creditNote);
            }
        }

        public CreditNote GetCreditNoteById(int id)
        {
            return _creditNotes.Where(creditNote => creditNote.Id == id &&
                                   !creditNote.IsDeleted).FirstOrDefault();
        }


        public void DeleteCreditNote(int creditNoteId)
        {
            CreditNote creditNote = GetCreditNoteById(creditNoteId);
            if (creditNote != null)
            {
                int index = _creditNotes!.FindIndex(i => i.Id == creditNoteId);
                if (index != -1)
                {
                    _creditNotes[index] = creditNote;
                }
            }
        }


        private void LoadDummyData()
        {
           _creditNotes.AddRange(
              new List<CreditNote>
              {
                     new CreditNote
                     {
                         Id = 1,
                         Note = "Note 1",
                         CreditNoteType = "Type A",
                         Type = "Type 1",
                         Value = 100.00,
                         DiscountAmount = 10.00,
                         Action = "Action 1",
                         TransactionId = 1,
                         IsDeleted = false
                     },
                     new CreditNote
                     {
                     Id = 2,
                     Note = "Note 2",
                     CreditNoteType = "Type B",
                     Type = "Type 2",
                     Value = 200.00,
                     DiscountAmount = 20.00,
                     Action = "Action 2",
                     TransactionId = 1,
                     IsDeleted = false
                     },
                     new CreditNote
                     {
                         Id = 3,
                         Note = "Note 3",
                         CreditNoteType = "Type C",
                         Type = "Type 3",
                         Value = 300.00,
                         DiscountAmount = 30.00,
                         Action = "Action 3",
                         TransactionId = 2,
                         IsDeleted = false
                     }
              }
             
           );
          
        }



    }
}
