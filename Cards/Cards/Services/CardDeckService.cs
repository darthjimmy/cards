using EjSmith.Cards.Classes;

namespace EjSmith.Cards.Services
{
    public class CardDeckService : ICardDeckService
    {
        private readonly CardDeck defaultDeck;

        public CardDeckService()
        {
            defaultDeck = new CardDeck();

            foreach (Suit suit in Suit.Suits)
            {
                defaultDeck.Cards.Add(new() { Suit = suit, Value = CardValue.Two });
                defaultDeck.Cards.Add(new() { Suit = suit, Value = CardValue.Three });
                defaultDeck.Cards.Add(new() { Suit = suit, Value = CardValue.Four });

            }
        }

        public IEnumerable<CardDeck> GetDecks()
        {
            return [defaultDeck];
        }
    }
}
