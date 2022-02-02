
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cactus.Common;
using Cactus.Common.BaseClass;
using Cactus.Common.Logger;
using Cactus.Common.Model;
using Cactus.SystemManagement.Dal.StorProcedure;
using Cactus_SubSystem_Model;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.SystemManagement.Dal
{
    public class UserDAL :DalBaseClass<User>,IUserDAL
    {
        #region Get Data

        public User GetUserDetile(int UserID)
        {
            DataSet dtUser = new DataSet();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand(StorProcedurName.GetUserDetile, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add parameters

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParameterNameUser.UserID, UserID);

                    #endregion

                    #region DataBase Connect

                    sqlDataAdapter.Fill(dtUser);

                    return ConvertToUser(dtUser); 

                    #endregion
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    throw;
                }
            }
        }

        public List<User> SearchUserFull(User user)
        {
            DataSet dSUser = new DataSet();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                       new SqlCommand(StorProcedurName.SerachUserFull, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParameterNameUser.UserName, user.UserName ?? (object)DBNull.Value);

                    #endregion

                    #region Database Connect

                    sqlDataAdapter.Fill(dSUser);

                    return ConvertToList(dSUser); 

                    #endregion
                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return new List<User>();
                }
            }
        }

        #endregion

        #region Insert User  

        public ServerValidationEnum InsertUser(User user)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                       new SqlCommand(StorProcedurName.InsertUser, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                                (StorProcedureParameterNameUser.UserName, user.UserName.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                    (StorProcedureParameterNameUser.Password, user.Password.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                    (StorProcedureParameterNameUser.RoleList, user.ConvertListRoleToDataTable());

                    sqlCommand.Parameters
                        [StorProcedureParameterNameUser.RoleList].SqlDbType =
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
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return ServerValidationEnum.Error;
            }
        }

        #endregion

        #region Update User  

        public ServerValidationEnum UpdateUser(User user)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                                  new SqlCommand(StorProcedurName.UpdateUser, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters 

                    sqlCommand.Parameters.AddWithValue
                                    (StorProcedureParameterNameUser.UserID, user.ID);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParameterNameUser.UserName, user.UserName.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParameterNameUser.Password, user.Password.Trim() ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParameterNameUser.RoleList, user.ConvertListRoleToDataTable());

                    sqlCommand.Parameters[StorProcedureParameterNameUser.RoleList].SqlDbType =
                       SqlDbType.Structured;

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcedureParameterNameUser.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = 
                        ParameterDirection.Output;

                    #endregion

                    #region DataBase Connect

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    return (ServerValidationEnum)returnParameter.Value; 

                    #endregion
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return ServerValidationEnum.Error;
            }
        }

        #region Update Current User

        public ServerValidationEnum UpdateCurrentUser(User user)
        { 
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                         new SqlCommand(StorProcedurName.UpdateCurrentUser, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                                    (StorProcedureParameterNameUser.UserName, user.UserName ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParameterNameUser.Password, user.Password ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                         (StorProcedureParameterNameUser.UserID, user.ID);

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
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return ServerValidationEnum.Error;
            }
        }

        #endregion

        #endregion

        #region Delete User

        public bool DeleteUser(int userID)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    int result;

                    SqlCommand sqlCommand =
                        new SqlCommand(StorProcedurName.DeleteUser, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcedureParameterNameUser.UserID, userID);

                    #endregion

                    #region DataBase Connect

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

        #region Metods

        protected override List<User> ConvertToList(DataSet dataSet)
        {
            List<User> users = new List<User>();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                User user = new User();

                user.ID = Convert.ToInt32(row["UserID"].ToString());

                user.UserName = row["UserName"].ToString();

                users.Add(user);
            }

            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                Role role = new Role();

                int UserId = Convert.ToInt32(row["UserID"].ToString());

                role.ID = Convert.ToInt32(row["RoleID"].ToString());

                role.Title = row["Title"].ToString();

                foreach (User user in users)

                    if (user.ID == UserId)

                        user.RoleList.Add(role);
            }

            return users;
        }        

         protected User ConvertToUser(DataSet dataSet)
        {
            User user = new User();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Role role = new Role();

                role.ID = Convert.ToInt32(row["RoleID"].ToString());

                role.Title = row["Title"].ToString();

                user.RoleList.Add(role);
            }

            foreach (DataRow row in dataSet.Tables[1].Rows)
            {
                int RoleID = Convert.ToInt32(row["RoleID"].ToString());

                string RoleTitle = row["Title"].ToString();

                int AccessRole = Convert.ToInt32(row["objectID"].ToString());

                if (!user.RoleList.Exists(x => x.ID == RoleID))
                {
                    user.RoleList.Add(new Role() { ID = RoleID, Title = RoleTitle });

                    user.RoleList.Last().AllSystemObj.Add(new ObjSystem() { ID = AccessRole });
                }
                else
                {
                    List<Role> roles = new List<Role>();

                    user.RoleList.Where(x => x.ID == RoleID).ToList()[0].AllSystemObj.Add(new ObjSystem() { ID = AccessRole });
                }
            }

            foreach (DataRow row in dataSet.Tables[2].Rows)
            {
                user.UserName = row["UserName"].ToString();

                user.Password = row["Password"].ToString();
            }

            return user;
        }

        #endregion
    }
}
