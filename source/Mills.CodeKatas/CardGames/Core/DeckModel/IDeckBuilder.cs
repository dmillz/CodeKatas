using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mills.CodeKatas.CardGames.Core.DeckModel
{
    public interface IDeckBuilder
    {
        Deck BuildDeck();
    }
}
