/*Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.*/

using System;

class BinaryToDec
{
    static void Main()
    {
        Console.WriteLine("Enter num in binary format");
        string binaryNum = Console.ReadLine();
        long decNumber = 0;
        for (int i = 0; i < binaryNum.Length; i++)
        {
            int position = binaryNum.Length - i - 1;
            int num = int.Parse(binaryNum[position].ToString());
            if (num == 1)
            {
                decNumber = (long)(decNumber + Math.Pow(2, i));
            }
        }
        Console.WriteLine(decNumber);
    }
}

