using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjSmith.Cards.Classes
{
    public class Room
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();

        [NotMapped]
        public CardDeck CardDeck { get; set; }
    }
}
