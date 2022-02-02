using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Cactus.Common.Interface;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using Cactus.Inventory.UI.Resources;
using Janus.Windows.GridEX;
using static Cactus.Common.Model.ModelUtility;
using Cactus.Common;
using Cactus.Common.Model;
using Cactus.Common.Utility;
using InventoryClass = Cactus.Inventory.Model.Inventory;


namespace Cactus.Inventory.UI
{
    public partial class UC_Transaction_Insert_Update : UserControl, IUserControl, IFindForm
    {
        #region Member

        private readonly Random _random = new Random();

        private IInventoryBLL _inventoryBLL;

        private FormModeEnum _formMode;

        private ITransactionBLL _transactionBLL;

        private ContactViewModel _customer;

        private IGoodsBLL _goodsBll;

        private List<InventoryClass> _inventoryList;

        private DataTable _tbTransactionDetile;

        private Transaction _transaction;

        private string _transactionCode;

        #endregion

        #region Constructors

        public UC_Transaction_Insert_Update()
        {
            _customer = new ContactViewModel();
            _inventoryBLL = DependencyInjector.Retrieve<InventoryBLL>();
            _goodsBll = DependencyInjector.Retrieve<GoodsBLL>();
            _transactionBLL = DependencyInjector.Retrieve<TransactionBLL>();
            _tbTransactionDetile = new DataTable();
            _transaction = new Transaction();

            InitializeComponent();

            InitializeTables();
        }

        public UC_Transaction_Insert_Update(Transaction transaction, FormModeEnum formMode) : this()
        {
            _transaction = transaction;
            _transactionCode = transaction.Number;
            _formMode = formMode;
        }

        #endregion

        #region Get UI Data 

        private void GetUIData()
        {
            _transaction.CustomerID = _customer.ID;
            _transaction.InventoryID = (int)cmbInventory.SelectedItem.Value;
            _transaction.TransactionType = (int)cmbTransactionType.SelectedItem.Value;
            _transaction.Date = txtData.Text.ConvertStringToDateMiladi();
            _transaction.Number = txtNumber.Text.Trim();
        }

        #endregion

        #region Fill Data Controls

        private void FillDataContorls(Transaction transaction)
        {
            txtNumber.Text = transaction.Number;

            txtCustomer.Text = _customer.FirstName + " " + _customer.LastName;

            cmbInventory.SelectedValue = transaction.InventoryID;

            txtData.Text = transaction.Date.MiladiToShamsi();

            cmbTransactionType.SelectedValue = transaction.TransactionType;

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            grdTransactionDetail.DataSource = _tbTransactionDetile;

            grdTransactionDetail.Refetch();
        }

        #endregion

        #region Get Transaction

        private void GetTransaction(Transaction transaction)
        {
            _transaction = _transactionBLL.GetTransaction(transaction);

            _tbTransactionDetile = _transaction.dtTransctionDetails;

            _customer.Code = _transaction.CustomerCode;

            _customer.ID = _transaction.CustomerID.Value;

            GetCustomer();

            _transaction.dtTransctionDetails = null;

            _transactionCode = _transaction.Number;
        }

        #endregion

        #region  Insert  Transaction

        private ServerValidationEnum InsertTransaction(Transaction transaction)
        {
            return
                _transactionBLL.InsertTransaction(transaction);
        }

        #endregion

        #region  Update Transaction 

        private ServerValidationEnum UpdateTransaction(Transaction transaction)
        {
            return
                _transactionBLL.UpdateTransaction(transaction);
        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            this.FindForm().MaximizeBox = true;

            if (_formMode == FormModeEnum.New)
            {
                this.FindForm().Text = Form_Res.FT_AddTransaction;
                this.FindForm().Icon = Form_Res.IconNewTransaction;
            }
            else
            {
                this.FindForm().Text = Form_Res.FT_EditTransaction;
                this.FindForm().Icon = Form_Res.IconEditTransaction;
            }
        }

        #endregion

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion     

        #region Get Inventory

        private void GetInventory(InventoryClass inventory, StatusHasDitailEnum statusHasDitail)
        {
            _inventoryList = new List<InventoryClass>();

            _inventoryList = _inventoryBLL.GetInventory(inventory, statusHasDitail);
        }

