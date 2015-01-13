/*Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.*/

using System;

class ExchangeVariables
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;

        Console.WriteLine(a);
        Console.WriteLine(b);

        Console.WriteLine();
        c = a;
        a = b;
        b = c;

        Console.WriteLine(a);
        Console.WriteLine(b);
       
    }
}

