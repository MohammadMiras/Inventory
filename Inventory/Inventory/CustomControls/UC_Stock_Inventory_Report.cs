using Cactus.Common.Interface;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory;
using ReportClass = Cactus.Inventory.UI.Report.Report;
using Cactus.Common;

namespace Cactus.Inventory.UI.CustomControls
{
    public partial class UC_Stock_Inventory_Report : UserControl ,IUserControl
    {
        #region Member 

        private IReportBLL _reportBLL;
        private IInventoryBLL _InventoryBLL;
        private InventoryClass _inventory;
        private DataTable _dataTable;
        private List<InventoryClass> _inventoryList;

        #endregion

        #region Constructor

        public UC_Stock_Inventory_Report()
        {
            _reportBLL = DependencyInjector.Retrieve<ReportBLL>();

            _InventoryBLL = DependencyInjector.Retrieve<InventoryBLL>();

            InitializeComponent();
        }

        #endregion

        #region Get Stock Inventory

        private void GetStockInventory()
        {
            _dataTable = _reportBLL.GetStockInventory(_inventory);
        }

        #endregion

        #region Get Data UI

        private void GetDataUI()
        {
            _inventory = new InventoryClass();

            if (cmbInventory.SelectedItem != null)

                _inventory.ID = Convert.ToInt32(cmbInventory.SelectedItem.Value);
        }

        #endregion

        #region Fill  Data Controls 

        private void FillDataControls()
        {
            grdCardex.DataSource = _dataTable;

            grdCardex.Refetch();
        }

        #endregion

        #region Metods

        #region Setting  UserControl

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region Get  Inventory 

        private void GetInventory()
        {  
            _inventoryList =
                _InventoryBLL.GetInventory(new InventoryClass(), StatusHasDitailEnum.No);
        }

        #endregion

        #region Prepare Controls

        private void PrepareControls()
        {
            if (_inventoryList != null)

                foreach (InventoryClass inventory in _inventoryList)

                    cmbInventory.Items.Add(inventory.Title, inventory.ID);
        }

        #endregion

        #endregion

        #region Validation

        #endregion

        #region Clear Controls

        private void ClearControls()
        {
            _dataTable = new DataTable();

            cmbInventory.SelectedItem = null;

            _inventory = new InventoryClass();

            FillDataControls();
        }

        #endregion

        #region Event

        private void UC_Stock_Inventory_Report_Load(object sender, EventArgs e)
        {
            SettingUserControl();

            GetInventory();

            PrepareControls();         
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetDataUI();

            GetStockInventory();

            FillDataControls();
        }

        private void BtnResat_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            GetDataUI();

            ReportClass.ShowReportStockInventory(_inventory.ID);
        }

        private void CmbInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion
    }
}
