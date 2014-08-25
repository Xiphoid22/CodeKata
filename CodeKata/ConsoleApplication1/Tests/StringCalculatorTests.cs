
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    class StringCalculatorTests
    {
        StringCalculatorKata _stringCalculatorKata;

        [TestFixtureSetUp]
        public void init()
        {
            _stringCalculatorKata = new StringCalculatorKata();
        }

        [Test]
        public void AddZeroNumber()
        {
            var result = _stringCalculatorKata.Add("");
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void AddOneNumber()
        {
            var result = _stringCalculatorKata.Add("1");
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void AddTwoNumbers()
        {
            var result = _stringCalculatorKata.Add("1,2");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void AddNegativeNumbers()
        {
            var result = _stringCalculatorKata.Add("-1,-2");
            Assert.AreEqual(result, -3);
        }

        [Test]
        public void AddMoreThanTwoNumbers()
        {
            var result = _stringCalculatorKata.Add("1,5,17,-10,11,-4");
            Assert.AreEqual(result, 20);
        }
    }
}
