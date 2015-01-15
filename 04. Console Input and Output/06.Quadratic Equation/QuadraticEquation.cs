/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double d = Math.Sqrt(b * b - (4 * a * c));
        Console.WriteLine("x1 = {0}", (-b - d)/(2*a));
        Console.WriteLine("x1 = {0}", (-b + d) / (2 * a));
    }
}

