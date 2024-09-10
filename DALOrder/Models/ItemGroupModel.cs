using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Models
{
    public class ItemGroupModel
    {

        public int ItemGroupID { get; set; }
        public int ParentGroupID { get; set; }
        public string Name { get; set; }
        public string ItemGroupFullName { get; set; }

        private bool _isDeleted;
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }

        public List<ItemGroupModel> ChildGroups { get; set; }

        public string ImagePath { get; set; } = "/Assets/Images/item.png";
    }
}
