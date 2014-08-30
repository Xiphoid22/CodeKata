
using System;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    class StringCalculatorTests
    {
        StringCalculatorKata _stringCalculatorKata;

        [TestFixtureSetUp]
        public void Init()
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
            var exception = Assert.Throws<NegativeNumbersException>(() => _stringCalculatorKata.Add("-1,-2"));
            Assert.That(exception.Message, Is.EqualTo("Negatives not allowed. -1 -2"));
        }

        [Test]
        public void AddMoreThanTwoNumbers()
        {
            var result = _stringCalculatorKata.Add("1,5,17,10,11,4");
            Assert.AreEqual(result, 48);
        }

        [Test]
        public void CommasOrNewLineDelimiter()
        {
            var result = _stringCalculatorKata.Add("1\n5,17,10\n11\n4");
            Assert.AreEqual(result, 48);
        }

        [Test]
        public void NewLineDelimiter()
        {
            var result = _stringCalculatorKata.Add("\n1\n5\n17\n10\n11\n4");
            Assert.AreEqual(result, 48);
        }

        [Test]
        public void CustomDelimiter()
        {
            var result = _stringCalculatorKata.Add("//;\n1;2");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void CustomnDelimiter()
        {
            var result = _stringCalculatorKata.Add("//n\n1n2n3");
            Assert.AreEqual(result, 6);
        }

        [Test]
        public void CustomSlashDelimiter()
        {
            var result = _stringCalculatorKata.Add("//\\\n1\\2\\3");
            Assert.AreEqual(result, 6);
        }
    }
}
