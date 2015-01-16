/*Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.*/

using System;

class ExchangeGreater
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        if (a>b)
        {
            Console.WriteLine("{0} {1}",b,a);
        }
        else if(b>a)
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

