
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
using Cactus.Core.Model;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Core.Dal
{
    public class CoreDAL : DalBaseClass<User> ,ICoreDAL
    {
        #region Get Data In DataBase

        public User GetUserDetile(int UserID)
        { 
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    DataSet dtUser = new DataSet();

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.GetUserDetile, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                               (StorProcdureParameterNameUser.UserID, UserID);

                    #endregion

                    #region DataBase Connect 

                    sqlDataAdapter.Fill(dtUser);

                    return ConvertToUser(dtUser); 

                    #endregion
                }
            }
            catch (Exception ex)
            {                 
                Logger.Log(ex);

                return new User();
            }
        }

        #endregion

        #region Update Current User

        public ServerValidationEnum UpdateCurrentUser(User user)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region  Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand
                            (StoreProcedureNames.UpdateCurrentUser, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Parameters

                    sqlCommand.Parameters.AddWithValue
                                    (StorProcdureParameterNameUser.UserName, user.UserName ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcdureParameterNameUser.Password, user.Password ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcdureParameterNameUser.UserID, user.ID);

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcdureParameterNameUser.ValidationResutlt, SqlDbType.Int);

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

        #region Validtion User Login

        public UserValidationResult ISValidUser(User user)
        {
            UserValidationResult userValidationResult = new UserValidationResult();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                        new SqlCommand(StoreProcedureNames.IsValidUser, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    #endregion

                    #region Add Paraneters

                    sqlCommand.Parameters.AddWithValue
                        (StorProcdureParameterNameUser.UserName, user.UserName ?? (object)DBNull.Value);

                    sqlCommand.Parameters.AddWithValue
                        (StorProcdureParameterNameUser.Password, user.Password ?? (object)DBNull.Value);

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcdureParameterNameUser.ValidationResutlt, SqlDbType.Int);

                    returnParameter.Direction = ParameterDirection.Output;

                    var returnParameterID =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcdureParameterNameUser.UserID, SqlDbType.Int);

                    returnParameterID.Direction = ParameterDirection.Output;

                    #endregion

                    #region DataBase Connect

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    userValidationResult.ServerValidation = (ServerValidationEnum)returnParameter.Value;

                    userValidationResult.UserID = (int)returnParameterID.Value;

                    sqlConnection.Close();

                    return userValidationResult; 

                    #endregion
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                userValidationResult.ServerValidation = ServerValidationEnum.Error;

                userValidationResult.UserID = 0;

                return userValidationResult;
            }
        }

        #endregion

        #region Date Time Now

        public DateTime GetDateTimeNowOfServer()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
                {
                    #region Preparation

                    SqlCommand sqlCommand =
                                   new SqlCommand(StoreProcedureNames.GetDateTimeNow, sqlConnection);

                    SqlDataAdapter sqlDataAdapter =
                        new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType =
                        CommandType.StoredProcedure;

                    #endregion

                    #region Add Prameters

                    var returnParameter =
                        sqlCommand.Parameters.AddWithValue
                            (StorProcdureParameterNameUser.DateTimeNow, SqlDbType.SmallDateTime);

                    returnParameter.Value = DateTime.Now;

                    returnParameter.Direction = ParameterDirection.Output;

                    #endregion

                    #region DataBase Connect 

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    return Convert.ToDateTime(returnParameter.Value); 

                    #endregion
                }
            }
            catch (Exception ex)
            { 
                Logger.Log(ex);

                DateTime dateTime = new DateTime(2000, 1, 1);

                return dateTime;
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

        protected  User ConvertToUser(DataSet dataSet)
        {
            User user = new User();

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                Role role = new Role
                {
                    ID = Convert.ToInt32(row["RoleID"].ToString()),

                    Title = row["Title"].ToString()
                };

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

        protected  Role ConvertToRole(DataSet dataSet)
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
