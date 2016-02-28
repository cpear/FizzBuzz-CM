using System.Collections.Generic;

namespace FizzBuzzLib
{
    public interface IComponent
    {
        IEnumerable<KeyValuePair<int,string>> GetNumberValuePairs();
    }
}
