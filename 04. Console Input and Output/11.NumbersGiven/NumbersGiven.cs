/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End number: ");
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            if (start % 5 == 0)
            {
                Console.Write("{0}, ", start);
            }
            start++;
        }
    }
}