        #endregion

        #region Prepare Controls

        private void PrepareControls()
        {
            List<GoodsUnit> units = _goodsBll.GetUnits();

            foreach (InventoryClass inventory in _inventoryList)
                cmbInventory.Items.Add(inventory.Title, inventory.ID);
            
            if (_formMode == FormModeEnum.Edit)
            {
                cmbInventory.Enabled = cmbTransactionType.Enabled = false;

                btnResat.Visible = false;
            }

            //-------<SET Grid  Transaction Detail>-----------------

            grdTransactionDetail.DataSource = _tbTransactionDetile;

            grdTransactionDetail.Refetch();

            foreach (GoodsUnit unit in units)
                grdTransactionDetail.RootTable.Columns["GoodsUnit"].ValueList.Add(unit.ID, unit.Title);

            grdTransactionDetail.RootTable.Columns["Price"].FormatMode = FormatMode.UseStringFormat;
            grdTransactionDetail.RootTable.Columns["Price"].FormatString = "{0:#,0}";
            grdTransactionDetail.RootTable.Columns["TotalPrice"].FormatMode = FormatMode.UseStringFormat;
            grdTransactionDetail.RootTable.Columns["TotalPrice"].FormatString = "{0:#,0}";

            grdTransactionDetail.RootTable.SortKeys.Clear();
        }

        #endregion

        #region checking  was emplty controls

        private bool AreControlsEmpty()
        {
            bool IsEmpty = false;

            IsEmpty = this.tlpHader.IsEmptyChildTextBoxControl();

            if (IsEmpty)
                return true;

            if (cmbInventory.SelectedItem == null || cmbTransactionType.SelectedItem == null)
                return true;

            IsEmpty = (txtData.Text == "") ? true : false;

            return IsEmpty;
        }

        #endregion

        #region InitializeTables

        private void InitializeTables()
        {
            _tbTransactionDetile.Columns.AddRange
                (
                    new DataColumn[]
                      {
                           new DataColumn("ID" ,typeof(int)),
                           new DataColumn("TransactionID" ,typeof(int)),
                           new DataColumn("GoodsID" ,typeof(int)),
                           new DataColumn("NumberOfGoods" ,typeof(int)),
                           new DataColumn("Price" ,typeof(int)),
                           new DataColumn("RecordStatus" ,typeof(int)),
                           new DataColumn("GoodsCode" ,typeof(string)),
                           new DataColumn("GoodsName" ,typeof(string)),
                           new DataColumn("GoodsUnit" ,typeof(int))
                      }
                );
        }

        #endregion

        #region Get  Contact 

        private void GetCustomer()
        {
            var Temporary =
                Faced.Contact.GetCustomer(_customer.ID);

            if (Temporary == null)
                return;

            _customer = Temporary;
        }

        #endregion

        #region Add TransactionDetail

        private void AddTransactionDetail(Goods goods)
        {
            int IDrandom = _random.Next(21, 50);

            _tbTransactionDetile.Rows.Add
                  (
                      IDrandom,
                      null,
                      goods.ID,
                      0,
                      0,
                      (int)goods.RecordStatus,
                      goods.Code,
                      goods.Name,
                      goods.GoodsUnit
                 );

            grdTransactionDetail.Refetch();

            TransactionDetail transactionDetail = new TransactionDetail();

            transactionDetail.ID = IDrandom;

            transactionDetail.Goods = goods;

            transactionDetail.RecordStatus = (int)RecordStatusEnum.Insert;

            _transaction.TransctionDetails.Add(transactionDetail);

            SelectNewRow();
        }

        #endregion

        #region SelectNewRow

        private void SelectNewRow()
        {
            grdTransactionDetail.SelectedItems.Clear();

            grdTransactionDetail.MoveLast();

            grdTransactionDetail.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;

            grdTransactionDetail.Col = grdTransactionDetail.RootTable.Columns[4].Index;

            grdTransactionDetail.Select();

        }

        #endregion

        #endregion

        #region Validation

