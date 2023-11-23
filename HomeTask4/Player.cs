using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        
        public Player()
        {
            Hand = new List<Card>();
        }

        public int CalculateScore()
        {
            int score = Hand.Sum(card => (int)card.Rank);
            return score;
        }

        public void ClearHand()
        {
            Hand.Clear();
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
        }
    }
}
