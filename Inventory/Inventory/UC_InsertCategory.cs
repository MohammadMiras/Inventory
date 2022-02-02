using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.UI
{
    public partial class UC_InsertCategory : UserControl ,IUserControl,IFindForm
    {
        #region Member

        private Category _category;

        private  IGoodsBLL _goodsBLL;

        private ICategoryBLL _categoryBLL;

        private FormModeEnum _formMode;

        #endregion

        #region Constructor

        public UC_InsertCategory()
        {
            _formMode = new FormModeEnum();

            _category = new Category();

            _goodsBLL = DependencyInjector.Retrieve<GoodsBLL>();

            _categoryBLL = DependencyInjector.Retrieve<CategoryBLL>();

            InitializeComponent();
        }

        public UC_InsertCategory(Category category ,FormModeEnum formMode ):this()
        {
            _formMode = formMode;

            _category = category;
        }

        #endregion

        #region Get UI Data

        private void GetUIData()
        {
            _category.Name = txtTitle.Text.Trim();
        }

        #endregion

        #region Fill Data Controls

        private void FillDataControls()
        {
            txtTitle.Text = _category.Name;
        }

        #endregion

        #region Get Category

        public void GetCategory(Category category)
        {   
            DataTable dataTable = new DataTable();

            dataTable = _categoryBLL.GetCategory(category);

            if (dataTable !=null)

                _category.Name = dataTable.Rows.Cast<DataRow>().Take(1).CopyToDataTable().Rows[0]["Name"].ToString();
        }

        #endregion

        #region Insert Catagory

        private bool InsertCategory(Category category)
        { 
            return _categoryBLL.InsertCategory(category);
        }

        #endregion

        #region Update Category 

        private bool UpdateCategory(Category category)
        {
            return _categoryBLL.UpdateCategory(category);          
        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            this.FindForm().Text = Resources.Form_Res.FT_Category;

            this.FindForm().Icon = Resources.Form_Res.IconTag;

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

        #region Validation

        private bool Validation()
        {
            if (txtTitle.Text.Trim() == "")
                return false;

            return true;
        }

        #endregion

        #region Event

        private void UC_InsertCategory_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            if(_formMode == FormModeEnum.Edit)
                
                GetCategory(_category);

            FillDataControls();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                GetUIData();

                if (_formMode == FormModeEnum.New)
                {
                    if (InsertCategory(_category))
                    {
                        ShowMessage.ShowSuccessMessage(Resources.Goods_Res.SuccessInsert);

                        this.FindForm().DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        ShowMessage.ShowErrorMessage(Resources.Common_Res.OperationFailed);
                    }
                }

                else
                {
                    if (UpdateCategory(_category))
                    {
                        MessageBox.Show(Resources.Goods_Res.SuccessInsert);

                        this.FindForm().DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        ShowMessage.ShowErrorMessage(Resources.Common_Res.OperationFailed);
                    }
                }
                
            }
        }

        #endregion      
    }
}
