using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Common.Model
{
   public  class ObjSystem
    {
        public int ID { get; set; }        

        public string Title { get; set; }

        public RecordStatusEnum RecordStatus { get; set; }
    }
}
