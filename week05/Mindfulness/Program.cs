using System;

class Program
{
    static void Main(string[] args)
    {
      while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness App");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("q. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine()?.Trim().ToLower();

            if (choice == "q")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            switch (choice)
            {
                case "1":
                    var breathing = new BreathingActivity();
                    breathing.Start();
                    break;
                case "2":
                    var reflecting = new ReflectionActivity();
                    reflecting.Start();
                    break;
                case "3":
                    var listing = new ListingActivity();
                    listing.Start();
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}