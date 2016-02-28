using System.Collections.Generic;
using FizzBuzzLib;
using NUnit.Framework;

namespace FizzBuzzTests
{
    public class TestableDecorator : Decorator
    {
        public override IEnumerable<KeyValuePair<int, string>> GetNumberValuePairs()
        {
            throw new System.NotImplementedException();
        }
    }

    [TestFixture]
    public class DecoratorTest
    {
        
        [Test]
        public void NewWordShouldNotContainNumber()
        {
            var testableDecorator = new TestableDecorator();
            var result = testableDecorator.BuildNewWord(3, "3", "Fizz");

            Assert.AreEqual("Fizz", result);
        }
    }
}
