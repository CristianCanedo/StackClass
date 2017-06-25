namespace Stack
{
    public class Card
    {
        public string Number { get; set; }
        public string Suit { get; set; }

        public Card(string number, string suit)
        {
            Number = number;
            Suit = suit;
        }
    }
}
