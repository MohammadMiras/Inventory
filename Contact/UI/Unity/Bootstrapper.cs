using Cactus.Common;
using Cactus.Contact.Bll;
using Cactus.Contact.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus.Contact.UI
{
    public static class Bootstrapper
    {
        public static void Init()
        {
            DependencyInjector.Register<IContactBLL, ContactBLL>();
            DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
        }
    }
}
