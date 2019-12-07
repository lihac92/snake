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
           
            
            Point1 p1 = new Point1(1, 3 , '*');
            p1.Draw();

            Point1 p2 = new Point1(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 4, '-');
            line.Draw();

            VerticalLine line1 = new VerticalLine(2, 6, 13, '+');
            line1.Draw();

            Console.ReadLine();
        }
        
    }
}
