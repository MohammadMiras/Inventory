using Cactus.Common.Interface;
using Cactus.Inventory.BLL;
using Cactus.Common;
using Cactus.Inventory.Model;
using Cactus.Inventory.UI.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory;
namespace Cactus.Inventory.UI
{
    public partial class UC_Stock_Inventory : UserControl ,IUserControl,IFindForm
    {
        #region Member

        InventoryClass _inventory;

        InventoryClass _inventorySelect;

        IInventoryBLL _inventoryBLL;

        IGoodsBLL _goodsBLL; 

        FormModeEnum _formMode;

        #endregion

        #region Constructors

        public UC_Stock_Inventory()
        {
            _inventory = new InventoryClass();
            _inventoryBLL = DependencyInjector.Retrieve<InventoryBLL>();
            _goodsBLL = DependencyInjector.Retrieve<GoodsBLL>();

            InitializeComponent();
        }

        public UC_Stock_Inventory(InventoryClass inventory) : this()
        {
            _inventory = inventory;

            _formMode = FormModeEnum.New;
        }

        public UC_Stock_Inventory(ref InventoryClass inventory, FormModeEnum formMode) : this()
        {
            _inventorySelect = inventory;

            _inventory = _inventorySelect;

            _formMode = formMode;
        }

        #endregion

        #region GetUI Data

        #endregion

        #region  Fill Data  Controls

        private void FillDataControls()
        {
            lblCodeInventory.Text = _inventory.Code;
            lblTitleInventory.Text = _inventory.Title;
            grdGoodsStock.DataSource = _inventory.GoodsList;

            grdGoodsStock.Refetch();
        }

        #endregion

        #region Get Inventory

        private void GetInventory(InventoryClass inventory)
        {
            List<InventoryClass> inventories = new List<InventoryClass>();

            inventories = _inventoryBLL.GetInventory(inventory,StatusHasDitailEnum.Yes);

            if (inventories != null)
            {
                _inventory = inventories[0];

                if (_formMode == FormModeEnum.Select)
                {
                    _inventorySelect.ID = _inventory.ID;

                    _inventorySelect.Title = _inventory.Title;
                }
            }
        }

        #endregion

        #region Metodes

        #region SetForm

        public void SetForm()
        {
            this.FindForm().Text = Form_Res.FT_Storyinventory;

            this.FindForm().Icon = Form_Res.IconInventory;

            this.FindForm().MaximizeBox = true;
        }

        #endregion

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #endregion

        #region Validation

        #endregion

        #region Events

        private void UC_Stock_Inventory_Load(object sender, EventArgs e)
        {
            SetForm();

            GetInventory(_inventory);

            FillDataControls();
        }

        private void GrdGoodsStock_DoubleClick(object sender, EventArgs e)
        {
            if (_formMode!=FormModeEnum.Select)
                return;            
            
            if (grdGoodsStock.GetValue("ID") != null)
                {
                    Goods goods = new Goods();

                    goods.ID = Convert.ToInt32(grdGoodsStock.GetValue("ID").ToString());

                    List<Goods> ListGoods = new List<Goods>();

                    goods = _goodsBLL.GetGoods(goods, StatusHasDitailEnum.Yes)[0];

                    if (goods != null)
                    {
                        goods.RecordStatus = (int)RecordStatusEnum.Fix;

                        ListGoods.Add(goods);

                        _inventorySelect.GoodsList = ListGoods;
                    }

                    this.FindForm().DialogResult = DialogResult.Yes;
                }
        }

        #endregion
    }
}
