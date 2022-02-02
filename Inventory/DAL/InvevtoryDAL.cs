using Cactus.Common;
using Cactus.Common.BaseClass;
using Cactus.Common.Logger;
using Cactus.Common.Utility;
using Cactus.Inventory.Dal.StorProcedure;
using Cactus.Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory;

namespace Cactus.Inventory.Dal
{
    public class InvevtoryDAL :DalBaseClass<InventoryClass>,IInvntoryDAL  
    {     
        #region Get Inventory

        public List<InventoryClass> GetInventoruy(InventoryClass inventory, StatusHasDitailEnum statusHasDitailEnum)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {                
                try
                {
                    #region Preparation

                    DataSet dsInventory = new DataSet();

                    SqlCommand sqlCommand = new SqlCommand(StoreProcedureNames.GetInventory, sqlConnection);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Parsmeters

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersNameInventory.InventoryID, inventory.ID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersNameInventory.InventoryCode, inventory.Code ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersNameInventory.InventoryTitle, inventory.Title ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersNameInventory.HasDetails, Convert.ToInt32(statusHasDitailEnum));

                    #endregion

                    #region Connection  DataBase

                    sqlDataAdapter.Fill(dsInventory);

                    return
                        ConvertToList(dsInventory); 

                    #endregion
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);
                    return null;

                }
            }
        } 

        #endregion

        #region  Insert Inventory

        public ServerValidationEnum InsertInventory(InventoryClass inventory )
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    ServerValidationEnum validationResult = ServerValidationEnum.NoProblem;

                    SqlCommand sqlCommand = new SqlCommand(StoreProcedureNames.InsertInventory, sqlConnection);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameInventory.InventoryCode, inventory.Code ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameInventory.InventoryTitle, inventory.Title ?? (object)DBNull.Value);

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcedureParametersNameInventory.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;
                    
                    #endregion

                    #region cannection DataBase

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    validationResult = (ServerValidationEnum)returnParameter.Value;

                    sqlConnection.Close();

                    return
                        validationResult;   

                    #endregion
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return ServerValidationEnum.Error;
                }
            }
        }

        #endregion

        #region  Delete Inventory

        public ServerValidationEnum DeleteInventory(int InventoryID)
        {
           

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    ServerValidationEnum validationResult = new ServerValidationEnum();

                    SqlCommand sqlCommand = new SqlCommand(StoreProcedureNames.DeleteInventory, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add  Parameters

                    sqlCommand.Parameters.AddWithValue
                       (StorProcedureParametersNameInventory.InventoryID, InventoryID);

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                             (StorProcedureParametersNameInventory.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    #endregion

                    #region Connection DataBase

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    validationResult = (ServerValidationEnum)returnParameter.Value;

                    sqlConnection.Close();

                    return validationResult;   

                    #endregion

                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return ServerValidationEnum.Error;
                }
            }
        }

        #endregion

        #region Update Inventory  

        public ServerValidationEnum UpdateInventory(InventoryClass inventory)
        {

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    ServerValidationEnum validationResult = ServerValidationEnum.NoProblem;

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.UpdateInventory, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameInventory.InventoryID, inventory.ID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameInventory.InventoryCode, inventory.Code ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameInventory.InventoryTitle, inventory.Title ?? (object)DBNull.Value);

                    var returnParameter =
                        sqlCommand.Parameters.Add
                            (StorProcedureParametersNameInventory.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    #endregion

                    #region Conection Databas

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    validationResult = (ServerValidationEnum)returnParameter.Value;

                    sqlConnection.Close();

                    return
                        validationResult; 

                    #endregion

                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                     return ServerValidationEnum.Error;
                }
            }
        }

        #endregion

        #region  Metods

        protected override List<InventoryClass> ConvertToList(DataSet dataSet)
        {
            List<InventoryClass> InventoryList = 
                dataSet.Tables[0].ConvertDataTable<InventoryClass>();

            if (dataSet.Tables.Count == 1)
                return InventoryList;

            Goods goods = new Goods();

            foreach (DataRow item in dataSet.Tables[1].Rows)
            {
                goods.ID = int.Parse(item["GoodsID"].ToString());
                goods.Name = item["Name"].ToString();
                goods.Stock = int.Parse(item["Stock"].ToString());

                InventoryList[0].GoodsList.Add(goods);

                goods = new Goods();
            }

            return
                InventoryList;
        }              

        #endregion
    }
}
