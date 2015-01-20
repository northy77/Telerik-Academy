/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.*/

using System;

class MinMaxNumbers
{
    static void Main()
    {
        Console.Write("How much numbers: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        double average = (double)sum / n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);

    }
}

