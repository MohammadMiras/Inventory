using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Contact.Bll;
using Cactus.Contact.Model;
using Cactus.Contact.UI.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;
using ClassContact = Cactus.Contact.Model.Contact;
namespace Cactus.Contact.UI
{
    public partial class UC_Contact_List : UserControl ,IUserControl,IFindForm
    {
        #region Member

        private FormModeEnum _formMode;

        private IContactBLL _contactBLL;

        private ClassContact _contact;

        private ClassContact _contactSelect;

        private List<ClassContact> _contactList;

        private DataTable _dtContact;

        #endregion

        #region Constructors

        public UC_Contact_List()
        {
            _contactList = new List<ClassContact>();

            _contact = new ClassContact();

            _dtContact = new DataTable();

            _contactBLL = DependencyInjector.Retrieve<ContactBLL>();

            InitializeTables();

            InitializeComponent();
        }

        public UC_Contact_List(ClassContact contact, FormModeEnum formMode) : this()
        {
            _contactSelect = new ClassContact();

            _contactSelect = contact;

            _formMode = formMode;
        }

        #endregion

        #region Get UI Data 

        public void GetUIData()
        {
            _contact = new ClassContact();

            _contact.Code =
                (string.IsNullOrEmpty(txtCode.Text) ? null : txtCode.Text.Trim());

            _contact.FirstName =
                (string.IsNullOrEmpty(txtFirstName.Text) ? null : txtFirstName.Text.Trim());

            _contact.LastName =
                (string.IsNullOrEmpty(txtLastName.Text) ? null : txtLastName.Text.Trim());

            _contact.NationalCode =
                (string.IsNullOrEmpty(txtNationalCode.Text) ? null : txtNationalCode.Text.Trim());

            _contact.FatherName =
                (string.IsNullOrEmpty(txtFatherName.Text) ? null : txtFatherName.Text.Trim());
        }

        #endregion

        #region Fill Data In Controls 

        public void FillDataInControls()
        {
            FillGridPerson();
        }

        #region Fill Grid Person  

        private void FillGridPerson()
        {
            _contactList = GetContacts(_contact, StatusHasDitailEnum.Yes);

            _dtContact.Clear();

            if (_contactList != null)
            {
                foreach (ClassContact contact in _contactList)
                {
                    string phoneContact = "";

                    string addressContact = "";

                    foreach (Phone phone in contact.Phones)
                        phoneContact += phone.PhoneNumber.ToString() + " / ";

                    if (phoneContact.Length > 2)
                        phoneContact = phoneContact.Remove(phoneContact.Length - 2, 1);

                    foreach (Address address in contact.Addresses)
                        addressContact += address.AddressTitle.ToString() + " / ";

                    if (addressContact.Length > 2)
                        addressContact = addressContact.Remove(addressContact.Length - 2, 1);

                    _dtContact.Rows.Add
                        (
                            contact.ID,
                            contact.Code,
                            contact.FirstName,
                            contact.LastName,
                            contact.NationalCode,
                            contact.FatherName,
                            addressContact.Trim(),
                            phoneContact.Trim()
                        );
                }

                grdContact.DataSource = _dtContact;

                grdContact.Refresh();

                _contact = new ClassContact();
            }
        }

        #endregion

        #endregion

        #region Get  Contacts

        public List<ClassContact> GetContacts(ClassContact contact, StatusHasDitailEnum statusHasDitail)
        {
            return _contactBLL.GetContact(contact, statusHasDitail);
        }

        #endregion

        #region  Delete Contact  

        private ServerValidationEnum DeleteContact(int contactID)
        {
            return
            _contactBLL.DeleteContact(contactID);
        }

        #endregion    

        #region Metodes

        #region Set Form

