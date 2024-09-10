using BLLOrder.Models;
 
namespace Dewan.QuickOrder.Client.Domain.Services
{
    public interface ITaxGroupService
    {
        TaxGroupModel GetTaxGrouById(int id);
        List<TaxGroupModel> GetTaxGroups();
    }
}