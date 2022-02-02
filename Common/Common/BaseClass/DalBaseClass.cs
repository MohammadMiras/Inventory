//using CommonModel.FacedInterfaces;
//using CommonModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Common.BaseClass
{
    public  class DalBaseClass<T> 
    {
        protected virtual List<T> ConvertToList(DataSet dataSet) 
        {
            return new List<T>();
        }
    }
}
