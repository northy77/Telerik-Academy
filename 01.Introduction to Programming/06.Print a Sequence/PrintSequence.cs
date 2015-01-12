//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class PrintSequence
{
    static void Main()
    {
        bool a = true;
        for (int i = 2; i < 12; i++)
        {
            
            if (a)
            {
                  Console.WriteLine(i);
                  a = false;
            }
            else
            {
                Console.WriteLine("-" + i);
                a = true;
            }
        }
    }
}

