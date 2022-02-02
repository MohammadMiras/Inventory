using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Common.Model
{
    public class Role
    {
        #region Property

        public int ID { get; set; }

        public string Title { get; set; }

        public List<ObjSystem> AllSystemObj { get; set; }

        public int RecordStatus { get; set; }

        #endregion

        #region Constructor

        public Role()
        {
            AllSystemObj = new List<ObjSystem>();

            this.RecordStatus = (int)RecordStatusEnum.Fix;
        }

        #endregion

        #region Metods

        public DataTable ConvertListObjToDataTable()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.AddRange
                (new DataColumn[]
                    {
                        new DataColumn("ID", typeof(int)),
                        new  DataColumn("RecordStatus" ,typeof(int))
                    }
                );

            foreach (ObjSystem obj in this.AllSystemObj)

                dataTable.Rows.Add(obj.ID, obj.RecordStatus);

            return dataTable;
        } 

        #endregion
    }
}
