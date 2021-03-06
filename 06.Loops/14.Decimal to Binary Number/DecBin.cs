﻿/*Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.*/

using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter decimal number: ");
            int decNum = int.Parse(Console.ReadLine());
            int reminder;
            string result = "";
            while (decNum > 0)
            {
                reminder = decNum % 2;
                decNum /= 2;
                result = reminder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }

