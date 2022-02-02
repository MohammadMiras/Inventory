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
using Cactus.SystemManagement.Bll;
using static Cactus.Common.Model.ModelUtility;
using Cactus.Common;
using Cactus.Common.Interface;
using Cactus_SubSystem_Model;

namespace Cactus.SystemManagement.UI
{
    public partial class UC_Insert_Update_Role : UserControl ,IUserControl ,IFindForm
    {
        #region Member

        private Role _role;

        private DataTable _dtobj;

        private IRoleBLL _roleBLL;

        private IObjSystemBLL _objSystemBLL;

        private FormModeEnum _formMode;

        #endregion

        #region Constructor

        public UC_Insert_Update_Role()
        {
            InitializeMember();

            _roleBLL = DependencyInjector.Retrieve<RoleBLL>();

            _objSystemBLL = DependencyInjector.Retrieve<ObjSystemBLL>();

            _formMode = FormModeEnum.New;

            InitializeComponent();
        }

        public UC_Insert_Update_Role(Role role):this()
        {
            _role = role;

            _formMode = FormModeEnum.Edit;
        }

        #region Ctor  From Test  
        //public UC_Insert_Update_Role(Role role,IRoleBLL roleBLL, IObjSystemBLL objSystemBLL  , FormModeEnum formMode) 
        //{
        // this  is Ctor  From  Test  

        //    _role = role;

        //    _roleBLL = roleBLL;

        //    _objSystemBLL = objSystemBLL;

        //    _formMode = formMode;

        //    InitializeComponent();

        //} 
        #endregion

        #endregion

        #region Get Data  UI

        private void GetDataUI()
        {
            _role.Title = txtTitle.Text.Trim();
        }

        #endregion

        #region Fill data Controls

        private void FillDataControls()
        {
            txtTitle.Text = _role.Title == null ? _role.Title : _role.Title.Trim();

            grdObj.DataSource = _dtobj;

            DataTable dataTable = new DataTable();

            dataTable = (DataTable)grdObj.DataSource;

            foreach (ObjSystem obj in _role.AllSystemObj)
            {
                string Where = string.Format("ObjectID= {0}", obj.ID);

                DataRow dr = dataTable.Select(Where).FirstOrDefault();

                dr["RecordStatus"] = 1;

            }

            grdObj.Refetch();
        }

        #endregion

        #region Insert Rols

        private ServerValidationEnum InsertRole()
        {
            return _roleBLL.InsertRole(_role);
        }

        #endregion

        #region Update Rols

        private ServerValidationEnum UpdateRole()
        {
            return _roleBLL.UpdateRole(_role);
        }

        #endregion

        #region Metods


        #region Set Form 

        public void SetForm()
        {
            this.FindForm().MaximizeBox = false;

            this.FindForm().FormBorderStyle = FormBorderStyle.Fixed3D;

            if (_formMode == FormModeEnum.New)
            {
                this.FindForm().Text = Resources.Form_Res.FT_NewRole;

                this.FindForm().Icon = Resources.Form_Res.IconRole;
            }

            else
            {
                this.FindForm().Text = Resources.Form_Res.FT_EditRole;

                this.FindForm().Icon = Resources.Form_Res.IconRole;
            }
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
            _dtobj = new DataTable();

            _role = new Role();

            _formMode = new FormModeEnum();
        }

        #endregion

        #region Get Obj System 

        public void GetObjSystem()
        {
            _dtobj = 
                _objSystemBLL.GetAllObjSystem();
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
                        if (_role.Title.Trim() == "")
                        {
                            ShowMessage.ShowErrorMessage(Resources.Common_Res.NothingEnterInformation);

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
                                    ShowMessage.ShowSuccessMessage(Resources.Common_Res.Success);

                                    return true;
                                }

                            case ServerValidationEnum.Error:
                                {
                                    ShowMessage.ShowErrorMessage(Resources.Common_Res.OperationFailed);

                                    return false;
                                }

                            case ServerValidationEnum.DuplicateRoleTitle:
                                {
                                    ShowMessage.ShowErrorMessage(Resources.User_Res.DuplicateRoleTitle);

                                    return false;
                                }
                        }

                        break; 
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
            txtTitle.Text = string.Empty;

            InitializeMember();

            GetObjSystem();

            FillDataControls();
        }

        #endregion

        #region Event

        #region Load User Controls

        private void UC_Insert_Update_Role_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            GetObjSystem();

            FillDataControls();
        }
        #endregion

        #region Grid

        private void GrdObj_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

            ObjSystem obj = new ObjSystem();

            obj.ID = int.Parse(grdObj.GetValue("ObjectID").ToString());

            obj.RecordStatus = RecordStatusEnum.Insert;

            foreach (ObjSystem objSystem in _role.AllSystemObj)
            {
                if (obj.ID == objSystem.ID)
                {
                    switch (objSystem.RecordStatus)
                    {
                        case RecordStatusEnum.Insert:
                            {
                                _role.AllSystemObj.Remove(objSystem);

                                return;
                            }

                        case RecordStatusEnum.Update:
                            break;
                        case RecordStatusEnum.Delete:
                            {
                                objSystem.RecordStatus = RecordStatusEnum.Fix;

                                return;
                            }
                        case RecordStatusEnum.Fix:
                            {
                                objSystem.RecordStatus = RecordStatusEnum.Delete;
                                return;
                            }
                        default:
                            break;
                    }
                }
            }

            _role.AllSystemObj.Add(obj);
        }
        #endregion

        #region Button 

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GetDataUI();

            bool result = Validation(ValidationTypeEnum.Client);

            if (result)
            {
                if (_formMode == FormModeEnum.Edit)
                {
                    result = Validation(ValidationTypeEnum.Server, UpdateRole());

                    if (result)

                        this.FindForm().DialogResult = DialogResult.Yes;
                }

                else
                {
                    result = Validation(ValidationTypeEnum.Server, InsertRole());

                    if (result)

                        ClearControls();
                }

            }
        }

        #endregion

        #endregion
    }
}
