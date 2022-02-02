using Cactus.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cactus.Common.Interface
{
    public  interface IContact : IFacedBaseClass
    {
        ContactViewModel GetCustomer(int ContactID);

        ContactViewModel ShowUCSelectCustomer();

        UserControl GetUCContactList();
    }
}