using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosComputacionGraficaApp
{
    internal class CDDA
    {
        private readonly int x0, y0, x1, y1;
        private readonly int altoCanvas, anchoCanvas;
        private readonly List<Point> puntos;
        private float escala;

        public CDDA(int x0, int y0, int x1, int y1, int anchoCanvas, int altoCanvas)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.x1 = x1;
            this.y1 = y1;
            this.anchoCanvas = anchoCanvas;
            this.altoCanvas = altoCanvas;
            puntos = new List<Point>();
            CalcularPuntos();
            CalcularEscalaDinamica();
        }

        private void CalcularPuntos()
        {
            puntos.Clear();
            float dx = x1 - x0;
            float dy = y1 - y0;

            if (dx == 0 && dy == 0)
            {
                puntos.Add(new Point(x0, y0));
                return;
            }

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                float step = dx > 0 ? 1 : -1;
                float m = dy / dx;
                float x = x0;
                float y = y0;

                for (int i = 0; i <= Math.Abs(dx); i++)
                {
                    puntos.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                    x += step;
                    y += m * step;
                }
            }
            else
            {
                float step = dy > 0 ? 1 : -1;
                float m = dx / dy;
                float x = x0;
                float y = y0;

                for (int i = 0; i <= Math.Abs(dy); i++)
                {
                    puntos.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                    y += step;
                    x += m * step;
                }
            }
        }

        private void CalcularEscalaDinamica()
        {
            if (puntos.Count == 0)
            {
                escala = 1;
                return;
            }

            int minX = Math.Min(0, puntos.Min(p => p.X));
            int maxX = Math.Max(0, puntos.Max(p => p.X));
            int minY = Math.Min(0, puntos.Min(p => p.Y));
            int maxY = Math.Max(0, puntos.Max(p => p.Y));

            int rangoX = maxX - minX + 1;
            int rangoY = maxY - minY + 1;

            float margen = 40f;
            float usableWidth = anchoCanvas - 2 * margen;
            float usableHeight = altoCanvas - 2 * margen;

            float escalaX = usableWidth / rangoX;
            float escalaY = usableHeight / rangoY;

            escala = Math.Min(escalaX, escalaY);
        }

        public void Dibujar(Graphics g, int hastaIndice)
        {
            Pen ejePen = new Pen(Color.Black, 2);
            Pen gridPen = new Pen(Color.LightGray, 1);
            Brush puntoBrush = Brushes.Black;
            Brush flechaBrush = Brushes.Red;

            if (puntos.Count == 0) return;

            int minX = Math.Min(0, puntos.Min(p => p.X));
            int maxX = Math.Max(0, puntos.Max(p => p.X));
            int minY = Math.Min(0, puntos.Min(p => p.Y));
            int maxY = Math.Max(0, puntos.Max(p => p.Y));

            float margen = 40f;
            float origenX = margen + (0 - minX) * escala;
            float origenY = altoCanvas - margen - (0 - minY) * escala;

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

            g.DrawLine(ejePen, margen, origenY, anchoCanvas - margen, origenY);
            g.DrawLine(ejePen, origenX, margen, origenX, altoCanvas - margen);

            Point[] flechaX = {
                new Point((int)(anchoCanvas - margen), (int)origenY),
                new Point((int)(anchoCanvas - margen - 10), (int)origenY - 5),
                new Point((int)(anchoCanvas - margen - 10), (int)origenY + 5)
            };
            g.FillPolygon(flechaBrush, flechaX);

            Point[] flechaY = {
                new Point((int)origenX, (int)margen),
                new Point((int)origenX - 5, (int)margen + 10),
                new Point((int)origenX + 5, (int)margen + 10)
            };
            g.FillPolygon(flechaBrush, flechaY);

            int limite = Math.Min(hastaIndice, puntos.Count - 1);
            for (int i = 0; i <= limite; i++)
            {
                float px = margen + (puntos[i].X - minX) * escala;
                float py = altoCanvas - margen - (puntos[i].Y - minY) * escala;
                g.FillEllipse(puntoBrush, px - 3, py - 3, 6, 6);
            }

            g.FillEllipse(Brushes.Blue, origenX - 4, origenY - 4, 8, 8);
        }

        public List<Point> GetPuntos() => puntos;
    }
}
