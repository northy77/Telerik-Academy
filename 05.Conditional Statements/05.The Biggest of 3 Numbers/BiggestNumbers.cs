//Write a program that finds the biggest of three numbers.

using System;

class BiggestNumbers
{
    static void Main()
    {

        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine()); 
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine()); 
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a>c)
        {
            Console.WriteLine("Biggest number: " + a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("Biggest number: " + b);
        }
        else if (c > a && c > b)
        {
             Console.WriteLine("Biggest number: " + c);
        }
        else if (a > b && a==c)
        {
             Console.WriteLine("Biggest number: " + a);
        }
        else if (a > c && a == b)
        {
            Console.WriteLine("Biggest number: " + a);
        }
        else if (b > a && b == c)
        {
            Console.WriteLine("Biggest number: " + b);
        }
        else if (b > c && b == a)
        {
            Console.WriteLine("Biggest number: " + b);
        }
        else if (c > a && c == b)
        {
            Console.WriteLine("Biggest number: " + c);
        }
        else if (c > b && c == a)
        {
            Console.WriteLine("Biggest number: " + c);
        }

    }
}

