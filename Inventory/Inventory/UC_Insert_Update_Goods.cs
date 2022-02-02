using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Cactus.Common;
using Cactus.Inventory.BLL;
using Cactus.Inventory.Model;
using Cactus.Inventory.UI.Resources;
using Janus.Windows.GridEX.EditControls;
using static Cactus.Common.Model.ModelUtility;
using Cactus.Common.Utility;
using Cactus.Common.Interface;

namespace Cactus.Inventory.UI
{
    public partial class UC_Insert_Update_Goods : UserControl ,IUserControl,IFindForm
    {
        #region Member

        private Goods _enteredGoods;

        private FormModeEnum _formMode;

        private List<Category> _categoryList;

        private Goods _currentGoods;

        private DataTable _dtCategory;

        private IGoodsBLL _goodsBLL;

        private ICategoryBLL _categoryBLL;

        private List<GoodsUnit> _unitList;

        #endregion

        #region  Constructors

        public UC_Insert_Update_Goods()
        {
            _enteredGoods = new Goods();

            _formMode = new FormModeEnum();

            _categoryList = new List<Category>();

            _dtCategory = new DataTable();

            _goodsBLL = DependencyInjector.Retrieve<GoodsBLL>();

            _categoryBLL = DependencyInjector.Retrieve<CategoryBLL>();

            InitializeComponent();
        }

        public UC_Insert_Update_Goods(Goods goods, FormModeEnum formMode) : this()
        {
            _enteredGoods = goods;

            _formMode = formMode;
        }

        #endregion

        #region Get Data UI

        private void GetDataUI()
        {
            _currentGoods = new Goods();

            _currentGoods.Code = txtGoodsCode.Text.Trim();

            _currentGoods.Name = txtGoodsName.Text.Trim();

            _currentGoods.Weight = float.Parse(txtGoodsWeight.Text.Trim());

            _currentGoods.GoodsUnit = (int)cmbUnit.SelectedItem.Value;

            _currentGoods.ID = _enteredGoods.ID;

            _currentGoods.CategoryGroup = _categoryList;

            _currentGoods.CategoryGroup = _enteredGoods.CategoryGroup;
        }

        #endregion

        #region Fill Data Controls 

        private void FillDataControls(Goods goods)
        {
            txtGoodsCode.Text = goods.Code.Trim();

            txtGoodsName.Text = goods.Name.Trim();

            txtGoodsWeight.Text = goods.Weight.ToString();

            cmbUnit.SelectedValue = goods.GoodsUnit;

            DataTable dataTable = new DataTable();

            dataTable = (DataTable)grdCategory.DataSource;

            foreach (Category category in goods.CategoryGroup)
            {
                if (category.RecordStatus == 0)
                {
                    string Where = string.Format("CategoryID = {0}", category.ID);

                    DataRow dr = dataTable.Select(Where).FirstOrDefault();

                    dr["SelectedStatus"] = 1;
                }
            }
        }

        #endregion

        #region Get Data In DataBase

        #region Get Category

        private DataTable GetAllCategory()
        {
            return _categoryBLL.GetCategory(new Category());
        }

        #endregion

        #region Get Unit

        public void GetUnit()
        {
            _unitList = new List<GoodsUnit>();

            _unitList = _goodsBLL.GetUnits();
        }

        #endregion

        #region Get Weight Unit


        #endregion

        #endregion

        #region Insert Goods

        private ServerValidationEnum InsertGoods(Goods goods)
        {
            return _goodsBLL.InsertGoods(goods);
        }

        #endregion

        #region Update Goods

        private ServerValidationEnum UpdateGoods(Goods goods)
        {
            return _goodsBLL.UpdateGoods(goods);

        }

        #endregion

        #region Metods

        #region Set Form

        public void SetForm()
        {
            if (_formMode == FormModeEnum.New)
            {
                this.FindForm().Text = Form_Res.FT_AddGoods;

                this.FindForm().Icon = Form_Res.IconNewGoods;
            }

            else
            {
                this.FindForm().Text = Form_Res.FT_EditGoods;

                this.FindForm().Icon = Form_Res.IconEditCustomer;
            }
        }

        #endregion

        #region Setting  User Controls

        public void SettingUserControl()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region Prepare Controls

