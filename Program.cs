using System;
using System.IO;

namespace WordEndingsCounter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the full path to the file:");
            string filePath = Console.ReadLine();

            if (string.IsNullOrEmpty(filePath))
            {
                Console.WriteLine("No file path entered.");
                return;
            }

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found: {filePath}");
                return;
            }

            string content = File.ReadAllText(filePath);
            int count = CountWordsEndingWithTOrE(content);

            Console.WriteLine($"Number of words ending with 't' or 'e': {count}");
        }

        private static int CountWordsEndingWithTOrE(string content)
        {
            string[] words = content.Split(new char[] { ' ', '.', ',', ';', '!', '?', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (string word in words)
            {
                char lastChar = char.ToLower(word[word.Length - 1]);
                if (lastChar == 't' || lastChar == 'e')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
