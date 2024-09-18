using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{

    internal class Snake : Figure
    {
        public Snake(Point taile, int leght, Direction direction)
        {
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
            throw new NotImplementedException();
        }
    }
}
