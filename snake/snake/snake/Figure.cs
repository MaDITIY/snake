using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {
        protected List<Point> points = new List<Point>();

        public bool Hit(Figure figure)
        {
            foreach (var p in points)
            {
                if (figure.Hit(p))
                {
                    return true;
                }
            }
            return false;
        }

        private bool Hit(Point point)
        {
            foreach (var p in points)
            {
                if (p.Hit(point))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
