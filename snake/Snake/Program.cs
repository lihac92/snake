using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point1 p1 = new Point1();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            Point1 p2 = new Point1();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();
            Console.ReadLine();
        }
        
    }
}
