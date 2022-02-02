
using Cactus.Common.Model;
using Cactus.SystemManagement.Dal;
using Cactus_SubSystem_Model;
using System;
using System.Collections.Generic;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.SystemManagement.Bll
{
    public class UserBLL:IUserBLL
    {
        #region Member

        private IUserDAL _userDAL;

        #endregion

        #region Constructor

        public UserBLL(IUserDAL userDAL) 
        {
            _userDAL = userDAL;
        }

        #endregion      

        #region Get                                    

        public User GetUserDetile(int UserID)
        {
            try
            {
                return _userDAL.GetUserDetile(UserID);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Insert

        public ServerValidationEnum InsertUser(User user)
        {
            return _userDAL.InsertUser(user);
        }


        public List<User> SearchUserFull(User user)
        {
            return _userDAL.SearchUserFull(user);
        }


        #endregion                                         

        #region  Update

        public ServerValidationEnum UpdateUser(User user)
        {
            return _userDAL.UpdateUser(user);
        }

        public ServerValidationEnum UpdateCurrentUser(User user)
        {
            return
                _userDAL.UpdateCurrentUser(user);
        }
        #endregion

        #region Delete 

        public bool DeleteUser(int userID)
        {
            return _userDAL.DeleteUser(userID);
        }

        #endregion   
    }
}
