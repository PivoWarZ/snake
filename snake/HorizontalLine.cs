using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> pList = new List<Point>();
        

        public HorizontalLine(int xLeft, int xRight, int y, char sym) 
        {

            for (int x = xLeft; x <= xRight; x++)
            {

                Point p = new Point(x, y, sym);

                pList.Add(p);

            }
          

          


        }

        public void Drow ()
        {

            foreach (Point p in pList)
            {

                p.Draw();

            }

        }

    }
}
