using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Common.Model
{
   public  class UserValidationResult
    {
        public int UserID { get; set; }

        public ServerValidationEnum ServerValidation { get; set; }
    }
}
