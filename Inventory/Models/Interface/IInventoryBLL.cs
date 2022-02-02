using System.Collections.Generic;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory; 


namespace Cactus.Inventory.Model
{
    public interface IInventoryBLL
    {
         List<InventoryClass> GetInventory(InventoryClass inventory, StatusHasDitailEnum statusHasDitailEnum);
        ServerValidationEnum InsertInventory(InventoryClass inventory);
        ServerValidationEnum UpdateInventory(InventoryClass inventory);
        ServerValidationEnum DeleteInventory(int ID);
    }
}
