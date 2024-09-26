using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{

    internal class Snake : Figure
    {
        public Direction direction;
        public Snake(Point taile, int leght, Direction snakeDirection)
        {
            direction = snakeDirection;
            pList = new List<Point>();

            for (int i = 0; i < leght; i++)
            {
                Point p = new Point (taile);
                p.Move (i, direction);
                pList.Add (p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First ();
            pList.Remove (tail);
            Point head = GetNextPoint();
            pList.Add (head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        { 
            Point head = pList.Last ();
            Point nextpoint = new Point (head);
            nextpoint.Move(1, direction);
            return nextpoint;
        }
    }
}
