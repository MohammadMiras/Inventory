using Cactus.Common;
using Cactus.Core.Bll;
using Cactus.Core.Model;
namespace Cactus.Core.UI
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<ILoginBLL, LoginBLL>();       
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
