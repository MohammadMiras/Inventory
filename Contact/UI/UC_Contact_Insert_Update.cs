using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Common.Utility;
using Cactus.Contact.Bll;
using Cactus.Contact.Model;
using Cactus.Contact.UI.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;
using ContactClass = Cactus.Contact.Model.Contact;
using InheritableBoolean = Janus.Windows.GridEX.InheritableBoolean;

namespace Cactus.Contact.UI
{
    public partial class UC_Contact_Insert_Update : UserControl, IUserControl, IFindForm
    {
        #region Members

        private ContactClass _enteredContact;

        private ContactClass _currentContact;

        private DataTable _phoneDataTable;

        private DataTable _addressDataTable;

        private FormModeEnum _formMode;

        private IContactBLL _contactBLL;

        #endregion

        #region Constructors

        public UC_Contact_Insert_Update()
        {
            _contactBLL = DependencyInjector.Retrieve<ContactBLL>();

            InitializeComponent();
        }

        public UC_Contact_Insert_Update(ContactClass contact, FormModeEnum formMode)
            : this()
        {
            _currentContact = new ContactClass();
            _currentContact.Addresses = new List<Address>();
            _currentContact.Phones = new List<Phone>();
            _currentContact = contact;

            _formMode = formMode;
        }

        #endregion

        #region Get UI Data

        public void GetUIData()
        {
            _enteredContact = new ContactClass();
            _enteredContact.ID = _currentContact.ID;
            _enteredContact.FirstName = txtFirstName.Text.Trim();
            _enteredContact.LastName = txtLastName.Text.Trim();
            _enteredContact.FatherName = txtFatherName.Text.Trim();
            _enteredContact.NationalCode = txtNationalCode.Text.Trim();
            _enteredContact.Code = txtContactCode.Text.Trim();
            _enteredContact.Addresses = _currentContact.Addresses;
            _enteredContact.Phones = _currentContact.Phones;
        }

        #endregion

        #region Fill Data In Controls

        public void FillDataInControls(ContactClass Contact)
        {
            txtFirstName.Text = Contact.FirstName.Trim();
            txtLastName.Text = Contact.LastName.ToString().Trim();
            txtNationalCode.Text = Contact.NationalCode.Trim();
            txtFatherName.Text = Contact.FatherName.Trim();
            txtContactCode.Text = Contact.Code.Trim();
            FillDataPhoneTable();
            FillDataAddressTable();
        }

        #region Fill Data  Grids  

        private void FillDataGrid(DataTable addressDataTable, DataTable phoneDataTable)
        {
            //-----------------<Grid Address>-------------------

            FillDataAddressTable();

            grdAddres.DataSource = addressDataTable;

            grdAddres.Refetch();

            //-----------------<Grid Phone>-------------------

            grdphone.DataSource = phoneDataTable;

            grdphone.Refetch();
        }

        #endregion


        #endregion

        #region Insert Contact 

        private ServerValidationEnum InsertContact()
        {
            return
                _contactBLL.InsertContact(_enteredContact);
        }

        #endregion

        #region Update Contact

        private ServerValidationEnum? UpdateContact()
        {
            return
                _contactBLL.UpdateContact(_enteredContact);
        }

        #endregion

        #region Metods

        #region Set form

        public void SetForm()
        {
            if (_formMode == FormModeEnum.New)
            {
                this.FindForm().Text = Form_Res.FT_AddContact;
                this.FindForm().Icon = Form_Res.IconNewContact;
            }

            else
            {
                this.FindForm().Text = Form_Res.FT_EditContact;
                this.FindForm().Icon = Form_Res.IconEditContact;
            }
        }

        #endregion

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region Prepare Form 

        public void PrepareForm()
        {
            switch (_formMode)
            {
                case FormModeEnum.New:
                    {
                        ClearControls();

                        this.FindForm().Text =
                            Contact_Res.FormInsertUpdateTitleModeNew;

                        break;
                    }
                case FormModeEnum.Edit:
                    {
                        this.FindForm().Text =
                            Contact_Res.FormInsertUpdateTitleModeUpdate;

                        break;
                    }
                case FormModeEnum.Review:
                    {
                        this.FindForm().Text =
                            Contact_Res.FormInsertUpdateTitleInModeReview;

                        DeActivateControls();

                        break;
                    }
                default:
                    break;
            }
        }

        #endregion

        #region Call The  Form   

        #region Call The Add address Form  

        private DialogResult CallTheAddAddressForm(Address address)
        {
            UserControl ucSetAddress = new UC_Add_Address(address: address);

            return
                ShowForm.Show(ucSetAddress, false);
        }

