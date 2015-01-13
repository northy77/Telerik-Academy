/*Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? age = null;
        double? money = null;

        Console.WriteLine(age);
        Console.WriteLine(money);

        age = 5;
        money = 123;

        Console.WriteLine(age);
        Console.WriteLine(money);
    }
}

