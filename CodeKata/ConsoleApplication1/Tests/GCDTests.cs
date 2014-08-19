using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    public class GCDTests
    {

        GreatestCommonDivisorKata GCD;

        [TestFixtureSetUp]
        public void init()
        {
            GCD = new GreatestCommonDivisorKata();
        }

        [Test]
        public void SecondNumberLargerTest()
        {
            Assert.AreEqual(6, GCD.CalcGcd(12,18));
        }

        [Test]
        public void FirstNumberLargerTest()
        {
            Assert.AreEqual(5, GCD.CalcGcd(55, 10));
        }

        [Test]
        public void ZeroFirstNumberTest()
        {
            Assert.AreEqual(10, GCD.CalcGcd(0, 10));
        }

        [Test]
        public void ZeroSecondNumberTest()
        {
            Assert.AreEqual(55, GCD.CalcGcd(55, 0));
        }
    }
}