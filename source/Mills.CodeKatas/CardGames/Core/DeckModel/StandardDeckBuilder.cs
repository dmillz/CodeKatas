using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Mills.CodeKatas.CardGames.Core.CardModel;
using Mills.CodeKatas.CardGames.Core.RankModel;
using Mills.CodeKatas.CardGames.Core.SuitModel;

namespace Mills.CodeKatas.CardGames.Core.DeckModel
{
    public class StandardDeckBuilder : IDeckBuilder
    {
        public Deck BuildDeck()
        {
            IList<Card> cards = new List<Card>();
            foreach (Suit suit in Suits.All)
            {
                foreach (Rank rank in Ranks.All)
                {
                    cards.Add(new Card(suit, rank));
                }
            }

            return new Deck(cards);
        }
    }
}
