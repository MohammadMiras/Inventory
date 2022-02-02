using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Cactus.Common;
using Cactus.Common.BaseClass;
using Cactus.Common.Logger;
using Cactus.Common.Utility;
using Cactus.Inventory.Dal.StorProcedure;
using Cactus.Inventory.Model;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.Dal
{
    public class GoodsDAL : DalBaseClass<Goods> ,IGoodsDAL
    {
        #region Get Data

        #region Get Goods

        public List<Goods> GetGoods(Goods goods, StatusHasDitailEnum statusHasDitail)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    DataSet dsGoods = new DataSet();

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.GetGoods, con);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.GoodsID, goods.ID == 0 ? (object)DBNull.Value : goods.ID);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.Code, goods.Code ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.GoodsName, goods.Name ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.HasDetails, statusHasDitail);

                    #endregion

                    #region DataBase Connect 

                    sqlDataAdapter.Fill(dsGoods);

                    return
                        ConvertToList(dsGoods);

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

        #region  Get Unit

        public List<GoodsUnit> GetUnits()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.GetUnit, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    DataTable dataTable = new DataTable();

                    #endregion

                    #region Database Connect 

                    sqlDataAdapter.Fill(dataTable);

                    return dataTable.ConvertDataTable<GoodsUnit>();

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

        #endregion

        #region Insert Goods

        public ServerValidationEnum InsertGoods(Goods goods)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    ServerValidationEnum validationResult =
                                   ServerValidationEnum.NoProblem;

                    goods.FillDataTable();

                    SqlCommand sqlCommand = 
                        new SqlCommand(StoreProcedureNames.InsertGoods, sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.GoodsCode, goods.Code.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.GoodsName, goods.Name.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.Weight, goods.Weight);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.GoodsUnitID, goods.GoodsUnit);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.CategoryTable, goods.dsGoodsCategory);

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcedureParametersNameGoods.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    sqlCommand.Parameters
                        [StorProcedureParametersNameGoods.CategoryTable].SqlDbType =
                            SqlDbType.Structured;

                    #endregion

                    #region DataBase Connect

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

        #region Update Goods

        public ServerValidationEnum UpdateGoods(Goods goods)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    ServerValidationEnum validationResult =
                        ServerValidationEnum.NoProblem;

                    goods.FillDataTable();

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.UpdateGoods, sqlConnection);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersNameGoods.ID, goods.ID == 0 ? (object)DBNull.Value : goods.ID);

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParametersNameGoods.Code, goods.Code.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.GoodsName, goods.Name.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.Weight, goods.Weight);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.GoodsUnitID, goods.GoodsUnit);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.CategoryTable, goods.dsGoodsCategory);

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                        (StorProcedureParametersNameGoods.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    sqlCommand.Parameters
                        [StorProcedureParametersNameGoods.CategoryTable].SqlDbType =
                            SqlDbType.Structured;

                    #endregion

                    #region  DataBase Connect 

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

        #region Delete Goods

        public ServerValidationEnum DeleteGoods(int GoodsID)
        {
            int result;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    ServerValidationEnum validationResult =
                        ServerValidationEnum.NoProblem;

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.DeleteGoods, sqlConnection);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                           (StorProcedureParametersNameGoods.GoodsID, GoodsID);

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                           (StorProcedureParametersNameGoods.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    #endregion

                    #region DataBase Connncet

                    sqlConnection.Open();

                    result = sqlCommand.ExecuteNonQuery();

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

        #region Metods 
        override protected List<Goods> ConvertToList(DataSet dataSet)
        {
            try
            {
                List<Goods> goodsList = new List<Goods>();

                goodsList =
                    dataSet.Tables[0].AsEnumerable()
                                .Select(DataRow => new Goods
                                {
                                    ID = DataRow.Field<int>("GoodsID"),
                                    Name = DataRow.Field<string>("Name"),
                                    Code = DataRow.Field<string>("Code"),
                                    Weight = DataRow.Field<float>("Weight"),
                                    GoodsUnit = DataRow.Field<int>("GoodsUnitID")
                                }).ToList();

                if (dataSet.Tables.Count == 1)
                    return goodsList;

                foreach (DataRow row in dataSet.Tables[1].Rows)
                {
                    Category category = new Category
                    {
                        ID = int.Parse(row["CategoryID"].ToString()),
                        Name = row["Name"].ToString()
                    };

                    foreach (Goods goods in goodsList)
                        if (goods.ID == int.Parse(row["GoodsID"].ToString()))
                            goods.CategoryGroup.Add(category);
                }

                return goodsList;
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


