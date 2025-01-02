namespace EjSmith.Cards.Classes
{
    public enum CardValue
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14,
    }

    public enum Suit
    {
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }

    public class Card
    {
        public int Id { get; set; }
        public Suit Suit { get; set; } = new Suit();
        public CardValue Value { get; set; }
        public string Name { get { return $"{Value} of {Suit}"; } }
    }
}
