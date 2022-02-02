using Cactus.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus_SubSystem_Model
{
     public interface IUserDAL
    {       
        bool DeleteUser(int userID);
        User GetUserDetile(int UserID);
        List<User> SearchUserFull(User user);
        ServerValidationEnum InsertUser(User user);        
        ServerValidationEnum UpdateUser(User user);
        ServerValidationEnum UpdateCurrentUser(User user);      
    }
}
