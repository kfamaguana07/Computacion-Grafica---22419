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
        private readonly int altoCanvas, escala;
        private readonly List<Point> puntos;

        public CDiscretizacionCircunferencia(int centroX, int centroY, int radio, int altoCanvas, int escala = 20)
        {
            this.centroX = centroX;
            this.centroY = centroY;
            this.radio = radio;
            this.altoCanvas = altoCanvas;
            this.escala = escala;
            this.puntos = new List<Point>();

            CalcularPuntos();
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

        public void Dibujar(Graphics g, int hastaIndice)
        {
            Pen ejes = new Pen(Color.Gray, 1);
            Brush brush = Brushes.Blue;

            // Ejes X y Y
            g.DrawLine(ejes, 0, altoCanvas, 800, altoCanvas); // X
            g.DrawLine(ejes, 0, 0, 0, altoCanvas); // Y

            for (int i = 0; i < hastaIndice && i < puntos.Count; i++)
            {
                int px = puntos[i].X * escala;
                int py = altoCanvas - puntos[i].Y * escala;
                g.FillEllipse(brush, px - 2, py - 2, 4, 4);
            }
        }

        public List<Point> GetPuntos() => puntos;
    }
}
