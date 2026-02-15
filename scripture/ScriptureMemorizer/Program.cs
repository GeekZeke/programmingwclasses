using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main()
        {
            // Example scripture
            Reference reference = new Reference("John", 3, 16);
            string text = "For God so loved the world, that he gave his only begotten Son, " +
                          "that whosoever believeth in him should not perish, but have everlasting life.";

            Scripture scripture = new Scripture(reference, text);

            while (true)
            {
                // Safe console clear
                try { Console.Clear(); } catch (System.IO.IOException) { }

                scripture.Display();

                if (scripture.AllHidden())
                {
                    Console.WriteLine("All words are hidden. Great job memorizing!");
                    break;
                }

                Console.WriteLine("Press ENTER to hide more words or type 'quit' to exit.");
                string? input = Console.ReadLine(); // null-safe
                if (input?.ToLower() == "quit")
                    break;

                scripture.HideRandomWords();
            }
        }
    }
}
