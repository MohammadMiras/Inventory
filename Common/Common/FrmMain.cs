using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cactus.Common
{
    public partial class FrmMain : Form
    {
        private bool _IsRounded = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
            );

        public FrmMain(bool IsRounded)
        {
            _IsRounded = IsRounded;

            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (!_IsRounded)
                return;

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.FromArgb(9, 106, 138),
                                                                       Color.FromArgb(38, 120, 113),
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!_IsRounded)
                return;

            this.FormBorderStyle = FormBorderStyle.None;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
    }
}
