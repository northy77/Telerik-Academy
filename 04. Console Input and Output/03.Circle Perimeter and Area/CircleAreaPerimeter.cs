/*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.*/

using System;

class CircleAreaPerimeter
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter: {0:F2}", 2*radius*Math.PI);
        Console.WriteLine("Area: {0:F2}",radius*radius*Math.PI);
    }
}

