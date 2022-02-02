using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
   public  interface Interface1
    {
         string FormTitle { get; set; }

         Image FormIcon { get; set; }

        void SetFormTitileAndIcon();

    }
}
