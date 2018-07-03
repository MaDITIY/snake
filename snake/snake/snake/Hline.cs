using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Hline : Figure
    {
        public Hline(int xL, int xR, int y, char sym)
        {
            for (int x = xL; x < xR; ++x)
            {
                Point p = new Point(x, y, sym);
                points.Add(p);
            }
        }
    }
}
