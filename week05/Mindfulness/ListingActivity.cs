using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    protected override void OnRun()
    {
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

     
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine("You will have a few seconds to think about it...");
        ShowCountdown(5);
        Console.WriteLine("\nStart listing items. Press Enter after each item.");

        List<string> items = new List<string>();


        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();

            
            if (!string.IsNullOrWhiteSpace(entry))
            {
                items.Add(entry.Trim());
            }

           
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} item(s).");
        Console.WriteLine();
    }
}
