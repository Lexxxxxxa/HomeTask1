using System;
using System.Collections.Generic;

namespace HomeTask4
{
    public class CardDeck
    {
        public List<Card> deck;

        public List<Card> cards => deck;

        public Enum.Suit[] Suits = { Enum.Suit.Spades, Enum.Suit.Hearts, Enum.Suit.Diamonds, Enum.Suit.Clubs };
        public Enum.Rank[] Ranks = { Enum.Rank.Six, Enum.Rank.Seven, Enum.Rank.Eight, Enum.Rank.Nine, Enum.Rank.Ten, Enum.Rank.Jack, Enum.Rank.Queen, Enum.Rank.King, Enum.Rank.Ace };

        public CardDeck()
        {
            deck = new List<Card>();
            GenerateDeck();
        }

        public void GenerateDeck()
        {
            foreach (Enum.Suit suit in Suits)
            {
                foreach (Enum.Rank rank in Ranks)
                {
                    deck.Add(new Card { Suit = suit, Rank = rank });
                }
            }
        }

        public void ShuffleDeck()
        {
            Random random = new Random();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        public void PrintDeck()
        {
            foreach (Card card in deck)
            {
                Console.WriteLine(card + " ");
            }
            Console.WriteLine();
        }

        public void ReturnPositionOfAce()
        {
            List<int> acePositions = deck
                .Select((card, index) => new { Card = card, Index = index })
                .Where(item => item.Card.Rank == Enum.Rank.Ace)
                .Select(item => item.Index)
                .ToList();

            foreach (int index in acePositions)
            {
                Console.WriteLine(index);
            }
        }

        public void SwitchAllClubsOnBeginning()
        {
            List<int> clubsPositions = deck
                .Select((card, index) => new { Card = card, Index = index })
                .Where(item => item.Card.Suit == Enum.Suit.Clubs)
                .Select(item => item.Index)
                .ToList();

            int currentIndex = 0;

            foreach (int clubIndex in clubsPositions)
            {
                Card temp = deck[currentIndex];
                deck[currentIndex] = deck[clubIndex];
                deck[clubIndex] = temp;

                currentIndex++;
            }
        }

        public void SortDeck()
        {
            deck.Sort((card1, card2) =>
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