        private bool Validation(ValidationTypeEnum validationType, ServerValidationEnum? validationResult = null)
        {
            switch (validationType)
            {
                case ValidationTypeEnum.Client:
                    {
                        if (AreControlsEmpty())
                        {
                            ShowMessage.ShowSuccessMessage(Transaction_Res.EnterTransactionFields);

                            return false;
                        }
                        if (!ValidationDate())
                        {
                            ShowMessage.ShowErrorMessage(Common_Res.ISIncorrectDate);

                            return false;
                        }

                        if (!txtNumber.Text.Trim().AreCodeValid())
                        {
                            ShowMessage.ShowErrorMessage(Common_Res.LengthCode);

                            return false;
                        }

                    }

                    break;

                case ValidationTypeEnum.Server:
                    {
                        switch (validationResult)
                        {
                            case ServerValidationEnum.NoProblem:
                                {
                                    ShowMessage.ShowSuccessMessage(Transaction_Res.SuccessInsert);

                                    return true;
                                }

                            case ServerValidationEnum.DuplicateCode:
                                {
                                    ShowMessage.ShowErrorMessage(Transaction_Res.MessageDuplicateCode);

                                    return false;
                                }

                            case ServerValidationEnum.ConversionCode:
                                {
                                    ShowMessage.ShowErrorMessage(Transaction_Res.ConversionCode);

                                    txtNumber.Text = _transactionCode;

                                    return false;
                                }

                            case ServerValidationEnum.InsertMoreStock:
                                {
                                    ShowMessage.ShowErrorMessage(Transaction_Res.InsertMoreStock);

                                    return false;
                                }
                            case ServerValidationEnum.Error:
                                {
                                    ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);

                                    return false;
                                }
                        }
                    }

                    break;
            }

            return true;
        }

        #region Validation Date

        private bool ValidationDate()
        {
            DateTime datetemp = new DateTime();

            datetemp = txtData.Text.ConvertStringToDateMiladi();

            if (datetemp == new DateTime())
                return false;

            return true;
        }

        #endregion

        #endregion

        #region Clear Controls 

        private void ClearControls()
        {
            txtNumber.Text =
                txtCustomer.Text = string.Empty;

            cmbInventory.SelectedItem =
                cmbTransactionType.SelectedItem = null;

            cmbInventory.Enabled =
                 cmbTransactionType.Enabled = true;

            cmbInventory.Items.Clear();

            _tbTransactionDetile.Clear();

            grdTransactionDetail.Refetch();
        }

        #endregion

        #region Events

        #region User Controls Load

        private void UC_Transaction_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            GetInventory(new InventoryClass(), StatusHasDitailEnum.No);

            PrepareControls();

