/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
* from the binary representation of n while preserving all other bits in n.*/

using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The representation of {0} in binary: {1}",
                    number, Convert.ToString(number, 2).PadLeft(16, '0'));

        int mask = 1 << position;
        if (value==0)
        {
            mask = number & ~(mask);
            Console.WriteLine("Binary number is:\n{0}\nand now has a value of: {1}",
                            Convert.ToString(number, 2).PadLeft(16, '0'));
        }
        else
        {
            number = number | mask;
            Console.WriteLine("Binary number is:{0} and now has a value of: {1}",
                             Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}

