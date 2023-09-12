// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using CaptainCoder.TextAnalyzer;

string text = File.ReadAllText("dracula.txt");
Dictionary<string, int> frequencies = TextAnalyzer.Frequency(text);
// string text = File.ReadAllText("bread.txt");
// Console.WriteLine(text);
// HashSet<string> tokens = TextAnalyzer.UniqueWords(text);
// Dictionary<string, int> frequencies = TextAnalyzer.Frequency(text);

// foreach (string token in frequencies.Keys)
// {
//     // count = TextAnalyzer.CountWords(text, token);
//     Console.WriteLine($"{token}: {frequencies[token]}");
// }

// Console.WriteLine($"Found: {frequencies.Count} unique tokens");

while (true)
{
    PromptUser();
}


void PromptUser()
{
    
    Console.WriteLine("What word to check? ");
    string toCheck = Console.ReadLine()!.ToLowerInvariant();
    if(frequencies.TryGetValue(toCheck, out int result))
    {
        Console.WriteLine($"{toCheck} appears {result} times.");
    }
    else
    {
        Console.WriteLine("No occurrences.");
    }
}