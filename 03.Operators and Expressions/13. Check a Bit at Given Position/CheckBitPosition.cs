//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.


using System;

    class CheckBitPosition
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("The representation of {0} in binary: {1}",
                    number, Convert.ToString(number, 2).PadLeft(16,'0'));

            if ((number & (1 << position)) == 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }

