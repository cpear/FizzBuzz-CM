using System.Collections.Generic;

namespace FizzBuzzLib
{
    public abstract class Decorator : IComponent
    {
        public abstract IEnumerable<KeyValuePair<int, string>> GetNumberValuePairs();

        public string BuildNewWord(int currentKey, string currentWord, string wordToConcat)
        {
            if (currentKey.ToString() == currentWord) return wordToConcat;

            return currentWord + " " + wordToConcat;
        }
    }
}
