using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Common.Utility;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using Cactus.Inventory.UI.Resources;
using System;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;

using InventoryClass = Cactus.Inventory.Model.Inventory;

namespace Cactus.Inventory.UI
{
    public partial class UC_Insert_Update_Inventory : UserControl, IUserControl, IFindForm
    {
        #region  Member

        IInventoryBLL _inventoryBLL;
        InventoryClass _enteredinventory;
        InventoryClass _currentinventory;
        FormModeEnum _formMode;

        #endregion

        #region Constructors

        public UC_Insert_Update_Inventory()
        {
            _inventoryBLL = DependencyInjector.Retrieve<InventoryBLL>();

            _enteredinventory = new InventoryClass();

            _currentinventory = new InventoryClass();

            _formMode = new FormModeEnum();

            InitializeComponent();
        }

        public UC_Insert_Update_Inventory(InventoryClass inventory, FormModeEnum FormMode) : this()
        {
            _enteredinventory = inventory;

            _formMode = FormMode;
        }

        #endregion

        #region Get UI Data

        private void GetUIData()
        {
            _currentinventory.Code = txtInventoryCode.Text.Trim();

            _currentinventory.Title = txtInventoryTitle.Text.Trim();

            _currentinventory.ID = _enteredinventory.ID;
        }

        #endregion

        #region Fill Data Controls  

        private void FillDataControls()
        {
            txtInventoryCode.Text = _enteredinventory.Code.Trim();

            txtInventoryTitle.Text = _enteredinventory.Title.Trim();
        }

        #endregion

        #region Get Inventory

        private void GetInventory(InventoryClass inventory)
        {
            _enteredinventory = _inventoryBLL.GetInventory(inventory, StatusHasDitailEnum.No)[0];
        }

        #endregion

        #region  Insert Inventory 

        public ServerValidationEnum InsertInventory(InventoryClass inventory)
        {
            return _inventoryBLL.InsertInventory(inventory);
        }

        #endregion

        #region Update  Inventory

        private ServerValidationEnum UpdateInventory(InventoryClass inventory)
        {
            return _inventoryBLL.UpdateInventory(inventory);
        }

        #endregion

        #region  Metods

        #region Set Form

        public void SetForm()
        {
            if (_formMode == FormModeEnum.New)

            {
                this.FindForm().Text = Form_Res.FT_AddInventory;

                this.FindForm().Icon = Form_Res.IconNewInventory;
            }
            else
            {
                this.FindForm().Text = Form_Res.FT_EditInventory;

                this.FindForm().Icon = Form_Res.IconEditInventory;
            }

            this.FindForm().FormBorderStyle = FormBorderStyle.Fixed3D;

            this.FindForm().MaximizeBox = false;

        }

        #endregion

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #endregion

        #region  Validation

        private bool Validation(ValidationTypeEnum validationType, ServerValidationEnum? validationResult = null)
        {
            switch (validationType)
            {
                case ValidationTypeEnum.Client:
                    {
                        if (_currentinventory.Code.Trim() == "" && _currentinventory.Title.Trim() == "")
                        {
                            ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);
                            return false;
                        }

                        if (!_currentinventory.Code.AreCodeValid())
                        {
                            ShowMessage.ShowErrorMessage(Common_Res.LengthCode);
                            return false;
                        }

                        return true;
                    }

                case ValidationTypeEnum.Server:
                    {
                        switch (validationResult)
                        {
                            case ServerValidationEnum.DuplicateCode:
                                {
                                    ShowMessage.ShowErrorMessage(Inventory_Res.DuplicateInventoryCode);
                                    return false;
                                }
                            case ServerValidationEnum.NoProblem:
                                {                                 
                                    ShowMessage.ShowSuccessMessage(Inventory_Res.SuccessInsertInventory);
                                    return true;
                                }
                            case ServerValidationEnum.ConversionCode:
                                {                                   
                                    ShowMessage.ShowErrorMessage(Inventory_Res.ConversionCode);
                                    txtInventoryCode.Text = _enteredinventory.Code;
                                    return false;
                                }
                            case ServerValidationEnum.Error:
                                {
                                    ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);
                                    return false;
                                }
                            default:
                                return false;
                        }
                    }
            }

            return false;
        }

        #endregion

        #region Events

        #region Load User Controls 

        private void UC_Insert_update_Inventory_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            if (_formMode == FormModeEnum.Edit)
            {
                GetInventory(_enteredinventory);

                FillDataControls();
            }
        }

        #endregion

        #region TextBox

        private void PreventEnteringLettersInTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        #region Button

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GetUIData();

            if (Validation(ValidationTypeEnum.Client))
            {
                switch (_formMode)
                {
                    case FormModeEnum.New:
                        {
                            if (Validation(ValidationTypeEnum.Server, InsertInventory(_currentinventory)))

                                this.FindForm().DialogResult = DialogResult.Yes;

                            break;
                        }
                    case FormModeEnum.Edit:
                        {
                            if (Validation(ValidationTypeEnum.Server, UpdateInventory(_currentinventory)))

                                this.FindForm().DialogResult = DialogResult.Yes;

                            break;
                        }
                }
            }
        } 

        #endregion

        #endregion
    }
}
