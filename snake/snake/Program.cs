using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 85;
            Console.WindowHeight = 25;
            Console.SetBufferSize(85, 25);

            Hline Upline = new Hline(1, 84, 0, '-');
            Hline Downline = new Hline(1, 84, 24, '-');
            Vline Leftline = new Vline(1, 1, 24, '|');
            Vline Rightline = new Vline(83, 1, 24, '|');

            Upline.Draw();
            Downline.Draw();
            Leftline.Draw();
            Rightline.Draw();

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}