// My hiderandomwords method only hides words that are not already hidden,
// so it gets progressively harder without re hiding the same words.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

        Console.Clear();
        string userInput = "";

        while (userInput?.ToLower() != "quit" && !scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            userInput = Console.ReadLine();

            if (userInput?.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nIf all words are hidden or user quit. THe program will end.");
    }
}