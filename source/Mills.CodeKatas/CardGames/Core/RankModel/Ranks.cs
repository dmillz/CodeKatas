using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mills.CodeKatas.CardGames.Core.RankModel
{
    public static class Ranks
    {
        public static Rank Two
        {
            get { return GetRank(RankNames.Two); }    
        }

        public static Rank Three
        {
            get { return GetRank(RankNames.Three); }    
        }

        public static Rank Four
        {
            get { return GetRank(RankNames.Four); }    
        }

        public static Rank Five
        {
            get { return GetRank(RankNames.Five); }    
        }

        public static Rank Six
        {
            get { return GetRank(RankNames.Six); }    
        }

        public static Rank Seven
        {
            get { return GetRank(RankNames.Seven); }    
        }

        public static Rank Eight
        {
            get { return GetRank(RankNames.Eight); }    
        }

        public static Rank Nine
        {
            get { return GetRank(RankNames.Nine); }    
        }

        public static Rank Ten
        {
            get { return GetRank(RankNames.Ten); }    
        }

        public static Rank Jack
        {
            get { return GetRank(RankNames.Jack); }    
        }

        public static Rank Queen
        {
            get { return GetRank(RankNames.Queen); }    
        }

        public static Rank King
        {
            get { return GetRank(RankNames.King); }    
        }

        public static Rank Ace
        {
            get { return GetRank(RankNames.Ace); }    
        }

        public static ICollection<Rank> All
        {
            get { return new Collection<Rank> { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }; }
        }

        private static IDictionary<string, Rank> _cardRanks = new Dictionary<string, Rank>();

        private static Rank GetRank(string name)
        {
            if (!_cardRanks.ContainsKey(name))
            {
                _cardRanks[name] = new Rank(name);
            }

            return _cardRanks[name];
        }
    }
}
