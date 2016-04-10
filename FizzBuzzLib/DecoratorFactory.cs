using System;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class DecoratorFactory
    {
        public IComponent GetDecoratedNumberGenerator(Tuple<int,int> startAndEndRange, Queue<Tuple<int,string>> numberWordPairs)
        {
            var words = new WordNumberComponent(startAndEndRange.Item1, startAndEndRange.Item2);

            IComponent currentComponent = words;

            foreach (var numberWordPair in numberWordPairs)
            {
                currentComponent = new WordNumberDecorator(currentComponent, numberWordPair.Item1, numberWordPair.Item2);
            }

            return currentComponent;
        }
    }
}
