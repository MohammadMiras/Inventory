using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using Cactus.Inventory.UI.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;
using InventoryClass = Cactus.Inventory.Model.Inventory;

namespace Cactus.Inventory.UI
{
    public partial class UC_Inventory_List : UserControl ,IUserControl,IFindForm
    {
        #region  Member

        IInventoryBLL _inventoryBLL;

        InventoryClass _inventory;

        List<InventoryClass> _inventoryList;

        #endregion

        #region Constructors

        public UC_Inventory_List()
        {
            _inventory = new InventoryClass();
            _inventoryBLL = DependencyInjector.Retrieve<InventoryBLL>();
            _inventoryList = new List<InventoryClass>();

            InitializeComponent();
        }

        #endregion

        #region Get Data UI

        private void GetDataUI()
        {
            _inventory = new InventoryClass();

            _inventory.Code = (string.IsNullOrEmpty(txtCode.Text.Trim()) ? null : txtCode.Text.Trim());

            _inventory.Title = (string.IsNullOrEmpty(txtTitle.Text.Trim()) ? null : txtTitle.Text.Trim());
        }

        #endregion

        #region Fill Data Controls

        private void FillDataControls()
        {
            grdInventory.DataSource = _inventoryList;

            grdInventory.Refetch();
        }

        #endregion

        #region Get Inventory

        private void GetInventoryList(InventoryClass inventory)
        {
            _inventoryList = _inventoryBLL.GetInventory(inventory, StatusHasDitailEnum.No);
        }

        #endregion

        #region Delete Inventory

        public ServerValidationEnum DeleteInventory(int ID)
        {
            return _inventoryBLL.DeleteInventory(ID);
        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            this.FindForm().Text = Form_Res.FT_Inventory;
            this.FindForm().Icon = Form_Res.IconInventory;
            this.FindForm().MaximizeBox = true;
            this.FindForm().WindowState = FormWindowState.Maximized;
            this.FindForm().KeyDown += new KeyEventHandler(FindFormKyeDown); 
        }

        #endregion

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region Send UserControls To Show 

        private DialogResult SendUserControlsToShow()
        {
            UserControl UCUpdateInventory =
                new UC_Insert_Update_Inventory(_inventory, FormModeEnum.Edit); 

            return
                 ShowForm.Show(UCUpdateInventory);
        }

        #endregion

        #region ReLoad Data

        private void ReLoadData()
        {
            GetInventoryList(new InventoryClass());

            FillDataControls();
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
                        ShowMessage.ShowSuccessMessage(Inventory_Res.DeleteInventory);

                        return true;
                    }

                case ServerValidationEnum.Error:
                    {
                        ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);

                        return false;
                    }

                case ServerValidationEnum.ThereIsTransaction:
                    {
                        ShowMessage.ShowErrorMessage(Inventory_Res.NoDelete);

                        return false;
                    }
                default:
                    return false;
            }
        }

        #endregion

        #region Clear Controls

        private void ClearControls()
        {
            txtCode.Text =
                txtTitle.Text = string.Empty;

            _inventoryList = new List<InventoryClass>();

            FillDataControls();
        }

        #endregion

        #region Events

        #region Load User Controls 

        private void UC_Inventory_List_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            GetInventoryList(_inventory);

            FillDataControls();
        }

        #endregion

        #region Button

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (grdInventory.CurrentRow != null)
            {
                _inventory = new InventoryClass();

                _inventory.ID =
                    Convert.ToInt32(grdInventory.GetValue("ID").ToString());

                SendUserControlsToShow();

                ReLoadData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (grdInventory.CurrentRow != null)
            {
                var result = ShowMessage.ShowQuestionMessage(Inventory_Res.AreYouDelelteInventory);

                if (result == DialogResult.Yes)
                {
                    int ID =
                         Convert.ToInt32(grdInventory.GetValue("ID").ToString());

                    bool ValidationResult = Validation(DeleteInventory(ID));

                    if (ValidationResult)

                        ReLoadData();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetDataUI();

            GetInventoryList(_inventory);

            FillDataControls();
        }

        private void BtnResat_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            UserControl UCNewInventory =
                new UC_Insert_Update_Inventory(new InventoryClass(), FormModeEnum.New);

            ShowForm.Show(UCNewInventory);

            ReLoadData();

        }

        #endregion

        #region TextBox

        private void PreventEnteringNumberInTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')

                if (
                        !char.IsDigit(e.KeyChar) ||
                        char.IsControl(e.KeyChar) ||
                        char.IsPunctuation(e.KeyChar)
                   )
                    e.Handled = true;
        }

        #endregion

        #region Form

        public void FindFormKyeDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F5:
                    {
                        BtnNew_Click(new object(), new EventArgs());
                        break;
                    }
                case Keys.F6:
                    {
                        BtnUpdate_Click(new object(), new EventArgs());
                        break;
                    }

                case Keys.F7:
                    {
                        BtnDelete_Click(new object(), new EventArgs());
                        break;
                    }
                case Keys.F8:
                    {
                        BtnSearch_Click(new object(), new EventArgs());
                        break;
                    }

                case Keys.F9:
                    {
                        BtnResat_Click(new object(), new EventArgs());
                        break;
                    }
            }
        }

        #endregion

        #endregion
    }
}
