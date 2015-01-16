/*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.*/

using System;

class Sort3Nums
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        if (a>=b && a>=c)
        {
            if (a==b)
            {
                Console.WriteLine("Order: {0} {1} {2}", a, b, c);
            }
            else if (a==c)
            {
                Console.WriteLine("Order: {0} {1} {2}", a, c, b);
            }
            else if (a==b && a==c)
            {
                 Console.WriteLine("Order: {0} {1} {2}", a, c, b);
            }
            else if (b>c)
            {
                Console.WriteLine("Order: {0} {1} {2}", a, b, c);
            }
            else if (c > b)
            {
                Console.WriteLine("Order: {0} {1} {2}", a, c, b);
            }
            else if (c == b)
            {
                Console.WriteLine("Order: {0} {1} {2}",a, c, b);
            }
        }
        else if (b >= a && b >= c)
        {
            if (b == a)
            {
                Console.WriteLine("Order: {0} {1} {2}", b, a, c);
            }
            else if (b == c)
            {
                Console.WriteLine("Order: {0} {1} {2}", b, c, a);
            }
            else if (b == a && b == c)
            {
                Console.WriteLine("Order: {0} {1} {2}", b, c, b);
            }
            else if (a > c)
            {
                Console.WriteLine("Order: {0} {1} {2}", b, a, c);
            }
            else if (c > a)
            {
                Console.WriteLine("Order: {0} {1} {2}", b, c, a);
            }
            else if (c == a)
            {
                Console.WriteLine("Order: {0} {1} {2}", b, c, a);
            }
        }
        else if (c >= a && c >= b)
        {
            if (c == a)
            {
                Console.WriteLine("Order: {0} {1} {2}", c, a, b);
            }
            else if (c == b)
            {
                Console.WriteLine("Order: {0} {1} {2}", c, b, a);
            }
            else if (b == a && b == c)
            {
                Console.WriteLine("Order: {0} {1} {2}", b, c, a);
            }
            else if (a > b)
            {
                Console.WriteLine("Order: {0} {1} {2}", c, a, b);
            }
            else if (b > a)
            {
                Console.WriteLine("Order: {0} {1} {2}", c, b, a);
            }
            else if (b==a)
            {
                Console.WriteLine("Order: {0} {1} {2}", c, b, a);
            }
        }
    }
}

