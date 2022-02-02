using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Common.Model;
using Cactus.Common.Utility;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using Cactus.Inventory.UI.Resources;
using Janus.Windows.GridEX;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory;
namespace  Cactus.Inventory.UI
{
    public partial class UC_Transaction_List : UserControl, IUserControl,IFindForm
    {
        #region Member

        TransactionSearch _transaction;

        ITransactionBLL _transactionBLL;

        List<InventoryClass> _inventoryList;

        #endregion

        #region Constructors

        public UC_Transaction_List()
        {
            InitializeMember();

            InitializeComponent();
        }

        #endregion

        #region Get UI Data

        private void GetUIData()
        {
            _transaction.TransactionNumber = 
                txtNumber.Text.Trim() == "" ? null : txtNumber.Text.Trim();

            string untilDate = txtUntilDate.Text == "" ? DateTimeTools.MaxDate : txtUntilDate.Text;
            string fromDate = txtFromDate.Text == "" ? DateTimeTools.MinDate : txtFromDate.Text;

            _transaction.ToDate = untilDate.ConvertStringToDateMiladi();
            _transaction.FromDate = fromDate.ConvertStringToDateMiladi();

            if (cmbInventory.SelectedItem != null)
                _transaction.InventoryID = (int)cmbInventory.SelectedItem.Value;
        }

        #endregion

        #region Fill Data Controls 

        private void FillDateControls()
        {
            grdTransaction.DataSource = GetTransactionFull(_transaction);

            DataTable dataTable = (DataTable)grdTransaction.DataSource;

            grdTransaction.Refetch();
        }

        #endregion

        #region Get  Transaction Full

        private DataTable GetTransactionFull(TransactionSearch transaction)
        {
            return _transactionBLL.GetTransactionFull(transaction);
        }

        #endregion       

        #region Delete Transaction

        private void DeleteTransaction(int transactionID)
        {
            if (transactionID != 0)
            {
                if (_transactionBLL.DeleteTrsaction(transactionID))
                {
                    MessageBox.Show(Transaction_Res.SuccessDelete);

                    _transaction = new TransactionSearch();

                    FillDateControls();
                }

                else
                    ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);
            }
        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            this.FindForm().Text = Form_Res.FT_Transactio;
            this.FindForm().Icon = Form_Res.IconTranaction;
            this.FindForm().WindowState = FormWindowState.Maximized;
            this.FindForm().MaximizeBox = true;
        }

        #endregion

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region Initialize Member

        private void InitializeMember()
        {
            _transaction = new TransactionSearch();

            _transactionBLL = DependencyInjector.Retrieve<TransactionBLL>();

            _inventoryList = new List<InventoryClass>();
        }

        #endregion

        #region Prepare Controls

        private void PrepareControls()
        {
            grdTransaction.RootTable.Columns["InventoryID"].HasValueList = true;

            grdTransaction.RootTable.SortKeys.Clear();

            grdTransaction.RootTable.SortKeys.Add
                (
                    new GridEXSortKey(grdTransaction.RootTable.Columns["Date"])
                );

            if (_inventoryList != null)

                foreach (InventoryClass inventory in _inventoryList)
                {
                    cmbInventory.Items.Add(inventory.Title, inventory.ID);

                    grdTransaction.RootTable.Columns["InventoryID"].ValueList.Add
                        (
                            inventory.ID,
                            inventory.Title
                        );
                }

            txtFromDate.Text =
                txtUntilDate.Text = string.Empty;
        }

        #endregion      

        #region Get Inventory

        private void GetInventory()
        {
            IInventoryBLL inventoryBll = DependencyInjector.Retrieve<InventoryBLL>();

            _inventoryList =
                inventoryBll.GetInventory(new InventoryClass(), StatusHasDitailEnum.No);
        }

        #endregion  

        #region Cell The Transaction Update Form 

        private DialogResult CellTheTransactonUpdateForm(Transaction transaction)
        {
            UserControl uCTransactionInsertUpdate =
                new UC_Transaction_Insert_Update
                    (
                        transaction,
                        FormModeEnum.Edit
                    );

            DialogResult result =
               ShowForm.Show(uCTransactionInsertUpdate);

            return result;
        }

        #endregion

        #region Print Transaction 

        private void PrintTransaction()
        {
            if (grdTransaction.CurrentRow != null)
            {
                int id = Convert.ToInt32(grdTransaction.GetValue("ID").ToString());

                Report.Report.ShowReportTransaction(id);
            }
        }

        #endregion

        #endregion

        #region Validition

        private bool Validition(ValidationTypeEnum validationType)
        {
            if (validationType == ValidationTypeEnum.Client)
            {
                TimeSpan span = _transaction.ToDate - _transaction.FromDate;

                if (span.TotalDays < 0)
                {
                    ShowMessage.ShowErrorMessage(Transaction_Res.ErrorTime);

                    return false;
                }

                if (_transaction.ToDate == new DateTime() || _transaction.FromDate == new DateTime())
                {
                    ShowMessage.ShowErrorMessage(Common_Res.ISIncorrectDate);

                    return false;

                }
            }

            return true;
        }

        #endregion

        #region Clear Controls  

        private void ClearControls()
        {
            txtCustomer.Text =
                txtNumber.Text =
                txtFromDate.Text =
                txtUntilDate.Text = string.Empty;

            cmbInventory.SelectedItem = null;

            grdTransaction.DataSource = new DataTable();

            grdTransaction.Refetch();

            grdTransaction.RemoveFilters();
        }

        #endregion

        #region Events

        #region User Controls Load

        private void UC_Transaction_List_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            GetInventory();

            PrepareControls();

            FillDateControls();
        }

        #endregion

        #region Button

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetUIData();

            if (Validition(ValidationTypeEnum.Client))

                FillDateControls();
        }

        private void BtnSelectCustomer_Click(object sender, EventArgs e)
        {
            ContactViewModel CustomertView = new ContactViewModel();            

            CustomertView =
                Faced.Contact.ShowUCSelectCustomer();

            if (CustomertView == null)
                return;

            _transaction.CustomerID = CustomertView.ID;

            _transaction.CustomerFullName =
                CustomertView.FirstName + " " + CustomertView.LastName;

            txtCustomer.Text = _transaction.CustomerFullName;
        }

        private void BtnResat_Click(object sender, EventArgs e)
        {
            InitializeMember();

            ClearControls();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            UC_Transaction_Insert_Update NewTransaction =
                new UC_Transaction_Insert_Update(new Transaction(), FormModeEnum.New);

            DialogResult result = ShowForm.Show(NewTransaction);

            if (result == DialogResult.Yes)
            {
                FillDateControls();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (grdTransaction.CurrentRow == null)

                return;

            int TransactionID =
                 Convert.ToInt32(grdTransaction.GetValue("ID").ToString() ?? "0");

            DialogResult result =
               ShowMessage.ShowQuestionMessage(Transaction_Res.AreYouSureDelete);

            if (result == DialogResult.Yes)

                DeleteTransaction(TransactionID);

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (grdTransaction.CurrentRow == null)
                return;

            if (grdTransaction.GetValue("ID") != null)
            {
                Transaction transaction = new Transaction
                {
                    ID = Convert.ToInt32(grdTransaction.GetValue("ID").ToString() ?? "0"),

                    Number = grdTransaction.GetValue("Number").ToString()
                };

                if (transaction.ID != 0)
                {
                    var result = CellTheTransactonUpdateForm(transaction);

                    if (result == DialogResult.Yes)
                    {
                        FillDateControls();
                    }
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintTransaction();
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

        #region ComboBox

        private void CmbInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion    

        #endregion
    }
}
