using System;
using System.Threading;
using System.IO;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }


    public void Start()
    {
        ShowStartMessage();
        AskDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        OnRun();
        ShowEndMessage();
    }

    protected abstract void OnRun();

    private void ShowStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    private void AskDuration()
    {
        while (true)
        {
            Console.Write("Enter duration in seconds: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int seconds) && seconds > 0)
            {
                _duration = seconds;
                break;
            }
            Console.WriteLine("Please enter a valid positive number.");
        }
    }

    protected int GetDuration()
    {
        return _duration;
    }

    private void ShowEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the activity for {_duration} seconds.");
        ShowSpinner(3);

        LogActivity();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = new string[] { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i++;
        }
    }


    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected void LogActivity()
{
    string log = $"{DateTime.Now}: Completed {_name} for {_duration} seconds.";

    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "activity_log.txt");

    File.AppendAllText(path, log + Environment.NewLine);

    Console.WriteLine($"Your activity was successfully logged!");
}
}