        private void PrepareControls()
        {
            _dtCategory = GetAllCategory();

            grdCategory.DataSource = _dtCategory;

            grdCategory.Refetch();

            GetUnit();

            if (_unitList != null)

                foreach (GoodsUnit unit in _unitList)

                    cmbUnit.Items.Add(unit.Title, unit.ID);
        }

        #endregion

        #region  Checking IS  Controls Empty

        private bool AreControlsEmpty()
        {
            if
                (
                    txtGoodsCode.Text.Trim() == "" ||
                    txtGoodsName.Text.Trim() == "" ||
                    txtGoodsWeight.Text.Trim() == "" ||
                    cmbUnit.SelectedItem == null
                )      
                return true;


            return false;
        }

        #endregion

        #region Delete Category

        private ServerValidationEnum DeleteCategory(int CategoryID)
        {
            return _categoryBLL.DeleteCategory(CategoryID);
        }

        #endregion

        #region Call  The New Category Form  

        private DialogResult CallTheNewCategoryForm()
        {
            UC_InsertCategory UC_InsertCategory = new UC_InsertCategory(new Category(), FormModeEnum.New);

            return ShowForm.Show(UC_InsertCategory);
        }

        #endregion

        #region Call The Category Update Form  

        private DialogResult CallTheCategoryUpdateForm(Category category)
        {
            UC_InsertCategory UC_InsertCategory = new UC_InsertCategory(category, FormModeEnum.Edit);

            return ShowForm.Show(UC_InsertCategory);
        }

        #endregion     

        #endregion

        #region Validation

        public bool Validation(ValidationTypeEnum validationType, ServerValidationEnum? validationResult = null)
        {
            switch (validationType)
            {
                case ValidationTypeEnum.Client:
                    {
                        bool resultControlsEmpty  = AreControlsEmpty();

                        bool resultValueValid = txtGoodsCode.Text.AreCodeValid();

                        if (resultControlsEmpty || !resultValueValid)
                        {
                            ShowMessage.ShowErrorMessage(Goods_Res.NothingEnterInformation);

                            return false;
                        }  

                        return true;
                    }
                case ValidationTypeEnum.Server:
                    {
                        switch (validationResult)
                        {
                            case ServerValidationEnum.DuplicateCode:
                                {
                                    ShowMessage.ShowErrorMessage(Goods_Res.DuplicateGoodsCode);

                                    return false;
                                }
                            case ServerValidationEnum.NoProblem:
                                {
                                    ShowMessage.ShowSuccessMessage(Goods_Res.SuccessInsert);

                                    ClearControls();

                                    return true;
                                }
                            case ServerValidationEnum.ConversionCode:
                                {
                                    ShowMessage.ShowErrorMessage(Goods_Res.ConversionGoodsCode);

                                    txtGoodsCode.Text = _enteredGoods.Code;

                                    return false;
                                }
                            case ServerValidationEnum.Error:
                                {
                                    ShowMessage.ShowErrorMessage(Common_Res.OperationFailed);

                                    return false;
                                }
                            case ServerValidationEnum.NoCategory:
                                {
                                    ShowMessage.ShowErrorMessage(Goods_Res.NoEnterCatgory);

                                    return false;
                                }
                            case ServerValidationEnum.ThereIsCategoryInGoods:
                                {
                                    ShowMessage.ShowErrorMessage(Goods_Res.ThisisCategoryInGoods);

                                    return false;
                                }   
                            default:
                                return false;
                        }
                    }
                default:
                    return false;
            }
        }

        #endregion

        #region Clear Controls

        private void ClearControls()
        {
            txtGoodsCode.Text =
                 txtGoodsWeight.Text =
                 txtGoodsName.Text = string.Empty;

            PrepareControls();
        }

        #endregion

        #region Events

        #region Load UserControls

        private void UC_Insert_Update_Goods_Load(object sender, EventArgs e)
        {
            SetForm();

            SettingUserControl();

            PrepareControls();            

            if (_formMode != FormModeEnum.New)
            {
                List<Goods> goodsList = new List<Goods>();

                goodsList = _goodsBLL.GetGoods(_enteredGoods, StatusHasDitailEnum.Yes);

                _enteredGoods = goodsList[0];

                _enteredGoods.CategoryGroup = goodsList[0].CategoryGroup;

                FillDataControls(_enteredGoods);
            }
        }

