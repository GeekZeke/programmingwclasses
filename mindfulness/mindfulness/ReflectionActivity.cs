using System;

class ReflectionActivity : Activity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What could you learn from this?",
        "What did you learn about yourself?",
        "How can you keep this in mind in the future?"
    };

    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "This activity helps you reflect on moments of strength and resilience.";
    }

    protected override void RunActivity(int duration)
    {
        Random rand = new Random();
        string prompt = Prompts[rand.Next(Prompts.Length)];

        Console.WriteLine(prompt);
        Spinner(3);

        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            string question = Questions[rand.Next(Questions.Length)];
            Console.WriteLine(question);
            Spinner(3);
        }
    }
}