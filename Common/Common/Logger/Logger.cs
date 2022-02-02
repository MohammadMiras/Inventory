using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cactus.Common.Logger
{
    public static class Logger
    {
        public static void Log(Exception exception)
        {
            WriteToFill(exception.Source, exception.Message);
        }

        private static void WriteToFill(string source, string massege)
        {
            try
            {
                string path = Path.GetDirectoryName(Application.ExecutablePath) + "\\exception.txt";

                FileInfo file = new FileInfo(path);

                using (StreamWriter stream = file.AppendText())
                {
                    stream.WriteLine(source + "  " + massege);

                    stream.Close();
                }
            }
            catch (Exception )
            {
                return;
            }
        }
    }
}

