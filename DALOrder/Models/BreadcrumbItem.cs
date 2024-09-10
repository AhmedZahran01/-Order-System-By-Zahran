using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BLLOrder.Models
{
    public class BreadcrumbItem
    {
        #region MyRegion

        public string Label { get; set; }
        public ICommand NavigationCommand { get; set; }
        public ItemGroupModel ItemGroup { get; set; } 
      
        #endregion

    }
}
