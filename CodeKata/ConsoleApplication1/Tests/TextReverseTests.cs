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
            Assert.AreEqual("hello", reverse.Reverse("olleh"));
        }

        [Test]
        public void OneCharacterTest()
        {
            Assert.AreEqual("a", reverse.Reverse("a"));
        }

        [Test]
        public void EmptyStringTest()
        {
            Assert.AreEqual("", reverse.Reverse(""));
        }
    }
}