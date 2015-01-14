//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter h: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine(new string('-',12));
        Console.WriteLine("Area is: {0}", ((a+b)/2)*h);
    }
}
