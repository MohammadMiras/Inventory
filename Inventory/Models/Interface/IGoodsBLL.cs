using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Inventory.Model
{
   public interface IGoodsBLL
    {
        List<Goods> GetGoods(Goods goods, StatusHasDitailEnum statusHasDitail);
        List<GoodsUnit> GetUnits();
        ServerValidationEnum InsertGoods(Goods goods);
        ServerValidationEnum UpdateGoods(Goods goods);
        ServerValidationEnum DeleteGoods(int GoodsID);
    }
}
