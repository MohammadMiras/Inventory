using Cactus.Common.Logger;
using Cactus_SubSystem_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Cactus.SystemManagement.Dal
{
    public class ServerDAL :IServerDAL
    {
        #region Member

        private readonly string SelectDataBaseName = "SELECT name from sys.databases";

        #endregion

        public List<string> GetDataBaseName(string Connection)
        {
            try
            {
                List<string> dbNameList = new List<string>();
              
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(SelectDataBaseName, con))

                    using (IDataReader dr = cmd.ExecuteReader())

                        while (dr.Read())

                            dbNameList.Add(dr[0].ToString());
                    return dbNameList;
                }
            }
            catch (Exception ex)
            {
                Logger.Log(ex);

                return new List<string>();
            }
        }
    }
}
