using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Interfaces
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
