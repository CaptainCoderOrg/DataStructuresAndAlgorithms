
string secretWord = "BANANA";
int guessesRemaining = 6;
BinarySearchTree guesses = new BinarySearchTree();
Console.Clear();
while (guessesRemaining > 0)
{
    DisplayWord(secretWord, guesses);
    if (IsWordGuessed(secretWord, guesses))
    {
        Console.WriteLine("You done did it!");
        break;
    }

    DisplayGuesses(guesses);
    Console.WriteLine($"Guesses Remaining: {guessesRemaining}");
    char guess = ReadLetter();
    
    if (guesses.Contains(guess))
    {
        Console.WriteLine($"You've already guessed {guess}.");
        continue;
    }

    guesses.Insert(guess);
    Console.Clear();
    if (secretWord.Contains(guess))
    {
        Console.WriteLine("Got one!");

    }
    else
    {
        Console.WriteLine("Nope!");
        guessesRemaining--;
    }
    

}

if (guessesRemaining <= 0)
{
    Console.WriteLine("You done did lost.");
}

bool IsWordGuessed(string secretWord, BinarySearchTree guesses)
{
    foreach (char ch in secretWord)
    {
        if (!guesses.Contains(ch)) { return false; }
    }
    return true;
}

void DisplayGuesses(BinarySearchTree guesses)
{
    Console.WriteLine($"Guesses so far: {string.Join(", ", guesses.AllData)}");
}

void DisplayWord(string word, BinarySearchTree guesses)
{
    foreach (char ch in word)
    {
        if (guesses.Contains(ch))
        {
            Console.Write(ch + " ");
        }
        else
        {
            Console.Write("_ ");
        }
    }
    Console.WriteLine();
}

char ReadLetter()
{
    Console.Write("What is your guess? ");
    string guess = Console.ReadLine()!;
    if (guess.Length != 1)
    {
        Console.WriteLine("You must enter exactly one letter.");
        return ReadLetter();
    }
    return guess.ToUpper()[0];
}