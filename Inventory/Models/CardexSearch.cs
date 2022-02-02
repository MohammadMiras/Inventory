using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cactus.Inventory.Model
{
    public  class CardexSearch 
    {
        #region Proprty

        public int? InventoryID { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public DataTable dtGoodsID { get; set; }

        #endregion

        #region Constructor

        public CardexSearch()
        {
            ToDate = new DateTime(9998, 1, 1);

            FromDate = new DateTime(2000, 1, 1);

            dtGoodsID = new DataTable();

            InitializeTables();
        }

        #endregion

        #region Metods

        public void InitializeTables()
        {

            dtGoodsID.Columns.AddRange
                (
                    new DataColumn[]
                        {
                            new DataColumn("ID", typeof(int))
                        }
                );
        } 

        #endregion
    }
}
