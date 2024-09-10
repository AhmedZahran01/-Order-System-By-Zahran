using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Models
{
    public class CreditNote
    {

        public int    Id { get; set; }
        public string Note { get; set; }
        public string CreditNoteType { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        public double DiscountAmount { get; set; }
        public string Action { get; set; }
        public int    TransactionId { get; set; }
        public bool   IsDeleted { get; set; }

    }
}
