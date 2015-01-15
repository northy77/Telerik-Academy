//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('-',20));
        Console.WriteLine("Sum: {0}",a+b+c);
    }
}

