using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    protected override void OnRun()
    {
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

      
        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine("When you are ready, reflect on the following questions.");
        ShowSpinner(3);

    
        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine();
            Console.WriteLine("-> " + question);
            ShowSpinner(6); 
        }
    }
}