using System;
using System.IO;
using Cactus.Common;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using Cactus.Inventory.UI.Resources;
using Stimulsoft.Report.Dictionary;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory;
namespace Cactus.Inventory.UI.Report
{
    public static class Report
    {
        public static void ShowReportTransaction(int TransactionID)
        {
            try
            {
                Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();

                string filePath = Path.Combine
                      (Directory.GetParent
                        (System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Inventory\\Inventory\\Report\\"+ Transaction_Res.PrintTransactionFileName);

                /*Path.Combine(Environment.CurrentDirectory, @"Report\", Transaction_Res.PrintTransactionFileName);*/

                report.Load(filePath);
          
                ((StiSqlDatabase)report.Dictionary.Databases[DetailsReports.DatabaseName]).ConnectionString = ConnectionString._ConnectionString;

                report.Compile();

                report[DetailsReports.PN_TransactionID] = TransactionID;

                report.Render();

                report.Show();
            }
            catch (Exception)
            {
                ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);
            }
        }

        public static void ShowReportCardex(CardexSearch cardex)
        {
            try
            {
                Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();

                string filePath = Path.Combine(Environment.CurrentDirectory, @"Report\", Transaction_Res.PrintCardexFileName);

                report.Load(filePath);

                ((StiSqlDatabase)report.Dictionary.Databases[DetailsReports.DatabaseName]).ConnectionString = ConnectionString._ConnectionString;

                report.Compile();

                report["@GoodsID"] = cardex.dtGoodsID;

                report[DetailsReports.PN_InventoryID] = cardex.InventoryID;

                report[DetailsReports.PN_FromDate] = cardex.FromDate;

                report[DetailsReports.PN_ToDate] = cardex.ToDate;

                report.Render();

                report.Show();
            }
            catch (Exception )
            {
                ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);
            }
        }

        public static void ShowReportStockInventory(int? InventoryID)
        {
            InventoryClass inventory = new InventoryClass();

            try
            {
                Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();

                string filePath = Path.Combine(Environment.CurrentDirectory, @"Report\", Transaction_Res.PrintStockInventoryFileName);

                report.Load(filePath);

                ((StiSqlDatabase)report.Dictionary.Databases[DetailsReports.DatabaseName]).ConnectionString = ConnectionString._ConnectionString;

                report.Compile();

                report[DetailsReports.PN_InventoryID] = InventoryID;

                report.Render();

                report.Show();
            }
            catch (Exception )
            {
               ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);
            }
        }

        private static InventoryClass GetInventory(int InventoryID)
        {
            InventoryClass inventory = new InventoryClass();

            IInventoryBLL inventoryBLL = DependencyInjector.Retrieve<InventoryBLL>();

            inventory.ID = InventoryID;

            return inventoryBLL.GetInventory(inventory,StatusHasDitailEnum.No)[0];
        }
    }
}
