using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosComputacionGraficaApp
{
    internal class CSutherlandHodgman
    {
        public List<PointF> RecortarPoligono(List<PointF> poligono, RectangleF ventana)
        {
            List<PointF> resultado = new List<PointF>(poligono);

            // Recortar contra cada borde del rectángulo
            resultado = RecortarContraBorde(resultado, ventana.Left, Edge.Left);
            resultado = RecortarContraBorde(resultado, ventana.Right, Edge.Right);
            resultado = RecortarContraBorde(resultado, ventana.Top, Edge.Top);
            resultado = RecortarContraBorde(resultado, ventana.Bottom, Edge.Bottom);

            return resultado;
        }

        private enum Edge { Left, Right, Top, Bottom }

        private List<PointF> RecortarContraBorde(List<PointF> poligono, float borde, Edge edge)
        {
            List<PointF> salida = new List<PointF>();

            for (int i = 0; i < poligono.Count; i++)
            {
                PointF actual = poligono[i];
                PointF previo = poligono[(i - 1 + poligono.Count) % poligono.Count];

                bool actualDentro = EstaDentro(actual, borde, edge);
                bool previoDentro = EstaDentro(previo, borde, edge);

                if (actualDentro)
                {
                    if (!previoDentro)
                    {
                        PointF interseccion = CalcularInterseccion(previo, actual, borde, edge);
                        salida.Add(interseccion);
                    }
                    salida.Add(actual);
                }
                else if (previoDentro)
                {
                    PointF interseccion = CalcularInterseccion(previo, actual, borde, edge);
                    salida.Add(interseccion);
                }
            }
            return salida;
        }

        private bool EstaDentro(PointF p, float borde, Edge edge)
        {
            switch (edge)
            {
                case Edge.Left: return p.X >= borde;
                case Edge.Right: return p.X <= borde;
                case Edge.Top: return p.Y >= borde;
                case Edge.Bottom: return p.Y <= borde;
                default: return false;
            }
        }

        private PointF CalcularInterseccion(PointF p1, PointF p2, float borde, Edge edge)
        {
            float x = 0, y = 0;
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;

            if (edge == Edge.Left || edge == Edge.Right)
            {
                x = borde;
                y = p1.Y + dy * (borde - p1.X) / dx;
            }
            else // Top o Bottom
            {
                y = borde;
                x = p1.X + dx * (borde - p1.Y) / dy;
            }
            return new PointF(x, y);
        }
    }
}
