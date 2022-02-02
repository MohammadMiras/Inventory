using Cactus.Inventory.Dal;
using Cactus.Inventory.Model;
using System.Data;
using InventoryClass = Cactus.Inventory.Model.Inventory;

namespace Cactus.Inventory.BLL
{
    public class ReportBLL:IReportBLL
    {
        #region Member

        IReportDAL _reportDAL;

        #endregion

        #region Contructor

        public ReportBLL(IReportDAL reportDAL)
        {
            _reportDAL = reportDAL;
        }

        #endregion

        #region Get Cardex Report

        public DataTable GetCardexReport(CardexSearch cardex)
        {
            return _reportDAL.GetCardex(cardex);
        }

        #endregion

        #region Get Stock Inventory

        public DataTable GetStockInventory(InventoryClass inventory)
        {
            return _reportDAL.GetStockInventory(inventory);
        }

        #endregion
    }
}
