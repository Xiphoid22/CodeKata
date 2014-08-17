using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    public class TeaPartyTests
    {
        TeaParty teaParty;

        [TestFixtureSetUp]
        public void init()
        {
            teaParty = new TeaParty();
        }

        [Test]
        public void mrTest()
        {
            Assert.AreEqual("Hello Mr. Marco", teaParty.Welcome("Marco",false,false));
        }

        [Test]
        public void msTest()
        {
            Assert.AreEqual("Hello Ms. Hufflepuff", teaParty.Welcome("Hufflepuff", true, false));
        }

        [Test]
        public void sirTest()
        {
            Assert.AreEqual("Hello Sir Auron", teaParty.Welcome("Auron", false, true));
        }

        [Test]
        public void LadyTest()
        {
            Assert.AreEqual("Hello Lady Akatsuki", teaParty.Welcome("Akatsuki", true, true));
        }

    }
}
