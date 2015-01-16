/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

using System;

class PlayWith
{
    static void Main()
    {
        Console.WriteLine("Choose a type: ");
        string choice = Console.ReadLine();

        if (choice=="1")
        {
            Console.Write("Please enter a int: ");
            int firstChoice = int.Parse(Console.ReadLine());
        }
        else if (choice=="2")
        {
            Console.Write("Please enter a string: ");
            string secondChoice = Console.ReadLine();
        }
        else if (choice=="3")
        {
            Console.Write("Please enter a double: ");
            double secondChoice = double.Parse(Console.ReadLine());
        }
    }
}

