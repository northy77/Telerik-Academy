/*Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int rand = rnd.Next(1, n);
            Console.Write("{0} ", rand);
        }
    }
}

