using System;
using System.Collections.Generic;
using FizzBuzzLib;

namespace FizzBuzz_CM
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = 1;
            var end = 100;

            var queue = new Queue<Tuple<int, string>>();
            queue.Enqueue(Tuple.Create(3, "FiZZ"));
            queue.Enqueue(Tuple.Create(5, "Buzz"));

            var facroty = new DecoratorFactory();

            var numberGerator = facroty.GetDecoratedNumberGenerator(Tuple.Create(start,end), queue);
           
            foreach (var word in numberGerator.GetNumberValuePairs())
            {
                Console.WriteLine(word.Value);
            }
        }
    }
}
