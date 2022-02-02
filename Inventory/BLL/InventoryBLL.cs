
using Cactus.Inventory.Dal;
using Cactus.Inventory.Model;
using System.Collections.Generic;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory;
namespace Cactus.Inventory.BLL
{
    public class InventoryBLL: IInventoryBLL
    {                
        #region Member

        IInvntoryDAL _invevtoryDAL;

        #endregion

        #region Constructor

        public InventoryBLL(IInvntoryDAL invntoryDAL)
        {
            _invevtoryDAL = invntoryDAL;
        }

        #endregion

        #region Get  Inventory

        public List<InventoryClass> GetInventory(InventoryClass inventory, StatusHasDitailEnum statusHasDitailEnum)
        {
            return
                _invevtoryDAL.GetInventoruy(inventory, statusHasDitailEnum);
        }

        #endregion

        #region Insert Inventory

        public ServerValidationEnum InsertInventory(InventoryClass inventory)
        {
            return _invevtoryDAL.InsertInventory(inventory);
        }

        #endregion

        #region UpdateInventory

        public ServerValidationEnum UpdateInventory(InventoryClass inventory)
        {
            return
                _invevtoryDAL.UpdateInventory(inventory); 
        }

        #endregion

        #region Delete Inventory 

        public ServerValidationEnum DeleteInventory(int ID)
        {
            return
                _invevtoryDAL.DeleteInventory(ID);
        }


        #endregion

    }
}
