/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;

class Program
{
    static void Main()
    {
        string companyName = "Telerik Academy";
        string companyAdress = "31 Al. Malinov, Sofia";
        string phoneNumber = "+359 888 55 55 555";
        byte faxNumber = 2;
        string webSite = "http://telerikacademy.com/";
        string managerF = "Nikolay";
        string managerL = "LastName";
        byte age = 25;
        string managerPhone = "+359 2 981 981";

        Console.WriteLine(companyName);
        Console.WriteLine("Phone number: {0}", phoneNumber);
        Console.WriteLine("Web Site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age:{2}, phone: {3}", managerF,managerL,age,managerPhone);


    }
}

