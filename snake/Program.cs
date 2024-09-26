using snake; //необходимо подключать область snake, иначе наш созданный класс не виден
using System.Runtime.CompilerServices;
using System.Threading;

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

Point p = new Point (15, 5, '*');

Snake snake = new Snake(p, 4, Direction.RIGHT);

snake.Drow();

while (true)
{
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.LeftArrow)
            snake.direction = Direction.LEFT;
        if (key.Key == ConsoleKey.RightArrow)
            snake.direction = Direction.RIGHT;
        if (key.Key == ConsoleKey.UpArrow)
            snake.direction = Direction.UP;
        if (key.Key == ConsoleKey.DownArrow)
            snake.direction = Direction.DOWN;
    }

    Thread.Sleep(100);
    snake.Move();
}



