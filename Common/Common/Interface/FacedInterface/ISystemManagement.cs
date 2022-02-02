using Cactus.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cactus.Common.Interface
{
   public interface ISystemManagement
    {
        User GetUserDetile(int ID);

        UserControl GetUCSubSystem();

        UserControl GetUCCurrentUserUpdate();

        UserControl GetUcServer();
    }
}
