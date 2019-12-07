using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point1 tail, int length, Direction direction)
        {
            pList = new List<Point1>();
            for(int i = 0; i < length; i++)
            {
                Point1 p = new Point1(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
