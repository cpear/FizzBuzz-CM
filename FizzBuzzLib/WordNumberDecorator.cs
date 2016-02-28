using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class WordNumberDecorator : Decorator
    {
        private readonly IComponent _component;
        private readonly int _divisor;
        private readonly string _wordToUse;

        public WordNumberDecorator(IComponent component, int divisor, string wordToUse)
        {
            _component = component;
            _divisor = divisor;
            _wordToUse = wordToUse;
        }

        public override IEnumerable<KeyValuePair<int, string>> GetNumberValuePairs()
        {
            foreach (var numberValuePair in _component.GetNumberValuePairs())
            {
                if (numberValuePair.Key % _divisor == 0)
                {
                    var key = numberValuePair.Key;
                    var currentWord = numberValuePair.Value;
                    var newWord = BuildNewWord(key, currentWord, _wordToUse);

                    yield return new KeyValuePair<int, string>(numberValuePair.Key, newWord);
                    continue;
                }
                yield return numberValuePair;
            }
        }
    }
}
