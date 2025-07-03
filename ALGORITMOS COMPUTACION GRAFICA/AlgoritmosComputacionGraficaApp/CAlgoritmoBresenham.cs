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
        private readonly int altoCanvas, anchoCanvas;
        private readonly List<Point> puntos;
        private float escala;

        public CAlgoritmoBresenham(int x0, int y0, int x1, int y1, int altoCanvas, int anchoCanvas)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
            this.altoCanvas = altoCanvas;
            this.anchoCanvas = anchoCanvas;
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
            Pen ejePen = new Pen(Color.Black, 2);
            Pen gridPen = new Pen(Color.LightGray, 1);
            Brush puntoBrush = Brushes.Black;
            Brush flechaBrush = Brushes.Red;

            if (puntos.Count == 0) return;

            // Calcular límites para adaptar escala
            int minX = Math.Min(0, puntos.Min(p => p.X));
            int maxX = Math.Max(0, puntos.Max(p => p.X));
            int minY = Math.Min(0, puntos.Min(p => p.Y));
            int maxY = Math.Max(0, puntos.Max(p => p.Y));

            int rangoX = maxX - minX + 1;
            int rangoY = maxY - minY + 1;

            // Margen para bordes
            float margen = 40f;
            float usableWidth = anchoCanvas - 2 * margen;
            float usableHeight = altoCanvas - 2 * margen;

            // Escala dinámica
            float escalaX = usableWidth / rangoX;
            float escalaY = usableHeight / rangoY;
            float escala = Math.Min(escalaX, escalaY);

            // Posición de origen en pantalla
            float origenX = margen + (0 - minX) * escala;
            float origenY = altoCanvas - margen - (0 - minY) * escala;

            // Dibujar cuadrícula
            for (int i = minX; i <= maxX; i++)
            {
                float x = margen + (i - minX) * escala;
                g.DrawLine(gridPen, x, margen, x, altoCanvas - margen);
            }

            for (int i = minY; i <= maxY; i++)
            {
                float y = altoCanvas - margen - (i - minY) * escala;
                g.DrawLine(gridPen, margen, y, anchoCanvas - margen, y);
            }

            // Dibujar ejes
            g.DrawLine(ejePen, margen, origenY, anchoCanvas - margen, origenY); // Eje X
            g.DrawLine(ejePen, origenX, margen, origenX, altoCanvas - margen); // Eje Y

            // Flecha eje X
            Point[] flechaX = {
        new Point((int)(anchoCanvas - margen), (int)origenY),
        new Point((int)(anchoCanvas - margen - 10), (int)origenY - 5),
        new Point((int)(anchoCanvas - margen - 10), (int)origenY + 5)
    };
            g.FillPolygon(flechaBrush, flechaX);

            // Flecha eje Y
            Point[] flechaY = {
        new Point((int)origenX, (int)margen),
        new Point((int)origenX - 5, (int)margen + 10),
        new Point((int)origenX + 5, (int)margen + 10)
    };
            g.FillPolygon(flechaBrush, flechaY);

            // Dibujar puntos del algoritmo
            int limite = Math.Min(hastaIndice, puntos.Count - 1);
            for (int i = 0; i <= limite; i++)
            {
                float px = margen + (puntos[i].X - minX) * escala;
                float py = altoCanvas - margen - (puntos[i].Y - minY) * escala;
                g.FillEllipse(puntoBrush, px - 3, py - 3, 6, 6);
            }

            // Dibujar origen (0,0)
            g.FillEllipse(Brushes.Blue, origenX - 4, origenY - 4, 8, 8);
        }


        public List<Point> GetPuntos() => puntos;
    }
}

