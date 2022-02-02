using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUtility
{
   public static class ShowMessage
    {
        public static void ShowErrorMessage(string ErrorMessage)
        {
            MessageBox.Show
                (
                    ErrorMessage,
                    Resources.MessageTitle_Res.Error,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading
                );
        }   

        public static void ShowSuccessMessage(string Message)
        {
            MessageBox.Show
                (
                    Message,
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign
                );
        }

        public static DialogResult ShowQuestionMessage(string Question)
        {
            var result =
                MessageBox.Show
                (
                    Question,
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading
                );
            return result;
        }    

        public static void ShowWarningMessage(string WarningMessage)
        {
            MessageBox.Show
                (
                    WarningMessage,
                    Resources.MessageTitle_Res.Warning,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading
                );
        }
    }
}
