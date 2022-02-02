using System;

namespace Cactus.Inventory.Model
{
    public  class TransactionSearch
    {
        #region Proprty

        public int ? CustomerID { get; set; }

        public string TransactionNumber { get; set; }

        public int InventoryID { get; set; }
        
        public string CustomerFullName { get; set; }

        public DateTime ToDate { get; set; }

        public DateTime FromDate { get; set; }

        #endregion

        #region Constructor

        public TransactionSearch()
        {
            ToDate = new DateTime(9998, 1, 1);
            FromDate = new DateTime(2000, 1, 1);
        } 

        #endregion
    }
}
