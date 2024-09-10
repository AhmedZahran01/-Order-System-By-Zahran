using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Interfaces
{
    public interface IItemGroupService
    {
        List<ItemGroupModel> GetActiveItemGroups(int ParentGroupID);
        ItemGroupModel GetItemGroupById(int id);
        ItemGroupModel GetItemGroupByFullName(string fullname);
        void LoadDummyData();
        void InsertItemGroupModel(ItemGroupModel itemGroup, int parentGroupId);
        void DeleteItemGroupModel(int id);

    }
}
