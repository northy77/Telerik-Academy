//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int check = int.Parse(Console.ReadLine());

        if (check % 5 == 0 && check % 7 == 0)
        {
            Console.WriteLine("The number can be divided by 7 and 5 (without remainder) at the same time.");
        }
        else
        {
            Console.WriteLine("The number can't be divided by 7 and 5 (without remainder) at the same time.");
        }

    }
}

