/*Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

using System;

class CompareFloat
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        bool compare = (Math.Abs(firstNum - secondNum) < 0.000001);

        if (compare)
        {
            Console.WriteLine((compare) + ": Numbers are equal with a precision of 0.000001.");
        }
        else
        {
            Console.WriteLine((compare) + ": Numbers are not equal with a precision of 0.000001.");
        }
    }
}

