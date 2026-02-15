using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random = new Random();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public void Display()
        {
            Console.WriteLine(_reference.ToString());
            foreach (Word word in _words)
            {
                Console.Write(word.Display() + " ");
            }
            Console.WriteLine("\n");
        }

        public void HideRandomWords(int count = 3)
        {
            // Only hide words that are currently visible
            var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
            if (visibleWords.Count == 0) return;

            for (int i = 0; i < count; i++)
            {
                if (visibleWords.Count == 0) break;
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }

        public bool AllHidden()
        {
            return _words.All(w => w.IsHidden());
        }
    }
}
