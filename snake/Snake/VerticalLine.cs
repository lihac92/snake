using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point1> pList;
        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point1>();
            for (int y = yDown; y <= yUp; y++)
            {
                Point1 p = new Point1(x, y, sym);
                pList.Add(p);
            }

        }
        public void Draw()
        {
            foreach (Point1 p in pList)
            {
                p.Draw();
            }
        }
    }
}
