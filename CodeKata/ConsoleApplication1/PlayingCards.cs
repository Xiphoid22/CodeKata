using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CodeKata
{
    class PlayingCards
    {
        public List<Card> CreateDeck()
        {
            var suits = new string[4] {"Spades","Hearts","Clubs","Diamonds"};
            var value = new string[13] {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            var deck = new List<Card>();

            foreach (var suit in suits)
            {
                deck.AddRange(value.Select(cardValue => new Card(suit, cardValue)));
            }
            return deck;
        }

        public void  ShuffleDeck(List<Card> deck)
        {
            var random = new Random();
            var shuffledDeck = new List<Card>();
            var deckSize = deck.Count;

            for (var i = 0; i < deckSize; i++)
            {
                var randomNumber = random.Next(0, deck.Count-1);
                shuffledDeck.Add(deck[randomNumber]);
                deck.RemoveAt(randomNumber);
            }

            for (var i = 0; i < deckSize; i++)
            {
                deck.Add(shuffledDeck[i]);
            }
        }

        public List<Card> DealHand(List<Card> deck, int cardsPerHand)
        {
            var hand = new List<Card>();
            try
            {
                for (var i = 0; i < cardsPerHand; i++)
                {
                    var takenCard = TakeCard(deck);
                    hand.Add(takenCard);
                }
                return hand;
            }
            catch (ArgumentOutOfRangeException)
            {
                return hand;
            }

        }

        public Card TakeCard(List<Card> deck)
        {
            var yourCard = new Card(deck[0].GetSuit(), deck[0].GetValue());
            deck.RemoveAt(0);
            return yourCard;
        }

        public void ReturnCardsFromHandToDeck(List<Card> hand, List<Card> deck)
        {
            deck.AddRange(hand);
            hand.Clear();
        }
    }

    public class Card
    {
        private readonly string _suit;
        private readonly string _value;

        public Card(string suit, string value)
        {
            _suit = suit;
            _value = value;
        }

        public string GetSuit()
        {
            return _suit;
        }

        public string GetValue()
        {
            return _value;
        }
    }
}
