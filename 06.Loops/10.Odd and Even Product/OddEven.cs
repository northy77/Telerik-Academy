/*u are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int productEven = 1;
        int productOdd = 1;
        bool check = true;

        for (int i = 0; i < number; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (check)
            {
                productEven *= num;  
            }
            else
            {
                productOdd *= num;
            }
            check = !check;
        }
        if (productOdd==productEven)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

