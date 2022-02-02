
using System.Collections.Generic;
using System.Data;

namespace Cactus.Common.Model
{
    public class User
    {
        #region Property

        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public List<Role> RoleList { get; set; }           

        #endregion

        #region Constructors

        public User()
        {
            RoleList = new List<Role>();           
        }

        #endregion

        #region Metods

        public DataTable ConvertListRoleToDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.AddRange
                (new DataColumn[]
                    {
                        new DataColumn("ID", typeof(int)),
                        new  DataColumn("RecordStatus" ,typeof(int))
                    }
                );

            foreach (Role role in this.RoleList)

                dataTable.Rows.Add(role.ID, role.RecordStatus);
     
            return dataTable;

        }

        #endregion
    }
}
