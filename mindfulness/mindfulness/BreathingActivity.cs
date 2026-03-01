using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity helps you relax by breathing in and out slowly.";
    }

    protected override void RunActivity(int duration)
    {
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            elapsed += 3;

            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            Countdown(3);
            elapsed += 3;
        }
    }
}