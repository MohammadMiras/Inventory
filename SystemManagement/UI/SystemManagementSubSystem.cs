using System.Windows.Forms;
using Cactus.Common;
using Cactus.Common.Interface;
using Cactus.Common.Model;
using Cactus.SystemManagement.Bll;
using Cactus_SubSystem_Model;

namespace Cactus.SystemManagement.UI
{
    public class SystemManagementSubSystem : ISystemManagement
    {
        private IUserBLL _userBLL;

        public SystemManagementSubSystem()
        {
            Bootstrapper.Init();

            _userBLL = DependencyInjector.Retrieve<UserBLL>();
        }

        public UserControl GetUCSubSystem()
        {
            return new UC_System_Management();
        }

        public User GetUserDetile(int ID)
        {
            return
                 _userBLL.GetUserDetile(ID);
        }

        public UserControl GetUCCurrentUserUpdate()
        {
            return
                DependencyInjector.Retrieve<UC_Update_CurrentUser>();
        }

        public UserControl GetUcServer()
        {
            return
                 DependencyInjector.Retrieve<UC_Server>();
        }
    }
}
