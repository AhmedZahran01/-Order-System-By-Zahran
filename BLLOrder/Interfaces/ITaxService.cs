using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Interfaces
{

    public interface ITaxService
    {

        public List<Tax> GetTaxesForGroup(int groupID);

    }
}
