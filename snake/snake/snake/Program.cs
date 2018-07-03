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
            Console.CursorVisible = false;

            Walls walls = new Walls(85, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Draw();

            Food newFood = new Food(85, 25, '$');
            Point food = newFood.Create();
            food.Draw();

            while (true)
            {
                if(walls.Hit(snake) || snake.HitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = newFood.Create();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(150);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
            }

            Console.Clear();
            walls.Draw();

            Console.SetCursorPosition(37, 12);
            Console.WriteLine("You Lose!");

            Console.ReadKey();
        }
    }
}