using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjSmith.Cards.Classes
{
    public class Player
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public List<Card> Hand { get; set; }

    }
}
