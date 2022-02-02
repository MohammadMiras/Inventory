using Cactus.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Core.Model
{
    public  interface ICoreDAL
    {
        User GetUserDetile(int UserID);

        ServerValidationEnum UpdateCurrentUser(User user);

        UserValidationResult ISValidUser(User user);

        DateTime GetDateTimeNowOfServer();
    }
}
