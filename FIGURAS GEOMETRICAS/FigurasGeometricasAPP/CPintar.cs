using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricasAPP
{
    internal class CPintar
    {
        private PictureBox canvas;

        public void AsignarCanvas(PictureBox pic)
        {
            canvas = pic;
        }

        public void FloodFill(Bitmap bmp, int x, int y, Color fillColor, int delay = 1)
        {
            Color targetColor = bmp.GetPixel(x, y);
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point p = pixels.Pop();
                int px = p.X;
                int py = p.Y;

                if (px < 0 || px >= bmp.Width || py < 0 || py >= bmp.Height)
                    continue;

                if (bmp.GetPixel(px, py).ToArgb() != targetColor.ToArgb())
                    continue;

                bmp.SetPixel(px, py, fillColor);

                if (canvas != null)
                {
                    canvas.Image = (Bitmap)bmp.Clone();
                    canvas.Refresh();
                }

                Thread.Sleep(delay);
                Application.DoEvents();

                // NESO → Se apilan en orden inverso para procesar en ese orden
                pixels.Push(new Point(px - 1, py)); // O = Oeste
                pixels.Push(new Point(px, py + 1)); // S = Sur
                pixels.Push(new Point(px + 1, py)); // E = Este
                pixels.Push(new Point(px, py - 1)); // N = Norte
            }
        }


    }
}

