/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Alexander";
        string middleName = "Avramov";
        string lastName = "Stefanov";
        string bankName = "Unicredit Bank";
        long iban = 8306112507;
        int balance = 27560000;
        string mastercard = "830611250712";
        string visa = "125125125512";
        string paypal = "545155315231";

        Console.WriteLine("Name: "+ firstName + " " + middleName + " " + lastName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Bank: " + bankName);
        Console.WriteLine("Balance: "+ balance);
        Console.WriteLine("Mastercard: " + mastercard);
        Console.WriteLine("Visa: " + visa);
        Console.WriteLine("Paypal: "+paypal);
    }
}

