using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Common.Utility;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using Cactus.Inventory.UI.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.UI.CustomControls
{
    public partial class UC_Cardex_Report : UserControl, IUserControl
    {
        #region Member        

        private List<Goods> _goodsList;

        private List<Model.Inventory> _inventoryList;

        private CardexSearch _cardexSearch;

        private DataTable _dataTable;

        private IReportBLL _reportBLL;

        #endregion

        #region Constructor

        public UC_Cardex_Report()
        {
            _inventoryList = new List<Model.Inventory>();

            InitializeComponent();
        }

        #endregion

        #region Get UI Data

        public void GetUIData()
        {
            _cardexSearch = new CardexSearch();

            DataTable dataTable = new DataTable();

            _cardexSearch.dtGoodsID = _goodsList.ToDataTable().DefaultView.ToTable(false, "ID");

            if (cmbInventory.SelectedItem != null)

                _cardexSearch.InventoryID = Convert.ToInt32(cmbInventory.SelectedItem.Value);

            else

                _cardexSearch.InventoryID = null;

            string toDate = txtToDate.Text == "" ? DateTimeTools.MaxDate: txtToDate.Text;

            string fromDate = txtFromDate.Text == "" ? DateTimeTools.MinDate : txtFromDate.Text;

            _cardexSearch.FromDate = fromDate.ConvertStringToDateMiladi();

            _cardexSearch.ToDate = toDate.ConvertStringToDateMiladi();

        }

        #endregion

        #region FillDataControls

        private void FillDataControls()
        {
            grdCardex.DataSource = _dataTable;

            grdCardex.Refetch();
        }

        private void FillDataTxtCode()
        {
            if (_goodsList.Count != 0)
            {
                foreach (Goods goods in _goodsList)

                    txtGoodsName.Text = txtGoodsName.Text.Trim() + goods.Name + " / ";

                txtGoodsName.Text = txtGoodsName.Text.Remove(txtGoodsName.Text.Length - 2, 1);
            }
        }

        #endregion

        #region Get Cardex

        public void GetCardex()
        {
            _dataTable = _reportBLL.GetCardexReport(_cardexSearch);
        }

        #endregion

        #region Metods

        #region SettingUserControl

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region InitializeMember

        private void InitializeMember()
        {
            _dataTable = new DataTable();

            _inventoryList = new List<Model.Inventory>();

            _goodsList = new List<Goods>();

            _reportBLL = DependencyInjector.Retrieve<ReportBLL>();
        }


        #endregion

        #region Prepare Controls

        private void PrepareControls()
        {
            if (_inventoryList != null)

                foreach (Model.Inventory inventory in _inventoryList)

                    cmbInventory.Items.Add(inventory.Title, inventory.ID);
        }

        #endregion

        #region Get Inventory

        private void GetInventory()
        {
            IInventoryBLL inventoryBLL = DependencyInjector.Retrieve<InventoryBLL>();

            _inventoryList =
                inventoryBLL.GetInventory(new Model.Inventory(), StatusHasDitailEnum.No);
        }

        #endregion

        #region Cell Form Goods Selection

        private void CellGoodSelectionForm()
        {
            List<Goods> goodsList = new List<Goods>();

            UC_Goods_List ucGoods = new UC_Goods_List(goodsList: goodsList);

            var result = ShowForm.Show(ucGoods);

            if (result == DialogResult.Yes)
            {
                _goodsList = goodsList;

                FillDataTxtCode();
            }
        }

        #endregion

        #endregion

        #region Validation

        private bool Validation()
        {
            TimeSpan span = _cardexSearch.ToDate - _cardexSearch.FromDate;

            if 
                (
                    span.TotalDays < 0 ||

                    _cardexSearch.ToDate.Year >=9999   ||

                    _cardexSearch.FromDate.Year <= 1753
                )
            {
                ShowMessage.ShowErrorMessage(Transaction_Res.ErrorTime);

                return false;
            }

            return true;
        }

        #endregion

        #region Clear Controls

        private void ClearControls()
        {
            txtFromDate.Text =
                txtGoodsName.Text =
                txtToDate.Text = string.Empty;

            cmbInventory.SelectedItem = null;

            grdCardex.DataSource = new DataTable();

            grdCardex.Refetch();

            _cardexSearch = new CardexSearch();

            _inventoryList = new List<Model.Inventory>();

            _goodsList = new List<Goods>();
        }

        #endregion

        #region Events

        private void UC_Report_Load(object sender, EventArgs e)
        {
            SettingUserControl();

            GetInventory();

            PrepareControls();

            InitializeMember();
        }

        private void BtnSelectGoods_Click(object sender, EventArgs e)
        {
            txtGoodsName.Text = string.Empty;

            CellGoodSelectionForm();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            GetUIData();

            if (Validation())

                Report.Report.ShowReportCardex(_cardexSearch);

        }

        private void CmbInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetUIData();

            if (Validation())
            {
                GetCardex();

                FillDataControls();
            }
        }

        private void CmbInventory_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BtnResat_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        #endregion    
    }
}
