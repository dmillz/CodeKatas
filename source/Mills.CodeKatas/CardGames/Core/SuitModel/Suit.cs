namespace Mills.CodeKatas.CardGames.Core.SuitModel
{
    public class Suit
    {
        public string Name { get; private set; }

        public Suit(string suitName)
        {
            Name = suitName;
        }
    }
}