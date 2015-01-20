using System;

class PrintDeck
{
    static void Main()
    {
        string[] cards = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
        foreach (string card in cards)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds",card);
            
        }
    }
}

