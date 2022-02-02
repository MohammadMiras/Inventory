using System.Data;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.Model
{
    public interface ITransactionBLL
    {
        DataTable GetTransactionFull(TransactionSearch transaction);
        Transaction GetTransaction(Transaction transaction);
         ServerValidationEnum InsertTransaction(Transaction transaction);
        bool DeleteTrsaction(int transactionID);
        ServerValidationEnum UpdateTransaction(Transaction transaction);     
    }
}
