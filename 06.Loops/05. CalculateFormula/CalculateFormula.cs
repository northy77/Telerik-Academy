/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;

class CalculateFormula
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        decimal xCheck = 1.00m;
        decimal fCheck = 1.00m;
        decimal sum = 1.00m;

        for (int i = 1; i <= n; i++)
        {
            xCheck *= x;
            fCheck *= x;
            sum += (fCheck / xCheck);
        }
        Console.WriteLine("Sum: " + sum);
    }
}

