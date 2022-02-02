using Cactus.Common.Fille.FileSetting;
using System;

namespace Cactus.Common
{
   public static class ConnectionString
    {
        public static string _ConnectionString;

        public static void SetCurrentConnectionString()
        {
            try
            {
                _ConnectionString = Connection.Default.ConnectionString;
            }
            catch (Exception)
            {
                _ConnectionString = "";
            }
        }

        public static void SetNewConnectionString(string newConnection)
        {
            Connection.Default.ConnectionString = newConnection;

            Connection.Default.Save();
        }
    }
}
