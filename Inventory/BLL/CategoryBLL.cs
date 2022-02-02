using System.Data;
using Cactus.Inventory.Dal;
using Cactus.Inventory.Model;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.BLL
{
    public class CategoryBLL :ICategoryBLL
    {
        #region Member

        private ICategoryDAL _categoryDAL;

        #endregion

        public CategoryBLL(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;

        }

        #region Get category

        public DataTable GetCategory(Category category)
        {
            return
              _categoryDAL.GetCategory(category);
        }

        #endregion

        #region Insert Category

        public bool InsertCategory(Category category)
        {
            return 
               _categoryDAL.InsertCategory(category);
        }

        #endregion

        #region Update Category

        public bool UpdateCategory(Category category)
        {
            return 
               _categoryDAL.UpdateCategory(category);
        }

        #endregion

        #region Delete Category

        public ServerValidationEnum DeleteCategory(int CategoryID)
        {
            return
               _categoryDAL.DeleteCategory(CategoryID);
        }

        #endregion
    }
}
