//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter of the rectangle is: {0}", 2 * (width + height));
        Console.WriteLine("The area of the rectangle is: {0}", width*height);

    }
}

