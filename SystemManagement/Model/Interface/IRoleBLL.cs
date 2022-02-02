using Cactus.Common.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus_SubSystem_Model
{
  public  interface IRoleBLL
    {
        DataTable GetAllRole();

        Role GetRoleDetile(int roleId);

        ServerValidationEnum InsertRole(Role role);

        ServerValidationEnum UpdateRole(Role role);
    }
}