        #endregion

        #region Call The Add Phone

        private DialogResult CallTheAddPhone(Phone phone)
        {
            UserControl ucSetPhone = new UC_Add_Phone(phone: phone);

            return
                ShowForm.Show(ucSetPhone, false);

        }

        #endregion

        #endregion

        #region Prepare Controls

        public void PrepareControls()
        {
            InitializeTables();

            if (_formMode == FormModeEnum.Edit || _formMode == FormModeEnum.Review)

                FillDataInControls(_currentContact);

            FillDataGrid(_addressDataTable, _phoneDataTable);

            PrepareForm();
        }

        #endregion

        #region Deactivate Controls 

        private void DeActivateControls()
        {
            txtContactCode.ReadOnly =
                txtFirstName.ReadOnly =
                txtLastName.ReadOnly =
                txtNationalCode.ReadOnly =
                txtFatherName.ReadOnly = true;

            tsPhone.Enabled =
                tsAddres.Enabled =
                btnSave.Enabled = false;

            this.Text =
                Contact_Res.FormInsertUpdateTitleInModeReview;
        }

        #endregion

        #region Initialize Tables

        private void InitializeTables()
        {
            _phoneDataTable = new DataTable();

            _addressDataTable = new DataTable();

            _phoneDataTable.Columns.AddRange(new DataColumn[]
                   {
                        new DataColumn("PhoneType" ,typeof(int)),
                        new DataColumn("PhoneNumber" ,typeof(string)),
                        new DataColumn("ID" ,typeof(int)),
                   });

            _addressDataTable.Columns.AddRange(new DataColumn[]
                {
                        new DataColumn("AddresType" ,typeof(int)),
                        new DataColumn("AddresTitle" ,typeof(string)),
                        new DataColumn("ID" ,typeof(int)),
                });
        }

        #endregion

        #region Fill Data Tables

        private void FillDataPhoneTable()
        {
            _phoneDataTable.Clear();

            foreach (Phone phone in _currentContact.Phones)

                if (phone.RecordStatus != (int)RecordStatusEnum.Delete)

                    _phoneDataTable.Rows.Add
                        (
                           (int)phone.PhoneType,
                            phone.PhoneNumber,
                            phone.ID
                        );
        }

        private void FillDataAddressTable()
        {
            _addressDataTable.Clear();

            foreach (Address address in _currentContact.Addresses)

                if (address.RecordStatus != (int)RecordStatusEnum.Delete)

                    _addressDataTable.Rows.Add
                        (
                           (int)address.AddressType,
                            address.AddressTitle,
                            address.ID
                        );
        }

        #endregion

        #endregion

        #region Validation

