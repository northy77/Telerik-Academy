/*Write a program that finds the biggest of five numbers by using only five if statements.*/

using System;

class BiggestFiveNums
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter e: ");
        double e = double.Parse(Console.ReadLine());

        if ((a > b && a > c && a > d && a > e) && (a==b || a==c || a==d || a==e || a==a))
        {
            Console.WriteLine("Biggest number: " + a);
        }
        else if ((b > a && b > c && b > d && b > e) && (b==b || b==c || b==d || b==e || b==b))
        {
            Console.WriteLine("Biggest number: " + b);
        }
        else if ((c > a && c > b && c > d && c > e) && (c == a || c == b || c == d || c == e || c == c))
        {
            Console.WriteLine("Biggest number: " + c);
        }
        else if ((d > a && d > b && d > c && d > e) && (d == a || d == b || d == c || d == e || d == d))
        {
            Console.WriteLine("Biggest number: " + d);
        }
        else
        {
            Console.WriteLine("Biggest number: " + e);
        }
    }
}

