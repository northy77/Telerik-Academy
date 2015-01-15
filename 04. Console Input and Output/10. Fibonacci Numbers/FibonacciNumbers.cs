﻿/*Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Numbers: ");
        int nums = int.Parse(Console.ReadLine());
        
        if (nums==1)
        {
            Console.WriteLine("0");
        }
        else if (nums==2)
        {
            Console.WriteLine("0, 2");
        }
        else if (nums==3)
	    {
		  Console.WriteLine("0, 1, 1");
	    }
        else
        {
            int startNum = 2;
            int futureNum = 3;
            Console.Write("0, 1, 1");
            for (int i = 0; i < nums; i++)
            {
                int oldNum = futureNum;
                Console.Write(", {0}", startNum);
                futureNum += startNum;
                startNum = oldNum;
            }
            Console.WriteLine();
        }
    }
}

