using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public static class StoreProcedureNames
    {

        public static string GetPhones = "GetPhone";

        public static string DeleteCustomer = "DeleteCustomer";

        public static string UpdateCustomer = "UpdateCustoner";

        public static string InsertCustomer = "InsertCustomer";

        public static string GetAddres = "GetAddress";

        public static string GetContacts = "GetCustomer";

        public static string GetPhoneAndAddressType = "GetPhoneAndAddressType";

        //-------------------<Goods>--------------------

        public static string GetGoods = "GetGoods";

        public static string Getcategory = "GetCategory";

        public static string InsertGoods = "InsertGoods";

        public static string UpdateGoods = "UpdateGoods";

        public static string DeleteGoods = "DeleteGoods";

        public static string GetWeihtUnit = "GetWeightUnit";

        public static string DeleteCategory = "DeleteCategory";

        public static string UpdateCategory = "UpdateCategory";

        //-----------------<Inventory>-----------------

        public static string GetInventory = "GetInventory";

        public static string InsertInventory = "InsertInventory";

        public static string DeleteInventory = "DeleteInventory";

        public static string UpdateInventory = "UpdateInventory";

        public static string GetUnit = "GetUnit";

        public static string InsertCategory = "InsertCategory";

        public static string InsertTransaction = "InsertTransaction";

        public static string GetStockInventory = "GetStockInventory";

        //----------------<transaction>--------------------------

        public static string GetTransactionFull = "GetTransactionFull";

        public static string GetTransaction  = "GetTransaction";

        public static string DeleteTransaction = "DeleteTransaction";

        public static string UpdateTransaction = "UpdateTransaction";


        //----------------------<Report>--------------------------

        public static string Cardex = "Cardex";

        //----------------------< User >----------------------------

        public static string IsValidUser = "IsValidUser";

        public static string InsertUser = "InsertUser";

        public static string GetUserDetile = "GetUserDetile";

        public static string UpdateCurrentUser = "UpdateCurrentUser";

        public static string SerachUserFull = "SearchUserFull";

        public static string GetRole = "GetRole";

        public static string UpdateUser = "UpdateUser";

        public static string DeleteUser = "DeleteUser";

        public static string GetAllObjSystem = "GetAllObjSystem";

        public static string InsertRole = "InsertRole";

        public static string UpdateRole = "UpdateRole";




    }
}
