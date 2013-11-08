using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mills.CodeKatas.CardGames.Core.SuitModel
{
    public static class Suits
    {
        public static Suit Spades
        {
            get { return GetSuit(SuitNames.Spades); }
        }

        public static Suit Hearts
        {
            get { return GetSuit(SuitNames.Hearts); }
        }

        public static Suit Clubs
        {
            get { return GetSuit(SuitNames.Clubs); }
        }

        public static Suit Diamonds
        {
            get { return GetSuit(SuitNames.Diamonds); }
        }

        public static ICollection<Suit> All
        {
            get { return new Collection<Suit> {Spades, Hearts, Clubs, Diamonds}; }
        }

        private static readonly IDictionary<string, Suit> _suits = new Dictionary<string, Suit>();
        private static Suit GetSuit(string suitName)
        {
            if (!_suits.ContainsKey(suitName))
            {
                _suits[suitName] = new Suit(suitName);
            }

            return _suits[suitName];
        }
    }
}
