using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x ;
        public int y ;
        public char sym ;

        public Point (int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int way, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x += way;
            }
            else if (direction == Direction.LEFT)
            {
                x -= way;
            }

            if (direction == Direction.UP)
            {
                y -= way;
            }
            else if (direction == Direction.DOWN)
            {
                y += way;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}