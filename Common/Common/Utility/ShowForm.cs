using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUtility
{
  public static  class ShowForm
    {
        #region Show  Standard Form 

        public static DialogResult Show(UserControl usercontrol, bool IsRounded = false)
        {
            FrmMain frm = new FrmMain(IsRounded);

            frm.Controls.Add(usercontrol);

            SetForm(usercontrol: usercontrol, frm: frm);

            return
                frm.ShowDialog();
        }

        #endregion

        #region Metods

        private static void SetForm(UserControl usercontrol, Form frm)
        {
            frm.Size = new System.Drawing.Size
            {
                Width = usercontrol.Width + 20,

                Height = usercontrol.Height + 50
            };
            frm.Padding = new Padding(0, 0, 0, 0);

            frm.BackColor = Color.FromArgb(223, 234, 249);

            frm.StartPosition = FormStartPosition.CenterScreen;
        } 

        #endregion
    }
}
