using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Inventory.UI.Resources;
using System;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.UI
{
    public partial class UC_Inventory_Main : UserControl, IUserControl, IFindForm
    {
        #region Constructors 

        public UC_Inventory_Main()
        {
            //ConnectionString.SetCurrentConnectionString();// تنظیم رشته اتصال 

            InitializeComponent();
        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            this.FindForm().Text = Form_Res.FT_Inventory;

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

        #region Events

        private void UC_Inventory_Main_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();
        }

        private void BtnGoods_Click(object sender, EventArgs e)
        {
            bool result =
               ObjectSystemEnum.Goods.CheckAccesslevelUser();

            if (!result)
            {
                UC_Goods_List uC_Goods_List = new UC_Goods_List();

                ShowForm.Show(uC_Goods_List);
            }
            else
            {
                ShowMessage.ShowErrorMessage(Common_Res.NOAccess);
            }

        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            bool result =
                ObjectSystemEnum.Inventory.CheckAccesslevelUser();

            if (!result)
            {
                UserControl uC_Inventory = new UC_Inventory_List();

                ShowForm.Show(uC_Inventory);
            }
            else
            {
                ShowMessage.ShowErrorMessage(Common_Res.NOAccess);
            }
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            bool result =
               ObjectSystemEnum.Transaction.CheckAccesslevelUser();

            if (!result)
            {
                UserControl UCTransaction = new UC_Transaction_List();

                ShowForm.Show(UCTransaction);
            }
            else
            {
                ShowMessage.ShowErrorMessage(Common_Res.NOAccess);
            }

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            bool result =
              ObjectSystemEnum.Report.CheckAccesslevelUser();

            if (!result)
            {
                UserControl cardex = new UC_Report();

                ShowForm.Show(cardex);
            }
            else
            {
                ShowMessage.ShowErrorMessage(Common_Res.NOAccess);
            }
        }

        #endregion

    }
}
