using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactus_SubSystem_Model
{
    public interface IServerDAL
    {
        List<string> GetDataBaseName(string Connection);
    }
}
