/*In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (1 < n < 100).*/

using System;
using System.Numerics;

class CatalanNums
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger numerator = 1, denominator = 1;
        for (int i = n + 2; i <= 2 * n; i++)
        {
            numerator *= i;
        }
        for (int i = 1; i <= n; i++)
        {
            denominator *= i;
        }
        Console.WriteLine("Catalan(n): {0}", numerator / denominator);
    }
}

