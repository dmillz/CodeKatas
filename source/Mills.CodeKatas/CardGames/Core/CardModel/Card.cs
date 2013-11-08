using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mills.CodeKatas.CardGames.Core.RankModel;
using Mills.CodeKatas.CardGames.Core.SuitModel;

namespace Mills.CodeKatas.CardGames.Core.CardModel
{
    /// <summary>
    /// A playing card with a Suit and a Rank.
    /// </summary>
    public class Card
    {
        public Suit Suit { get; private set; }
        public Rank Rank { get; private set; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
