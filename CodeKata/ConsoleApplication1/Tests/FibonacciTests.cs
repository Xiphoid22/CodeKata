using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    class FibonacciTests
    {
        FibonacciKillerKata fibonacci;

        [TestFixtureSetUp]
        public void init()
        {
            fibonacci = new FibonacciKillerKata();
        }

        [Test]
        public void FiveTest()
        {
            Assert.AreEqual(fibonacci.Fibonacci(5) ,  5);
        }

        [Test]
        public void ZeroTest()
        {
            Assert.AreEqual(fibonacci.Fibonacci(0) , 0);
        }

        [Test]
        public void OneTest()
        {
            Assert.AreEqual(fibonacci.Fibonacci(1) , 1);
        }

        [Test]
        public void ElevenTest()
        {
            Assert.AreEqual(fibonacci.Fibonacci(11) , 89);
        }

        [Test]
        public void TwelveTest()
        {
            Assert.AreEqual(fibonacci.Fibonacci(12) , 144);
        }

    }
}
