using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "q")
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("a. Write a new entry");
            Console.WriteLine("b. Display the journal");
            Console.WriteLine("c. Save the journal to a file");
            Console.WriteLine("d. Load the journal from a file");
            Console.WriteLine("q. Quit");
            Console.Write("What would you like to Choose?: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    journal.WriteNewEntry();
                    break;
                case "b":
                    journal.DisplayJournal();
                    break;
                case "c":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case "d":
                    Console.Write("Enter file to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case "q":
                    Console.WriteLine("GoodBye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
    }
}