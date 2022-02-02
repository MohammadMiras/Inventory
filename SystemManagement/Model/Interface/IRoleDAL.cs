using Cactus.Common.Model;
using System.Data;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus_SubSystem_Model
{
  public  interface IRoleDAL
    {
        Role GetRoleDetile(int RoleID);

        DataTable GetALLRols();

        ServerValidationEnum InsertRole(Role role);

        ServerValidationEnum UpdateRole(Role role);

    }
}