            if (_formMode == FormModeEnum.Edit)
            {
                GetTransaction(_transaction);

                FillDataContorls(_transaction);
            }
        }

        #endregion

        #region button

        private void BtnSelectCutomer_Click(object sender, EventArgs e)
        {
            var Temporary =
                Faced.Contact.ShowUCSelectCustomer();

            if (Temporary == null)
                return;

            _customer = Temporary;

            txtCustomer.Text = _customer.FirstName + " " + _customer.LastName;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (Validation(ValidationTypeEnum.Client))
            {
                GetUIData();

                if (_formMode == FormModeEnum.New)
                {
                    if (Validation(ValidationTypeEnum.Server, InsertTransaction(_transaction)))

                        this.FindForm().DialogResult = DialogResult.Yes;
                }

                else
                {

                    if (Validation(ValidationTypeEnum.Server, UpdateTransaction(_transaction)))

                        this.FindForm().DialogResult = DialogResult.Yes;
                }
            }
        }

        private void BtnResat_Click(object sender, EventArgs e)
        {
            ClearControls();

            _formMode = FormModeEnum.New;

            _transaction = new Transaction();

            UC_Transaction_Load(new object(), new EventArgs());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Validation(ValidationTypeEnum.Client))
            {
                if ((int)cmbTransactionType.SelectedItem.Value == 1)
                {
                    Goods goods = new Goods();

                    UC_Goods_List UCGoods =
                        new UC_Goods_List(goods: goods, formMode: FormModeEnum.Select);

                    if (ShowForm.Show(UCGoods) == DialogResult.Yes)
                    {
                        AddTransactionDetail(goods);

                        cmbTransactionType.Enabled = cmbInventory.Enabled = false;
                    }
                }

                else
                {
                    InventoryClass inventory = new InventoryClass
                    {
                        ID =
                        Convert.ToInt32(cmbInventory.SelectedItem.Value)
                    };

                    UC_Stock_Inventory UCstock =

                        new UC_Stock_Inventory(ref inventory, FormModeEnum.Select);

                    if (ShowForm.Show(UCstock) == DialogResult.Yes)
                    {
                        foreach (Goods goods in inventory.GoodsList)

                            AddTransactionDetail(goods);

                        cmbTransactionType.Enabled = cmbInventory.Enabled = false;
                    }
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            GridEXRow CurrentRow = grdTransactionDetail.CurrentRow;

            if (CurrentRow == null)
                return;

            DataTable f = (DataTable)grdTransactionDetail.DataSource;

            foreach (TransactionDetail transactionDetail in _transaction.TransctionDetails)

                if (transactionDetail.ID == Convert.ToInt32(grdTransactionDetail.GetValue("ID").ToString()))

                    if (transactionDetail.RecordStatus == (int)RecordStatusEnum.Insert)
                    {
                        _transaction.TransctionDetails.Remove(transactionDetail);
                        break;
                    }
                    else
                    {
                        transactionDetail.RecordStatus = (int)RecordStatusEnum.Delete;
                        break;
                    }

            CurrentRow.Delete();
        }

        private void BtnCalculations_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)grdTransactionDetail.DataSource;

            foreach (DataRow item in data.Rows)
            {
                string TotalPrice = string.Format
                    (
                        "{0:#,0}",
                         Convert.ToInt32(item["Price"].ToString())
                         *
                         Convert.ToInt32(item["NumberOfGoods"].ToString())

                    );

                grdTransactionDetail.GetRow(item).Cells["TotalPrice"].Text = TotalPrice;
            }
        }

        #endregion

        #region TextBox

        private void TxtCodeContact_txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')

                if (
                        !char.IsDigit(e.KeyChar) ||
                        char.IsControl(e.KeyChar) ||
                        char.IsPunctuation(e.KeyChar)
                   )
                    e.Handled = true;
        }

        private void NO_Number_Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        #endregion

        #region Grid

        private void GrdTransactionDetail_RecordUpdated(object sender, EventArgs e)
        {
            foreach (TransactionDetail transactionDetail in _transaction.TransctionDetails)

                if (transactionDetail.ID == Convert.ToInt32(grdTransactionDetail.GetValue("ID").ToString()))
                {
                    string NumberOfGoods = grdTransactionDetail.GetValue("NumberOfGoods").ToString();

                    string Price = grdTransactionDetail.GetValue("Price").ToString();

                    transactionDetail.NumberOfGoods = NumberOfGoods.Trim() == "" ? 0 : Convert.ToInt32(NumberOfGoods);

                    transactionDetail.Price = Price.Trim() == "" ? 0 : Convert.ToInt32(Price);

                    if (_formMode == FormModeEnum.Edit)
                        if (transactionDetail.RecordStatus == (int)RecordStatusEnum.Fix)
                            transactionDetail.RecordStatus = (int)RecordStatusEnum.Update;

                }
        }

        private void GrdTransactionDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                grdTransactionDetail.RootTable.AllowEdit = InheritableBoolean.True;

                int countRow = grdTransactionDetail.RowCount;
                int rowIndex = grdTransactionDetail.CurrentRow.RowIndex + 1;
                int callIndex = grdTransactionDetail.CurrentColumn == null ? 0 : grdTransactionDetail.CurrentColumn.Index;

                if (rowIndex == countRow && callIndex == 6)
                {
                    grdTransactionDetail.RootTable.AllowEdit = InheritableBoolean.False;
                    grdTransactionDetail.RootTable.AllowEdit = InheritableBoolean.True;
                    grdTransactionDetail.SelectedItems.Clear();
                }
            }
        }

        #endregion

        #region ComboBox

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        #endregion        
    }
}


