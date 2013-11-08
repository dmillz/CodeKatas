using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mills.CodeKatas.CardGames.Core.CardModel;

namespace Mills.CodeKatas.CardGames.Core.DeckModel
{
    /// <summary>
    /// A deck of playing cards
    /// </summary>
    public class Deck
    {
        public IList<Card> Cards { get; private set; }

        public Deck(IList<Card> cards)
        {
            Cards = cards;
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }
    }
}
