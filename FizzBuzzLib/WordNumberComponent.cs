using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class WordNumberComponent : IComponent
    {
        private readonly int _start;
        private readonly int _end;

        public WordNumberComponent(int start, int end)
        {
            _start = start;
            _end = end;
        }

        public IEnumerable<KeyValuePair<int, string>> GetNumberValuePairs()
        {
            for (int i = _start; i <= _end; i++)
            {
                yield return new KeyValuePair<int, string>(i, i.ToString());
            }
            
        }
    }
}
