using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cactus.Common.Utility
{
  public static  class GeneralTools
    {
        //===================<checking Code>===============================

        public static bool AreCodeValid(this string code, int len = 4)
        {
            return
                 code.Length == len ? true : false;
        }

        //===================<Checking Empty Controls >====================

        public static bool IsEmptyChildTextBoxControl(this Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                String value = String.Empty;

                switch (control.GetType().Name.ToString())
                {
                    case "EditBox":
                        if (control.Text.Trim() == "")
                            return true;
                        break;
                }
            }

            return false;
        }

        public static string GetRootDirection()
        {
            return Application.StartupPath;
        }
    }
}
