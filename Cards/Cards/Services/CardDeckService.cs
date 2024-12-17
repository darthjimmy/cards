using EjSmith.Cards.Classes;

namespace EjSmith.Cards.Services
{
    public class CardDeckService : ICardDeckService
    {
        private readonly CardDeck defaultDeck;

        public CardDeckService()
        {
            defaultDeck = CreateDeck();
        }

        public IEnumerable<CardDeck> GetDecks()
        {
            return [defaultDeck];
        }

        // Fisher-Yates shuffle
        public CardDeck Shuffle(CardDeck deck)
        {
            Random rnd = new();
            int n = deck.Cards.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (deck.Cards[j], deck.Cards[i]) = (deck.Cards[i], deck.Cards[j]);
            }

            return deck;
        }

        private static CardDeck CreateDeck()
        {
            var deck = new CardDeck();

            foreach (Suit suit in Suit.Suits)
            {
                for (var num = 2; num <= 14; num++)
                {
                    deck.Cards.Add(new Card { Suit = suit, Value = (CardValue)num });
                }
            }

            return deck;
        }
    }
}
