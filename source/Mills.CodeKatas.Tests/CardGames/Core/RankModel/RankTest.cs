using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mills.CodeKatas.CardGames.Core.RankModel;
using NUnit.Framework;

namespace Mills.CodeKatas.Tests.CardGames.Core.RankModel
{
    [TestFixture]
    public class RankTest
    {
        [Test]
        public void ConstructorSetsRankName()
        {
            Rank rank = new Rank(RankNames.Eight);
            Assert.That(rank.Name, Is.EqualTo(RankNames.Eight));
        }
    }
}
