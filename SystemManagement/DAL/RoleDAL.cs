
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cactus.Common;
using Cactus.Common.Logger;
using Cactus.Common.Model;
using Cactus.SystemManagement.Dal.StorProcedure;
using Cactus_SubSystem_Model;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.SystemManagement.Dal
{
    public class RoleDAL  : IRoleDAL
    {
        #region Get  Role  Detile

        public Role GetRoleDetile(int RoleID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    DataSet dsData = new DataSet();

                    SqlCommand sqlCommand =
                        new SqlCommand(StorProcedurName.GetRole, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add  Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcdureParameterNameRole.RoleID, RoleID);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcdureParameterNameRole.HasDetails, 1);

                    #endregion

                    #region DataBase Connect

                    sqlDataAdapter.Fill(dsData);

                    return ConvertToRole(dsData); 

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

        #region Get All  Role 

        public DataTable GetALLRols()
        {
            DataTable dtUser = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand(StorProcedurName.GetRole, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcdureParameterNameRole.RoleID, DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcdureParameterNameRole.HasDetails, 0);

                    #endregion

                    #region Database Connect

                    sqlDataAdapter.Fill(dtUser);

                    return dtUser; 

                    #endregion
                }
                catch (Exception ex)
                {
                       Logger.Log(ex);

                    return new DataTable();
                }
            }
        }

        #endregion

        #region Insert Role 

        public ServerValidationEnum InsertRole(Role role)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {

                    #region Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand(StorProcedurName.InsertRole, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParameterNameUser.RoleTitle, role.Title.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParameterNameUser.ObjectSystemList, role.ConvertListObjToDataTable());

                    sqlCommand.Parameters
                        [StorProcedureParameterNameUser.ObjectSystemList].SqlDbType = SqlDbType.Structured;

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcedureParameterNameUser.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    #endregion

                    #region DataBase Connect 

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    return (ServerValidationEnum)returnParameter.Value; 

                    #endregion
                }
                catch (Exception ex)
                {
                       Logger.Log(ex);

                    return Common.Model.ModelUtility.ServerValidationEnum.Error;
                }
            }
        }

        #endregion

        #region Update Role

        public ServerValidationEnum UpdateRole(Role role)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {

                    #region Preparation

                    SqlCommand sqlCommand = 
                        new SqlCommand(StorProcedurName.UpdateRole, sqlConnection);

                    SqlDataAdapter sqlDataAdapter = 
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = 
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParameterNameUser.RoleID, role.ID);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParameterNameUser.RoleTitle, role.Title.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParameterNameUser.ObjectSystemList, role.ConvertListObjToDataTable());

                    sqlCommand.Parameters
                        [StorProcedureParameterNameUser.ObjectSystemList].SqlDbType =
                            SqlDbType.Structured;

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcedureParameterNameUser.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;


                    #endregion

                    #region DataBase Connect

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    return (ServerValidationEnum)returnParameter.Value; 

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

         protected Role ConvertToRole(DataSet dataSet)
        {
            Role role = new Role();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                role.ID = Convert.ToInt32(row["RoleID"].ToString());

                role.Title = row["Title"].ToString();

                break;
            }

            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                int ObjID = Convert.ToInt32(row["objectSystemID"].ToString());

                role.AllSystemObj.Add(new ObjSystem() { ID = ObjID });
            }

            return role;
        }

        #endregion
    }
}
