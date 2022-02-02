using System.Windows.Forms;
using System;
using Cactus.Inventory.UI.CustomControls;
using Cactus.Inventory.UI.Resources;
using Cactus.Common.Interface;

namespace Cactus.Inventory.UI
{
    public partial class UC_Report : UserControl , IUserControl,IFindForm
    {
        #region Member

        private UserControl _ucCardex; 

        private UserControl _ucStockInventory;

        #endregion

        #region Constructor

        public UC_Report()
        {
            _ucCardex = new UC_Cardex_Report ();

            _ucStockInventory = new UC_Stock_Inventory_Report();

            InitializeComponent();            
        }

        #endregion

        #region Metods
        
        #region Setform

        public void SetForm()
        {
            this.FindForm().Text = Form_Res.FT_Report;
            this.FindForm().Icon = Form_Res.IconReport;
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

        #endregion

        #region Event

        #region Load User Control

        private void UC_Report_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();
        }

        #endregion

        #region Tree Menu

        private void TreevMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Index == 1)
            {
                gbReport.Controls.Clear();

                gbReport.Controls.Add(_ucCardex);
            }
            else
            {
                gbReport.Controls.Clear();

                gbReport.Controls.Add(_ucStockInventory);
            }
        } 

        #endregion

        #endregion
    }
}
