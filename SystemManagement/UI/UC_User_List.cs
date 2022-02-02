using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Cactus.Common.Model;
using Cactus.SystemManagement.Bll;
using Cactus.SystemManagement.UI.Resources;
using Cactus.Common;
using Cactus_SubSystem_Model;
using Unity.Resolution;

namespace Cactus.SystemManagement.UI
{
    public partial class UC_User_List : UserControl
    {
        #region Member

        private DataTable _dtUser;

        private User _User;

        private IUserBLL _userBll;

        #endregion

        #region Constructor

        public UC_User_List()
        {
            _userBll = DependencyInjector.Retrieve<UserBLL>();

            InitializeComponent();
        }

        #endregion

        #region Get Data UI

        private void GetDataUI()
        {
            _User.UserName = txtUserName.Text.Trim();
        }

        #endregion

        #region Fill Data Controls

        private void FillDataControls()
        {
            grdUser.DataSource = _dtUser;

            grdUser.Refetch();
        }

        #endregion

        #region Get User

        private void GetUser()
        {
            List<User> users = new List<User>();

            users = _userBll.SearchUserFull(_User);

            ConvertToDataTable(users);
        }

        private User GetUserDitile(int ID)
        {
            return _userBll.GetUserDetile(ID);
        }

        #endregion

        #region Delete User

        private bool DeleteUser(int userID)
        {
            return _userBll.DeleteUser(userID);
        }

        #endregion

        #region  Metods

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region Initialize Member

        private void InitializeMember()
        {
            _dtUser = new DataTable();

            InitializeTable();

            _User = new User();
        }

        #endregion

        #region InitializeTable

        private void InitializeTable()
        {
            _dtUser.Columns.AddRange
            (
                new DataColumn[]
                {
                    new DataColumn("UserID",typeof(int)),
                    new DataColumn("UserName",typeof(string)),
                    new DataColumn ("Title",typeof(string))
                }
            );
        }

        #endregion

        #region ConvertTo DataTable

        private void ConvertToDataTable(List<User> users)
        {
            _dtUser.Rows.Clear();

            foreach (User user in users)
            {
                string roleTitle = "";

                foreach (Role role in user.RoleList)

                    roleTitle += role.Title + " / ";

                if (roleTitle.Length > 2)

                    roleTitle = roleTitle.Remove(roleTitle.Length - 2, 1);

                _dtUser.Rows.Add
                    (
                       user.ID,
                       user.UserName,
                       roleTitle
                    );
            }
        }

        #endregion

        #region ReLoad Data Controls

        private void ReloadData()
        {
            InitializeMember();

            GetUser();

            FillDataControls();
        }

        #endregion

        #endregion

        #region Clear Controls

        private void ClearControls()
        {
            txtUserName.Text = string.Empty;

            InitializeMember();

            _dtUser.Clear();

            FillDataControls();
        }

        #endregion

        #region Event

        #region  Load  User Controls 

        private void UC_User_List_Load(object sender, EventArgs e)
        {
            SettingUserControl();

            InitializeMember();

            GetUser();

            FillDataControls();
        }

        #endregion

        #region Button

        #region btn New 

        private void BtnNew_Click(object sender, EventArgs e)
        {
            UserControl ucInsertUser = new UC_Insert_Update_User();

            ShowForm.Show(ucInsertUser);

            ReloadData();
        }

        #endregion

        #region ben Search 

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetDataUI();

            GetUser();

            FillDataControls();
        }

        #endregion

        #region btn Update

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdUser.CurrentRow == null)

                    return;

                int userID = Convert.ToInt32(grdUser.GetValue("UserID").ToString());

                User user = new User();

                user = GetUserDitile(userID);

                user.ID = userID;

                UserControl ucUpdate =
                   new UC_Insert_Update_User(user);

                ShowForm.Show(ucUpdate);

                ReloadData();
            }
            catch (Exception)
            {
                ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);
            }
        }

        #endregion

        #region btn Delete 

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (grdUser.CurrentRow == null)

                return;

            var formResult =
                ShowMessage.ShowQuestionMessage(User_Res.AreYouDeleteUser);

            if (formResult == DialogResult.Yes)
            {
                int userID = Convert.ToInt32(grdUser.GetValue("UserID").ToString());

                bool result = DeleteUser(userID);

                if (result)

                    ShowMessage.ShowSuccessMessage(Common_Res.Success);

                else
                    ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);

                ReloadData();

            }

        }

        #endregion

        #region btn Resat

        private void BtnResat_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        #endregion

        #endregion

        #endregion

    }
}
