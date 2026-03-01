using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity helps you list positive things in your life.";
    }

    protected override void RunActivity(int duration)
    {
        Random rand = new Random();
        string prompt = Prompts[rand.Next(Prompts.Length)];

        Console.WriteLine(prompt);
        Console.WriteLine("Take a moment to think...");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("Start listing items. Press Enter after each one.");

        while (DateTime.Now < end)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}