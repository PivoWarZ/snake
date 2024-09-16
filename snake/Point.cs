using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {

        public int x;
        public int y;
        public char sym;

        public Point (int pX, int pY, char pSym)
        {

            x = pX;
            y = pY;
            sym = pSym;

        }

        public void Draw()
        {

            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }

    }
}
