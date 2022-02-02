using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonCore.FileExcption
{
  public  class WriteToFile
    {
        public static void WriteExceptionToFile(string Source, string Message ,DateTime  dateTime)
        {

            try
            {
                string path =
                      Path.Combine
                      (Directory.GetParent
                        (Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Core\\CommonCore\\FileExcption\\FileExcption.txt");

                FileInfo file = new FileInfo(path);

                using (StreamWriter stream = file.AppendText())
                {
                    stream.WriteLine(dateTime.ToString() +":" +  Source + "||" + Message);

                    stream.Close();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
