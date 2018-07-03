using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Direction direction;

        public Snake (Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            for (int i = 0; i < lenght; ++i)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                points.Add(p);
            }
        }

        public void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNext();
            points.Add(head);

            tail.Clear();
            head.Draw();        
        }

        public Point GetNext()
        {
            Point head = points.Last();
            Point next = new Point(head);
            next.Move(1, direction);
            return next;
        }

        internal bool HitTail()
        {
            var head = points.Last();

            for(int i = 0; i < points.Count - 2; ++i)
            {
                if (head.Hit(points[i]))
                {
                    return true;
                }
            }
            return false;

        }

        public void Handle(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNext();
            if (head.Hit(food))
            {
                food.sym = head.sym;
                points.Add(food);
                return true;
            }
            else return false;
        }
    }
}
