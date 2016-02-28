using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class DecoratorFactory
    {
        public IComponent GetDecoratedNumberGenerator(Tuple<int,int> startAndEndRange, Queue<Tuple<int,string>> numberWordPairs)
        {
            var words = new WordNumberComponent(startAndEndRange.Item1, startAndEndRange.Item2);
            var fizzDecorator = new WordNumberDecorator(words, 3, "Fizz");
            var buzzDecorator = new WordNumberDecorator(fizzDecorator, 5, "Buzz");

            return null;
        }
    }
}
