using System;
using System.Windows.Forms;
using Cactus.Common.Model;
using static Cactus.Common.Model.ModelUtility;
using Cactus.SystemManagement.Bll;
using Cactus.SystemManagement.UI.Resources;
using Cactus.Common;
using Cactus_SubSystem_Model;
using Cactus.Common.Interface;

namespace Cactus.SystemManagement.UI
{
    public partial class UC_Update_CurrentUser : UserControl, IFindForm
    {
        #region Member      

        private User _user;

        private string _confirmPassword;

        private IUserBLL _userBLL;

        private string _previousPassword;

        #endregion

        #region Constructors

        public UC_Update_CurrentUser(IUserBLL userBLL)
        {
            _userBLL = userBLL;

            InitializeComponent();

            _user = new User();
        }      

        #endregion

        #region Get Data UI

        public void GetDataUI()
        {
            _user.UserName = txtUserName.Text.Trim();

            _previousPassword = txtPreviousPassword.Text.Trim();

            _user.Password = txtNewPassword.Text.Trim();

            _confirmPassword = txtConfirmPass.Text.Trim();
        }

        #endregion

        #region Update User

        private ServerValidationEnum UpdateUser()
        {
            _user.ID = CurrentUser.currentUser.ID;

            return
                 _userBLL.UpdateCurrentUser(_user);
        }

        #endregion

        #region Metods 

        public void SetForm()
        {
            this.FindForm().Icon = Common_Res.Cactus_icon___Copy;
        }

        private bool IsvalidConfirmPassword()
        {
            bool result = _confirmPassword == _user.Password ? true : false;

            return result;
        }

        private bool IsValidPreviousPassword()
        {
            bool result = CurrentUser.currentUser.Password == _previousPassword ? true : false;

            return result;
        }

        private bool IsEmptyControls()
        {
            if (_confirmPassword == string.Empty) return true;
            if (_previousPassword == string.Empty) return true;
            if (_user.Password == string.Empty) return true;
            if (_user.UserName == string.Empty) return true;

            return false;
        }

        private void CloseCurrentForm()
        {
            this.FindForm().DialogResult = DialogResult.No;
        }

        #endregion

        #region Validation

        private bool Validation(ValidationTypeEnum validationTypeEnum, ServerValidationEnum? serverValidationEnum = null)
        {
            switch (validationTypeEnum)
            {
                case ValidationTypeEnum.Client:
                    {
                        bool result;

                        if (IsEmptyControls())
                        {
                            ShowMessage.ShowErrorMessage(Common_Res.NothingEnterInformation);

                            return false;
                        }

                        result = IsValidPreviousPassword();

                        if (!result)
                        {
                            ShowMessage.ShowErrorMessage(User_Res.NoValidPreviousPass);

                            return false;
                        }

                        result = IsvalidConfirmPassword();

                        if (!result)
                        {
                            ShowMessage.ShowErrorMessage(User_Res.NoValidConfirmPass);

                            return false;
                        }

                        return true;
                    }
                case ValidationTypeEnum.Server:
                    {
                        switch (serverValidationEnum)
                        {
                            case ServerValidationEnum.Error:
                                {
                                    ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);

                                    return false;
                                }

                            case ServerValidationEnum.NoProblem:
                                {
                                    ShowMessage.ShowSuccessMessage(Common_Res.Success);

                                    return true;
                                }

                            case ServerValidationEnum.DuplicateUserName:
                                {
                                    ShowMessage.ShowErrorMessage(User_Res.DuplicateUserName);

                                    return false;
                                }

                            default:
                                return false;
                        }
                    }
                default:
                    return false;
            }
        }

        #endregion

        #region Event

        private void UC_Update_CurrentUser_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GetDataUI();

            bool result = Validation(ValidationTypeEnum.Client);

            if (!result)
                return;

            result = Validation(ValidationTypeEnum.Server, UpdateUser());

            if (result)
            {
                CurrentUser.UpdateCurrentUser(_user);

                this.FindForm().Close();
            }
        }

        private void BtnCloseWindoiw_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        #endregion


    }
}
