using System;
using System.Drawing;
using System.Windows.Forms;
using Cactus.Common.Model;
using Cactus.Core.Bll;
using static Cactus.Common.Model.ModelUtility;
using Cactus.Common.Interface;
using Cactus.Common;
using Cactus.Core.Model;

namespace Cactus.Core.UI.UserControls
{
    public partial class UC_Login : UserControl ,IFindForm
    {
        #region Member

        private User _user;

        private ILoginBLL _loginBLL;

        #endregion

        #region Constructors

        public UC_Login(User user , ILoginBLL loginBLL) 
        {
            _user = user;

            _loginBLL = loginBLL;

            InitializeComponent();
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
            txtPassword.Text = CurrentUser.currentUser.Password;

            txtUserName.Text = CurrentUser.currentUser.UserName; 
        }

        #endregion

        #region Metods

        public void SetForm()
        {
            this.FindForm().FormBorderStyle = FormBorderStyle.None;

            this.FindForm().Icon =General_Res.Cactus_icon;

            this.FindForm().AutoSize = false;

            this.FindForm().BackColor = Color.FromArgb(0, 92, 230);
        }

        private void CallServerForm()
        {
          

            UserControl ucServer = 
                Faced.SystemManagement.GetUcServer();

            ShowForm.Show(ucServer,true);
        }

        private bool IsValidUser()
        {
            UserValidationResult result;

            result = _loginBLL.IsValidUser(_user);

            if (result.ServerValidation != ServerValidationEnum.NoProblem)
            {
                if (result.ServerValidation == ServerValidationEnum.NovalidUser)

                    ShowMessage.ShowErrorMessage(General_Res.NoValidUser);

                if (result.ServerValidation == ServerValidationEnum.Error)

                    ShowMessage.ShowErrorMessage(General_Res.NoCommunication);

                return false;
            }

            _user.ID = result.UserID;

            return true;
        }

        private void StopTimerAll()
        {
            TLbl1.Enabled =
            Tlbl2.Enabled =
            Tlbl3.Enabled =
            Tlbl4.Enabled =
            Tlbl4Stop.Enabled = 
            TCoordinator.Enabled = false;
        }

        #endregion

        #region Event

        private void UCLogin_Load(object sender, EventArgs e)
        {
            SetForm();

            ConnectionString.SetCurrentConnectionString();

            CurrentUser.SetCurrentUser();

            FillDataControls();

            TCoordinator.Start();
        }

        private void BtnSettingsServer_Click(object sender, EventArgs e)
        {
            CallServerForm();          
        }

        private void CbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void PbCloseForm_Click(object sender, EventArgs e)
        {
            this.FindForm().DialogResult = DialogResult.No;
        } 

        private void BtnLoging_Click(object sender, EventArgs e)
        {
            GetDataUI();

            bool Result = true;

            Result = IsValidUser();

            if (Result)
            {
                StopTimerAll();

                CurrentUser.SetCurrentUser(_user);

                User user = new User();

                user = _loginBLL.GetUserDetile(_user.ID);

                user.ID = _user.ID;

                CurrentUser.SetCurrentUser(user);

                this.FindForm().DialogResult = DialogResult.Yes;

                this.FindForm().Close();
            }
        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnLoging_Click(new object(), new EventArgs());

                txtPassword.Text =
                    txtUserName.Text = string.Empty;
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)

                BtnLoging_Click(new object(), new EventArgs());
        }
        
        // Timer For Lbl 1 = و

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TLbl1.Stop();

            lblTL1.Padding = new Padding(0, 0, 0, 10);//lbl و 

            lblTL4.Padding = new Padding(0, 0, 0, 0);
        }  
        
        // Timer For Lbl 2 = ر

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Tlbl2.Stop();

            lblTL2.Padding = new Padding(0, 0, 0, 10);

            lblTL1.Padding = new Padding(0, 0, 0, 0);//lbl و 
        }  
       
        // Timer For Lbl 3 = و

        private void Tlbl3_Tick(object sender, EventArgs e)
        {
            Tlbl3.Stop();

            lblTL3.Padding = new Padding(0, 0, 0, 10);

            lblTL2.Padding = new Padding(0, 0, 0, 0);//lbl و 
        }  
        
        // Timer For Lbl 4 = د

        private void Tlbl4_Tick(object sender, EventArgs e)
        {
            Tlbl4.Stop();

            lblTL4.Padding = new Padding(0, 0, 0, 10);

            lblTL3.Padding = new Padding(0, 0, 0, 0);//lbl و         

            Tlbl4Stop.Start();
        }   

        private void TCoordinator_Tick(object sender, EventArgs e)
        {
            TCoordinator.Stop();
            TLbl1.Start();
            Tlbl2.Start();
            Tlbl3.Start();
            Tlbl4.Start();
        } 

        // Timer Stop Animation

        private void Tlbl4Stop_Tick(object sender, EventArgs e)
        {
            Tlbl4Stop.Stop();

            lblTL4.Padding = new Padding(0, 0, 0, 0);//lbl و  

            TCoordinator.Start();
        } 

        #endregion       
    }
}
