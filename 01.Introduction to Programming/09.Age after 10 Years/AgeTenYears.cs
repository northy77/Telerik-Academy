//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

using System;

class AgeTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday in fromat MM/DD/YYYY:");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        DateTime timeNow = DateTime.Now;
        int ageNow = timeNow.Year - birthDate.Year;
        
        if (DateTime.Now.AddYears(-ageNow) < birthDate) 
        {
            --ageNow;
        }
        Console.WriteLine("Today you are {0} years old.", ageNow);
        Console.WriteLine("After ten years you will be {0} years old.", ageNow + 10);
    }
}

