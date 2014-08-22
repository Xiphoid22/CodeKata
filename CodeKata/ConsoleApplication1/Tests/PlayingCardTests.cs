using System.Collections.Generic;
using NUnit.Framework;

namespace CodeKata.Tests
{
    [TestFixture]
    internal class PlayingCardTests
    {
        private PlayingCards _cards;
        private List<Card> _deck;
 
        [TestFixtureSetUp]
        public void init()
        {
            _cards = new PlayingCards();
            _deck = _cards.CreateDeck();
        }

        [Test]
        public void CreateDeckTest()
        {
            Assert.IsTrue(_deck.Count == 52);
        }

        [Test]
        public void CheckSuit()
        {
            Assert.IsTrue(_deck[0].GetSuit() == "Spades");
        }

        [Test]
        public void CheckValue()
        {
            Assert.IsTrue(_deck[0].GetValue() == "Ace");
        }

        [Test]
        public void ShuffleDeck()
        {
            var originalDeck = _cards.CreateDeck();
            _cards.ShuffleDeck(_deck);
            Assert.IsTrue(originalDeck[0].GetValue() != _deck[0].GetValue());
        }

        [Test]
        public void GetHand()
        {
            _cards.ShuffleDeck(_deck);
            var hand = _cards.DealHand(_deck, 7);
            Assert.IsTrue(hand.Count == 7);
        }
    }
}
