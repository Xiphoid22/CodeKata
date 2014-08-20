using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    class PlayingCards
    {
        public List<Card> CreateDeck()
        {
            var suits = new string[4] {"Spades","Hearts","Clubs","Diamonds"};
            var value = new string[13] {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            var deck = new List<Card>();

            for (var i = 0; i < suits.Length; i++)
            {
                for (var j = 0; j < value.Length; j++)
                {
                    var card = new Card(suits[i], value[j]);
                    deck.Add(card);
                }
            }
            return deck;
        }

        public void ShuffleDeck(string[] deck)
        {
            throw new NotImplementedException();
        }

        public List<Card> CreateHand(List<Card> deck)
        {
            throw new NotImplementedException();
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
