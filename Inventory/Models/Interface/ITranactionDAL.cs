
using System.Data;

using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.Model
{
    public interface ITranactionDAL
    {
        ServerValidationEnum InsertTransaction(Transaction transaction);
        DataTable GetTransactionFull(TransactionSearch transaction);
        Transaction GetTransaction(Transaction transaction);
        ServerValidationEnum UpdateTransaction(Transaction transaction);
        bool DeleteTransaction(int ID);
    }
}
