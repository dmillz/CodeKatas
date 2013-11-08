using Mills.CodeKatas.CardGames.Core.SuitModel;
using NUnit.Framework;

namespace Mills.CodeKatas.Tests.CardGames.Core.SuitModel
{
    [TestFixture]
    public class SuitTest
    {
        [Test]
        public void ConstructorSetsSuitName()
        {
            Suit suit = new Suit(SuitNames.Spades);
            Assert.That(suit.Name, Is.EqualTo(SuitNames.Spades));
        }

        [Test]
        public void SuitsAccessorConvenienceMethodsReturnSameReferenceForSameSuit()
        {
            Assert.That(Suits.Hearts, Is.EqualTo(Suits.Hearts));
        }
    }
}
