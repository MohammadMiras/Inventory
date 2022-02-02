using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Contact.Bll;
using Cactus.Contact.Model;
using System;
using System.Data;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;
using static Cactus.Contact.Model.ModelUtility;

namespace Cactus.Contact.UI
{
    public partial class UC_Add_Address : UserControl, IUserControl, IFindForm
    {
        #region Member

        private Address _address;

        private IContactBLL _contactBLL;

        #endregion

        #region constructor 

        public UC_Add_Address()
        {
            InitializeComponent();
        }

        public UC_Add_Address(Address address) : this()
        {
            _address = new Address();

            _contactBLL = DependencyInjector.Retrieve<ContactBLL>();

            _address = address;
        }

        #endregion

        #region Get UI Data

        public void GetUIData()
        {
            _address.ID =
                new Random().Next(0, 100);

            _address.AddressTitle =
                  txtAddressTitle.Text == "" ? null : txtAddressTitle.Text;

            _address.AddressType =
                    (int)cmbAddressType.SelectedItem.Value;

            _address.RecordStatus =
                (int)RecordStatusEnum.Insert;
        }

        #endregion

        #region Fill Data In Controls

        public void FillDatatInControls()
        {
            DataTable dataTable = new DataTable();

            dataTable = GetAddressType();

            if (dataTable != null)
                foreach (DataRow row in dataTable.Rows)
                    cmbAddressType.Items.Add
                        (
                            row["Type"].ToString(),
                            Convert.ToInt32(row["ID"].ToString())
                        );


        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            this.FindForm().Text = Resources.Form_Res.FT_Address;

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

        #region Prepare Controls 

        private void PrepareControls()
        {
            cmbAddressType.Text = Resources.Contact_Res.ComboboxDefaultValue;
        }

        #endregion

        #region Get AddressType

        private DataTable GetAddressType()
        {
            return
                 _contactBLL.GetPhoneAndAddressType(TypeEnum.AddressType);
        }

        #endregion

        #endregion

        #region Validation

        public bool Validation(ValidationTypeEnum validationEnum)
        {
            switch (validationEnum)
            {
                case ValidationTypeEnum.Client:
                    {
                        if (txtAddressTitle.Text.Trim() == "" || cmbAddressType.SelectedItem == null)
                        {
                            ShowMessage.ShowErrorMessage
                                (Resources.Contact_Res.NothingEnterInformation);

                            return false;
                        }

                        GetUIData();

                        return true;
                    }

                case ValidationTypeEnum.Server:

                    return true;

                default:

                    return false;
            }
        }

        #endregion

        #region  Events 

        #region Load User Controls Add Address

        private void UC_Add_Address_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            FillDatatInControls();
        }

        #endregion

        #region Button       

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Validation(ValidationTypeEnum.Client))

                this.FindForm().DialogResult = DialogResult.Yes;
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
