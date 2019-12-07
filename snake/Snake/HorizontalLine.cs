using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point1> pList;
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point1>();
            for(int x = xLeft; x <= xRight; x++)
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
