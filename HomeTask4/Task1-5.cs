using System;

namespace HomeTask4
{
    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    public class CardDeck
    {
        public List<Card> Deck;

        public List<Card> Cards => Deck;

        public string[] Suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        public string[] Ranks = { "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        public CardDeck()
        {
            Deck = new List<Card>();
            GenerateDeck();
        }

        public void GenerateDeck()
        {
            foreach (string suit in Suits)
            {
                foreach (string rank in Ranks)
                {
                    Deck.Add(new Card { Suit = suit, Rank = rank });
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

        public void ReturnPositionOfAce(int countOfAce = 0)
        {
            foreach (Card card in Deck)
            {
                if (card.Rank == "Ace")
                {
                    int index = Deck.IndexOf(card);
                    Console.WriteLine($"Index of {card.Rank} {card.Suit} is {index + 1}");
                    countOfAce++;

                    if (countOfAce == 4)
                        break;
                }
            }
        }

        public void SwitchAllClubsOnBeginning(int clubIndex = 0)
        {

            for (int i = 0; i < Deck.Count && clubIndex < Deck.Count; i++)
            {
                if (Deck[i].Suit == "Clubs")
                {
                    Card temp = Deck[clubIndex];
                    Deck[clubIndex] = Deck[i];
                    Deck[i] = temp;
                    clubIndex++;
                }
            }
        }

        public void SortDeck()
        {
            Deck.Sort((card1, card2) =>
            {
                int suitComparison = String.Compare(card1.Suit, card2.Suit);
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
