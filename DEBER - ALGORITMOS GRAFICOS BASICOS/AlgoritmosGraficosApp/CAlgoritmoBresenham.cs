using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosApp
{
    internal class CAlgoritmoBresenham
    {
        private readonly int x0, y0, x1, y1;
        private readonly int altoCanvas, escala;
        private readonly List<Point> puntos;

        public CAlgoritmoBresenham(int x0, int y0, int x1, int y1, int altoCanvas, int escala = 20)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
            this.altoCanvas = altoCanvas;
            this.escala = escala;

            puntos = new List<Point>();
            CalcularPuntos();
        }

        private void CalcularPuntos()
        {
            puntos.Clear();

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            int x = x0;
            int y = y0;

            while (true)
            {
                puntos.Add(new Point(x, y));
                if (x == x1 && y == y1) break;

                int e2 = 2 * err;

                if (e2 > -dy)
                {
                    err -= dy;
                    x += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y += sy;
                }
            }
        }

        public void Dibujar(Graphics g, int hastaIndice)
        {
            Pen ejes = new Pen(Color.Gray, 1);
            Brush puntoBrush = Brushes.Black;

            // Dibujar ejes
            g.DrawLine(ejes, 0, altoCanvas, 800, altoCanvas); // Eje X
            g.DrawLine(ejes, 0, 0, 0, altoCanvas);             // Eje Y

            for (int i = 0; i <= 800; i += escala)
                g.DrawLine(ejes, i, altoCanvas - 3, i, altoCanvas + 3);
            for (int j = 0; j <= altoCanvas; j += escala)
                g.DrawLine(ejes, -3, j, 3, j);

            int limite = Math.Min(hastaIndice, puntos.Count - 1);

            for (int i = 0; i <= limite; i++)
            {
                int px = puntos[i].X * escala;
                int py = altoCanvas - puntos[i].Y * escala;
                g.FillEllipse(puntoBrush, px - 3, py - 3, 6, 6);
            }
        }

        public List<Point> GetPuntos() => puntos;
    }
}
