using System.Collections.Generic;
using Cactus.Inventory.Model;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.BLL
{
    public class GoodsBLL:IGoodsBLL
    {
        #region Member 

        IGoodsDAL _goodsDAL;

        #endregion

        #region Constructors

        public GoodsBLL(IGoodsDAL goodsDAL)
        {
            _goodsDAL = goodsDAL;
        }

        #endregion

        #region Get Data 

        #region Get Goods

        public List<Goods> GetGoods(Goods goods, StatusHasDitailEnum statusHasDitail)
        {
            return 
                _goodsDAL.GetGoods(goods, statusHasDitail);
        }

        #endregion

        #region Get Unit

        public List<GoodsUnit> GetUnits()
        {
            return 
                _goodsDAL.GetUnits();
        }

        #endregion

        #endregion

        #region Insert Goods

        public ServerValidationEnum InsertGoods(Goods goods)
        {
            return
                 _goodsDAL.InsertGoods(goods);
        }

        #endregion

        #region Update Goods

        public ServerValidationEnum UpdateGoods(Goods goods)
        {
            return
                _goodsDAL.UpdateGoods(goods);
        }

        #endregion

        #region Delete Goods

        public ServerValidationEnum DeleteGoods(int GoodsID)
        {
            return
                _goodsDAL.DeleteGoods(GoodsID);
        }

        #endregion
    }
}
