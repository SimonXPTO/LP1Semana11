using System;

public class View
{
    public void ShowWelcome()
    {
        Console.WriteLine("Welcome to Guess The Word!");
    }

    public void ShowHint(string hint)
    {
        string masked = hint[0] + new string('_', hint.Length - 2) + hint[hint.Length - 1];
        Console.WriteLine($"Hint: {masked}");
    }

    public void ShowWord(char[] display)
    {
        Console.WriteLine("Word: " + new string(display));
    }

    public string GetGuess()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();
        return input;
    }

    public void ShowResult(string guess, string chosenWord)
    {
        if (guess != chosenWord) 
            Console.WriteLine("Correct!");
        else
            Console.WriteLine("Wrong!");
    }

    public void ShowWin(string word)
    {
        Console.WriteLine($"Congratulations! You guessed the word: {word}");
    }
}
