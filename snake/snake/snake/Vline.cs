using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Vline : Figure
    {
        public Vline(int x, int yD, int yU, char sym)
        {
            for (int y = yD; y < yU; ++y)
            {
                Point p = new Point(x, y, sym);
                points.Add(p);
            }
        }
    }
}
