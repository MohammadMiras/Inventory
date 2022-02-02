using Cactus.Inventory.Model;
using Cactus.Inventory.Dal;
using Unity;
using Unity.Extension;

namespace Cactus.Inventory.BLL
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {            
            Container.RegisterType<ITranactionDAL, TransactionDAL>();
            Container.RegisterType<IInvntoryDAL, InvevtoryDAL>();
            Container.RegisterType<ICategoryDAL, CategoryDAL>();
            Container.RegisterType<IReportDAL, ReportDAL>();
            Container.RegisterType<IGoodsDAL, GoodsDAL>();                       
        }
    }
}
