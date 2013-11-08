using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mills.CodeKatas.CardGames.Core.CardModel;
using Mills.CodeKatas.CardGames.Core.DeckModel;
using Mills.CodeKatas.CardGames.Core.RankModel;
using Mills.CodeKatas.CardGames.Core.SuitModel;
using NUnit.Framework;

namespace Mills.CodeKatas.Tests.CardGames.Core.DeckModel
{
    [TestFixture]
    public class StandardDeckBuilderTest
    {
        private Deck _deck;

        [SetUp]
        public void SetUp()
        {
            IDeckBuilder builder = new StandardDeckBuilder();
            _deck = builder.BuildDeck();
        }

        [Test]
        public void DeckContains52Cards()
        {
            Assert.That(_deck.Cards.Count, Is.EqualTo(52));
        }

        [Test]
        public void DeckContains13OfEachSuit()
        {
            IDictionary<Suit, int> counts = new Dictionary<Suit, int>();
            foreach (Card card in _deck.Cards)
            {
                if (!counts.ContainsKey(card.Suit))
                {
                    counts[card.Suit] = 0;
                }
                counts[card.Suit]++;
            }

            foreach (Suit suit in counts.Keys)
            {
                Assert.That(counts[suit], Is.EqualTo(13));
            }
        }

        [Test]
        public void DeckContains4OfEachRank()
        {
            IDictionary<Rank, int> counts = new Dictionary<Rank, int>();
            foreach (Card card in _deck.Cards)
            {
                if (!counts.ContainsKey(card.Rank))
                {
                    counts[card.Rank] = 0;
                }
                counts[card.Rank]++;
            }

            foreach (Rank rank in counts.Keys)
            {
                Assert.That(counts[rank], Is.EqualTo(4));
            }
        }
    }
}
