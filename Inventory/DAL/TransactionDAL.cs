using Cactus.Common;
using Cactus.Common.Logger;
using Cactus.Common.Utility;
using Cactus.Inventory.Dal.StorProcedure;
using Cactus.Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Cactus.Common.Model.ModelUtility;
namespace Cactus.Inventory.Dal
{
   public class TransactionDAL :ITranactionDAL
    { 
        #region  Insert Trasaction

        public ServerValidationEnum InsertTransaction(Transaction transaction)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    transaction.InitializeTables();

                    transaction.FillDataTable();

                    ServerValidationEnum validationResult = ServerValidationEnum.NoProblem;

                    SqlCommand sqlCommand = 
                        new SqlCommand(StoreProcedureNames.InsertTransaction, sqlConnection);

                    SqlDataAdapter sqlDataAdapter = 
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.Number, transaction.Number ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.CustomerID, transaction.CustomerID ?? (object)DBNull.Value);

                    int transactionType = (int)transaction.TransactionType;

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.TransactionType,transactionType);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.Date, transaction.Date);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.InventoryID, (int)transaction.InventoryID);                   

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.TransactionDetail, transaction.dtTransctionDetails ?? (object)DBNull.Value );

                    var returnParameter = 
                        sqlCommand.Parameters.AddWithValue
                             (StorProcedureParametersNameTransaction.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    validationResult = (ServerValidationEnum)returnParameter.Value;

                    sqlConnection.Close();

                    return
                        validationResult;

                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    
                    return ServerValidationEnum.Error;                   
                }
            }
        }

        #endregion

        #region Get Transaction

        public DataTable GetTransactionFull(TransactionSearch transaction)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.GetTransactionFull, sqlConnection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    #endregion

                    #region Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.FromDate, transaction.FromDate);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.UntilDate, transaction.ToDate);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.Number, transaction.TransactionNumber ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.CustomerID, transaction.CustomerID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                       (
                            StorProcedureParametersNameTransaction.InventoryID,
                            transaction.InventoryID == 0 ? (object)DBNull.Value : transaction.InventoryID
                       );

                    #endregion

                    #region Connect DataBase

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    return dataTable; 

                    #endregion
                }
                catch (Exception ex)
                {                  
                    Logger.Log(ex);
                    
                    return null;
                }
            }            
        }

        public Transaction GetTransaction(Transaction transaction)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    SqlCommand sqlCommand = 
                        new SqlCommand(StoreProcedureNames.GetTransaction, sqlConnection);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.TransactionID, transaction.ID ?? (object)DBNull.Value);

                    DataSet dataSet = new DataSet();

                    sqlDataAdapter.Fill(dataSet);
                   
                    return ConvertToTransaction(dataSet);
                }
                catch (Exception ex )
                {
                    Logger.Log(ex);
                    
                    return null;
                }
            }

        }

        #endregion

        #region  Update Trasaction

        public ServerValidationEnum UpdateTransaction(Transaction transaction)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    transaction.InitializeTables();

                    transaction.FillDataTable();

                    int TransactionType = (int)transaction.TransactionType;

                    ServerValidationEnum validationResult = ServerValidationEnum.NoProblem;

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.UpdateTransaction, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Parameters 

                    sqlCommand.Parameters.AddWithValue
                    (StorProcedureParametersNameTransaction.TransactionID, transaction.ID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.Number, transaction.Number ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.CustomerID, transaction.CustomerID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.TransactionType, TransactionType);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.Date, transaction.Date);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameTransaction.InventoryID, (int)transaction.InventoryID);

                    sqlCommand.Parameters.AddWithValue
                        (
                            StorProcedureParametersNameTransaction.TransactionDetail,
                            transaction.dtTransctionDetails ?? (object)DBNull.Value
                        );

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcedureParametersNameTransaction.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    #endregion

                    #region Connect DataBase

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    validationResult = (ServerValidationEnum)returnParameter.Value;

                    sqlConnection.Close(); 

                    #endregion

                    return
                        validationResult;
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    
                    return ServerValidationEnum.Error;
                }
            }
        }

        #endregion

        #region Delete Transaction

        public bool DeleteTransaction(int ID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.DeleteTransaction, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    DataTable TableID =
                        DataTableTools.ConvertIntToDatatable(ID); 

                    #endregion

                    #region Parameters


                    sqlCommand.Parameters.AddWithValue
                     (StorProcedureParametersNameTransaction.listTransactionID, TableID);

                    sqlCommand.Parameters
                        [StorProcedureParametersNameTransaction.listTransactionID].SqlDbType =
                            SqlDbType.Structured;

                    #endregion

                    #region Connect DataBase 

                    int Result;

                    sqlConnection.Open();

                    Result = sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    return Convert.ToBoolean(Result); 

                    #endregion
                }
                catch (Exception ex)
                {                  
                    Logger.Log(ex);
                    
                    return false; 
                }
            }
        }

        #endregion

        #region Metods

        protected  Transaction ConvertToTransaction(DataSet dataSet)
        {
            try
            {
                Transaction transaction = new Transaction();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    transaction.ID = Convert.ToInt32(row["ID"].ToString());
                    transaction.Number = row["Number"].ToString();
                    transaction.CustomerID = Convert.ToInt32(row["CustomerID"].ToString());
                    transaction.CustomerCode = row["CustomerCode"].ToString();
                    transaction.InventoryID = Convert.ToInt32(row["InventoryID"].ToString());
                    transaction.TransactionType = Convert.ToInt32(row["TransactionType"].ToString());
                    transaction.Date = (DateTime)row["Date"];

                    break;
                }

                if (dataSet.Tables.Count == 1)
                    return transaction;

                transaction.TransctionDetails = ConvertDataTableTransactionDetailToList(dataSet.Tables[1]);

                transaction.dtTransctionDetails = dataSet.Tables[1];

                return transaction;
            }
            catch (Exception )
            { 
                return null;
            }

        }

        protected  List<TransactionDetail> ConvertDataTableTransactionDetailToList(DataTable dataTable)
        {
            try
            {
                List<TransactionDetail> TransactionDetails =
                    new List<TransactionDetail>();

                foreach (DataRow row in dataTable.Rows)
                {
                    TransactionDetail TransactionDetail = new TransactionDetail();

                    TransactionDetail.ID = Convert.ToInt32(row["ID"].ToString());
                    TransactionDetail.TransactionID = Convert.ToInt32(row["TransactionID"].ToString());
                    TransactionDetail.Goods.ID = Convert.ToInt32(row["GoodsID"].ToString());
                    TransactionDetail.NumberOfGoods = Convert.ToInt32(row["NumberOfGoods"].ToString());
                    TransactionDetail.Price = Convert.ToInt32(row["Price"].ToString());
                    TransactionDetail.RecordStatus = Convert.ToInt32(row["RecordStatus"].ToString());
                    TransactionDetail.Goods.Code = row["GoodsCode"].ToString();
                    TransactionDetail.Goods.Name = row["GoodsName"].ToString();
                    TransactionDetail.Goods.GoodsUnit = Convert.ToInt32(row["GoodsUnit"].ToString());

                    TransactionDetails.Add(TransactionDetail);
                }

                return TransactionDetails;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return null;
            }
        }

        #endregion
    } 
        
}
