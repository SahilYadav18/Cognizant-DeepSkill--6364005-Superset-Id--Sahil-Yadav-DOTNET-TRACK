using System;
using System.Collections.Generic;

class WordFrequencyCounter
{
    public static void Main()
    {
        string input = "hello world hello code hello CSharp";
        string[] words = input.Split(' ');

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key} → {pair.Value}");
        }
    }
}