using HomeTask4.Enum;

namespace HomeTask4
{
    public struct Card
    {
        public Suit Suit { get;}
        public Rank Rank { get;}

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
