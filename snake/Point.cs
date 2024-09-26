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
      
        public Point (Point p)
        { 
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT: x = x + offset; break;
                case Direction.LEFT: x = x - offset; break;
                case Direction.UP: y = y - offset; break;
                case Direction.DOWN: y = y + offset; break;
            }
        }

        public void Draw()
        {

            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }


        public override string ToString()
        {
            return x + " , " + y + " + " + sym;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }



    }
}
