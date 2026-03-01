using System;
using System.Threading;

abstract class Activity
{
    protected string Name;
    protected string Description;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine(Description);

        Console.Write("How many seconds would you like to do this activity? ");
        if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
        {
            duration = 10;
        }

        Console.WriteLine("Prepare to begin...");
        Spinner(3);

        RunActivity(duration);

        End(duration);
    }

    protected abstract void RunActivity(int duration);

    protected void End(int duration)
    {
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on {Name}.");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        int index = 0;
        DateTime end = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            Console.Write(frames[index % frames.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            index++;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}