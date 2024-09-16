using snake; //необходимо подключать область snake, иначе наш созданный класс не виден
using System.Runtime.CompilerServices;



Point p1 = new Point(3, 5, '*');

   // p1.Draw();


Point p2 = new Point(1, 2, '#');

   // p2.Draw();

HorizontalLine hlLine = new HorizontalLine(4, 10, 4, '-');

hlLine.Drow();

VerticalLine vLine = new VerticalLine(4, 10, 4, '|');

vLine.Drow();

Console.ReadLine();