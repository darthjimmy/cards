namespace EjSmith.Cards.Classes
{
    public enum Colors
    {
        Black,
        Red
    }

    public class Suit
    {
        public static List<Suit> Suits
        {
            get
            {
                return
                [
                    new() { Name = "Clubs", Color = Colors.Black },
                    new() { Name = "Spades", Color= Colors.Black },
                    new() { Name = "Diamonds", Color = Colors.Red },
                    new() { Name = "Hearts", Color = Colors.Red }
                ];
            }
        }

        public string Name { get; set; } = "";
        public Colors Color { get; set; }
    }
}
