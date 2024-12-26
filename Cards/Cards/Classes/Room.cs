using System.ComponentModel.DataAnnotations;

namespace EjSmith.Cards.Classes
{
    public class Room
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public CardDeck CardDeck { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
