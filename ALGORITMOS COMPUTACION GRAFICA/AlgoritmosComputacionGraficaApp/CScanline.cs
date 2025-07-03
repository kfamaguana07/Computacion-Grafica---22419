using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosComputacionGraficaApp
{
    internal class CScanline
    {
        public void Rellenar(Bitmap bmp, Point[] poligono, Color colorRelleno)
        {
            int ymin = poligono[0].Y;
            int ymax = poligono[0].Y;

            // Encontrar Y mín y máx
            foreach (var p in poligono)
            {
                if (p.Y < ymin) ymin = p.Y;
                if (p.Y > ymax) ymax = p.Y;
            }

            // Para cada scanline horizontal
            for (int y = ymin; y <= ymax; y++)
            {
                List<int> interseccionesX = new List<int>();

                for (int i = 0; i < poligono.Length; i++)
                {
                    Point p1 = poligono[i];
                    Point p2 = poligono[(i + 1) % poligono.Length];

                    if ((p1.Y <= y && p2.Y > y) || (p2.Y <= y && p1.Y > y))
                    {
                        int x = p1.X + (y - p1.Y) * (p2.X - p1.X) / (p2.Y - p1.Y);
                        interseccionesX.Add(x);
                    }
                }

                interseccionesX.Sort();

                for (int i = 0; i < interseccionesX.Count; i += 2)
                {
                    if (i + 1 >= interseccionesX.Count) break;

                    int xInicio = interseccionesX[i];
                    int xFin = interseccionesX[i + 1];

                    for (int x = xInicio; x <= xFin; x++)
                    {
                        if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                        {
                            bmp.SetPixel(x, y, colorRelleno);
                        }
                    }
                }
            }
        }
    }
}
