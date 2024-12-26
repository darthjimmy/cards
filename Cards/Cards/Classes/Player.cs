using System.ComponentModel.DataAnnotations;

namespace EjSmith.Cards.Classes
{
    public class Player
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Card> Hand { get; set; }

    }
}
