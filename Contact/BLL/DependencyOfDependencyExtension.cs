using Unity.Extension;
using Unity;
using Cactus.Contact.Model;
using Cactus.Contact.Dal;

namespace Cactus.Contact.Bll
{
    public class DependencyOfDependencyExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IContactDAL, ContactDAL>();
        }
    }
}
