using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    public class TextReverseTests
    {
        TextReverse reverse;

        [TestFixtureSetUp]
        public void init()
        {
            reverse = new TextReverse();
        }

        [Test]
        public void HelloTest()
        {
            Assert.AreEqual("hello", reverse.Revert("olleh"));
        }

        [Test]
        public void OneCharacterTest()
        {
            Assert.AreEqual("a", reverse.Revert("a"));
        }

        [Test]
        public void EmptyStringTest()
        {
            Assert.AreEqual("", reverse.Revert(""));
        }
    }
}