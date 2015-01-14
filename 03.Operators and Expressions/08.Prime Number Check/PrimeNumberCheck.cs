//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool check = true;
        if (number < 2)
        {
            check = false;
        }
        else
        {
            for (int i = 2; i < 2; i++)
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
            }
        }
      
        
        if (check)
        {
            Console.WriteLine("Number is Prime.");
        }
        else
        {
            Console.WriteLine("Number is not Prime.");
        }
    }
}

