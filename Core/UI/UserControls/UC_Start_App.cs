using System;
using System.Windows.Forms;
using Cactus.Common.Interface;
using static Cactus.Common.Model.ModelUtility;
using Cactus.Common;
using Cactus.Core.UI;
using Cactus.Common.Model;
namespace Cactus.Core.UI.UserControls
{
    public partial class UC_Start_App : UserControl, IUserControl, IFindForm
    {
        public UC_Start_App()
        {
            InitializeComponent();
        }

        #region Metods

        public void SetForm()
        {
            this.FindForm().Icon = General_Res.Cactus_icon;

            this.FindForm().Text = General_Res.FT_Start;

            this.FindForm().FormBorderStyle = FormBorderStyle.Fixed3D;

            this.FindForm().MaximizeBox = false;
        }

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        public DialogResult CallLogingForm()
        {
            UC_Login login = DependencyInjector.Retrieve<UC_Login>();

            return
                ShowForm.Show(login, true);
        }

        #endregion

        #region Event

        private void Start_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            bool result =
               ObjectSystemEnum.Inventory.CheckAccesslevelUser();

            if (!result)
            {
                UserControl uC_Inventory =
                    Faced.Inventory.GetUserControlMain();

                ShowForm.Show(uC_Inventory);
            }
            else
            {
                ShowMessage.ShowErrorMessage(General_Res.NOAccess);
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            bool result =
               ObjectSystemEnum.Customer.CheckAccesslevelUser();

            if (!result)
            {
                UserControl uC_Customer_List =
                    Faced.Contact.GetUCContactList();

                ShowForm.Show(uC_Customer_List);
            }
            else
            {
                ShowMessage.ShowErrorMessage(General_Res.NOAccess);
            }
        }

        private void btnSystemManagement_Click(object sender, EventArgs e)
        {
            bool result =
             ObjectSystemEnum.SystemManagement.CheckAccesslevelUser();

            if (!result)
            {
                UserControl uc_SysemManagement =
                    Faced.SystemManagement.GetUCSubSystem();

                ShowForm.Show(uc_SysemManagement);
            }
            else
            {
                ShowMessage.ShowErrorMessage(General_Res.NOAccess);
            }
        }

        private void btnUserSetup_Click(object sender, EventArgs e)
        {
            bool result =
           ObjectSystemEnum.UpdateCurrentUser.CheckAccesslevelUser();

            if (!result)
            {
                UserControl UpCurrUser =
                    Faced.SystemManagement.GetUCCurrentUserUpdate();

                ShowForm.Show(UpCurrUser, true);
            }
            else
            {
                ShowMessage.ShowErrorMessage(General_Res.NOAccess);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var resualt = CallLogingForm();

            if (resualt != DialogResult.Yes)

                this.FindForm().Close();

            ConnectionString.SetCurrentConnectionString();
        } 
        #endregion
    }
}
