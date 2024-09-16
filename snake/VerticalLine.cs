using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class VerticalLine
    {
        List<Point> vList = new List<Point>();
        public VerticalLine(int x, int upperY, int lowerY, char sym) 
        
        { 
        

            for (int y = upperY; y >= lowerY; y--)
            { 
            
                Point p = new Point (x, y, sym);

                vList.Add (p);
            
            }
        }


        public void Drow()
        { 
            foreach (Point p in vList)

            p.Draw();
        }
    }
}
