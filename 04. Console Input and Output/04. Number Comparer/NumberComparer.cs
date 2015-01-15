/*Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.*/

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        if (a>b)
        {
            Console.WriteLine("{0} bigger than {1}",a,b);
        }
        else if (a<b)
        {
            Console.WriteLine("{0} bigger than {1}",b,a);
        }
        else
        {
            Console.WriteLine("Equal");
        }
    }
}

