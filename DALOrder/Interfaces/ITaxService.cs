using BLLOrder.Models;
 
namespace Dewan.QuickOrder.Client.Abstract.Services
{
    public interface ITaxService
    {
        
        public List<Tax> GetTaxesForGroup(int groupID);

    }
}
