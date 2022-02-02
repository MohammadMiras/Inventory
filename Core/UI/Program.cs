using Cactus.Common;
using Cactus.Common.Model;
using Cactus.Core.UI.UserControls;
using System;
using System.Windows.Forms;

namespace Cactus.Core.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Bootstrapper.Init();

            Faced faced = new Faced();

            UserControl ucLogin = DependencyInjector.Retrieve<UC_Login>();

            var resualt = ShowForm.Show(ucLogin,true);

            if (resualt == DialogResult.Yes)
            {      
                UserControl start = new UC_Start_App();

                ShowForm.Show(start);
            }
        }
    }
}
