using System;
using System.Collections.Generic;

namespace list_of_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
// Make a new list
List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

// Create dictionary to represent a few words
Dictionary<string, string> excitedWord = new Dictionary<string, string>();

// Add each of the 4 bits of data about the word to the Dictionary
excitedWord.Add("word", "excited");
excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
excitedWord.Add("part of speech", "adj");
excitedWord.Add("example", "I am excited to learn C#!");

// Add Dictionary to your `dictionaryOfWords` list
dictionaryOfWords.Add(excitedWord);

// create another Dictionary and add that to the list
Dictionary<string, string> sadWord = new Dictionary<string, string>() {
    {"word", "sad"},
    {"definition", "not happy"},
    {"part of speech", "adj"},
    {"example", "I am sad that I keep getting stuck."}
};

dictionaryOfWords.Add(sadWord);

// Iterate the List of Dictionaries
 dictionaryOfWords.ForEach(dictionary =>
      {
        // Iterate the KeyValuePairs of the Dictionary
        foreach (KeyValuePair<string, string> wordData in dictionary)
        {
          Console.WriteLine($"{wordData.Key}: {wordData.Value}");
        }
      });
}
    }
}
