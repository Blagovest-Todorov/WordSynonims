using System;
using System.Collections.Generic;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfwords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfwords; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synonim);
                }
                else // (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>() { synonim});
                }
            }

            foreach (var synonim in dictionary)
            {
                Console.WriteLine($"{synonim.Key} - {string.Join(", " , synonim.Value)}");
            }
        }
    }
}
