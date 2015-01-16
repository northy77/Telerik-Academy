/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.*/

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double product = 0;

        if (a*b*c > 0)
        {
            Console.WriteLine("+");
        }
        else if (a*b*c < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }

    }
}

