using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using Cactus.Common.Model;
using Cactus.SystemManagement.Bll;

using Cactus.Common.Interface;
using Cactus.Common;
using Cactus_SubSystem_Model;

namespace Cactus.SystemManagement.UI
{
    public partial class UC_Server : UserControl,IFindForm
    {
        #region Member

        private string _serverName;

        private SqlConnectionStringBuilder _connectionStringBuilder;

        private List<string> _dataBaseNameList;

        private UC_Loding _ucLoading;

        private string _connectionString;

        private IServerBLL _serverBLL;

        #endregion

        #region Constructors

        public UC_Server(IServerBLL serverBLL)
        {
            _connectionStringBuilder = new SqlConnectionStringBuilder();

            _dataBaseNameList = new List<string>();

            _ucLoading = new UC_Loding();

            _serverBLL = serverBLL;

            InitializeComponent();
        }

        #endregion

        #region Get Data UI

        private void GetDataUI()
        {
            string userServer = txtUserServer.Text.Trim();

            string pattern;

            pattern = 
                userServer == string.Empty ? Patterns.ConnectionStringPatternNoUP : Patterns.ConnectionStringPatternWithUP;

            if (userServer != string.Empty )

                _connectionString = string.Format
                    (
                        pattern,
                        _serverName,
                        cmbDataBaseName.Text,
                        txtUserServer.Text,
                        txtPassword.Text
                    );

            else
                _connectionString = string.Format
                    (
                        pattern,
                        _serverName,
                        cmbDataBaseName.Text
                    );
        }

        #endregion

        #region Metods

        public void SetForm()
        {
            this.FindForm().FormBorderStyle = FormBorderStyle.None;

            this.FindForm().BackColor = Color.FromArgb(0, 92, 230);
        }

        private void GetNameServer()
        {
            int value = 0;

            DataTable dataTable = SmoApplication.EnumAvailableSqlServers(false);

            foreach (DataRow row in dataTable.Rows)
            {
                cmbServerName.Items.Add(row["Name"].ToString(), value);

                value++;
            }

            _ucLoading.FindForm().DialogResult = DialogResult.Yes;
        }

        private void GetDatabaseNameList(string Connection)
        {
            try
            {
                List<string> dbNameList = new List<string>(); // Data Base Name  list 

                cmbDataBaseName.Items.Clear();             

                dbNameList = _serverBLL.GetDataBaseName(Connection);

                int value = 0;

                foreach (string dbName in dbNameList)
                {
                    cmbDataBaseName.Items.Add(dbName, value);

                    value++;
                }
            }
            catch (Exception)
            {

            }
        }

        private void CallLoadingForm()
        {
            _ucLoading = new UC_Loding();

            ShowForm.Show(_ucLoading);
        }

        #endregion

        #region Validation

        private bool ValidationClient()
        {
            bool result;

            foreach (TextBox control in this.tblBody.Controls.OfType<TextBox>())

                if (string.IsNullOrWhiteSpace(control.Text.Trim()))

                    return false;

            result = cmbDataBaseName.Text.Trim() == "" || cmbServerName.Text.Trim() == "" ? false : true;

            return result;
        }

        #endregion

        #region Event

        #region Load

        private void UC_ServerSetup_Load(object sender, EventArgs e)
        {
            SetForm();

            var thread1 = new Thread(GetNameServer);

            var thread2 = new Thread(CallLoadingForm);

            thread2.Start();

            thread1.Start();
        }

        #endregion

        #region TextBox

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (cmbServerName.SelectedItem == null)

                return;

            string Conn = string.Format("server={0};User Id={1};" + "pwd={2};", _serverName, txtUserServer.Text, txtPassword.Text);

            GetDatabaseNameList(Conn);
        }

        #endregion

        #region Button

        private void BtnSaveConnection_Click(object sender, EventArgs e)
        {

            if (ValidationClient())
            {
                GetDataUI();

                ConnectionString.SetNewConnectionString(_connectionString);

                ConnectionString.SetCurrentConnectionString();

                this.FindForm().DialogResult = DialogResult.Yes;
            }

            else
                ShowMessage.ShowErrorMessage("");
        }

        private void BtnCloseWindiow_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }

        #endregion

        #region ComboBox

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CmbServerName_SelectedItemChanged(object sender, EventArgs e)
        {
            _serverName = cmbServerName.Text.ToString();
        }

        #endregion

        #endregion
    }
}
