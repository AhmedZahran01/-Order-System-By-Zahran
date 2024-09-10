using BLLOrder.Models;


namespace Dewan.QuickOrder.Client.Abstract.Services
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

