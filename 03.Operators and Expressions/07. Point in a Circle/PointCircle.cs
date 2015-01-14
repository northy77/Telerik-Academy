//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool checkPoint = Math.Sqrt(x * x + y * y) <= 2;
        if (checkPoint)
        {
            Console.WriteLine("Point is inside circle.");
        }
        else
        {
            Console.WriteLine("Point isn't inside cicle.");
        }
    }
}

