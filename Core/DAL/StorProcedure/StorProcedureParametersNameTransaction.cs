using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.StorProcedure
{
    public  class StorProcedureParametersNameTransaction : StorProcedureParametersName
    {
        public static string TransactionID = "TransactionID";

        public static string Number ="Number";

        public static string CustomerID = "CustomerID";

        public static string TransactionType = "TransactionTypeID";

        public static string Date = "Date ";

        public static string FromDate = "FromDate";

        public static string UntilDate = "UntilDate";

        public static string InventoryID = "InventoryID ";        

        public static string TransactionDetail = "TransactionDetailTable";

        public static string listTransactionID = "listTransactionID";

    }
}
