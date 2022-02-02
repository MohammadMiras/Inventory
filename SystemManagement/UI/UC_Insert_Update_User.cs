using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cactus.Common.Model;
using static Cactus.Common.Model.ModelUtility;
using Cactus.SystemManagement.Bll;
using Cactus.SystemManagement.UI.Resources;
using Cactus.Common;
using Cactus.Common.Interface;
using Cactus_SubSystem_Model;
using Unity.Resolution;

namespace Cactus.SystemManagement.UI
{
    public partial class UC_Insert_Update_User : UserControl , IUserControl , IFindForm
    {
        #region Member

        private DataTable _dtRols;

        private User _user;

        private FormModeEnum _formMode;

        private IRoleBLL _roleBLL;

        private IUserBLL _userBLL;

        #endregion

        #region  Constructors

        public UC_Insert_Update_User()
        {
            _userBLL = DependencyInjector.Retrieve<UserBLL>();

            _roleBLL = DependencyInjector.Retrieve<RoleBLL>();

            _user = new User();

            _dtRols = new DataTable();

            _formMode = FormModeEnum.New;
             
            InitializeComponent();
        }

        public UC_Insert_Update_User(User user) : this()
        {
            _formMode = FormModeEnum.Edit;

            _user = user;
        }

        #endregion

        #region Get Data UI

        private void GetDataUI()
        {
            _user.UserName = txtUserName.Text.Trim();

            _user.Password = txtPassword.Text.Trim();
        }

        #endregion

        #region Fill Data Controls

        private void FillDataControls()
        {
            txtUserName.Text = _user.UserName;

            txtPassword.Text = _user.Password;

            grdRole.DataSource = _dtRols;

            DataTable dataTable = new DataTable();

            dataTable = (DataTable)grdRole.DataSource;

            foreach (Role role in _user.RoleList)
            {
                if (role.RecordStatus!=(int) RecordStatusEnum.Delete)
                {
                    string Where = string.Format("RoleID = {0}", role.ID);

                    DataRow dr = dataTable.Select(Where).FirstOrDefault();

                    dr["RecordStatus"] = 1;
                }
            }
        }

        #endregion

        #region Insert User

        private ServerValidationEnum InsertUser()
        {
            return _userBLL.InsertUser(_user);
        }

        #endregion

        #region Update User

        private ServerValidationEnum UpdateUser()
        {
            return _userBLL.UpdateUser(_user);
        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            if (_formMode == FormModeEnum.New)
            {
                this.FindForm().Text = Form_Res.FT_NewUser;

                this.FindForm().Icon = Form_Res.IconNewUser;
            }

            else
            {
                this.FindForm().Text = Form_Res.FT_EditUser;

                this.FindForm().Icon = Form_Res.IconUserEdit;
            }
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
            grdRole.DataSource = _dtRols;

            grdRole.Refetch();
        }

        #endregion

        #region Get Rols

        private void GetRols()
        {
            _dtRols = _roleBLL.GetAllRole();
        }

        #endregion

        #region Reload Data

        private void ReloadData()
        {
            GetRols();

            FillDataControls();
        }

        #endregion

        #endregion

        #region Validation

        private bool Validation(ValidationTypeEnum validationType, ServerValidationEnum? serverValidation = null)
        {
            switch (validationType)
            {
                case ValidationTypeEnum.Client:
                    {
                        if (_user.UserName.Trim() == "" || _user.Password.Trim() == "")
                        {
                            ShowMessage.ShowErrorMessage(Common_Res.NothingEnterInformation);

                            return false;
                        }
                        return true;
                    }
                case ValidationTypeEnum.Server:
                    {
                        switch (serverValidation)
                        {
                            case ServerValidationEnum.NoProblem:
                                {
                                    ShowMessage.ShowSuccessMessage(Common_Res.Success);

                                    return true;
                                }
                            case ServerValidationEnum.Error:
                                {
                                    ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);

                                    return false;
                                }
                            case ServerValidationEnum.DuplicateUserName:
                                {
                                    ShowMessage.ShowErrorMessage(User_Res.DuplicateUserName);

                                    return false;
                                }
                            case ServerValidationEnum.noRole:
                                {
                                    ShowMessage.ShowErrorMessage(User_Res.NoRole);

                                    return false;
                                }
                            case ServerValidationEnum.ConversionUserName:
                                {
                                    ShowMessage.ShowErrorMessage(User_Res.ChangeUserName);

                                    return false;
                                }
                        }

                        return false;
                    }

                default:
                    break;
            }

            return false;
        }

        #endregion

        #region Clear Controls

        private void ClearControls()
        {
            txtPassword.Text =
                 txtUserName.Text = string.Empty;

            _user = new User
            {
                RoleList = new List<Role>()
            };

            GetRols();

            FillDataControls();
        }

        #endregion

        #region Event

        #region Load  User Control

        private void UC_Insert_Update_User_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            GetRols();

            PrepareControls();

            FillDataControls();
        }

        #endregion

        #region Grid

        private void GrdRole_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Role role = new Role
            {
                ID = int.Parse(grdRole.GetValue("RoleID").ToString()),

                RecordStatus = (int)RecordStatusEnum.Insert
            };

            foreach (Role roleitem in _user.RoleList)
            {
                if (role.ID == roleitem.ID)
                {
                    switch (roleitem.RecordStatus)
                    {
                        case (int)RecordStatusEnum.Insert:
                            {
                                _user.RoleList.Remove(roleitem);

                                return;
                            }
                        case (int)RecordStatusEnum.Update:
                            break;
                        case (int)RecordStatusEnum.Delete:
                            {
                                roleitem.RecordStatus = (int)RecordStatusEnum.Fix;

                                return;
                            }
                        case (int)RecordStatusEnum.Fix:
                            {
                                roleitem.RecordStatus = (int)RecordStatusEnum.Delete;
                                return;
                            }
                        default:
                            break;
                    }
                }
            }

            _user.RoleList.Add(role);
        }

        #endregion

        #region Button

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GetDataUI();

            bool result = Validation(ValidationTypeEnum.Client);

            if (!result)
                return;

            if (_formMode == FormModeEnum.New)
            {
                result = Validation(ValidationTypeEnum.Server, InsertUser());

                if (result)

                    ClearControls();
            }

            else
            {
                result = Validation(ValidationTypeEnum.Server, UpdateUser());

                if (result)

                    this.FindForm().DialogResult = DialogResult.Yes;
            }
        }

        private void BtnNewRole_Click(object sender, EventArgs e)
        {
            UC_Insert_Update_Role ucRole = 
                new UC_Insert_Update_Role();

            ShowForm.Show(ucRole);

            ReloadData();
        }

        private void BtnEditRole_Click(object sender, EventArgs e)
        {
            if (grdRole.CurrentRow != null)
            {
                DataTable dataTable = new DataTable();

                dataTable = (DataTable)grdRole.DataSource;

                int RoleID = Convert.ToInt32(grdRole.GetValue("RoleID").ToString());

                Role role = new Role();

                role = _roleBLL.GetRoleDetile(RoleID);

                UC_Insert_Update_Role ucRole = 
                    new UC_Insert_Update_Role(role);

                ShowForm.Show(ucRole);

                ReloadData();
            }
        }

        #endregion

        #endregion
    }
}
