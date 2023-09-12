namespace CaptainCoder.TextAnalyzer;
public static class TextAnalyzer
{
    /// <summary>
    /// Given a string of text, removes all non-alphanumeric characters and splits
    /// on whitespace.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static IEnumerable<string> Tokenize(string text)
    {
        // TODO: We could implement this further
        // What about hyphens? 
        // Can we do it in a single pass?
        string filteredText = string.Join("", text.Where(ch => char.IsLetter(ch) || char.IsWhiteSpace(ch)));
        return filteredText.ToLowerInvariant().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
    }

    public static Dictionary<string, int> Frequency(string text)
    {
        IEnumerable<string> tokens = Tokenize(text);
        Dictionary<string, int> frequency = new ();
        foreach (string token in tokens)
        {
            if ( ! frequency.ContainsKey(token)) // O(1) - Constant time
            {
                frequency[token] = 1;
            }
            else
            {
                frequency[token]++;
            }
            
        }
        return frequency;
    }

    /// <summary>
    /// Counts the number of times the specified <paramref name="word"/> appears in the
    /// specified <paramref name="text"/>
    /// </summary>
    public static int CountWords(string text, string word)
    {
        IEnumerable<string> tokens = Tokenize(text);
        int count = 0;
        foreach (string token in tokens)
        {
            if (token == word)
            {
                count++;
            }
        }
        return count;
    }

    /// <summary>
    /// Finds the unique tokens within the specified <paramref name="text"/> and returns
    /// them.
    /// </summary>
    public static HashSet<string> UniqueWords(string text)
    {
        IEnumerable<string> tokens = Tokenize(text);
        HashSet<string> uniqueTokens = new (); 
        foreach (string token in tokens)
        {
            if ( ! uniqueTokens.Contains(token)) // O(1) - Constant time
            {
                uniqueTokens.Add(token);
            }
        }
        return uniqueTokens;
    }
}