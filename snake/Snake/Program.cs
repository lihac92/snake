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

            Point1 p3 = new Point1(2, 6, '$');
            p3.Draw();

            Point1 p4 = new Point1(7, 9, '@');
            p4.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }
            List<Point1> pList = new List<Point1>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

           

            Console.ReadLine();
        }
        
    }
}
