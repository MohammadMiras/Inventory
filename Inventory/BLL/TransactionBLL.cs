using Cactus.Inventory.Dal;
using Cactus.Inventory.Model;
using System.Data;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.BLL
{
   public class TransactionBLL: ITransactionBLL
    {
        #region Member

        ITranactionDAL _transactionDAL;

        #endregion

        #region Constructors 

        public TransactionBLL(ITranactionDAL tranactionDAL)
        {
            _transactionDAL = tranactionDAL;
        }

        #endregion

        #region Get Transacton

        public DataTable GetTransactionFull(TransactionSearch transaction)
        {
            return _transactionDAL.GetTransactionFull(transaction);
        }

        public Transaction GetTransaction(Transaction transaction)
        {
            return _transactionDAL.GetTransaction(transaction);
        }

        #endregion

        #region  Insert Transaction

        public ServerValidationEnum InsertTransaction(Transaction transaction)
        {
            return _transactionDAL.InsertTransaction(transaction); 
        }

        #endregion

        #region Delete Transaction 

        public bool DeleteTrsaction(int transactionID)
        {
            return _transactionDAL.DeleteTransaction(transactionID);
        }

        #endregion

        #region Update Transaction

        public ServerValidationEnum UpdateTransaction(Transaction transaction)
        {
            return _transactionDAL.UpdateTransaction(transaction);
        }

        #endregion
    }
}
