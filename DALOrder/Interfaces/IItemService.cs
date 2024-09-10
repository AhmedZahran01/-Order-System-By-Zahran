using BLLOrder.Models; 

namespace Dewan.QuickOrder.Client.Abstract.Services
{
    public interface IItemService
    {
        List<Item> GetActiveItems(int ParentGroupID);
        Item GetItemById(int id);
        Item GetItemByFullName(string fullname);
        List<string> Search(Func<Item, bool> predicate);
        void InsertItem(Item item, int parentGroupId);
        void DeleteItem(int id);
    }
}
