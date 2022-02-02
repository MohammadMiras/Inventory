using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.Model
{
   public interface ICategoryBLL
    {
        DataTable GetCategory(Category category);
        bool InsertCategory(Category category);
        bool UpdateCategory(Category category);
        ServerValidationEnum DeleteCategory(int CategoryID);
    }
}
