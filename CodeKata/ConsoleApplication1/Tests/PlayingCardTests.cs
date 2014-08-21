using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    internal class PlayingCardTests
    {
        private PlayingCards cards;

        [TestFixtureSetUp]
        public void init()
        {
            cards = new PlayingCards();
        }

        [Test]
        public void CreateDeckTest()
        {
            var deck = cards.CreateDeck();
            Assert.IsTrue(deck.Count == 52);
        }

        [Test]
        public void CheckSuit()
        {
            var deck = cards.CreateDeck();
            Assert.IsTrue(deck[0].GetSuit() == "Spades");
        }

        [Test]
        public void CheckValue()
        {
            var deck = cards.CreateDeck();
            Assert.IsTrue(deck[0].GetValue() == "Ace");
        }

        [Test]
        public void shuffleDeck()
        {
            var deck = cards.CreateDeck();
            var originalDeck = cards.CreateDeck();
            cards.ShuffleDeck(deck);
            Assert.IsTrue(originalDeck[0].GetValue() != deck[0].GetValue());
        }
    }
}
