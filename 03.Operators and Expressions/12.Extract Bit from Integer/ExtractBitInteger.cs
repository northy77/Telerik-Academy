//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int input = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of {0} is: {1}",input, Convert.ToString(input, 2).PadLeft(16, '0'));
        int mask = 1 << position;
        Console.WriteLine((input & mask) == mask ? 
                            "The bit in position {0} is: 1 " :
                            "The bit in position {0} is: 0"
                            , position);
    }
}

