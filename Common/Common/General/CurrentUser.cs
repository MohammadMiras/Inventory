using Cactus.Common.Fille.FileSetting;
using Cactus.Common.Model;
using static Cactus.Common.Model.ModelUtility;

namespace Cactus.Common
{
  public static  class CurrentUser
    {
        public static User currentUser = new User();

        public static void SetCurrentUser(this User user)
        {
            currentUser = user;

            AddUserToFillSetting();
        }

        public static void SetCurrentUser()
        {
            try
            {
                currentUser.ID = UserSetting.Default.UserID;
                currentUser.UserName = UserSetting.Default.UserName;
                currentUser.Password = UserSetting.Default.Password;

            }
            catch (System.Exception)
            {
                currentUser = new User();
            }
        }

        private static void AddUserToFillSetting()
        {
            UserSetting.Default.UserName = currentUser.UserName;
            UserSetting.Default.Password = currentUser.Password;
            UserSetting.Default.UserID = currentUser.ID;
            UserSetting.Default.Save();
        }

        public static void SetDetailsUser(this User user)
        {
            currentUser.RoleList = user.RoleList;
        }

        public static void UpdateCurrentUser(User user)
        {  
            currentUser.Password = user.Password;
            currentUser.UserName = user.UserName;
            AddUserToFillSetting();
        }

        public static bool CheckAccesslevelUser(this ObjectSystemEnum objSystemEnum)
        {
            return
                currentUser.RoleList.Exists
                (
                    x => x.AllSystemObj.Exists
                        (
                            a => a.ID == (int)objSystemEnum
                        )
                );
        }
    }
}
