using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosGraficosApp
{
    internal class CDiscretizacionCircunferencia
    {
        private readonly int radio;
        private readonly int centroX, centroY;
        private readonly int anchoCanvas, altoCanvas;
        private readonly List<Point> puntos;
        private float escala;

        public CDiscretizacionCircunferencia(int centroX, int centroY, int radio, int anchoCanvas, int altoCanvas)
        {
            this.centroX = centroX;
            this.centroY = centroY;
            this.radio = radio;
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
            int y = radio;
            int p = 1 - radio;

            while (x <= y)
            {
                AgregarSimetricos(x, y);
                x++;

                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
            }
        }

        private void AgregarSimetricos(int x, int y)
        {
            puntos.Add(new Point(centroX + x, centroY + y));
            puntos.Add(new Point(centroX - x, centroY + y));
            puntos.Add(new Point(centroX + x, centroY - y));
            puntos.Add(new Point(centroX - x, centroY - y));
            puntos.Add(new Point(centroX + y, centroY + x));
            puntos.Add(new Point(centroX - y, centroY + x));
            puntos.Add(new Point(centroX + y, centroY - x));
            puntos.Add(new Point(centroX - y, centroY - x));
        }

        private void CalcularEscalaDinamica()
        {
            float margen = 0.9f;
            float maxR = radio + 1;

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

            // Dibujar cuadrícula
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
