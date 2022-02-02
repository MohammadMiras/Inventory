
using System.Collections.Generic;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory;
namespace Cactus.Inventory.Model
{
   public interface IInvntoryDAL
    {
        List<InventoryClass> GetInventoruy(InventoryClass inventory, StatusHasDitailEnum statusHasDitailEnum);
        ServerValidationEnum InsertInventory(InventoryClass inventory);
        ServerValidationEnum DeleteInventory(int InventoryID);
        ServerValidationEnum UpdateInventory(InventoryClass inventory);
    }
}
