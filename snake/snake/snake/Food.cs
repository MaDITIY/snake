using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Food
    {
        int width;
        int height;
        char sym;

        Random rand = new Random();

        public Food(int width, int height, char sym)
        {
            this.width = width;
            this.height = height;
            this.sym = sym;
        }

        public Point Create()
        {
            int x = rand.Next(3, width - 3);
            int y = rand.Next(3, height - 3);
            return new Point(x, y, sym);
        }
    }
}
