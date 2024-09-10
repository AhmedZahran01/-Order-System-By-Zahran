using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Models
{
    public class Tax
    {
        public int Id { get; set; }
        public int TaxGroupId { get; set; }
        public string Name { get; set; }
        public decimal TaxPresentage { get; set; }

    }
}
