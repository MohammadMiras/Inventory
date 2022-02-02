
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cactus.Common.Model;
using Cactus.Core.Dal;
using Cactus.Core.Model;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Core.Bll
{
    public class LoginBLL :ILoginBLL
    {
        #region Member

        private ICoreDAL _dal;

        #endregion

        #region Constructor

        public LoginBLL(ICoreDAL coreDAL)
        {
            _dal = coreDAL;
        }

        #endregion

        #region Get Data

        public User GetUserDetile(int UserID)
        {
            return 
                _dal.GetUserDetile(UserID);
        }   

        public DateTime GetDateTimeNowServer()
        {
            return
                _dal.GetDateTimeNowOfServer();
        }

        #endregion

        #region  Update Current User

        public ServerValidationEnum UpdateCurrentUser(User user)
        {
            return
                _dal.UpdateCurrentUser(user);
        }

        #endregion

        #region Validation User Login

        public UserValidationResult IsValidUser(User user)
        {
            return
                _dal.ISValidUser(user);
        }

        #endregion               
    }
}
