namespace Mills.CodeKatas.CardGames.Core.RankModel
{
    /// <summary>
    /// A Rank is one of two identifying traits for a card, having values such as "Two", "Five", "Ten", "Jack", "Ace"
    /// </summary>
    public class Rank
    {
        /// <summary>
        /// The name of the Rank, such as "Two", "Five", "Ten", "Jack", "Ace"
        /// </summary>
        public string Name { get; private set; }

        public Rank(string name)
        {
            Name = name;
        }
    }
}