        #endregion

        #region Grid

        private void GrdCategory_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Category category = new Category();

            category.ID = int.Parse(grdCategory.GetValue("CategoryID").ToString());

            category.Name = grdCategory.GetValue("Name").ToString();

            foreach (Category categoryItem in _enteredGoods.CategoryGroup)

                if (categoryItem.ID == category.ID)
                {
                    switch (categoryItem.RecordStatus)
                    {
                        case (int)RecordStatusEnum.Insert:
                            {
                                _enteredGoods.CategoryGroup.Remove(categoryItem);
                                return;
                            }

                        case (int)RecordStatusEnum.Delete:
                            {
                                categoryItem.RecordStatus = (int)RecordStatusEnum.Fix;
                                return;
                            }
                        case (int)RecordStatusEnum.Fix:
                            {
                                categoryItem.RecordStatus = (int)RecordStatusEnum.Delete;
                                return;
                            }
                    }
                }

            category.RecordStatus = (int)RecordStatusEnum.Insert;

            _enteredGoods.CategoryGroup.Add(category);

        }

        #endregion

        #region Button

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Validation(ValidationTypeEnum.Client))
            {
                GetDataUI();

                switch (_formMode)
                {
                    case FormModeEnum.New:
                        {
                            if (Validation(ValidationTypeEnum.Server, InsertGoods(_currentGoods)))

                                ClearControls();

                            return;
                        }

                    case FormModeEnum.Edit:
                        {
                            if (Validation(ValidationTypeEnum.Server, UpdateGoods(_currentGoods)))

                                this.FindForm().DialogResult = DialogResult.Yes;

                            return;
                        }
                }

            }
        }

        private void BtnAddCategory_ButtonClick(object sender, EventArgs e)
        {
            var result = CallTheNewCategoryForm();

            if (result == DialogResult.Yes)

                PrepareControls();
            FillDataControls(_enteredGoods);
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            if (grdCategory.GetValue("CategoryID") == null)

                return;
         
            var result =
               ShowMessage.ShowQuestionMessage(Goods_Res.AreYouDeleteCategory);

            if (result == DialogResult.Yes)
                {
                    int SelectedCategoryID;

                    SelectedCategoryID =
                        Convert.ToInt32
                        (
                            grdCategory.GetValue("CategoryID").ToString()
                        );

                    Validation
                        (
                            ValidationTypeEnum.Server,
                            DeleteCategory(SelectedCategoryID)
                        );
               
                    PrepareControls();

                    FillDataControls(_enteredGoods);
                }
 
        }

        private void BtnEditCategory_Click(object sender, EventArgs e)
        {
            if (grdCategory.GetValue("CategoryID") == null)

                return;

            var ID = grdCategory.GetValue("CategoryID");

            if (ID == null)

                return;
          
            Category category = new Category();

            category.ID = (int)ID;

            var result = CallTheCategoryUpdateForm(category);

            if (result == DialogResult.Yes)

                PrepareControls();

            FillDataControls(_enteredGoods);        
        }

        #endregion

        #region TextBox

        private void TxtCodeContact_txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')

                if (
                        !char.IsDigit(e.KeyChar) ||
                        char.IsControl(e.KeyChar) ||
                        char.IsPunctuation(e.KeyChar)
                   )
                    e.Handled = true;
        }

        private void NO_Number_Enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar);
        }

        private void TxtGoodsWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            EditBox textBox = (EditBox)sender;

            if (e.KeyChar == '.' || e.KeyChar == '\b')
            {

                if (textBox.Text.Trim() == "") //عدم اجازه ورود . اول  متن 

                    e.Handled = true;

                if (!textBox.Text.Contains('.'))//عدم اجازه ورود بیش از  یک . در متن 

                    return;
                else
                    e.Handled = true;
            }
            else

            if (
                    !char.IsDigit(e.KeyChar) ||
                    char.IsControl(e.KeyChar) ||
                    char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;//عدم اجازه ورود کارکتر به متن 
        }
        
        #endregion

        #region ComboBox

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        #endregion        
    }
}
