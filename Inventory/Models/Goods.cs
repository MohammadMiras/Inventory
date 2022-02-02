using Cactus.Common.Interface;
using System.Collections.Generic;
using System.Data;

namespace Cactus.Inventory.Model
{
    public class Goods : ITableBase, IFillDataTable
    {
        #region Member

        public int ID { get; set; }

        public string Code { get; set; }

        public int InventoryID { get; set; }

        public string Name { get; set; }

        public float Weight { get; set; }

        public int GoodsUnit { get; set; }

        public int Stock { get; set; }

        public List<Category> CategoryGroup { get; set; }

        public int RecordStatus { get; set; }

        public DataTable dsGoodsCategory;

        #endregion

        #region Constructors

        public Goods()
        {
            CategoryGroup = new List<Category>();

            dsGoodsCategory = new DataTable();

            RecordStatus = 0;

            InitializeTables();
        }

        #endregion

        #region Metods

        public void FillDataTable()
        {
            dsGoodsCategory.Rows.Clear();

            foreach (Category category in this.CategoryGroup)

                dsGoodsCategory.Rows.Add
                    (
                        category.ID,
                        category.Name,
                        category.RecordStatus
                   );
        }

        public void InitializeTables()
        {
            dsGoodsCategory.Columns.AddRange
                (
                    new DataColumn[]
                        {
                            new DataColumn("ID",typeof(int)),
                            new DataColumn("Name",typeof(string)),
                            new DataColumn("RecordStatus",typeof(int))
                        }
                );
        }

        #endregion
    }
}
