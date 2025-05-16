using System.Collections.Generic;

public static class WordRepository
{
    public static readonly IDictionary<string, string> WordsWithHints = new Dictionary<string, string>
    {
        { "apple", "fruit" },
        { "banana", "fruit" },
        { "tiger", "animal" },
        { "elephant", "animal" },
        { "guitar", "instrument" },
        { "violin", "instrument" },
        { "canada", "country" },
        { "brazil", "country" },
        { "laptop", "object" },
        { "microscope", "scientific instrument" }
    };
}
