using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cactus.SystemManagement.Dal;
using Cactus_SubSystem_Model;

namespace Cactus.SystemManagement.Bll
{
    public class ObjSystemBLL: IObjSystemBLL
    {
        private IObjSystemDAL _objSystemDAL;

        public ObjSystemBLL(IObjSystemDAL objSystemDAL)
        {
            _objSystemDAL = objSystemDAL;
        }

        public  DataTable GetAllObjSystem()
        {
            return 
               _objSystemDAL.GetAllObjSystem();
        }
    }
}
