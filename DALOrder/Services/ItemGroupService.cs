using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrder.Services
{
    public class ItemGroupService
    {

        private List<ItemGroupModel>? _itemGroupModels;

        public ItemGroupService()
        {
            _itemGroupModels = new List<ItemGroupModel>();
            LoadDummyData();
        }
      
        public List<ItemGroupModel> GetActiveItemGroups(int parentGroupID)
        {
            return _itemGroupModels!
            .Where(group => group.ParentGroupID == parentGroupID && !group.IsDeleted)
            .ToList();
        } 

        public ItemGroupModel GetItemGroupByFullName(string fullname)
        {
            return _itemGroupModels!.Where(itemGroup => itemGroup.ItemGroupFullName == fullname)
                              .FirstOrDefault()!;
        }

        public ItemGroupModel GetItemGroupById(int id)
        {
            if (_itemGroupModels!.Any(group => group.ItemGroupID == id && !group.IsDeleted))
            {
                return _itemGroupModels!
                .Where(group => group.ItemGroupID == id && !group.IsDeleted).FirstOrDefault()!;
            }
            return null;
        }
        public void LoadDummyData()
        {
            _itemGroupModels!.AddRange(
           [
               new ItemGroupModel
                {
                    ItemGroupID = 1,
                    ParentGroupID = 0,
                    Name = "Electronics",
                    ItemGroupFullName = "Electronics",
                    ImagePath = "/Dewan.QuickOrder.Client;component/Assets/Images/Electronics-phones-labtops.png"

                },
                new ItemGroupModel
                {
                    ItemGroupID = 2,
                    ParentGroupID = 1,
                    Name = "Mobile Phones",
                    ItemGroupFullName = "Electronics-Mobile Phones",
                    ImagePath = "/Dewan.QuickOrder.Client;component/Assets/Images/Mobile_Phones.png"

                },
                new ItemGroupModel
                {
                    ItemGroupID = 3,
                    ParentGroupID = 1,
                    Name = "Laptops",
                    ItemGroupFullName = "Electronics-Laptops",
                    ImagePath = "/Dewan.QuickOrder.Client;component/Assets/Images/LapTops.webp"

                },
                new ItemGroupModel
                {
                    ItemGroupID = 4,
                    ParentGroupID = 0,
                    Name = "Home Appliances",
                    ItemGroupFullName = "Home Appliances",
                    ImagePath = "/Dewan.QuickOrder.Client;component/Assets/Images/Home-appliances.jfif"
                }
           ]);
        }

        public void InsertItemGroupModel(ItemGroupModel itemGroup, int parentGroupId)
        {  
            if (itemGroup != null)
            {
                var parentItemGroup = GetItemGroupById(parentGroupId);
                if (parentItemGroup != null)
                {
                    itemGroup.ItemGroupFullName = (parentItemGroup.ItemGroupFullName + "-" + itemGroup.Name);
                    itemGroup.ParentGroupID = parentGroupId;
                    _itemGroupModels!.Add(itemGroup);

                }
            }
        }

    }
}
