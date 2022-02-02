using Cactus.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Core.Model
{
  public  interface ILoginBLL 
    {
        ServerValidationEnum UpdateCurrentUser(User user);
        UserValidationResult IsValidUser(User user);
        User GetUserDetile(int UserID);
        DateTime GetDateTimeNowServer();
    }
}
