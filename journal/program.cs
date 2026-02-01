using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "What did I learn today?"
        };

        Random random = new Random();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Search entries by date");
            Console.WriteLine("6. Quit");
            
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                string prompt = prompts[random.Next(prompts.Count)];
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToString("M/d/yyyy");

                Entry entry = new Entry
                {
                    _date = date,
                    _prompt = prompt,
                    _response = response
                };

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved.\n");
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded.\n");
            }

            else if (choice == 5)
            {
                Console.Write("Enter date to search (ex: 3/15/2026): ");
                string date = Console.ReadLine();

                journal.SearchByDate(date);
            }

        }
    }
}
