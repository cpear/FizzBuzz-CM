using System;
using FizzBuzzLib;

namespace FizzBuzz_CM
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            foreach (var word in buzzDecorator.GetNumberValuePairs())
            {
                Console.WriteLine(word.Value);
            }
        }
    }
}
