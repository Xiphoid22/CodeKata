using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    public class NasaCountdownTests
    {
        NasaCountdownKata nasaCountDown;

        [TestFixtureSetUp]
        public void init()
        {
            nasaCountDown = new NasaCountdownKata();
        }

        [Test]
        public void Countdown10()
        {
            int[] countdown = new int[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            Assert.AreEqual(countdown, nasaCountDown.Countdown(10));
        }

        [Test]
        public void Countdown1()
        {
            int[] countdown = new int[] {1, 0};
            Assert.AreEqual(countdown, nasaCountDown.Countdown(1));
        }

        [Test]
        public void Countdown0()
        {
            int[] countdown = new int[] { 0 };
            Assert.AreEqual(countdown, nasaCountDown.Countdown(0));
        }


        [Test]
        public void CountdownMinus1()
        {
            int[] countdown = new int[] { };
            Assert.AreEqual(countdown, nasaCountDown.Countdown(-1));
        }
    }
}