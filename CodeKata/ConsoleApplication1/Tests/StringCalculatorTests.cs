
using System;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    class StringCalculatorTests
    {
        StringCalculatorKata _stringCalculatorKata;

        [Test]
        public void AddZeroNumber()
        {
            _stringCalculatorKata = new StringCalculatorKata("");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void AddOneNumber()
        {
            _stringCalculatorKata = new StringCalculatorKata("1");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void AddTwoNumbers()
        {
            _stringCalculatorKata = new StringCalculatorKata("1,2");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void AddNegativeNumbers()
        {
            _stringCalculatorKata = new StringCalculatorKata("-1,-2");
            var exception = Assert.Throws<NegativeNumbersException>(() => _stringCalculatorKata.Add());
            Assert.That(exception.Message, Is.EqualTo("Negatives not allowed. -1 -2"));
        }

        [Test]
        public void AddMoreThanTwoNumbers()
        {
            _stringCalculatorKata = new StringCalculatorKata("1,5,17,10,11,4");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 48);
        }

        [Test]
        public void CommasOrNewLineDelimiter()
        {
            _stringCalculatorKata = new StringCalculatorKata("1\n5,17,10\n11\n4");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 48);
        }

        [Test]
        public void NewLineDelimiter()
        {
            _stringCalculatorKata = new StringCalculatorKata("\n1\n5\n17\n10\n11\n4");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 48);
        }

        [Test]
        public void CustomDelimiter()
        {
            _stringCalculatorKata = new StringCalculatorKata("//;\n1;2");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void CustomnDelimiter()
        {
            _stringCalculatorKata = new StringCalculatorKata("//n\n1n2n3");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 6);
        }

        [Test]
        public void CustomSlashDelimiter()
        {
            _stringCalculatorKata = new StringCalculatorKata("//\\\n1\\2\\3");
            var result = _stringCalculatorKata.Add();
            Assert.AreEqual(result, 6);
        }
    }
}
