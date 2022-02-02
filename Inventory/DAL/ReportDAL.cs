using Cactus.Common;
using Cactus.Common.Logger;
using Cactus.Inventory.Dal.StorProcedure;
using Cactus.Inventory.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using InventoryClass = Cactus.Inventory.Model.Inventory;


namespace Cactus.Inventory.Dal
{
    public class ReportDAL:IReportDAL
    {
        #region Get Cardex 

        public DataTable GetCardex(CardexSearch cardex)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.Cardex, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue
                      (StoreProcedureParametersNameCardex.InventoryID, cardex.InventoryID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                      (StoreProcedureParametersNameCardex.GoodsID, cardex.dtGoodsID ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                      (StoreProcedureParametersNameCardex.FromDate, cardex.FromDate);

                    sqlCommand.Parameters.AddWithValue
                      (StoreProcedureParametersNameCardex.ToDate, cardex.ToDate);

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return null;
                }
            }
        }

        #endregion

        #region Get Stock Inventory

        public DataTable GetStockInventory(InventoryClass inventory)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.GetStockInventory, sqlConnection);

                    SqlDataAdapter sqlDataAdapter = 
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue
                      (StoreProcedureParametersNameCardex.InventoryID, inventory.ID ?? (object)DBNull.Value);

                    DataTable dataTable = new DataTable();

                    sqlDataAdapter.Fill(dataTable);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return null;
                }
            }
        }

        #endregion
    }
}
