using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosComputacionGraficaApp
{
    internal class CBresenhamElipses
    {
        private readonly int rx, ry;
        private readonly int centroX, centroY;
        private readonly int anchoCanvas, altoCanvas;
        private readonly List<Point> puntos;
        private float escala;

        public CBresenhamElipses(int centroX, int centroY, int rx, int ry, int anchoCanvas, int altoCanvas)
        {
            this.centroX = centroX;
            this.centroY = centroY;
            this.rx = rx;
            this.ry = ry;
            this.anchoCanvas = anchoCanvas;
            this.altoCanvas = altoCanvas;
            this.puntos = new List<Point>();

            CalcularPuntos();
            CalcularEscalaDinamica();
        }

        private void CalcularPuntos()
        {
            puntos.Clear();

            int x = 0;
            int y = ry;

            double rx2 = rx * rx;
            double ry2 = ry * ry;
            double p1 = ry2 - (rx2 * ry) + (0.25 * rx2);
            double dx = 2 * ry2 * x;
            double dy = 2 * rx2 * y;

            // Región 1
            while (dx < dy)
            {
                AgregarSimetricos(x, y);
                if (p1 < 0)
                {
                    x++;
                    dx += 2 * ry2;
                    p1 += dx + ry2;
                }
                else
                {
                    x++;
                    y--;
                    dx += 2 * ry2;
                    dy -= 2 * rx2;
                    p1 += dx - dy + ry2;
                }
            }

            // Región 2
            double p2 = (ry2) * ((x + 0.5) * (x + 0.5)) + (rx2) * ((y - 1) * (y - 1)) - (rx2 * ry2);
            while (y >= 0)
            {
                AgregarSimetricos(x, y);
                if (p2 > 0)
                {
                    y--;
                    dy -= 2 * rx2;
                    p2 += rx2 - dy;
                }
                else
                {
                    x++;
                    y--;
                    dx += 2 * ry2;
                    dy -= 2 * rx2;
                    p2 += dx - dy + rx2;
                }
            }
        }

        private void AgregarSimetricos(int x, int y)
        {
            puntos.Add(new Point(centroX + x, centroY + y));
            puntos.Add(new Point(centroX - x, centroY + y));
            puntos.Add(new Point(centroX + x, centroY - y));
            puntos.Add(new Point(centroX - x, centroY - y));
        }

        private void CalcularEscalaDinamica()
        {
            float margen = 0.9f;
            float maxR = Math.Max(rx, ry) + 1;

            float escalaX = (anchoCanvas / 2f) * margen / maxR;
            float escalaY = (altoCanvas / 2f) * margen / maxR;

            escala = Math.Min(escalaX, escalaY);
        }

        public void Dibujar(Graphics g, int hastaIndice)
        {
            Pen ejePen = new Pen(Color.Black, 1);
            Pen gridPen = new Pen(Color.LightGray, 1);
            Brush puntoBrush = Brushes.Blue;

            int origenX = anchoCanvas / 2;
            int origenY = altoCanvas / 2;

            // Dibujar cuadrícula (opcional)
            int gridStep = (int)escala;
            if (gridStep > 0)
            {
                for (int x = origenX; x < anchoCanvas; x += gridStep)
                    g.DrawLine(gridPen, x, 0, x, altoCanvas);
                for (int x = origenX; x >= 0; x -= gridStep)
                    g.DrawLine(gridPen, x, 0, x, altoCanvas);

                for (int y = origenY; y < altoCanvas; y += gridStep)
                    g.DrawLine(gridPen, 0, y, anchoCanvas, y);
                for (int y = origenY; y >= 0; y -= gridStep)
                    g.DrawLine(gridPen, 0, y, anchoCanvas, y);
            }

            // Ejes cartesianos
            g.DrawLine(ejePen, 0, origenY, anchoCanvas, origenY); // eje X
            g.DrawLine(ejePen, origenX, 0, origenX, altoCanvas);  // eje Y

            // Dibujo de los puntos
            int limite = Math.Min(hastaIndice, puntos.Count);

            for (int i = 0; i < limite; i++)
            {
                float px = origenX + puntos[i].X * escala;
                float py = origenY - puntos[i].Y * escala;
                g.FillEllipse(puntoBrush, px - 2, py - 2, 4, 4);
            }
        }

        public List<Point> GetPuntos() => puntos;
    }
}
