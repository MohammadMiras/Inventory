using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Cactus.Common;
using Cactus.Common.Logger;
using Cactus.SystemManagement.Dal.StorProcedure;
using Cactus_SubSystem_Model;

namespace Cactus.SystemManagement.Dal
{
  public  class ObjDAL : IObjSystemDAL
    {
        public  DataTable GetAllObjSystem()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString._ConnectionString))
            {
                try
                {
                    DataTable dataTable = new DataTable();

                    SqlCommand sqlCommand = new SqlCommand(StorProcedurName.GetAllObjSystem, sqlConnection);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlDataAdapter.Fill(dataTable);

                    return dataTable;

                }
                catch (Exception ex)
                {
                    Logger.Log(ex);

                    return new DataTable();
                }
            }
        }

    }
}
