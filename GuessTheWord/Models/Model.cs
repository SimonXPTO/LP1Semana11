using System;
using System.Collections.Generic;

public class Model
{
    public string ChosenWord { get; private set; }
    public string Hint { get; private set; }
    public char[] Display { get; private set; }
    public HashSet<int> RevealedIndices { get; private set; }

    public Model()
    {
        // Select a random word
        Random rand = new Random();
        List<string> words = new List<string>(WordRepository.WordsWithHints.Keys);
        string chosenWord = words[rand.Next(words.Count)];
        string hint = WordRepository.WordsWithHints[chosenWord];

        // Determine revealed letter positions (up to 50% of the length)
        int length = chosenWord.Length;
        int numToReveal = Math.Max(1, (int)Math.Floor(length * 0.4));  // at least 1 letter
        char[] display = new string('_', length).ToCharArray();

        // Use hash code of the word for consistent seeding
        int seed = chosenWord.GetHashCode();
        Random maskRand = new Random(seed);

        HashSet<int> revealedIndices = new HashSet<int>();
        while (revealedIndices.Count < numToReveal)
        {
            int index = maskRand.Next(length);
            revealedIndices.Add(index);
        }

        // Assign to properties
        ChosenWord = chosenWord;
        Hint = hint;
        Display = display;
        RevealedIndices = revealedIndices;
    }
}
