using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzzKata fizzBuzz;

        [TestFixtureSetUp]
        public void init()
        {
            fizzBuzz = new FizzBuzzKata();
        }

        [Test]
        public void fizzTest()
        {
            Assert.AreEqual("Fizz", fizzBuzz.Answer(3));
        }

        [Test]
        public void BuzzTest()
        {
            Assert.AreEqual("Buzz", fizzBuzz.Answer(5));
        }

        [Test]
        public void fizzBuzzTest()
        {
            Assert.AreEqual("Fizz Buzz", fizzBuzz.Answer(15));
        }

        [Test]
        public void NotDivisibleTest()
        {
            Assert.AreEqual("", fizzBuzz.Answer(7));
        }

    }
}
