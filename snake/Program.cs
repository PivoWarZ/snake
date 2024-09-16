using snake; //необходимо подключать область snake, иначе наш созданный класс не виден
using System.Runtime.CompilerServices;



Point p1 = new Point(3, 5, '*');

   // p1.Draw();


Point p2 = new Point(1, 2, '#');

   // p2.Draw();

//Console.ReadLine();

List<int> inList = new List<int>();

    inList.Add(1);
    inList.Add(2);
    inList.Add(3);

    foreach (int i in inList)
    {

        Console.WriteLine(i);

    }

List<Point> list = new List<Point>();
list.Add(p1);
list.Add(p2);

foreach (Point i in list)
    {

        i.Draw();

    }
Console.ReadLine();