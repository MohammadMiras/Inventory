using Cactus.Core.Dal;
using Cactus.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Extension;
using Unity;

namespace Cactus.Core.Bll
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ICoreDAL, CoreDAL>();
        }
    }
}
