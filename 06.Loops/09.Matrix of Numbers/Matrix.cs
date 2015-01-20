/*Write a program that reads from the console a positive integer number n (1 = n = 20) 
 * and prints a matrix like in the examples below. Use two nested loops.*/

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int k = 0;

        for (int row = 0; row < n; row++)
        {
            for (int z = 1 + k ; z <= n + k; z++)
            {
                Console.Write("{0} ", z);
            }
            Console.WriteLine();
            k++;
        }
    }
}

