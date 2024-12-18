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
            return [defaultDeck, Shuffle(defaultDeck)];
        }

        // Fisher-Yates shuffle
        public CardDeck Shuffle(CardDeck deck)
        {
            CardDeck result = new();
            result.Cards.AddRange(deck.Cards);

            Random rnd = new();
            int n = result.Cards.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (result.Cards[j], result.Cards[i]) = (result.Cards[i], result.Cards[j]);
            }

            return result;
        }

        private static CardDeck CreateDeck()
        {
            var deck = new CardDeck();

            foreach (Suit suit in Enum.GetValues<Suit>())
            {
                foreach (CardValue num in Enum.GetValues<CardValue>())
                {
                    deck.Cards.Add(new Card { Suit = suit, Value = num });
                }
            }

            return deck;
        }
    }
}
