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
    public partial class UC_Add_Phone : UserControl, IUserControl, IFindForm
    {

        #region Member

        private Phone _phone;

        private IContactBLL _contactBLL;

        #endregion

        #region constructor 

        public UC_Add_Phone()
        {
            _contactBLL = DependencyInjector.Retrieve<ContactBLL>();

            InitializeComponent();
        }

        public UC_Add_Phone(Phone phone) : this()
        {
            _phone = new Phone();

            _phone = phone;
        }

        #endregion

        #region Get UI Data

        public void GetUIData()
        {
            _phone.ID = new Random().Next(0, 100);

            _phone.PhoneNumber = txtPhoneNumber.Text == "" ? null : txtPhoneNumber.Text;
            _phone.PhoneType = (int)cmbPhoneType.SelectedItem.Value;
            _phone.RecordStatus = (int)RecordStatusEnum.Insert;

        }

        #endregion

        #region Fill Data In Controls

        public void FillDatatInControls()
        {
            DataTable dataTable = new DataTable();

            dataTable = GetPhoneType();

            if (dataTable != null)
                foreach (DataRow row in dataTable.Rows)
                    cmbPhoneType.Items.Add
                    (
                        row["Type"].ToString(),
                        Convert.ToInt32(row["ID"].ToString())
                    );
        }

        #endregion

        #region Prepare Controls 

        private void PrepareControls()
        {
            cmbPhoneType.Text = Resources.Contact_Res.ComboboxDefaultValue;
        }

        #endregion

        #region Get PhoneType

        private DataTable GetPhoneType()
        {
            return
                _contactBLL.GetPhoneAndAddressType(TypeEnum.PhoneType);

        }

        #endregion

        #region Metods

        #region Set Form 

        public void SetForm()
        {
            this.FindForm().Text = Resources.Form_Res.FT_Phone;
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

        #region Validation

        public bool Validation(ValidationTypeEnum validationEnum)
        {
            switch (validationEnum)
            {
                case ValidationTypeEnum.Client:
                    {
                        if (txtPhoneNumber.Text.Trim() == "" || cmbPhoneType.SelectedItem == null)
                        {
                            ShowMessage.ShowErrorMessage
                                (Resources.Contact_Res.NothingEnterInformation);

                            return false;
                        }

                        GetUIData();

                        if (_phone.IsValidPhone() == ClientValidationEnum.PhonePatternIsIncorrect)
                        {
                            ShowMessage.ShowErrorMessage
                                (Resources.Contact_Res.PhonePatternIncorrect);

                            return false;
                        }

                        return true;
                    }

                case ValidationTypeEnum.Server:

                    return true;

                default:

                    return false;
            }
        }

        #endregion

        #region Events

        #region Load User Controls

        private void UC_Add_Phone_Load(object sender, EventArgs e)
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

        #region TextBox

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        #endregion

    }
}
