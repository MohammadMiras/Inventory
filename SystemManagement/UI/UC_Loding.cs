using Cactus.Common.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cactus.SystemManagement.UI
{
    public partial class UC_Loding : UserControl ,IFindForm
    {
        #region  Member

        public bool _isCloseForm = false;

        #endregion

        #region Constructor

        public UC_Loding()
        {
            InitializeComponent();

            PrepareControls();
        }

        #endregion

        #region Set Form 

        public void SetForm()
        {
            this.FindForm().FormBorderStyle = FormBorderStyle.None;

            this.FindForm().AutoSize = false;
        }

        #endregion

        #region Prepare Controls

        private void PrepareControls()
        {
           
        }

        #endregion

        #region Evints

        private void UC_Loading_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            if (_isCloseForm)

                this.FindForm().Close();
            else
                timer1.Start();
        }

        #endregion
    }
}
