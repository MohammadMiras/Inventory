using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryClass = Cactus.Inventory.Model.Inventory;
namespace Cactus.Inventory.Model
{
   public interface IReportDAL
    {
        DataTable GetCardex(CardexSearch cardex);
        DataTable GetStockInventory(InventoryClass inventory);
    }
}
