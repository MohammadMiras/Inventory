using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Inventory.Dal.StorProcedure
{
   public static class StoreProcedureNames
    {

        //-------------------< Goods >--------------------

        public static string GetGoods = "GetGoods";

        public static string Getcategory = "GetCategory";

        public static string InsertGoods = "InsertGoods";

        public static string UpdateGoods = "UpdateGoods";

        public static string DeleteGoods = "DeleteGoods";

        public static string GetWeihtUnit = "GetWeightUnit";

        public static string DeleteCategory = "DeleteCategory";

        public static string UpdateCategory = "UpdateCategory";

        //-----------------< Inventory >-----------------

        public static string GetInventory = "GetInventory";

        public static string InsertInventory = "InsertInventory";

        public static string DeleteInventory = "DeleteInventory";

        public static string UpdateInventory = "UpdateInventory";

        public static string GetUnit = "GetUnit";

        public static string InsertCategory = "InsertCategory";

        public static string InsertTransaction = "InsertTransaction";

        public static string GetStockInventory = "GetStockInventory";

        //----------------< Transaction >--------------------------

        public static string GetTransactionFull = "GetTransactionFull";

        public static string GetTransaction  = "GetTransaction";

        public static string DeleteTransaction = "DeleteTransaction";

        public static string UpdateTransaction = "UpdateTransaction";


        //----------------------< Report >--------------------------

        public static string Cardex = "Cardex";

    }
}
