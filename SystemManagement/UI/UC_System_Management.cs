using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cactus.Common.Interface;
using Cactus.Common;
using Cactus.SystemManagement.UI.Resources;

namespace Cactus.SystemManagement.UI
{
    public partial class UC_System_Management : UserControl ,IUserControl ,IFindForm
    {
        #region Constructor

        public UC_System_Management()
        {
            InitializeComponent();
        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            this.FindForm().Text = Resources.Form_Res.FT_SystemManagement;

            this.FindForm().Icon =Common_Res.Cactus_icon___Copy;

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

        private void UC_System_Management_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();
        }

        private void TreeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Index == 0)
            {
                UC_User_List ucUsers = new UC_User_List();

                GbControl.Controls.Add(ucUsers);
            }
            if (e.Node.Index == 1)
            {
                GbControl.Controls.Clear();

                DialogResult result = new DialogResult();

                UserControl ucServer = DependencyInjector.Retrieve<UC_Server>();

                result = ShowForm.Show(ucServer,true);   
            }

        }

        #endregion
    }
}
