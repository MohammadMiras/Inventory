using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cactus.SystemManagement.Dal;
using Cactus_SubSystem_Model;

namespace Cactus.SystemManagement.Bll
{
    public class ServerBLL :IServerBLL
    {
        private IServerDAL _serverDAL;

        public ServerBLL(IServerDAL serverDAL)
        {
            _serverDAL = serverDAL;
        }

        public List<string> GetDataBaseName(string Connection)
        {
            return _serverDAL.GetDataBaseName(Connection);            
        }
    }
}
