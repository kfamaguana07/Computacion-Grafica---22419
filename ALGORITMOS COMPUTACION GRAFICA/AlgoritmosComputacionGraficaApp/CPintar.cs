using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmosGraficosApp
{
    internal class CPintar
    {
        private PictureBox canvas;

        public void AsignarCanvas(PictureBox pic)
        {
            canvas = pic;
        }

        public void FloodFill(Bitmap bmp, int x, int y, Color fillColor)
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

                pixels.Push(new Point(px - 1, py));
                pixels.Push(new Point(px + 1, py));
                pixels.Push(new Point(px, py - 1));
                pixels.Push(new Point(px, py + 1));
            }

            if (canvas != null)
            {
                canvas.Image = bmp;
                canvas.Refresh();
            }
        }

    }
}
