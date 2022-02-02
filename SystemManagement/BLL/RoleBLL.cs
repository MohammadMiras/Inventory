using Cactus.Common.Model;
using Cactus.SystemManagement.Dal;
using Cactus_SubSystem_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.SystemManagement.Bll
{
    public class RoleBLL :IRoleBLL
    {
        private IRoleDAL _roleDAL;

        public RoleBLL(IRoleDAL roleDAL)
        {
            _roleDAL = roleDAL;
        }

        #region Get 

        public DataTable GetAllRole()
        {
            return _roleDAL.GetALLRols();
        }

        public Role GetRoleDetile(int roleId)
        {
            return _roleDAL.GetRoleDetile(roleId);
        }

        #endregion

        #region Insert

        public ServerValidationEnum InsertRole(Role role)
        {
            return _roleDAL.InsertRole(role);
        }

        #endregion

        #region Upadte

        public ServerValidationEnum UpdateRole(Role role)
        {
            return _roleDAL.UpdateRole(role);
        }

        #endregion
    }
}
