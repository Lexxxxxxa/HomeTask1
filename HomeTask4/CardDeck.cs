using HomeTask4.Enum;
using System;


namespace HomeTask4
{
    public class CardDeck
    {
        private List<Card> Deck;

        public IReadOnlyList<Card> Cards => Deck.AsReadOnly();

        private readonly Suit[] Suits = { Suit.Spades, Suit.Hearts, Suit.Diamonds, Suit.Clubs };
        private readonly Rank[] Ranks = { Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.Jack, Rank.Queen, Rank.King, Rank.Ace };

        public CardDeck()
        {
            Deck = new List<Card>();
            GenerateDeck();
        }

        public void GenerateDeck()
        {
            foreach (Suit suit in Suits)
            {
                foreach (Rank rank in Ranks)
                {
                    Deck.Add(new Card (suit, rank));
                }
            }
        }

        public void ShuffleDeck()
        {
            Random random = new Random();

            for (int i = Deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = Deck[i];
                Deck[i] = Deck[j];
                Deck[j] = temp;
            }
        }

        public void PrintDeck()
        {
            foreach (Card card in Deck)
            {
                Console.WriteLine(card + " ");
            }
            Console.WriteLine();
        }

        private List<int> GetCardPositions(Func<Card, bool> filter)
        {
            return Deck
                .Select((card, index) => new { Card = card, Index = index })
                .Where(item => filter(item.Card))
                .Select(item => item.Index)
                .ToList();
        }

        public void ReturnPositionOfAce()
        {
            List<int> acePositions = GetCardPositions(card => card.Rank == Rank.Ace);

            foreach (int index in acePositions)
            {
                Console.WriteLine(index);
            }
        }

        public void SwitchAllClubsOnBeginning()
        {
            List<int> clubsPositions = GetCardPositions(card => card.Suit == Suit.Clubs);

            int currentIndex = 0;

            foreach (int clubIndex in clubsPositions)
            {
                Card temp = Deck[currentIndex];
                Deck[currentIndex] = Deck[clubIndex];
                Deck[clubIndex] = temp;

                currentIndex++;
            }
        }

        public void SortDeck()
        {
            Deck.Sort((card1, card2) =>
            {
                int suitComparison = card1.Suit.CompareTo(card2.Suit);
                if (suitComparison != 0)
                {
                    return suitComparison;
                }

                int rank1 = Array.IndexOf(Ranks, card1.Rank);
                int rank2 = Array.IndexOf(Ranks, card2.Rank);
                return rank1.CompareTo(rank2);
            });
        }
    }
}
