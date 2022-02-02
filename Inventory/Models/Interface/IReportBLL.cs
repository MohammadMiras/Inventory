using System.Data;
using InventoryClass = Cactus.Inventory.Model.Inventory;
namespace Cactus.Inventory.Model
{
   public interface IReportBLL
    {
        DataTable GetCardexReport(CardexSearch cardex);
        DataTable GetStockInventory(InventoryClass inventory);
    }
}
