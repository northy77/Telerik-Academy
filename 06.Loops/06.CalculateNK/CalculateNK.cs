/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/

using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        if (1 < k && k < n && n < 100)
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        Console.WriteLine("N!/!K = {0}", result);
    }
}