        public bool Validation(ValidationTypeEnum validationType, ServerValidationEnum? validationResult = null)
        {
            switch (validationType)
            {
                case ValidationTypeEnum.Client:
                    {
                        bool resualt = false;

                        this.tlpHeader.IsEmptyChildTextBoxControl();

                        if (resualt)
                        {
                            ShowMessage.ShowErrorMessage(Contact_Res.NothingEnterInformation);

                            return false;
                        }

                        resualt = _enteredContact.IsValidIranianNationalCode();

                        if (!resualt)
                        {
                            ShowMessage.ShowErrorMessage(Contact_Res.TheNationalCodeIsInCorrect);

                            return false;
                        }

                        resualt = _enteredContact.Code.AreCodeValid();

                        if (!resualt)
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
                                    ShowMessage.ShowErrorMessage(Contact_Res.DuplicateContactCode);

                                    return false;
                                }
                            case ServerValidationEnum.NoProblem:
                                {
                                    ShowMessage.ShowSuccessMessage(Contact_Res.InsertedContact);

                                    ClearControls();

                                    return true;
                                }
                            case ServerValidationEnum.ConversionCode:
                                {
                                    ShowMessage.ShowErrorMessage(Contact_Res.ConversionContactCode);

                                    txtContactCode.Text = _currentContact.Code;

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

        #region Clear Controls

        public void ClearControls()
        {
            txtContactCode.Text =
                txtFatherName.Text =
                txtFirstName.Text =
                txtLastName.Text =
                txtNationalCode.Text = string.Empty;

            grdAddres.RemoveFilters();

            if (_phoneDataTable != null)
                _phoneDataTable.Clear();

            if (_addressDataTable != null)
                _addressDataTable.Clear();

            _currentContact = null;

            _currentContact = new ContactClass();
        }

        #endregion

        #region Events

        #region Load  User Controls

        private void UC_Contact_Insert_Update_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            PrepareControls();
        }

        #endregion

        #region Button

        private void BtnAddPhone_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();

            if (CallTheAddPhone(phone: phone) == DialogResult.Yes)
            {
                _currentContact.Phones.Add(phone);

                _phoneDataTable.Rows.Add
                    (
                        phone.PhoneType,
                        phone.PhoneNumber,
                        new Random().Next(0, 100)
                    );

                grdphone.Refetch();
            }
        }

        private void BtnAddAddres_Click(object sender, EventArgs e)
        {
            Address address = new Address();

            if (CallTheAddAddressForm(address: address) == DialogResult.Yes)
            {
                _currentContact.Addresses.Add(address);

                _addressDataTable.Rows.Add
                    (
                    address.AddressType,
                    address.AddressTitle,
                    new Random().Next(0, 100)
                    );
            }
        }

        private void BtnRemovePhone_Click(object sender, EventArgs e)
        {
            foreach (Phone phone in _currentContact.Phones)

                if (phone.ID == int.Parse(grdphone.GetValue("ID").ToString()))
                {
                    phone.RecordStatus = (int)RecordStatusEnum.Delete;

                    break;
                }

            foreach (DataRow row in _phoneDataTable.Rows)

                if (row["ID"].ToString() == grdphone.GetValue("ID").ToString())
                {
                    row.Delete();

                    break;
                }
        }

        private void ButRemoveAddres_Click(object sender, EventArgs e)
        {
            foreach (Address address in _currentContact.Addresses)

                if (address.ID == int.Parse(grdAddres.GetValue("ID").ToString()))
                {
                    address.RecordStatus = (int)RecordStatusEnum.Delete;

                    break;
                }

            foreach (DataRow row in _addressDataTable.Rows)

                if (row["ID"].ToString() == grdAddres.GetValue("ID").ToString())
                {
                    row.Delete();

                    break;
                }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GetUIData();

            if (Validation(ValidationTypeEnum.Client))
            {
                if (_formMode == FormModeEnum.New)
                    Validation(ValidationTypeEnum.Server, InsertContact());

                else

                   if (Validation(ValidationTypeEnum.Server, UpdateContact()))
                    this.FindForm().DialogResult = DialogResult.Yes;
            }
        }

        private void BtnEditAddres_Click(object sender, EventArgs e)
        {
            grdAddres.AllowEdit = InheritableBoolean.True;

            MessageBox.Show(Contact_Res.EditGrid);
        }

        private void BtnEditPhone_Click(object sender, EventArgs e)
        {
            grdphone.AllowEdit = InheritableBoolean.True;

            MessageBox.Show(Contact_Res.EditGrid);
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
                    e.Handled = true; if (e.KeyChar != '\b')

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

        private void Gridphone_RecordUpdated(object sender, EventArgs e)
        {
            Phone phone = new Phone
            {
                ID = int.Parse(grdphone.GetValue("ID").ToString()),
                PhoneNumber = grdphone.GetValue("PhoneNumber").ToString(),
                PhoneType = int.Parse(grdphone.GetValue("PhoneType").ToString())
            };

            ClientValidationEnum validationPhone = new ClientValidationEnum();

            validationPhone = ClientValidationEnum.NoProblem;

            if (validationPhone == ClientValidationEnum.NoProblem)
            {
                foreach (Phone phoneitem in _currentContact.Phones)
                {
                    if (phoneitem.ID == phone.ID)
                    {
                        if (phoneitem.RecordStatus != (int)RecordStatusEnum.Insert)
                            phoneitem.RecordStatus = (int)RecordStatusEnum.Update;

                        phoneitem.PhoneNumber = phone.PhoneNumber;
                        phoneitem.PhoneType = phone.PhoneType;
                        phoneitem.PhoneType = phone.PhoneType;
                    }
                }
            }

            else
            {
                ShowMessage.ShowErrorMessage(Contact_Res.PhonePatternIncorrect);

                FillDataPhoneTable();
            }

            grdphone.Refetch();
        }

        private void GridAddres_RecordUpdated(object sender, EventArgs e)
        {
            foreach (Address item in _currentContact.Addresses)
            {
                if (item.ID == int.Parse(grdAddres.GetValue("ID").ToString()))
                {
                    if (item.RecordStatus != (int)RecordStatusEnum.Insert)
                        item.RecordStatus = (int)RecordStatusEnum.Update;

                    item.AddressTitle = grdAddres.GetValue("AddresTitle").ToString();
                    item.AddressType = (int)grdAddres.GetValue("AddresType");
                }
            }
        }

        #endregion        

        #endregion
    }
}
