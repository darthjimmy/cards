using EjSmith.Cards.Classes;

namespace EjSmith.Cards.Services
{
    public interface ICardDeckService
    {
        IEnumerable<CardDeck> GetDecks();

        CardDeck Shuffle(CardDeck deck);
    }
}
