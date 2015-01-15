//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumNumbers
{
    static void Main()
    {
        double number;
        double sum=0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Enter number №:{0} --->",i);
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}

