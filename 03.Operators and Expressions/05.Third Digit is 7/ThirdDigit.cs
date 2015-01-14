//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int check = int.Parse(Console.ReadLine());
        int divide = check / 100;
        int remainder = divide % 10;
        if (remainder==7)
        {
            Console.WriteLine("Third digit is 7.");
        }
        else
        {
            Console.WriteLine("Third digit isn't 7.");
        }
    }
}

