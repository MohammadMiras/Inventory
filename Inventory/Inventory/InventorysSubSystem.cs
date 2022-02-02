using System.Windows.Forms;
using Cactus.Common.Interface;

namespace Cactus.Inventory.UI
{
    public class InventorysSubSystem : IInventory
    {
        public InventorysSubSystem()
        {
            Bootstrapper.Init();
        }

        public UserControl GetUserControlMain()
        {
            return new  UC_Inventory_Main();
        }
    }
}
