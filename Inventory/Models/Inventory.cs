using System.Collections.Generic;

namespace Cactus.Inventory.Model
{
    public class Inventory
    {
        #region Proprty

        public int? ID { get; set; }
        
        public string Code { get; set; }

        public string Title { get; set; }

        public List<Goods> GoodsList;

        #endregion

        #region Constructor

        public Inventory()
        {
            GoodsList = new List<Goods>();
        } 

        #endregion
    }
}
