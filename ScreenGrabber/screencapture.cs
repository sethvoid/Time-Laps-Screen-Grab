using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;  
using System.Drawing;         
using System.Drawing.Imaging;
using System.Threading;
using System.IO;

namespace ScreenGrabber
{
    class alternativeScreenCap
    {
        private Image img = null;
        public int screenLeft = Screen.PrimaryScreen.Bounds.Left;
        public int screenTop = Screen.PrimaryScreen.Bounds.Top;
        public void GetScreenGrab (string savePath, int serialnumber)
        {
         Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
           
         //   bmp.SetResolution(resolution);  //figure out how to get 100%
            Graphics g = Graphics.FromImage(bmp as Image);
            try
            {
                g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                bmp.Save(savePath + Convert.ToString(serialnumber) + ".jpg" , ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
