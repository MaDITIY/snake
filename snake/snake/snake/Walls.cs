using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls 
    {
        List<Figure> wallList = new List<Figure>();

        public Walls(int mapWidth, int mapHeight)
        {
            Hline Upline = new Hline(0, mapWidth - 1, 0, 'x');
            Hline Downline = new Hline(0, mapWidth - 1, mapHeight - 1, 'x');
            Vline Leftline = new Vline(0, 1, mapHeight - 1 , 'X');
            Vline Rightline = new Vline(mapWidth - 2, 1, mapHeight - 1, 'X');

            wallList.Add(Upline);
            wallList.Add(Downline);
            wallList.Add(Leftline);
            wallList.Add(Rightline);
        }

        public bool Hit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.Hit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
