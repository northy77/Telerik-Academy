//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

using System;

class PrintLongSequence
{
    static void Main()
    {
        bool check = true;
        for (int i = 2; i <= 1001; i++)
        {
            if (check)
            {
                Console.WriteLine(i);
                check = false;
            }
            else
            {
                Console.WriteLine("-"+i);
                check = true;
            }
        }
    }
}

