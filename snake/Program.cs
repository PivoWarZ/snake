using snake; //необходимо подключать область snake, иначе наш созданный класс не виден
using System.Runtime.CompilerServices;

Console.SetWindowSize(width: 80, height: 25); // выставляем размеры окна и отключаем возможность прокрутки


// отрисовываем рамочку

HorizontalLine uplLine = new HorizontalLine(0, 78, 0, '+');

HorizontalLine downlLine = new HorizontalLine(0, 78, 24, '+');

VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');

VerticalLine rightLine = new VerticalLine(78, 24, 0, '+');

uplLine.Drow();

downlLine.Drow();

leftLine.Drow();

rightLine.Drow();


Console.ReadLine();