using Cactus.Common.Interface;
using System;
using System.Reflection;

namespace Cactus.Common.Model
{
    public class Faced
    {
        // This Is Class Faced  in sub sysytem  
        #region Enumerations type
        public enum SubSystem
        {
            Inventory = 1,
            SystemManagement = 2,
            Contact = 3
        } 
        #endregion

        #region Proprty 
        public static IContact Contact { get; set; }

        public static ISystemManagement SystemManagement { get; set; }

        public static IInventory Inventory { get; set; }
        #endregion

        #region Constructors
        public Faced()
        {
            SystemManagement = (ISystemManagement)LoadAssemble(SubSystem.SystemManagement);

            Contact = (IContact)LoadAssemble(SubSystem.Contact);

            Inventory = (IInventory)LoadAssemble(SubSystem.Inventory);
        } 
        #endregion

        #region Metods
        public object LoadAssemble(SubSystem subSystem)
        {
            string pathRoot = Environment.CurrentDirectory;

            var DLL = Assembly.LoadFile(pathRoot + @"\" + "Cactus." + subSystem + ".UI.exe");

            Type[] types = DLL.GetExportedTypes();

            Type type;

            var obj = new object();

            foreach (var item in types)
            {
                if (item.Name.Contains("SubSystem"))
                {
                    type = item;

                    obj = Activator.CreateInstance(type);

                    break;
                }
            }

            return obj;
        } 
        #endregion
    }
}
