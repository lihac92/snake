using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {

        protected List<Point1> pList;

        public void Draw()
        {
            foreach (Point1 p in pList)
            {
                p.Draw();
            }
        }
    }
}
