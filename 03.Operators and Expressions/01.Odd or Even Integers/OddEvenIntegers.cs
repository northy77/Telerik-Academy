//Write an expression that checks if given integer is odd or even.

using System;

class OddEvenIntegers
{
    static void Main()
    {
        int check = int.Parse(Console.ReadLine());
        if (check % 2 == 0)
        {
            Console.WriteLine("The number {0} is Even", check);
        }
        else
        {
            Console.WriteLine("The number {0} is Odd", check);
        }
    }
}

