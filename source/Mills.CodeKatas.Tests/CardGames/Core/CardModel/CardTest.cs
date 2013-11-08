using Mills.CodeKatas.CardGames.Core.CardModel;
using Mills.CodeKatas.CardGames.Core.RankModel;
using Mills.CodeKatas.CardGames.Core.SuitModel;
using NUnit.Framework;

namespace Mills.CodeKatas.Tests.CardGames.Core.CardModel
{
    [TestFixture]
    public class CardTest
    {
        [Test]
        public void ConstructorSetsSuitAndRank()
        {
            Card card = new Card(Suits.Spades, Ranks.Ace);
            Assert.That(card.Suit, Is.EqualTo(Suits.Spades));
            Assert.That(card.Rank, Is.EqualTo(Ranks.Ace));
        }
    }
}
