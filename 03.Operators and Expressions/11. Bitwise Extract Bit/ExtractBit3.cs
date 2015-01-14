/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of the {0} is: {1}", number, Convert.ToString(number, 2).PadLeft(8, '0'));
        int position = 3;
        int bit = 1 << position;
        Console.WriteLine((number & bit) == bit ? "Third bit is 1" : "Third bit is 0");
    }
}

