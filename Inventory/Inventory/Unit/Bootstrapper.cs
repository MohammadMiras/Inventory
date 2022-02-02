using Cactus.Common;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;

namespace Cactus.Inventory.UI
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IInventoryBLL, InventoryBLL>();
            DependencyInjector.Register<IGoodsBLL, GoodsBLL>();
            DependencyInjector.Register<IReportBLL, ReportBLL>();
            DependencyInjector.Register<ITransactionBLL, TransactionBLL>();
            DependencyInjector.Register<ICategoryBLL, CategoryBLL>();
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