        public void SetForm()
        {
            this.FindForm().Text = Form_Res.FT_ContactList;

            this.FindForm().Icon = Form_Res.IconContactList;

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

        private void PrepareControls()
        {
            grdContact.RootTable.SortKeys.Clear();

            grdContact.RootTable.SortKeys.Add
                (
                    new Janus.Windows.GridEX.GridEXSortKey(grdContact.RootTable.Columns["ID"])
                );

            this.FindForm().Text =
                Contact_Res.FormContactListTitle;

            if (_formMode == FormModeEnum.Select)
                btnDelete.Enabled =
                    btnNew.Enabled =
                    btnUpdate.Enabled =
                    cmsGrid.Enabled = false;
            
        }

        #endregion

        #region InitializeTables

        private void InitializeTables()
        {
            _dtContact.Columns.AddRange
             (
                 new DataColumn[]
                 {
                        new DataColumn("ID",typeof(int)),
                        new DataColumn("Code",typeof(string)),
                        new DataColumn("FirstName",typeof(string)),
                        new DataColumn("LastName",typeof(string)),                        
                        new DataColumn("NationalCode",typeof(string)),
                        new DataColumn ("FatherName",typeof(string)),
                        new DataColumn("AddressList",typeof(string)),
                        new DataColumn("PhoneList",typeof(string)),
                 }
             );
        }

        #endregion

        #region Call Form

        #region Call The New Contact Form   

        private DialogResult CallTheNewContactForm()
        {
            ClassContact contact = new ClassContact();

            UserControl InsertContact =
                new UC_Contact_Insert_Update(contact, FormModeEnum.New);

            return ShowForm.Show(InsertContact);
        }

        #endregion

        #region call The Edit  Contact Form       

        public DialogResult CallTheEditContactForm(ClassContact contact)
        {
            UserControl ContactUpdate = new UC_Contact_Insert_Update
            (
                contact,
               FormModeEnum.Edit
            );
            return ShowForm.Show(ContactUpdate); 
        }

        #endregion

        #endregion

        #region ReLoadData

        public void ReLoadData()
        {
            _contact = new ClassContact();

            FillDataInControls();
        }

        #endregion

        #endregion

        #region Validation

        public bool Validation
            (
                ValidationTypeEnum validationTypeEnum,
                ServerValidationEnum? validationResult = null
            )
        {
            switch (validationTypeEnum)
            {
                case ValidationTypeEnum.Client:
                    {
                        return true;
                    }

                case ValidationTypeEnum.Server:
                    {
                        switch (validationResult)
                        {
                            case ServerValidationEnum.NoProblem:
                                {
                                    ShowMessage.ShowSuccessMessage(Common_Res.Success);

                                    return true;
                                }
                            case ServerValidationEnum.Error:
                                {
                                    ShowMessage.ShowSuccessMessage(Common_Res.OperationFailed);

                                    return false;
                                }

                            case ServerValidationEnum.ThereIsTransaction:
                                {
                                    ShowMessage.ShowErrorMessage(Contact_Res.NoDeleteContact);

                                    return false;
                                }
                            default:
                                return false;
                        }
                    }

                default:
                    return true;
            }
        }

        #endregion

        #region Clear  Contorls

        public void ClearControls()
        {
            txtCode.Text =
                txtFatherName.Text =
                txtFirstName.Text =
                txtLastName.Text =
                txtNationalCode.Text = string.Empty;

            grdContact.RemoveFilters();

            grdContact.DataSource = null;
        }

        #endregion

        #region Events

        #region Load User Controls 

        private void UC_Contact_List_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            PrepareControls();

            FillDataInControls();
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

        private void GrdContact_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            if (_formMode == FormModeEnum.Select)
            {
                _contactSelect.ID =  Convert.ToInt32(grdContact.GetValue("ID").ToString());

                _contactSelect.Code =  grdContact.GetValue("Code").ToString();

                ClassContact contact = new ClassContact();

                contact = GetContacts(_contactSelect, StatusHasDitailEnum.No).SingleOrDefault();

                _contactSelect.FirstName = contact.FirstName;

                _contactSelect.LastName = contact.LastName;

                this.FindForm().DialogResult = DialogResult.Yes;
            }
        }

        #endregion

        #region Button

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var CustomerID = grdContact.GetValue("ID");

            if (CustomerID != null)
            {
                var UserResponseStatus =
                  ShowMessage.ShowQuestionMessage(Contact_Res.AreYouDeleteContact);

                if (UserResponseStatus == DialogResult.Yes)

                    Validation(ValidationTypeEnum.Server, DeleteContact(Convert.ToInt32(CustomerID)));

                ReLoadData();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            CallTheNewContactForm();

            FillDataInControls();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetUIData();

            GetContacts(_contact, StatusHasDitailEnum.Yes);

            FillDataInControls();
        }

        private void BtnResat_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (grdContact.GetValue("ID") != null)
            {
                _contact.ID = Convert.ToInt32(grdContact.GetValue("ID").ToString());

                List<ClassContact> Customerlist = new List<ClassContact>();

                Customerlist = GetContacts(_contact, StatusHasDitailEnum.Yes);

                if (Customerlist == null)

                    return;

                var FormStatus = CallTheEditContactForm(Customerlist[0]);

                if (FormStatus == DialogResult.Yes)

                    ReLoadData();
            }
        }

        #endregion

        #endregion    
    }
}
