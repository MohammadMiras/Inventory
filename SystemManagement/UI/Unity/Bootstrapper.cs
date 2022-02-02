using Cactus.Common;
using Cactus.SystemManagement.Bll;
using Cactus_SubSystem_Model;

namespace Cactus.SystemManagement.UI
{
   public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IUserBLL, UserBLL>();
            DependencyInjector.Register<IRoleBLL, RoleBLL>();
            DependencyInjector.Register<IObjSystemBLL, ObjSystemBLL>();
            DependencyInjector.Register<IServerBLL, ServerBLL>();
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
