/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
 * 
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)*/

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Alex";
        string lastName = "Stefanov";
        byte age = 19;
        char gender = 'm';
        ulong idNumber = 8306112507;
        long employeeNumber = 27560000;

        Console.WriteLine("Full Name:"+firstName + " " + lastName + "\n" 
                          + "Age:" + age + "\n"
                          + "Gender:" + gender + "\n"
                          + "idNumber:" + idNumber + "\n" 
                          + "Employee Number:" + employeeNumber);
    }
}

