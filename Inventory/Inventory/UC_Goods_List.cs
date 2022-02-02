using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.UI
{
    public partial class UC_Goods_List : UserControl, IUserControl, IFindForm
    {
        #region Member 

        private Goods _goods;

        private FormModeEnum _formMode;

        private Goods _goodsSelect;

        private List<Goods> _goodsList;

        private IGoodsBLL _goodsBLL;

        private DataTable _dtGoods;

        private List<Goods> _selectedGoodsList;

        #endregion

        #region Constructors

        public UC_Goods_List()
        {
            InitializeComponent();

            _goods = new Goods();

            _goodsList = new List<Goods>();

            _dtGoods = new DataTable();

            _goodsBLL = DependencyInjector.Retrieve<GoodsBLL>();

            InitializeTables();
        }

        public UC_Goods_List(Goods goods, FormModeEnum formMode) : this()
        {
            _goodsSelect = new Goods();

            _goodsSelect = goods;

            _formMode = FormModeEnum.Select;
        }

        public UC_Goods_List(List<Goods> goodsList) : this()
        {
            _selectedGoodsList = new List<Goods>();

            _formMode = FormModeEnum.SelectMultiple;

            _selectedGoodsList = goodsList;
        }

        #endregion

        #region Get UI Data 

        private void GetUIData()
        {
            _goods = new Goods
            {
                Code =
                    (
                        string.IsNullOrEmpty
                            (txtGoodsCode.Text.Trim()) ? null : txtGoodsCode.Text.Trim()
                    ),

                Name =
                    (
                        string.IsNullOrEmpty
                            (txtGoodsName.Text.Trim()) ? null : txtGoodsName.Text.Trim()
                    )
            };
        }

        #endregion

        #region Fill Data controls

        private void FillDatacontrols()
        {
            _goodsList = GetGoods(_goods);

            _dtGoods.Clear();

            if (_goodsList != null)
            {
                foreach (Goods goods in _goodsList)
                {
                    string categoryGoods = "";

                    foreach (Category category in goods.CategoryGroup)
                        categoryGoods += category.Name + " / ";

                    if (categoryGoods.Length >= 2)
                        categoryGoods = categoryGoods.Remove(categoryGoods.Length - 2, 1);

                    _dtGoods.Rows.Add
                        (
                            goods.ID,
                            goods.Code,
                            goods.Weight,
                            categoryGoods,
                            goods.Name,
                            goods.GoodsUnit
                        );

                }

                grdGoods.DataSource = _dtGoods;

                grdGoods.Refetch();

                _goods = new Goods();
            }
        }

        #endregion

        #region Get Goods 

        private List<Goods> GetGoods(Goods goods)
        {
            return
               _goodsBLL.GetGoods(goods, StatusHasDitailEnum.Yes);
        }

        #endregion

        #region Delete Goods

        private ServerValidationEnum DeleteGoods(int GoodsID)
        {
            return _goodsBLL.DeleteGoods(GoodsID);
        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            this.FindForm().Text = Resources.Form_Res.FT_Goods;
            this.FindForm().Icon = Resources.Form_Res.IconGoods;
            this.FindForm().MaximizeBox = true;
            this.FindForm().WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region Prepare Controls

        private void PrepareGridGoods()
        {
            btnConfirmation.Visible = false;

            grdGoods.RootTable.Columns["Selector"].Visible = false;

            grdGoods.RootTable.SortKeys.Clear();

            grdGoods.RootTable.SortKeys.Add
                (
                    new Janus.Windows.GridEX.GridEXSortKey(grdGoods.RootTable.Columns["ID"])
                );

            List<GoodsUnit> units = new List<GoodsUnit>();

            units = GetUnits();

            if (units != null)
                foreach (GoodsUnit unit in units)
                    grdGoods.RootTable.Columns["GoodsUnit"].ValueList.Add((int)unit.ID, unit.Title);

            if (_formMode == FormModeEnum.SelectMultiple || _formMode == FormModeEnum.Select)
            {
                btnNew.Enabled =
                   btnRemove.Enabled =
                   btnUpdate.Enabled =
                   cmsGrid.Enabled = false;

                if (_formMode == FormModeEnum.SelectMultiple)
                    btnConfirmation.Visible =
                        grdGoods.RootTable.Columns["Selector"].Visible = true;

            }

        }

        #endregion

        #region Initialize Tables

        private void InitializeTables()
        {
            _dtGoods.Columns.AddRange
             (
                 new DataColumn[]
                 {
                        new DataColumn("GoodsID",typeof(int)),
                        new DataColumn("Code",typeof(string)),
                        new DataColumn("GoodsWeight",typeof(string)),
                        new DataColumn("Category",typeof(string)),
                        new DataColumn("Name",typeof(string)),
                        new DataColumn("GoodsUnit",typeof(int)),
                        new DataColumn("WeightUnitID",typeof(int)),
                 }
             );
        }

        #endregion

        #region Get weight Unit 


        #endregion

        #region Get Unit Goods

        private List<GoodsUnit> GetUnits()
        {
            return
                _goodsBLL.GetUnits();
        }


        #endregion

        #region cell Form New Goods

        private void CellFormNewGoods()
        {
            UserControl UCNewGoods = new UC_Insert_Update_Goods();

            ShowForm.Show(UCNewGoods);

            FillDatacontrols();
        }

        #endregion

        #region Cell Form  Update Goods

        private void CellFormUpdateGoods()
        {
            if (grdGoods.GetValue("ID") != null)
            {
                DataTable dataTable = new DataTable();

                dataTable = (DataTable)grdGoods.DataSource;

                _goods = new Goods
                {
                    ID = int.Parse(grdGoods.GetValue("ID").ToString())
                };

                UserControl UCInsertGoods = new UC_Insert_Update_Goods(_goods, FormModeEnum.Edit);

                ShowForm.Show(UCInsertGoods);

                _goods = new Goods();

                FillDatacontrols();
            }
        }

        #endregion

        #region Set Controls

        private void SetControls()
        {
            grdGoods.RootTable.Columns["Selector"].Visible = true;

            btnNew.Enabled =
                btnUpdate.Enabled =
                btnRemove.Enabled = false;

            btnConfirmation.Visible = true;
        }

        #endregion

        #region Initialize Member

        private void InitializeMember()
        {
            this._dtGoods.Clear();

            this._goodsList.Clear();

            this._goods = new Goods();

            this._goodsSelect = new Goods();

            if (_selectedGoodsList == null)
                return;

            _selectedGoodsList.Clear();

        }

        #endregion

        #endregion

        #region Validation

        private bool Validation(ServerValidationEnum validationResult)
        {
            switch (validationResult)
            {
                case ServerValidationEnum.NoProblem:
                    {
                        ShowMessage.ShowSuccessMessage(Resources.Goods_Res.DeleteGoods);

                        return true;
                    }
                case ServerValidationEnum.Error:
                    {
                        ShowMessage.ShowErrorMessage(Resources.Common_Res.OperationFailed);

                        return false;
                    }

                case ServerValidationEnum.ThereIsTransaction:
                    {
                        ShowMessage.ShowErrorMessage(Resources.Goods_Res.NoDelete);

                        return false;
                    }
                default:
                    return false;
            }
        }

        #endregion

        #region  Clear Controls 

        private void ClearControls()
        {
            InitializeMember();

            txtGoodsCode.Text =
                txtGoodsName.Text = string.Empty;

            _dtGoods.Clear();

            grdGoods.RemoveFilters();

            grdGoods.Refetch();

        }



        #endregion

        #region Events

        #region Load User Controls Goods

        private void UC_Goods_List_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            PrepareGridGoods();

            FillDatacontrols();
        }

        #endregion

        #region TextBox

        private void PreventEnteringNumberInTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')

                if
                    (
                      !char.IsDigit(e.KeyChar) ||
                      char.IsControl(e.KeyChar) ||
                      char.IsPunctuation(e.KeyChar)
                    )
                    e.Handled = true;
        }

        #endregion

        #region Button

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CellFormNewGoods();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CellFormUpdateGoods();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int GoodsID = grdGoods.GetValue("ID") == null ? 0 : Convert.ToInt32(grdGoods.GetValue("ID"));

            if (GoodsID != 0)
            {
                var result =
                    ShowMessage.ShowQuestionMessage(Resources.Goods_Res.AreYouDeleteGoods);

                if (result == DialogResult.Yes)
                {
                    if (Validation(DeleteGoods(GoodsID)))
                        _goods = new Goods();

                    FillDatacontrols();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetUIData();

            FillDatacontrols();
        }

        private void BtnResat_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnConfirmation_Click(object sender, EventArgs e)
        {
            this.FindForm().DialogResult = DialogResult.Yes;
        }

        #endregion

        #region Grid

        private void GrdGoods_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            if (_formMode == FormModeEnum.Select)
            {
                Goods goods = new Goods();

                goods.ID = Convert.ToInt32(grdGoods.GetValue("ID").ToString());

                List<Goods> goodsList = new List<Goods>();

                goodsList = GetGoods(goods);

                if (goodsList != null)
                {
                    goods = goodsList[0];

                    _goodsSelect.ID = goods.ID;
                    _goodsSelect.Code = goods.Code;
                    _goodsSelect.Name = goods.Name;
                    _goodsSelect.GoodsUnit = goods.GoodsUnit;
                }

                _goodsSelect.RecordStatus = (int)RecordStatusEnum.Insert;

                this.FindForm().DialogResult = DialogResult.Yes;
            }

        }

        private void GrdGoods_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (_formMode == FormModeEnum.SelectMultiple)
            {
                Goods goods = new Goods();

                goods.ID = int.Parse(grdGoods.GetValue("ID").ToString());
                goods.Code = grdGoods.GetValue("Code").ToString();
                goods.Name = grdGoods.GetValue("Name").ToString();

                foreach (Goods item in _selectedGoodsList)
                    if (item.ID == goods.ID)
                    {
                        _selectedGoodsList.Remove(item);

                        return;
                    }

                _selectedGoodsList.Add(goods);

            }
        }

        #endregion

        #endregion

    }
}
