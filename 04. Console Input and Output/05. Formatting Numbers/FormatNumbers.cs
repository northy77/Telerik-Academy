/*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/

using System;

class FormatNumbers
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("{0,-3:X}|{1}|{2,6:F2}|{3,-3:F2}",a,Convert.ToString(a,2).PadLeft(16,'0'),b,c);
    }
}

