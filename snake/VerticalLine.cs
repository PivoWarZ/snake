using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class VerticalLine : Figure
    {
    
        public VerticalLine(int x, int upperY, int lowerY, char sym) 
        
        { 
            pList = new List<Point>();

            for (int y = upperY; y >= lowerY; y--)
            { 
            
                Point p = new Point (x, y, sym);

                pList.Add (p);
            
            }
        }

         
    }
}
