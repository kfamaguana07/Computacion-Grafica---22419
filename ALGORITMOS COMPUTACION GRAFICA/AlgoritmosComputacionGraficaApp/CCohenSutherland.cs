using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohenSutherlandAPP
{
    internal class CCohenSutherland
    {
        private const int INSIDE = 0; // 0000
        private const int LEFT = 1; // 0001
        private const int RIGHT = 2; // 0010
        private const int BOTTOM = 4; // 0100
        private const int TOP = 8; // 1000

        public int xMin, yMin, xMax, yMax;

        public CCohenSutherland(int xMin, int yMin, int xMax, int yMax)
        {
            this.xMin = xMin;
            this.yMin = yMin;
            this.xMax = xMax;
            this.yMax = yMax;
        }

        private int ComputeOutCode(int x, int y)
        {
            int code = INSIDE;

            if (x < xMin) code |= LEFT;
            else if (x > xMax) code |= RIGHT;

            if (y < yMin) code |= BOTTOM;
            else if (y > yMax) code |= TOP;

            return code;
        }

        public bool Clip(ref Point p1, ref Point p2)
        {
            int x1 = p1.X, y1 = p1.Y;
            int x2 = p2.X, y2 = p2.Y;

            int outcode1 = ComputeOutCode(x1, y1);
            int outcode2 = ComputeOutCode(x2, y2);

            bool accept = false;

            while (true)
            {
                if ((outcode1 | outcode2) == 0)
                {
                    // Ambos puntos dentro
                    accept = true;
                    break;
                }
                else if ((outcode1 & outcode2) != 0)
                {
                    // Ambos puntos fuera por la misma región
                    break;
                }
                else
                {
                    // Algún punto está fuera
                    int outcodeOut = (outcode1 != 0) ? outcode1 : outcode2;
                    int x = 0, y = 0;

                    // Encuentra el punto de intersección
                    if ((outcodeOut & TOP) != 0)
                    {
                        x = x1 + (x2 - x1) * (yMax - y1) / (y2 - y1);
                        y = yMax;
                    }
                    else if ((outcodeOut & BOTTOM) != 0)
                    {
                        x = x1 + (x2 - x1) * (yMin - y1) / (y2 - y1);
                        y = yMin;
                    }
                    else if ((outcodeOut & RIGHT) != 0)
                    {
                        y = y1 + (y2 - y1) * (xMax - x1) / (x2 - x1);
                        x = xMax;
                    }
                    else if ((outcodeOut & LEFT) != 0)
                    {
                        y = y1 + (y2 - y1) * (xMin - x1) / (x2 - x1);
                        x = xMin;
                    }

                    // Reemplaza el punto fuera
                    if (outcodeOut == outcode1)
                    {
                        x1 = x; y1 = y;
                        outcode1 = ComputeOutCode(x1, y1);
                    }
                    else
                    {
                        x2 = x; y2 = y;
                        outcode2 = ComputeOutCode(x2, y2);
                    }
                }
            }

            if (accept)
            {
                p1 = new Point(x1, y1);
                p2 = new Point(x2, y2);
                return true;
            }

            return false;
        }

    }
}
