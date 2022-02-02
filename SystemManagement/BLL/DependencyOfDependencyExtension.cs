using Cactus.SystemManagement.Dal;
using Cactus_SubSystem_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;

namespace Cactus.SystemManagement.Bll
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IServerDAL, ServerDAL>();
            Container.RegisterType<IObjSystemDAL, ObjDAL>();
            Container.RegisterType<IUserDAL, UserDAL>();
            Container.RegisterType<IRoleDAL, RoleDAL>();
        }
    }
}
