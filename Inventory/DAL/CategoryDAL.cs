using Cactus.Common;
using Cactus.Common.Logger;
using Cactus.Inventory.Dal.StorProcedure;
using Cactus.Inventory.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.Dal
{
    public class CategoryDAL :ICategoryDAL
    {
        #region Get Category

        public DataTable GetCategory(Category category)
        {  
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    DataTable dtcategory = new DataTable();

                    SqlCommand sqlCommand =
                             new SqlCommand(StoreProcedureNames.Getcategory, con);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersNameGoods.CategoryID, category.ID == 0 ? (object)DBNull.Value : category.ID);

                    #endregion

                    #region Connection DataBase

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    sqlDataAdapter.Fill(dtcategory);

                    return dtcategory; 

                    #endregion
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return null;
            }
        }

        #endregion

        #region Insert Category

        public bool InsertCategory(Category category)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region  Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.InsertCategory, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameter

                    sqlCommand.Parameters.AddWithValue
                       (StorProcedureParametersNameGoods.CategoryTitle, category.Name);

                    #endregion

                    #region Connection DataBase

                    sqlConnection.Open();

                    int Result = sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    return
                       Convert.ToBoolean(Result); 

                    #endregion
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return false;
            }
        }

        #endregion

        #region Update Category 

        public bool UpdateCategory(Category category)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    int result;

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.UpdateCategory, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.CategoryID, category.ID);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.CategoryTitle, category.Name ?? (object)DBNull.Value);

                    #endregion

                    #region Connection DataBase

                    sqlConnection.Open();

                    result = sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    return Convert.ToBoolean(result); 

                    #endregion
                }
            }

            catch (Exception ex)
            {
                Logger.Log(ex);

                return false;
            }
        }

        #endregion

        #region Delete Category

        public ServerValidationEnum DeleteCategory(int CategoryID)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    ServerValidationEnum validationResult = ServerValidationEnum.NoProblem;

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.DeleteCategory, sqlConnection);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.CategoryID, CategoryID);

                    var returnParameter =
                       sqlCommand.Parameters.AddWithValue
                           (StorProcedureParametersNameGoods.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = 
                        ParameterDirection.Output;

                    #endregion

                    #region Connection DataBase

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    validationResult = (ServerValidationEnum)returnParameter.Value;

                    sqlConnection.Close();

                    return validationResult;

                    #endregion
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return ServerValidationEnum.Error;
            }
        }

        #endregion
    }
}