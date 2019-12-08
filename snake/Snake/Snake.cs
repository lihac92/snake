using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point1 tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point1>();
            for(int i = 0; i < length; i++)
            {
                Point1 p = new Point1(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point1 tail = pList.First();
            pList.Remove(tail);
            Point1 head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point1 GetNextPoint()
        {
            Point1 head = pList.Last();
            Point1 nextPoint = new Point1(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;

        }
    }
}
