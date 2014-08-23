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
        }

        [Test]
        public void CreateDeckTest()
        {
            _deck = _cards.CreateDeck();
            Assert.IsTrue(_deck.Count == 52);
        }

        [Test]
        public void CheckSuit()
        {
            _deck = _cards.CreateDeck();
            Assert.IsTrue(_deck[0].GetSuit() == "Spades");
        }

        [Test]
        public void CheckValue()
        {
            _deck = _cards.CreateDeck();
            Assert.IsTrue(_deck[0].GetValue() == "Ace");
        }

        [Test]
        public void ShuffleDeck()
        {
            _deck = _cards.CreateDeck();
            var originalDeck = _cards.CreateDeck();
            _cards.ShuffleDeck(_deck);
            Assert.IsTrue(originalDeck[0].GetValue() != _deck[0].GetValue());
        }

        [Test]
        public void GetHand()
        {
            _deck = _cards.CreateDeck();
            _cards.ShuffleDeck(_deck);
            var hand = _cards.DealHand(_deck, 7);
            Assert.IsTrue(hand.Count == 7);
        }

        [Test]
        public void GetHandWhichIsTooBig()
        {
            _deck = _cards.CreateDeck();
            _cards.ShuffleDeck(_deck);
            var hand = _cards.DealHand(_deck, 53);
            Assert.IsTrue(hand.Count == 52);
        }

        [Test]
        public void GetEmptyHand()
        {
            _deck = _cards.CreateDeck();
            _cards.ShuffleDeck(_deck);
            var hand = _cards.DealHand(_deck, 0);
            Assert.IsTrue(hand.Count == 0);
        }

        [Test]
        public void ReturnHand()
        {
            _deck = _cards.CreateDeck();
            _cards.ShuffleDeck(_deck);
            var hand = _cards.DealHand(_deck, 7);
            _cards.ReturnCardsFromHandToDeck(hand,_deck);
            Assert.IsTrue(hand.Count == 0 && _deck.Count == 52);
        }

        [Test]
        public void ReturnEmptyHand()
        {
            _deck = _cards.CreateDeck();
            _cards.ShuffleDeck(_deck);
            var hand = _cards.DealHand(_deck, 0);
            _cards.ReturnCardsFromHandToDeck(hand, _deck);
            Assert.IsTrue(hand.Count == 0 && _deck.Count == 52);
        }
    }
}
