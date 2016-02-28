using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzzLib;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class DecoratorFactoryTest
    {
        [Test]
        public void ShouldReturnFizzBuzz15()
        {
            var factory = new DecoratorFactory();
            var range = new Tuple<int, int>(1,100);

            var numberWordPairs = new Queue<Tuple<int, string>>();
            numberWordPairs.Enqueue(new Tuple<int, string>(3, "Fizz"));
            numberWordPairs.Enqueue(new Tuple<int, string>(5, "Buzz"));

            var numberGenerator = factory.GetDecoratedNumberGenerator(range, numberWordPairs);

            var results = numberGenerator.GetNumberValuePairs().ToList();

            Assert.AreEqual("Fizz Buzz", results[14].Value);
        }
    }
}
