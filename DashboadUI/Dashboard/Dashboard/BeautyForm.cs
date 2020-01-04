using Shaping;
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

namespace Dashboard
{
    public partial class BeautyForm : Form
    {
        public BeautyForm()
        {
            InitializeComponent();
        }
        //Moving form with mouse
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        protected virtual void OnMouseDownMoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }



        //Making form rounded by radius of 5
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = RoundedRectangle.Create(this.ClientRectangle, 5, RoundedRectangle.RectangleCorners.All);
            this.Region = new Region(path);
            
            base.OnPaint(e);
        }
        private void BeautyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
