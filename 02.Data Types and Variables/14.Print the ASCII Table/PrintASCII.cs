﻿/*Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).*/

using System;

class PrintASCII
{
    static void Main()
    {
        for (int i = 32; i < 127; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

